using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InvoiceTracker.Database;

namespace InvoiceTracker.Forms
{
    public partial class Main : Form
    {
        public InvoiceTrackerDB Model { get; set; }

        public Main()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            NewProject np = new NewProject() { Model = this.Model };
            np.ShowDialog();
        }
    }
}
