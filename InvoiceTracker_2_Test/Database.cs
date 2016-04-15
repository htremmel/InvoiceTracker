using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using InvoiceTracker.Database;
using System.IO;
using LinqToDB.Data;
using System.Data;
using LinqToDB;

using NUnit.Framework;

namespace InvoiceTracker_2_Test
{
    [TestFixture]
    public class ControllerTests
    {        
        InvoiceTrackerDB Model
        {
            get
            {
                return InvoiceTrackerDB.AccessDatabaseProvider(@"Provider=Microsoft.ACE.OLEDB.12.0;
                    Data Source=D:\Dropbox\2-Projects\_Git_Root\InvoiceTracker\0-Database\InvoiceTracker.accdb;Persist Security Info=False");
            }
        }

        string AccessDbPath
        {
            get
            {
                return Directory.GetParent(this.ExecutingAssemblyPath).ToString();
            }
        }

        string ExecutingAssemblyPath
        {
            get
            {
                return Path.GetDirectoryName(Assembly.GetExecutingAssembly().GetName().CodeBase);
            }
        }

        string DatabaseName
        {
            get
            {
                return "InvoiceTracker.accdb";
            }
        }        

        [Test]
        public void DoesItConnect()
        {
            using (var db = this.Model)
            {
                Assert.IsTrue(this.Model.Connection.State == ConnectionState.Open);
            }
        }

        [Test]
        public void CanItInsertAnActorRecord()
        {
            using (var db = this.Model)
            {
                Actor ac = new Actor()
                {
                    FirstName = "Test",
                    LastName = "Tester"
                };
                db.InsertWithIdentity(ac);
            }
        }

        [Test]
        public void CanItQueryAProjectRecord()
        {
            using (var db = this.Model)
            {
                var proj = from p in db.Projects where p.ProjectId == "FCC0001239" select p;
                Console.WriteLine(proj.Count());
                Assert.IsNotNull(proj);
            }
        }
    }
}
