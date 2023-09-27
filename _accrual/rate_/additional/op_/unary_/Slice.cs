using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.finance._accrual.rate_.additional.op_.unary_
{
	/// <summary>
	/// slice the period, say year, to shorter period (such as month) or longer period; and computer the rate for the shorter period
	/// </summary>
	static public class _SliceX
	{
		static public double Exponential(double rateAdd, double periodMultiplier)
		{

			return 	exp.convert_._SliceX.Slice(
					rate._ConvertX.Add2Exp(rateAdd)
					,
					periodMultiplier
				)
			;

		}
		/// <summary>
		/// 
		/// </summary>
		/// <param name="rateAdd"></param>
		/// <param name="periodMultiplier"></param>
		/// <returns>additional</returns>
		static public double Slice(double rateAdd, double periodMultiplier)
		{

			return _accrual.rate._ConvertX.Exp2Add(
				exp.convert_._SliceX.Slice(
					rate._ConvertX.Add2Exp(rateAdd)
					,
					periodMultiplier
				)
			);

		}


		static public double Year2Month(double rate)
		{
			return Slice(rate, 1d / 12);
		}
		static public double Year2Day(double rate)
		{
			return Slice(rate, 1d / 365);
		}

		static public double Month2Year(double rate)
		{
			return Slice(rate,12);
		}


	}
}
