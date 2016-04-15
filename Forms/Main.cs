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
        public LoggedInUser User { get; set; }

        public Main()
        {
            InitializeComponent();
        }

        #region Support classes
        class SummaryTreeView
        {
            TreeView _listner;
            LoggedInUser _user;
            InvoiceTrackerDB _model;

            public SummaryTreeView(LoggedInUser user, InvoiceTrackerDB model)
            {
                this._user = user;
                this._model = model;
            }

            public void FillTreeView(TreeView listner)
            {
                this._listner = listner;
                PopulateTreeviewListner();
            }

            private void PopulateTreeviewListner()
            {
                _listner.Nodes.Add(new UserTree(this._user, this._model));
            }

            class UserTree: TreeNode
            {
                LoggedInUser _user;
                InvoiceTrackerDB _model;

                public UserTree(LoggedInUser user, InvoiceTrackerDB model): base()
                {
                    this.Text = SetUserTreeNodeText();
                    UserTreeFactory();
                }

                void UserTreeFactory()
                {
                    List<Project> projects = _user.GetProjects(_model);

                    foreach (var proj in projects)
                    {
                        this.Nodes.Add(new ProjectNode(proj));
                    }
                }                

                string SetUserTreeNodeText()
                {
                    return string.Format("{0}'s Projects", this._user.Information.FirstName);
                }
            }

            class ProjectNode: TreeNode
            {
                public ProjectNode(Project project)
                {

                }
                
            }

            class InvoiceNode
            {
            
            }

            class DeliverablesNode
            {
            
            }
        }

        #endregion

        

        

    }
}
