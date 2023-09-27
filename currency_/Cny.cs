using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.finance.currency_
{
	public class Cny:CurrencyI
	{


		static public Cny Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Cny>.Instance;
			}
		}



	}
}
