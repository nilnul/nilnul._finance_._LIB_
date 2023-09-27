using System.Collections.Generic;
using System.Linq;

namespace nilnul.finance.venture.present.on_.rate_
{
	/// <summary>
	/// the venture has at least one nonzero earnings|future|prediction|balance;
	/// </summary>
	/// <remarks>
	/// this is not a monotone function;
	/// </remarks>
	public class OfDiscounts
		: nilnul.obj.Box_ofIn<
			IEnumerable<(double duration, double future)>
		>
		,
		nilnul.num.real.op_.Unary4dblI
	{

		static public (double duration, double future)[] Group9lean9order(in IEnumerable<(double duration, double future)> val) 
		{
			return val.GroupBy(x => x.duration).Select(
				g => (duration: g.Key , future:g.Sum(t => t.future) )
			).Where(d=>d.future!=0).OrderBy(x=>x.duration).ToArray();
		}


		public double op(double rate)
		{
			//if (!boxed.Any())
			//{
			//	return 0;
			//}
			// monotonic;

			if (rate == double.NegativeInfinity)
			{
				return boxed.Last().future >0? double.PositiveInfinity: double.NegativeInfinity;
			}

			return boxed.Select( d=> nilnul.finance.interest._DiscountX.OfExpRate(rate,d.duration,d.future) ).Sum();
			
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="val">
		/// there exists  at least a duration such that for that duration, the total future is not nil;
		/// </param>
		public OfDiscounts(in IEnumerable<(double duration, double future)> val) : base(
			Group9lean9order(val)
		)
		{
			
		}

		public OfDiscounts(IEnumerable<(double duration, double future)> x) : this(in x)
		{
		}


	}
}
