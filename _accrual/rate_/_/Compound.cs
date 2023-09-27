using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.finance.interest
{
	/// <summary>
	/// 100 becomes 110 over a year. the compound rate of a year is 100*e^x=110 such that x=ln(110/100)
	/// </summary>
	public class Compound
	{
		static public double FroGrowth(double growth) {
			return Math.Log(growth);
		}

		static public double FromRate(double rate) {

			return FroGrowth( 1 + rate);

		}
		static public double Slice(double compound, double subPeriod) {
			return compound * subPeriod;

		}

		static public double Slice_monthFromYear(double compound) {
			return Slice(compound, 1.0 / 12);
		}
		static public double GivenYearRate_returnMonthCompound(double yearRate) {
			return FromRate(yearRate)/12;
		}

	}
}
