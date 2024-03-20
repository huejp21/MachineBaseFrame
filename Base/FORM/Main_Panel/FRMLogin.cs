using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Base.Value;
using Base.Function;

namespace Base.FORM.Main_Panel
{
  public partial class FRMLogin : Form
  {
    public FRMLogin()
    {
      InitializeComponent();
    }

    private void btn_login_createID_Click(object sender, EventArgs e)
    {
      CVo.g_frmUserCreate.ShowDialog();
    }

    private void btn_login_manageID_Click(object sender, EventArgs e)
    {
      if (txt_login_ID.Text.Trim().CompareTo("") == 0)
      {
        MessageBox.Show("Please Enter ID.");
        return;
      }
      if (txt_login_PW.Text.Trim().CompareTo("") == 0)
      {
        MessageBox.Show("Please Enter Password.");
        return;
      }
      if (txt_login_ID.Text.CompareTo(CVo.SUPER_ID) == 0)
      {
        if (txt_login_PW.Text.CompareTo(CVo.SUPER_PW) == 0)
        {
          CVo.g_frmUserManager.ShowDialog();
          return;
        }
        else 
        {
          MessageBox.Show("Password does not match.");
          return;
        }
      }
      else
      {
        CManageSystem.LoadUserInfo();
        
        if (CVo.USER_INFO.Count <= 0)
        {
          MessageBox.Show("No User Data");
          return;
        }
        bool bExist = false;
        int nIndex = -1;
        for (int i = 0; i < CVo.USER_INFO.Count; i++)
        {
          if (CVo.USER_INFO[i].Split(',')[0].CompareTo(txt_login_ID.Text) == 0)
          {
            nIndex = i;
            bExist = true;
            break;
          }
        }
        if (!bExist)
        {
          MessageBox.Show("ID does not exist.");
          return;
        }
        if (CVo.USER_INFO[nIndex].Split(',')[1].CompareTo(txt_login_PW.Text) != 0)
        {
          MessageBox.Show("Password does not match.");
          return;
        }
        if (CVo.USER_INFO[nIndex].Split(',')[3].CompareTo("") != 0) //Admin
        {
          MessageBox.Show("An Unauthorized ID.");
          return;
        }
      }
      CVo.g_frmUserManager.ShowDialog();
    }

    private void txt_login_ID_Click(object sender, EventArgs e)
    {

      if (chk_login_keypad.Checked)
      {
        CVo.g_frmKeypadEnglish.SetTextBox(txt_login_ID);
        CVo.g_frmKeypadEnglish.ShowDialog("ID");
      }
    }

    private void FRMLogin_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (chk_login_keypad.Checked)
        {
            CVo.g_frmKeypadEnglish.SetTextBox(txt_login_ID);
            CVo.g_frmKeypadEnglish.ShowDialog("ID");
        }

    }

    private void btn_login_login_Click(object sender, EventArgs e)
    {
        if (chk_login_keypad.Checked)
        {
            CVo.g_frmKeypadEnglish.SetTextBox(txt_login_ID);
            CVo.g_frmKeypadEnglish.ShowDialog("ID");
        }
    }
  }
}
