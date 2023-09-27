using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.finance._accrual.rate_.multi
{

	static public class _SliceX
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="rateMulti"></param>
		/// <param name="periodFraction">a fraction of the period</param>
		/// <returns></returns>
		static public double Exp(double rateMulti, double periodFraction)
		{
			return				
				exp.convert_._SliceX.Slice(
					rate.convert_.Amplifier2Compound.Eval(rateMulti)
					,
					periodFraction
				)
			;
		}


	}
}
