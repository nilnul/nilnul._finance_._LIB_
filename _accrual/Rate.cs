using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.finance._accrual
{
	/// <summary>
	/// 100 becomes 110 over a year. the rate is .1 per year. So the rate is a proportion and a timespan
	/// the rate is defined to by any real number, be it positive, negative, or nil, thus free of the whether2plusOne ambiguity-- that is, it can be the rate without, or with, one plused, subject to interpretation later.
	/// </summary>
	///
	public interface IRate {

	}
	public class Rate
	{
        private nilnul.num.RealI _val;

        public nilnul.num.RealI val
        {
            get { return _val; }
            set { _val = value; }
        }



    }
}
