using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num;

namespace nilnul.finance.interest.rate
{
    /// <summary>
    /// discount a future value to present value.
    /// </summary>
    public class Grow
    {
        static public nilnul.num.RealI Eval(nilnul.num.RealI money, nilnul.finance._accrual.Rate rate,  nilnul.num.RealI periods) {

            return nilnul.num.real.combine_.Multi.Singleton.combine(
				money, 
                nilnul.num.real.op_.unary_.Exp.Singleton.op(
					nilnul.num.real.combine_.Multi.Singleton.combine(
						rate.val,
						periods
					)
				)
            );

        }

    }
}
