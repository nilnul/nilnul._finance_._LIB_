using nilnul.num.real.expr.equation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.finance._accrual.rate_
{
	/*折现表达式是个关于y的严格减函数*/
	/// <summary>
	/// 
	/// </summary>
	static public class _InternalRateOfReturnX
	{

		static public double Solve(Dictionary<double,double> durationFlow) {

			Func<double, double> func = irr => {
				double currentValue = 0;
				foreach (var item in durationFlow)
				{
					currentValue += item.Value / Math.Exp(item.Key* irr);
				}
				return currentValue;

			};


			return BinarySearchX._Solve(func, 0, 0, 1).Value;

		}
	}
}
