using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.regime_.prc.tax_.personal_
{
	public class Revenue
	{
		/// <summary>
		/// 应纳税额=(工资薪金所得 -“五险一金”-扣除数)×适用税率-速算扣除数
		/// </summary>
		/// <returns></returns>
		static public double ComputeTax2Pay(double payableB4Tax, double socialSecurity)
		{
			throw new NotImplementedException();

		}

		/// <summary>
		/// 
		/// </summary>
		/// 
		/*
		 1 不超过1500元的 不超过1455元的 3 0 
2 超过1500元至4500元的部分 超过1455元至4155元的部分 10 105 
3 超过4500元至9000元的部分 超过4155元至7755元的部分 20 555 
4 超过9000元至35000元的部分 超过7755元至27255元的部分 25 1005 
5 超过35000元至55000元的部分 超过27255元至41255元的部分 30 2755 

			 */
		static public Dictionary<nilnul.num.real.Interval, nilnul.num.real_.Quotient> rate = new Dictionary<num.real.Interval, num.real_.Quotient>() {
			{
				 num.real.Interval.CreateClopen(
					 0
					 ,
					 3500
				)
				,
				nilnul.num.real_.Quotient.CreatePercent(0)
			}
			,
			{
				 num.real.Interval.CreateClopen(
					 3500
					 ,
					 3500+1500
				)
				,
				nilnul.num.real_.Quotient.CreatePercent(3)
			}

			,
			{
				 num.real.Interval.CreateClopen(
					 3500+1500
					 ,
					 3500+4500
				)
				,
				nilnul.num.real_.Quotient.CreatePercent(10)
			}

			,
			{
				 num.real.Interval.CreateClopen(
					 3500+4500
					 ,
					 3500+9000
				)
				,
				nilnul.num.real_.Quotient.CreatePercent(20)
			}

			,
			{
				 num.real.Interval.CreateClopen(
					 3500+9000
					 ,
					 3500+35000
				)
				,
				nilnul.num.real_.Quotient.CreatePercent(25)
			}
			,
			{
				 num.real.Interval.CreateClopen(
					 3500+35000
					 ,
					 3500+55000
				)
				,
				nilnul.num.real_.Quotient.CreatePercent(30)
			}

			,//6 超过55000元至80000元的部分 超过41255元至57505元的部分 35 5505 

			{
				 num.real.Interval.CreateClopen(
					 3500+55000
					 ,
					 3500+80000
				)
				,
				nilnul.num.real_.Quotient.CreatePercent(35)
			}
			,
			//7 超过80000元的部分 超过57505元的部分 45 13505

			{
				 num.real.Interval.CreateClopen(
					 3500+80000
					 
				)
				,
				nilnul.num.real_.Quotient.CreatePercent(45)
			}



		};
	}
}
