using System.Collections.Generic;
using System.Linq;

namespace nilnul.finance.invest.divvy.on_.rate_
{
	/// <summary>
	/// future value are positive; 
	/// </summary>
	/// <remarks>
	/// this ensures a monotone dwindling function;
	/// </remarks>
	public class OfDiscounts
		: nilnul.obj.Box_ofIn<
			IEnumerable<(double duration, double future)>
		>
		,
		nilnul.num.real.op_.Unary4dblI
	{


		public double op(double rate)
		{
			

			return boxed.Select( d=> nilnul.finance.interest._DiscountX.OfExpRate(rate,d.duration,d.future) ).Sum();
			
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="val">
		/// there exists  at least a duration such that for that duration, the total future is not nil;
		/// </param>
		public OfDiscounts(in IEnumerable<(double duration, double future)> val) : base(
			(val)
		)
		{
			
		}

		public OfDiscounts(IEnumerable<(double duration, double future)> x) : this(in x)
		{
		}


	}
}
