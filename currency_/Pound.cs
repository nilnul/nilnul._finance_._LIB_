using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.finance.currency
{
	public class Pound:CurrencyI
	{


		static public Pound Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Pound>.Instance;
			}
		}


	}
}
