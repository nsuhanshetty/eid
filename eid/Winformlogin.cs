using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic.Devices;

namespace eid
{
    /// <summary>
    /// Login Methods.
    /// </summary>
    public partial class Winformlogin : Form
    {
        # region 'ConstructorsAndPrivateVariables
        public Winformlogin()
        {
            InitializeComponent();
        }

        int no_rows = 0;
        string qry = "";
        Object userId = null;
        //int index = 0;
        //int menuno = 1;
        DataTable dt = new DataTable();
        MysqlConn ObjData = new MysqlConn();
        WinformMainmenu wfMain = new WinformMainmenu();
        # endregion 'ConstructorsAndPrivateVariables

        //private void frmMain_KeyDown(Object sender, System.Windows.Forms.KeyEventArgs e)
        //{   ///<summary>
        //    ///Enables or Disables Label "Caps Lock is On."
        //    ///</summary>            
        //    Computer mc = new Computer();            
        //    LBLCAPSLCK.Visible = mc.Keyboard.CapsLock?true:false;
        //}
        
        private void btncncl_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (DialogResult.Yes == dr)
                this.Close();
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            statusStrip1.Text = "Authenticating..";
            //compare txt and db values            
            if (string.IsNullOrEmpty(txtusernm.Text) || string.IsNullOrEmpty(txtpasswd.Text))
            {
                MessageBox.Show("Username and Password are Mandatory." + Environment.NewLine + "Please try again.", "Incorrect Input", MessageBoxButtons.OK, MessageBoxIcon.Error);                 statusStrip1.Text = "Waiting for User's input...";
                return;
            }
            else
            {               
               userId = MysqlConn.returnFirstCell("select USPUSERID from userprivilege where USPUSERNAME='" + txtusernm.Text + "' and USPPASSWORD='" + txtpasswd.Text+"'");
               if (userId == null)
               {
                   MessageBox.Show("Username / Password is Incorrect." + Environment.NewLine + "Please try again.", "Incorrect Input", MessageBoxButtons.OK, MessageBoxIcon.Error);                   statusStrip1.Text = "Waiting for User's input...";
                   return;
               }
                //on match continue..
               User.UserId = (int)userId;
            }                         

            //insert into the log table
            qry = "insert into log_table(LT_USER_ID,LT_DATE_ENTRY,LT_TIME_OF_ENTRY)values ('" + (int)userId + "','" + DateTime.Now.Date.ToString("yyyy-MM-dd") + "','" + DateTime.Now.ToShortTimeString() + "')";
            no_rows=MysqlConn.executeQry(qry);

            ////collect respective user attributes 
            //this.qry = "select UA_menu,UA_enable from user_attribute where UA_user_id='" + userId + "'";
            //this.dt = ObjData.getDataTable(qry);
            //foreach (ToolStripMenuItem item in wfMain.Mainmenustrip.Items.OfType<ToolStripMenuItem>())
            //    if (index < 2)
            //    {
            //        index = index + 1;
            //        foreach (ToolStripMenuItem subitem in item.DropDownItems.OfType<ToolStripMenuItem>())
            //        {
            //            //if (((int)dt.Rows[this.menuno - 1][1] == 1))
            //            //    item.Enabled = true;
            //            subitem.Enabled = Convert.ToBoolean(this.dt.Rows[menuno - 1][1]);
            //            menuno = menuno + 1;
            //        }
            //    }

            //enable submenu's in the mainform
            wfMain.EnableMenu();            
            this.Close();
        }
    }
}
