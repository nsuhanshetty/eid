using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace eid   
{
    class Common
    {
        public void clearcontrol(Control container, Boolean Recurse)
        {
            foreach (Control ctrol in container.Controls)
            {
                // substitute with switch case
                if (ctrol is TextBox)
                {
                    TextBox txt = (TextBox)ctrol;
                    txt.Text = "";
                }

                if (ctrol is CheckBox)
                {
                    CheckBox chkbx = (CheckBox)ctrol;
                    chkbx.Checked = false;
                }

                if (ctrol is ComboBox)
                {
                    ComboBox cbobx = (ComboBox)ctrol;
                    cbobx.SelectedIndex = -1;
                }

                if (ctrol is DateTimePicker)
                {
                    DateTimePicker dtp = (DateTimePicker)ctrol;
                    dtp.Value = DateTime.Now;
                }

                if (Recurse)
                {
                    if (ctrol is Panel)
                    {
                        Panel pnl = (Panel)ctrol;
                        clearcontrol(pnl, Recurse);
                    }
         
                    if (ctrol is GroupBox)
                    {
                        GroupBox grbx = (GroupBox)ctrol;
                        clearcontrol(grbx, Recurse);
                    }
                }
            }
        }

        public bool controlisinedit( Control.ControlCollection controls)
        { 
            foreach (Control c in controls.OfType<TextBox>())
            {     
                  if (c.Text != "")
                     return true;                     
            }  
      
            //else
            return false;    
        }

        public string qrytime(String qry, string  str = "")
        {
            if (qry == "ins")
                return "'" + User.UserId + "','" + DateTime.Now.Date.ToString("yyyy/MM/dd") + " " + DateTime.Now.ToString("HH:mm:ss") + "','" + User.UserId + "','" + DateTime.Now.Date.ToString("yyyy/MM/dd") + " " + DateTime.Now.ToString("HH:mm:ss") + "'";

            else if (qry == "upd")
                return str + "MODIFIEDBY='" + User.UserId + "'," + str + "MODIFIEDON='" + DateTime.Now.Date.ToString("yyyy/MM/dd") + " " + DateTime.Now.ToString("HH:mm:ss") + "'";
            else
                return null;
         }

    }       

}
