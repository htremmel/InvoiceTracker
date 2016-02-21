using System.Configuration;

namespace InvoiceTracker
{
   public static class ConnfigurationStrings
   {	
      public static string AccessDb
      {      
      	get { return ConfigurationManager.ConnectionStrings["AccessDb"].ConnectionString; }
      }		
   } 
}





