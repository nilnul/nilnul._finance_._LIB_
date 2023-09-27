using nilnul.num.real.be_.positive.vow;
using nilnul.time.grad.deviation.be_.positive.vow;
	//.bound.metric.be_.positive.vow;
using System;

namespace nilnul.finance._accrual
{
	/// <summary>
	/// 
	/// </summary>
	public interface Rate4dblI
		:_accrual.IRate
	{
		Ee duration { get; set; }
		/// <summary>
		/// the instantaneous rate of change (that is, the derivative) of a quantity with respect to time is proportional to the quantity itself.
		/// </summary>
		/// <remarks>
		/// alias:
		///		expansion
		///		explosion
		///		growth.
		///		compound
		/// </remarks>
		double exponentCoef { get; set; }

		
	}
}