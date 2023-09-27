using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.finance._accrual.rate.convert_
{
	/// <summary>
	/// 
	/// </summary>
	/// alias:
	///		amplifier2growth
	///		amplifier2ponent
	///		amplifier2accural
	public class Amplifier2Compound
	{
		static public double Eval(double amplifier) {
			return Math.Log(amplifier);

		}
	}
}
