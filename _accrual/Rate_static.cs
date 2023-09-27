using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.finance._accrual
{
	public  class _RateX
	{
		static public double Eval(uint n,double r) {
			return Math.Pow((1 + r), n)-1;
		}

		static public double Eval(double interests,double principal) {
			return interests / principal;
		}

		static public double MultiplePeriodRate(double rateOfSinglePeriod, uint periodsCount) {
			return Math.Pow((1 + rateOfSinglePeriod), periodsCount)-1;
		}


		static public double MultiplePeriodRate2SinglePeriodRate(double rateOfPeriods, uint periodsCount) {
			return Math.Pow((1 + rateOfPeriods), 1d/periodsCount)-1;
		}




		static public double YearRateFromMonth(double monthRate) {

			return MultiplePeriodRate( monthRate,12);
		
		}



		static public double YearRateFromDay(double dailyRate) {

			return MultiplePeriodRate( dailyRate,365);
		
		}

	}
}
