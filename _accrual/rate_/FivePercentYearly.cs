using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.finance._accrual.rate_
{
	public class FivePercentOv365days : RateDbl
	{
		public FivePercentOv365days( ) : base(0.05, TimeSpan.FromDays(365) )
		{
		}

		static public FivePercentOv365days Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<FivePercentOv365days>.Instance;
			}
		}

	}
}
