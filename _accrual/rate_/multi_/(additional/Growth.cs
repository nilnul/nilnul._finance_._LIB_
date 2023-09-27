using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.finance.interest
{
	/// <summary>
	/// 100 yuan becomes 110 over a year. the growth is 1.1
	/// </summary>
	public class Growth
	{
		static public double FroRate(double rate) {
			return 1 + rate;
		}


	}
}
