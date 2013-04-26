using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace eid
{
    public partial class WinformAbstract : Form
    {
        # region 'PublicConstructorAndVariables
        public WinformAbstract()
        {
            InitializeComponent();
        }       

        public enum State 
        {        
            Menu=0, Search =1 , Save=2
        }
        # endregion 'PublicConstructorAndVariables

        #region 'Public Methods
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        protected virtual void btnnew_Click(object sender, EventArgs e)
        {

        }

        protected virtual void btnmodify_Click(object sender, EventArgs e)
        {

        }

        protected virtual void btndelete_Click(object sender, EventArgs e)
        {

        }

        protected virtual void btnsave_Click(object sender, EventArgs e)
        {

        }

        protected virtual void btncancel_Click(object sender, EventArgs e)
        {

        }

        public void updateStatus(string Status)
        {
            StatusStripLabel.Text = Status;
        }
        #endregion 'Public Methods
    }
}
