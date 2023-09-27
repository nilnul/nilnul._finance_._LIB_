using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using N = nilnul.num.bigint.be.Natural.Asserted;

namespace nilnul.finance.entry.str
{
	public class Periodic
	{
		private double _amount;

		public double amount
		{
			get { return _amount; }
			set { _amount = value; }
		}

		private nilnul.num.bigint.be.Natural.Asserted _periods;

		public N periods
		{
			get { return _periods; }
			set { _periods = value; }
		}

		public Periodic(double amount, N periods)
		{
			_amount = amount;
			_periods = periods;
		}

		public double presentVal(double compound) {


			var r = 0;
			var movingDiscount = Math.Exp(-compound);
			return nilnul.num.doubl.normal.str.Geometric_givenHead.Sum(_amount * movingDiscount, movingDiscount, _periods);
			
		}

		static public double PresentVal(double _amount, int _periods, double compound) {

			var movingDiscount = Math.Exp(-compound);
			return nilnul.num.doubl.normal.str.Geometric_givenHead.Sum(_amount * movingDiscount, movingDiscount, _periods);

		}




	}
}
