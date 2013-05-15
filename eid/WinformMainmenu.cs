using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace eid
{
    public partial class WinformMainmenu : Form
    {
        private int childFormNumber = 0;
        int index = 0;
        int menuno = 1;
        string qry = "";
        DataTable dt = new DataTable();
        MysqlConn ObjData = new MysqlConn();

        public WinformMainmenu()
        {
            InitializeComponent();
        }



        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void AboutustoolStripMenuItem3_Click(object sender, EventArgs e)
        {
            //WinformAboutus WinformAboutus = new WinformAboutus();
           // WinformAboutus.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void CalculatorAccess_Click(object sender, EventArgs e)
        {
            Process.Start("calc.exe");
        }

        private void Loginbtn_Click(object sender, EventArgs e)
        {
            Winformlogin wfLogin = new Winformlogin();
            wfLogin.Show();
        }

        private void Staffdetails_Click(object sender, EventArgs e)
        {

        }

        private void UserMasterAccess_Click(object sender, EventArgs e)
        {
            WinformUsermaster wfUserMast = new WinformUsermaster();
            wfUserMast.ShowDialog();
        }

        private void WinformMainmenu_Load(object sender, EventArgs e)
        {
            Winformlogin login = new Winformlogin();
            login.Show();            
        }

        public void EnableMenu()
        {
            //collect respective user attributes 
            this.qry = "select UA_menu,UA_enable from user_attribute where UA_user_id='" + User.UserId + "'";
            this.dt = ObjData.getDataTable(qry);
            foreach (ToolStripMenuItem item in this.Mainmenustrip.Items.OfType<ToolStripMenuItem>())
                if (index < 2)
                {
                    index = index + 1;
                    foreach (ToolStripMenuItem subitem in item.DropDownItems.OfType<ToolStripMenuItem>())
                    {
                        //if (((int)dt.Rows[this.menuno - 1][1] == 1))
                        //    item.Enabled = true;
                        subitem.Enabled = Convert.ToBoolean(this.dt.Rows[menuno - 1][1]);
                        menuno = menuno + 1;
                    }
                }            
        }
    }
}
