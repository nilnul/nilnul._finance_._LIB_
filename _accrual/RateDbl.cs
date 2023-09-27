using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.finance._accrual
{
	/// <summary>
	/// A * e^(Tr), where A is the principal, e is the natural logrithm base, T is the duration, r is this rate.
	/// </summary>
	/// <remarks>
	/// e^p=(1+a)=m, where p is this rate, m is <see cref="rate_.AmplifierDbl"/>, a is <see cref="rate_.AdditionalDbl"/>;
	/// hence p=ln(m)=ln(1+a);
	/// </remarks>
	///

	public class RateDbl : _accrual.IRate, Rate4dblI
	{
		private double _exponentCoef;

		/// <summary>
		///  A * e^(Tr), where A is the principal, e is the natural logrithm base, T is the duration, r is this.
		/// </summary>
		public double exponentCoef
		{
			get { return _exponentCoef; }
			set { _exponentCoef = value; }
		}

		private nilnul.time.grad.deviation.be_.positive.vow.Ee _duration;
		public nilnul.time.grad.deviation.be_.positive.vow.Ee duration
		{
			get { return _duration; }
			set { _duration = value; }
		}

		public RateDbl(double val, nilnul.time.grad.deviation.be_.positive.vow.Ee timespan)

		{
			this._duration = timespan;
			this._exponentCoef = val;
		}

		public RateDbl(double val, TimeSpan timeSpan) : this(val, new time.grad.deviation.be_.positive.vow.Ee(timeSpan))
		{
		}

		//public RateDbl(double val) : this(val, TimeSpan.FromSeconds(1))
		//{
		//}

		public RateDbl toMultiDuration(
			nilnul.num.real.be_.positive.vow.EeDbl multiplier
		)
		{
			return new RateDbl(
				this._exponentCoef * multiplier
				,

				TimeSpan.FromMilliseconds(
					this._duration.ee.TotalMilliseconds * multiplier
				)
			);
		}

		public RateDbl toDivideDuration(
			nilnul.num.real.be_.positive.vow.EeDbl multiplier
		)
		{
			return new RateDbl(
				this._exponentCoef / multiplier
				,

				TimeSpan.FromMilliseconds(
					this._duration.ee.TotalMilliseconds / multiplier
				)
			);
		}

		public static RateDbl OfDays(double val)
		{
			return new RateDbl(
				val, TimeSpan.FromDays(1)
			);
		}

		public static RateDbl Of365days(double val)
		{
			return new RateDbl(
				val, TimeSpan.FromDays(365)
			);
		}

		public static RateDbl Of30days(double val)
		{
			return new RateDbl(
				val, TimeSpan.FromDays(30)
			);
		}


	

	}
}
