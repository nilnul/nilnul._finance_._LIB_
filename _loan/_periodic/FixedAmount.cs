using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.num.real.expr.equation;
using RateX = nilnul.finance._accrual._RateX;

namespace nilnul.finance._loan._periodic
{
	/// <summary>
	/// compute the interest rate of credit card accrue.
	/// Mortgages are types of loans that are secured with real estate or personal property. 
	/// </summary>
	static public partial class FixedAmount
	{
		public const double RATE_CEIL = 1000;

		static public double Rate(uint periods, double paymentEveryPeriod, double credit,bool payAtTheEnd) {

			if (payAtTheEnd)
			{
				return Rate_payAtEnd(periods, paymentEveryPeriod,credit);
				
			}

			throw new Exception();
			
		}


		static public double ComputePeriodRate(double firstPayDue_ratioOverPeriod,  uint countOfSubsequentPaybacks, double paymentEveryPeriod,double currentVal)
		{

			
			Func<double, double> func = r => {
				var compoundRate = nilnul.finance._loan.CompoundRate.GetCompoundRate(r);

				double currentValue=nilnul.finance._loan.CompoundRate.Eval_futureVal(
						currentVal,compoundRate,firstPayDue_ratioOverPeriod
					);


				for (int i = 1; i <= countOfSubsequentPaybacks; i++)
				{
					currentValue += CompoundRate.Discount(paymentEveryPeriod,compoundRate,firstPayDue_ratioOverPeriod+ i);
					
				}
				return currentValue;
			
			};


			return BinarySearchX._Solve(func, currentVal, 0, RATE_CEIL).Value;


		}

		static public double ComputeCompoundRate(double firstPayDue_ratioOverPeriod,  uint countOfSubsequentPaybacks, double paymentEveryPeriod,double currentVal)
		{

			
			Func<double, double> func = r => {


				double currentValue = 0;// nilnul.finance._loan.CompoundRate.Discount(paymentEveryPeriod, r,firstPayDue_ratioOverPeriod);


				for (int i = 0; i <= countOfSubsequentPaybacks; i++)
				{
					currentValue += CompoundRate.Discount(paymentEveryPeriod,r,firstPayDue_ratioOverPeriod+ i);
					
				}
				return currentValue;
			
			};

			return BinarySearchX._Solve(func, currentVal, 0, RATE_CEIL).Value;

		}
		static public double ComputeCompoundRate_payAtEnd( uint countOfPaybacks, double paymentEveryPeriod,double currentVal)
		{

			return ComputeCompoundRate(1, countOfPaybacks - 1, paymentEveryPeriod, currentVal);

		}
		static public double ComputePeriodRate_payAtEnd( uint countOfPaybacks, double paymentEveryPeriod,double currentVal)
		{

			return CompoundRate.ToPeriodRate( ComputeCompoundRate_payAtEnd(countOfPaybacks, paymentEveryPeriod, currentVal));

		}

		static public double Compute12PeriodRate_payAtEnd( uint countOfPaybacks, double paymentEveryPeriod,double currentVal)
		{

			return CompoundRate.ToPeriodRate( ComputeCompoundRate_payAtEnd(countOfPaybacks, paymentEveryPeriod, currentVal),12);

		}

		static public double Rate_payAtEnd(uint periods, double paymentEveryPeriod,double currentVal)
		{
			Func<double, double> func = r => {
				double currentValue=0;
				for (int i = 1; i <= periods; i++)
				{
					currentValue += paymentEveryPeriod / Math.Pow((1 + r), i);
					
				}
				return currentValue;
			
			};


			return BinarySearchX._Solve(func, currentVal, 0, RATE_CEIL).Value;


		}


		static public double RateOfCreditInstallments(uint periods, double chargeRate, double currentVal)
		{

			var charge = currentVal * chargeRate;
			var principalAndCharge = currentVal + charge;

			var payEveryPeriod = principalAndCharge / periods;

			Func<double, double> func = r =>
			{
				double currentValue = 0;
				for (int i = 1; i <= periods; i++)
				{
					currentValue += payEveryPeriod / Math.Pow((1 + r), i);

				}
				return currentValue;

			};


			return BinarySearchX._Solve(func, currentVal, 0, RATE_CEIL).Value;


		}

		static public double RateOfCreditInstallments(uint periods, double chargeRate )
		{

			var principalAndChargeRate =1+chargeRate;

			var payEveryPeriod_rate = principalAndChargeRate / periods;

			Func<double, double> func = r =>
			{
				double currentValue_rate = 0;
				for (int i = 1; i <= periods; i++)
				{
					currentValue_rate += payEveryPeriod_rate / Math.Pow((1 + r), i);

				}
				return currentValue_rate;

			};


			return BinarySearchX._Solve(func, 1, 0, RATE_CEIL).Value;


		}

		static public double RateOfCreditInstallments_onRatePerPeriod(uint periods, double chargeRatePerPeriod)
		{


			var payEveryPeriod_rate =1.0/periods *(1 + chargeRatePerPeriod ) ;

			Func<double, double> func = r =>
			{
				double currentValue_rate = 0;
				for (int i = 1; i <= periods; i++)
				{
					currentValue_rate += payEveryPeriod_rate / Math.Pow((1 + r), i);

				}
				return currentValue_rate;

			};


			return BinarySearchX._Solve(func, 1, 0, RATE_CEIL).Value;


		}


		static public double YearRateOfCreditInstallments(uint periods, double chargeRatePerPeriod) {

			return RateX.YearRateFromMonth( RateOfCreditInstallments_onRatePerPeriod(periods, chargeRatePerPeriod));
		}



		static public double YearRateOfCreditInstallments(double presentVal,uint periods, double chargePerPeriod) {

			return RateX.YearRateFromMonth( Rate_payAtEnd(periods, chargePerPeriod,presentVal));
		}



	}
}
