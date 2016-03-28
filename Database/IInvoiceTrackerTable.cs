/*
 * Created by SharpDevelop.
 * User: HTREMMEL
 * Date: 3/23/2016
 * Time: 11:09 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace InvoiceTracker.Database
{
	/// <summary>
	/// Description of IInvoiceTrackerTable.
	/// </summary>
	public interface IInvoiceTrackerTable
	{
		void Update();
		void Insert();
		void Delete();
		void Clear();
	}
}
