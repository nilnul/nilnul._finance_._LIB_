using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.finance._accrual.rate
{
	static public class _ConvertX
	{
		static public double Exp2Multi(double rateExp) {
			return Math.Exp(rateExp);
		}

		static public double Multi2Add(double rateMulti) {
			return rateMulti-1;
		}

		static public double Exp2Add(double rate) {
			return Multi2Add( Exp2Multi(rate) );
  }

		static public double Add2Multi(double additionRate)
		{
			return 1 + additionRate;
		}
		static public double Multi2Exp(double amplifier)
		{
			return Math.Log(amplifier);
		}

		static public double Add2Exp(double simple)
		{
			return Multi2Exp(Add2Multi(simple));
		}

	}
}
