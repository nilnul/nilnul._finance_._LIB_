using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.finance._accrual.rate_
{
	public class FivePercentOv360days : RateDbl
	{
		public FivePercentOv360days( ) : base(0.05, TimeSpan.FromDays(360) )
		{
		}


		static public FivePercentOv360days Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<FivePercentOv360days>.Instance;
			}
		}

	}
}
