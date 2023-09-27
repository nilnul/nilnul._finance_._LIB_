using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.finance.interest
{
	public class PresentVal
	{

		static public double Pv_payAtEnd_ofAdditionRate(double rate, int periods, double payment) {

			var r = 0d;
			for (int i = 0; i < periods; i++)
			{
				r += _DiscountX.OfAdditionRate(rate, i + 1, payment);
			}

			return r;
  
		}



	}
}
