using nilnul.finance.currency;
using nilnul.finance.currency_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.finance.currencies
{
	public class ExchangeRate
	{
		private CurrencyI _prime;

		public CurrencyI prime
		{
			get { return _prime; }
			set { _prime = value; }
		}

		private CurrencyI _target;

		public CurrencyI target
		{
			get { return _target; }
			set { _target = value; }
		}

		private double _rate;

		public double rate
		{
			get { return _rate; }
			set { _rate = value; }
		}


		public ExchangeRate(CurrencyI prime, CurrencyI target, double rate)
		{

			_prime = prime;
			_target = target;
			_rate = rate;
		}


		static public ExchangeRate CreatePoundCny(double rate) {

			return new ExchangeRate(Pound.Singleton, Cny.Singleton, rate);
		}




	}
}
