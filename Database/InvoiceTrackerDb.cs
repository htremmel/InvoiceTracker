using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqToDB.DataProvider.Access;
using System.IO;
using System.Xml;

namespace InvoiceTracker.Database
{
    public partial class InvoiceTrackerDB 
    {
        private InvoiceTrackerDB(AccessDataProvider accessDb, string connectionString): base(accessDb,connectionString)
        {
            InitDataContext();
        }

        public static InvoiceTrackerDB AccessDatabaseProvider(string connectionString)
        {
            return new InvoiceTrackerDB(new AccessDataProvider(), connectionString);
        }
    }

}
