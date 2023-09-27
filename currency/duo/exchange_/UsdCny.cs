using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.real.be_;
using nilnul.obj.aver_;
using nilnul.finance.currency_;

namespace nilnul.finance.currency.duo.exchange_
{
	public class UsdCny : Exchange
	{
		public UsdCny( nilnul.num.real.be_.positive.vow.En rate) : base(Usd.Singleton, Cny.Singleton, rate)
		{
		}

		
		

	}
}
