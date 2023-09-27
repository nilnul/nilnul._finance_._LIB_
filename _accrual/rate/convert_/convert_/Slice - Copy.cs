using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.finance._accrual.rate_.compound.convert_
{
	/// <summary>
	/// convert the compound rate of one period to another that is a ratio of the former
	/// </summary>
	public class Slice
	{
		static public double Eval(double compoundOfLongerPeriod, double ratioOfShorterPeriod2Longer) {
			return compoundOfLongerPeriod * ratioOfShorterPeriod2Longer;
		}
	}
}
