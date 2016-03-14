using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InvoiceTracker.Views;
using InvoiceTracker.Database;
using InvoiceTracker.Controllers;

namespace InvoiceTracker.Forms
{
    public partial class NewProject : Form, IProjectView
    {
        ProjectController _cntrl;

        public InvoiceTrackerDb Model { get; set; }

        public NewProject()
        {
            InitializeComponent();
            this.AddListner(new ProjectController(this, this.Model));            
        }

        private void NewProject_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            _cntrl.Insert();
        }

        int IProjectView.Id
        {
            get
            {
                return 0;
            }
            set
            {
                
            }
        }

        string IProjectView.Name
        {
            get
            {
                return this.txbProjectName.Text;
            }
            set
            {
                this.txbProjectName.Text = value;
            }
        }

        string IProjectView.Summary
        {
            get
            {
                return this.txtSummary.Text;
            }
            set
            {
                this.txtSummary.Text = value;
            }
        }

        string IProjectView.SuperDistrict
        {
            get
            {
                return this.txbSupDistrict.Text;
            }
            set
            {
                this.txbSupDistrict.Text = value;
            }
        }

        bool IProjectView.IsComplete
        {
            get
            {
                return false;
            }
            set
            {
                
            }
        }

        string IProjectView.ProjectId
        {
            get
            {
                return this.txbProjectId.Text;
            }
            set
            {
                this.txbProjectId.Text = value;
            }
        }

        public void AddListner(Controllers.ProjectController cntrl)
        {
            _cntrl = cntrl;
        }
    }
}
