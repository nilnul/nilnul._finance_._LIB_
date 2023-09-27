using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.finance.interest
{
	static public class _DiscountX
	{
		static public double OfExpRate(double exponentRate, double time, double futureVal) {
			return futureVal * Math.Exp(
				-time*exponentRate
			); 
		}

		static public double OfMultiRate(double exponentRate, double time, double futureVal) {
			return OfExpRate(
				_accrual.rate.convert_.Amplifier2Compound.Eval(exponentRate)
				,
				time,futureVal
			); 
		}

		static public double OfAdditionRate(double exponentRate, double time, double futureVal) {
			return OfMultiRate(
				_accrual.rate.convert_.Addition2Amplifier.Eval(exponentRate)
				,
				time,futureVal
			); 
		}






	}
}
