using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.num.real.expr.equation;
using RateX = nilnul.finance._accrual._RateX;

namespace nilnul.finance._loan
{
	/// <summary>
	/// compute the interest rate of credit card accrue.
	/// Mortgages are types of loans that are secured with real estate or personal property. 
	/// </summary>
	static public partial class Periodic
	{
		public const double RATE_CEIL = 1000;
		static public double Rate(uint periods, double paymentEveryPeriod, double credit,bool payAtTheEnd) {

			if (payAtTheEnd)
			{
				return Rate_payAtEnd(periods, paymentEveryPeriod,credit);
				
			}

			throw new Exception();
			
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
