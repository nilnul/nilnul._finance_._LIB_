using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using N = nilnul._num.bigint.be.Natural.Asserted;
using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;
using Qr = nilnul.num.real_.Quotient;
using R = nilnul.num.RealI;
using Rx = nilnul.num.RealIX;

using nilnul.num.real;
using nilnul.num;
using nilnul.num.quotient_;

namespace nilnul.finance.currency.duo
{
	public class Exchange
	{
		private CurrencyI _src;

		public CurrencyI src
		{
			get { return _src; }
			set { _src = value; }
		}

		private CurrencyI _dst;

		public CurrencyI dst
		{
			get { return _dst; }
			set { _dst = value; }
		}

		private nilnul.num.real.be_.positive.vow.En _rate;

		public nilnul.num.real.be_.positive.vow.En rate
		{
			get { return _rate; }
			set { _rate = value; }
		}

		public Exchange(CurrencyI src, CurrencyI dst, nilnul.num.real.be_.positive.vow.En rate)
		{
			_src = src;
			_dst = dst;
			_rate = rate;
		}

		[Obsolete]
		public RealI convert(double src)
		{
			

			return  nilnul.num.quotient_._ObsoletedX.ToQuotient( nilnul.num.quotient.continuedFrac.to_.Quotient.Singleton.to(src,
				new num_.Positive(10000)
				) )
				* _rate.en.ToReal();

		}

		static public Real Convert(double src, double rate, nilnul.num_.Positive forPrecision)
		{

			return ( nilnul.num.quotient.continuedFrac.to_.Quotient.Singleton.to(
				src,
				forPrecision

			).ToQuotient()
			*
			nilnul.num.quotient.continuedFrac.to_.Quotient.Singleton.to(
				rate,
				forPrecision
			).ToQuotient() ).ToReal();
		}
	}
}
