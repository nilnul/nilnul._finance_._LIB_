using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.finance._accrual.rate_.multi.convert_
{
	static public class _SliceX
	{
		static public double Slice(double rateMulti, double periodMulitiplier)
		{
			return				rate._ConvertX.Exp2Multi(
				exp.convert_._SliceX.Slice(
					rate.convert_.Amplifier2Compound.Eval(rateMulti)
					,
					periodMulitiplier
				)
			);
		}


	}
}
