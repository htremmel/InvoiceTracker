using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using InvoiceTracker.Database;
using InvoiceTracker.Controllers;
using InvoiceTracker.Views;
using System.IO;
using LinqToDB.Data;

using NUnit.Framework;

namespace InvoiceTracker_2_Test
{
    [TestFixture]
    public class ControllerTests
    {
        string connString;
        
        public InvoiceTrackerDB Model
        {
            get { return new InvoiceTrackerDB(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Documents\Dropbox\2-Projects\InvoiceTracker_2\InvoiceTracker.accdb"); }
        }

        [Test]
        void IsConnected()
        {
            
        }

        [Test]
        void IsClosed()
        {

        }

        [Test]
        public void Exists()
        {
            FileInfo fi = new FileInfo(@"D:\Documents\Dropbox\2-Projects\InvoiceTracker_2\InvoiceTracker.accdb");
            Assert.IsTrue(fi.Exists);
        }

        [Test]
        public void ControllerInsert()
        {
            ProjectController.Insert(new Project() {ProjectId = "1234",
                                                    Name = "Test",
                                                    Summary = "Test",
                                                    SuperDistrict = "t"},
                                                    this.Model);
        }
    }
}
