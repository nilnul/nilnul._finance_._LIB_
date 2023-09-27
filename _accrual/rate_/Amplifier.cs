using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.finance._accrual.rate_
{
	/// <summary>
	/// the multiplier to the principal.
	/// for example, if the rate is 8% , the the Amplifier is (1+8%).
	/// this must be positive, as  for amplifier "x", we need ln(x) to get the compound rate.
	/// </summary>
	public class AmplifierDbl : Rate4dblI
	{

		static public double ExpCoefOfAmplifier(double multi)
		{
			return Math.Log(multi);
		}
		static public double ExpCoefOfAmplifier(nilnul.num.real.be_.positive.vow.EeDbl multi)
		{
			return ExpCoefOfAmplifier(multi.ee);
		}

		private nilnul.num.real.be_.positive.vow.EeDbl _multiplier;

		public nilnul.num.real.be_.positive.vow.EeDbl multiplier
		{
			get { return _multiplier; }
			set { _multiplier = value; }
		}

		private nilnul.time.grad.deviation.be_.positive.vow.Ee _duration;

		public nilnul.time.grad.deviation.be_.positive.vow.Ee duration
		{
			get { return _duration; }
			set { _duration = value; }
		}

		public double exponentCoef
		{
			get => ExpCoefOfAmplifier(_multiplier);
			set => this._multiplier = new num.real.be_.positive.vow.EeDbl(Math.Exp(value));
		}

		/// <summary>
		/// the x in a*e^(xt).
		/// </summary>
		/// <remarks>
		/// alias:
		///		igniter
		///		trigger
		///		detonator
		///		fuse
		/// </remarks>
		/// <returns></returns>
		static public double AmplifierOfExploder(double exploder)
		{
			return Math.Exp(exploder);
		}


		public AmplifierDbl(
			nilnul.num.real.be_.positive.vow.EeDbl addend
			,
			nilnul.time.grad.deviation.be_.positive.vow.Ee timespan

		)
		{
			this._multiplier = addend;
			this._duration = timespan;
		}

		public AmplifierDbl(
			double multiplier
			,
			nilnul.time.grad.deviation.be_.positive.vow.Ee timespan

		) : this(
			new num.real.be_.positive.vow.EeDbl(multiplier)
			,
			timespan
		)
		{

		}



		public _accrual.RateDbl toExp()
		{
			return new RateDbl(
				Math.Log(this._multiplier)
				,
				this._duration
			);
		}

	}
}
