using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.finance._accrual.rate.convert_
{
	public class Simple2Compound
	{
		static public double Eval(double simple)
		{
			return Amplifier2Compound.Eval(Addition2Amplifier.Eval(simple));
		}


		static public double YearSimple2DayCompound(double yearSimple) {

			return rate_.compound.convert_.Slice.Eval(  Eval(yearSimple), 1d / 365);
		}

		static public double YearSimple2MonthCompound(double yearSimple) {

			return rate_.compound.convert_.Slice.Eval(  Eval(yearSimple), 1d / 12);
		}




	}
}
