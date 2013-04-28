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
    public partial class WinformUsermaster : WinformAbstract
    {
        # region 'PropertiesAndVariables

        string qry ="";
        Common com = new Common();      
        DataTable dt = new DataTable();
        MysqlConn objData = new MysqlConn();
        WinformAbstract wfAbs = new WinformAbstract();
        WinformMainmenu wfMain = new WinformMainmenu();                                               

        private bool mdelete;
        private bool DeleteState
        {
            get
            {
                return mdelete;
            }
            set
            {
                mdelete = value;
            }
        }

    # endregion 'PropertiesAndVariables

        public WinformUsermaster()
        {
            InitializeComponent();
        }

        private void WinformUsermaster_Load(object sender, EventArgs e)
        {
           // LOADCHECKBX();
            pnlUsrNew.Visible = false;
            pnlUsrView.Visible = false;
        }

        protected override void btnnew_Click(object sender, EventArgs e)
        {
            //enable / Disable the controls
            MenuMode(this, false);
            this.pnlUsrNew.Visible = true;
            this.GrbxNewUser.Enabled = true;
            this.pnlUsrView.Visible = false;
            
            //all the checkbox are checked
            LoadCheckBox("");
        }

        protected override void btnmodify_Click(object sender, EventArgs e)
        {
            MenuMode(this, false);
            this.pnlUsrNew.Visible = false;
            this.pnlUsrView.Visible = true;
            
            //load the datagrid
        }

        protected override void btndelete_Click(object sender, EventArgs e)
        {
            this.pnlUsrNew.Visible = false;
            this.pnlUsrView.Visible = true;
            DeleteState  = true;
            //load the datagrid with checkboxes
        }

        protected override void btnsave_Click(object sender, EventArgs e)
        {
            //Check if textbox null or empty
            if (string.IsNullOrEmpty(txtUsrname.Text) || string.IsNullOrEmpty(txtPass.Text) || string.IsNullOrEmpty(txtConPass.Text))
            {
                MessageBox.Show("Username and Password are Mandatory." + Environment.NewLine + "Please try again.", "Incorrect Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //check if pass and con pass match
            if (string.Compare(txtConPass.Text, txtPass.Text) != 0)
            {
                MessageBox.Show("Password and Confirm Password do not match." + Environment.NewLine + "Please try again.", "Incorrect Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPass.Text = string.Empty;
                txtUsrname.Focus();
                txtUsrname.Text = string.Empty;
                txtConPass.Text = string.Empty;
                return;
            }

            //save user into DB
            qry = "insert userprivilege(USPUSERNAME,USPPASSWORD,USPCREATEDBY,USPCREATEDON)values('" + txtUsrname.Text + "','" + txtPass.Text + "','" + User.UserId + "','" + DateTime.Now.ToString("yyyy-MM-dd") + "')";
            objData.executeQry(qry);

            qry="Select USPUSERID from userprivilege where USPUSERNAME='" + txtUsrname.Text + "'";
            int USPUserid = (int) objData.returnFirstCell(qry);

            //save userAttribute into DB
            if (wfAbs.MenuState != true)
                for (int i = this.chklstbx.Items.Count - 1; i >= 0; i--)
                {
                    qry = "insert into user_attribute(UA_user_id,UA_menu,UA_enable,UA_CREATEDBY,UA_CREATEDON,UA_MODIFIEDBY,UA_MODIFIEDon)values('" + USPUserid + "','" + i + "','" + Convert.ToInt16(this.chklstbx.GetItemChecked(i)) + "'," + com.qrytime("ins") + ")";
                    objData.executeQry(qry);
                    //status bar value inserted                   
                }

            else
                //for updates
                for (int i = this.chklstbx.Items.Count - 1; i >= 0; i--)
                {

                    qry = "update userattribute set UAenable='" + Convert.ToInt16(this.chklstbx.GetItemChecked(i)) + "'," + com.qrytime("upd", "UA") + 
                        " where  UAuserid='" + User.UserId + "' and UAmenu='" + i + "'";
                    objData.executeQry(qry);
                    //Status Bar values are updated.
                }

            //Accessing the Status bar in Winform Abstract (Parent)                         
            updateStatus(this,"Values Saved");

            //Clear all Controls After Save
            com.clearcontrol(GrbxNewUser, false);
            LoadCheckBox("reset");
            txtUsrname.Focus();
        }

        protected override void btncancel_Click(object sender, EventArgs e)
        {
            //check if on edit
            //if (com.controlisinedit(GrbxNewUser))
            //{

            //}
            MenuMode(this, false);
        }

        private void LoadCheckBox(string rcvid)
        {
            int count = 0, menuno = 0;
            chklstbx.ColumnWidth = 350;
        
            if (this.chklstbx.Items.Count != 0 && rcvid != "reset")
               return;                   
            
            //fetch the menu items and add it into checklistbox
            foreach (ToolStripMenuItem item in wfMain.Mainmenustrip.Items)
            {
                if (count < 2 )
                {    count = count + 1;
                                    
                    foreach (ToolStripMenuItem subitem in item.DropDownItems.OfType<ToolStripMenuItem>())
                     {
                       string chkname;
                       switch (item.Name)
                       {
                           case "Utilities":
                               chkname = item.Name + "........" + subitem.Name;
                               break;
                           case "Master":
                               chkname = item.Name + "..........." + subitem.Name;
                               break;
                           default:
                               chkname = item.Name + "....." + subitem.Name;
                               break;
                       }
                       if (rcvid == "" || rcvid == "reset")
                        {
                            if (rcvid == "")
                                // add the name only for new user
                                chklstbx.Items.Add(chkname, true);
                            else
                                //check state on reset
                                chklstbx.SetItemChecked(menuno, true);
                        }
                        else
                        {
                            //if user already exists,set according to his settings
                            qry = "SELECT UAmenu,UAenable FROM userattribute WHERE UAuserid='" + rcvid + "'";
                            dt = objData.getDataTable(qry);
                            chklstbx.Items.Add(chkname);
                            //check if menuno corresponds to name
                            chklstbx.SetItemChecked(menuno,(bool)dt.Rows[menuno][1]);
                        }
                        menuno += 1;
                    }
                   }
                else
                    return;
            }
          }       

        private void chklstbx_leave(object sender, EventArgs e)
        {
            //Check atleast one check box is checked
            int count = chklstbx.Items.Count;
            foreach (CheckBox chkbx in chklstbx.Items.OfType<CheckBox>())
            {
                if (chkbx.Checked)
                    count++;
            }
            if (count == 0)
            {
                MessageBox.Show("Atleast one Privilege must be selected to enable the User Account." + Environment.NewLine + "Please try again.", "Incorrect Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void txtUsrname_TextChanged(object sender, EventArgs e)
        {            
            if (string.IsNullOrEmpty(txtUsrname.Text))
                 return;
            
            //Check if Username already exists
            qry = "select USPUSERNAME from userprivilege where USPUSERNAME = '" + txtUsrname + "'";
            if (objData.returnFirstCell(qry) != null)
            {
                MessageBox.Show("Username already Exists." + Environment.NewLine + "Please try again.", "Incorrect Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPass.Text = string.Empty;
                txtUsrname.Focus();
                txtUsrname.Text = string.Empty;
                txtConPass.Text = string.Empty;
                //reflect values in user inherited status bar 
                return;
            }
        }
    }
}
