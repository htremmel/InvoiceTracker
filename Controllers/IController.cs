using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InvoiceTracker.Views;
using InvoiceTracker.Database;


namespace InvoiceTracker.Controllers
{
	public interface IController
	{
		IInvoiceTrackerDb Model { get; }
		IView View { get; }
		
		void OnClick();
		void OnExit();
		void OnEnter();		
	}

}
