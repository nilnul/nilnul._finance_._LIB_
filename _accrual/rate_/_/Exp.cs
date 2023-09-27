using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.finance._loan
{
	/// <summary>
	/// exponential rate
	/// </summary>
	public partial class CompoundRate
	{
		static public double Eval_futureVal(double principal, double interest, double time) {
			return principal*Math.Exp(interest* time);
		}

		static public double GetCompoundRate(double ratePerPeriod) {
			return Math.Log(1 + ratePerPeriod);
		}

		static public double ToPeriodRate(double compoundRate) {
			return Math.Exp(compoundRate) - 1;
		}
		static public double ToPeriodRate(double compoundRate,double periods) {
			return Math.Exp(compoundRate*periods) - 1;
		}
		static public double Eval_futureVal_byPeriodRate(double principal, double periodRate, double time) {
			return Eval_futureVal(principal,GetCompoundRate(periodRate), time);
		}

		static public double Discount(double futureVal, double rate, double time) {
			return futureVal / Math.Exp(rate * time);
		}

		static public double Discount_givenPeriodRate(double futureVal, double periodRate, double time) {
			return futureVal / Math.Exp(GetCompoundRate(periodRate) * time);
		}




	}
}
