using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.finance
{
	static public class _AccrualX
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="principal"></param>
		/// <param name="timeSpan">if negative, meaning to discount the present value to a past value</param>
		/// <returns></returns>
		static public double EndVal(double initialValue, _accrual.Rate4dblI rate4Dbl, TimeSpan timeSpan)
		{

			return initialValue * Math.Exp(
				timeSpan.TotalMilliseconds / rate4Dbl.duration.ee.TotalMilliseconds * rate4Dbl.exponentCoef
				);

		}

		static public double EndValOfDays(double principal, _accrual.Rate4dblI rate4Dbl, int days)
		{
			return EndVal(principal, rate4Dbl, TimeSpan.FromDays(days));
		}
		static public double EndValOfYears(double principal, _accrual.Rate4dblI rate4Dbl, int yrs)
		{
			return EndValOfDays(principal, rate4Dbl, (yrs*365));
		}


	}
}
