/*
 * Created by SharpDevelop.
 * User: HTREMMEL
 * Date: 3/23/2016
 * Time: 11:05 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using InvoiceTracker.Controllers;

namespace InvoiceTracker.Views
{
	/// <summary>
	/// Description of Interface1.
	/// </summary>
	public interface IView
	{
		IController Controller { get; }
		
		void UpdateView();
		void AddListner(IController controller);
	}
}
