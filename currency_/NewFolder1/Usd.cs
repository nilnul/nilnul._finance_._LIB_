using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.finance
{
	public partial class Usd:CurrencyI
	{



		public override string ToString()
		{
			return "Usd";
		}


		static public Usd Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Usd>.Instance;
			}
		}

	}
}
