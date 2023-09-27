using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.finance._accrual.rate_.multi_
{
	/// <summary>
	/// 100 yuan becomes 110 over a year. the growth is 1.1
	/// </summary>
	static public class _AdditionalX
	{
		static public double Multi(double additional) {
			return 1 + additional;
		}


	}
}
