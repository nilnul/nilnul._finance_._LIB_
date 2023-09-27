using nilnul.time.grad.deviation.be_.positive.vow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.finance._accrual.rate_
{
	/// <summary>
	/// this must be gt -one, as to make amplifier positive, we need 1+this to be positive.
	/// The timespan is defaulted to second
	/// </summary>
	public class AdditionalDbl
		:Rate4dblI
		
	{
		static public double AmplifierOfAdditional(double x)
		{
			return 1 + x;
		}

		static public double AdditionalOfAmplifier(double x)
		{
			return  x-1;
		}



		static public double ExpCoefOfAdditional(double x)
		{
			return AmplifierDbl.ExpCoefOfAmplifier(
				AmplifierOfAdditional(x)
			);
		}
		static public double AdditionalOfExpander(double x)
		{
			return AdditionalOfAmplifier(
				AmplifierDbl.AmplifierOfExploder(x)
			);
		}



		private nilnul.num.real.be_.gtNegOne.vow.EeOfDouble _addend;

		public nilnul.num.real.be_.gtNegOne.vow.EeOfDouble addend
		{
			get { return _addend; }
			set { _addend = value; }
		}

		private nilnul.time.grad.deviation.be_.positive.vow.Ee _duration;

		public nilnul.time.grad.deviation.be_.positive.vow.Ee duration
		{
			get { return _duration; }
			set { _duration = value; }
		}

		public double exponentCoef {
			get =>ExpCoefOfAdditional(_addend);
			set => this._addend= new num.real.be_.gtNegOne.vow.EeOfDouble( AdditionalOfExpander(value) ) ; }

		public AdditionalDbl(
			nilnul.num.real.be_.gtNegOne.vow.EeOfDouble addend
			,
			nilnul.time.grad.deviation.be_.positive.vow.Ee timespan

		)
		{
			this._addend = addend;
			this._duration = timespan;
		}

		public AdditionalDbl(double x, Ee timespan):this(new num.real.be_.gtNegOne.vow.EeOfDouble(x),timespan)
		{
		}

		static public AdditionalDbl OfPercent(
			double x
			,
			nilnul.time.grad.deviation.be_.positive.vow.Ee timespan
		) {
			return new AdditionalDbl(x/100,timespan);
		}

		static public AdditionalDbl OfPercent(
			double x
			,
			TimeSpan timespan
		) {
			return OfPercent(x,new Ee(timespan) );
		}

		public static AdditionalDbl OfPercentIn365days(double val)
		{
			return OfPercent(
				val
				,
				TimeSpan.FromDays(365)
			);
		}

		public _accrual.rate_.AmplifierDbl toMulti() {
			return new AmplifierDbl(
				1 + _addend
				,
				this._duration
			);
		}



		public _accrual.RateDbl toExp() {
			return toMulti().toExp();
		}

	}
}
