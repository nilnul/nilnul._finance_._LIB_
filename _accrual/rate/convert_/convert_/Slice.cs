using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.finance._accrual.rate_.exp.convert_
{
	/// <summary>
	/// convert the compound rate of one period to another that is a ratio of the former
	/// </summary>
	static public class _SliceX
	{
		static public double Slice(double compoundOfLongerPeriod, double ratioOfShorterPeriod2Longer) {
			return compoundOfLongerPeriod * ratioOfShorterPeriod2Longer;
		}
	}
}
