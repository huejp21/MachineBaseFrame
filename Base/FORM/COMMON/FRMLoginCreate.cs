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

namespace Base.FORM.COMMON
{
  public partial class FRMLoginCreate : Form
  {
    public FRMLoginCreate()
    {
      InitializeComponent();
    }

    private void btn_loginCreate_Create_Click(object sender, EventArgs e)
    {
      if (txt_loginCreate_PW.Text.CompareTo(txt_loginCreate_CfPW.Text) != 0)
      {
        MessageBox.Show("Password is not same as Confirm Password.");
        return;
      }
      if (!CManageSystem.AddUserInfo(txt_loginCreate_ID.Text, txt_loginCreate_PW.Text, txt_loginCreate_Info.Text, eLOGIN_LEVEL.NONE))
      {
        MessageBox.Show("Create Fail.");
        return;
      }
      MessageBox.Show("Create ID Success.");
    }

    private void btn_loginCreate_Cancel_Click(object sender, EventArgs e)
    {
      txt_loginCreate_ID.Text = "";
      txt_loginCreate_PW.Text = "";
      txt_loginCreate_CfPW.Text = "";
      txt_loginCreate_Info.Text = "";
      this.Hide();
    }

    private void FRMLoginCreate_KeyPress(object sender, KeyPressEventArgs e)
    {
      char chKey = e.KeyChar;
      if (chKey == '\r')
      {
        if (txt_loginCreate_PW.Text.CompareTo(txt_loginCreate_CfPW.Text) != 0)
        {
          MessageBox.Show("Password is not same as Confirm Password.");
          return;
        }
        if (!CManageSystem.AddUserInfo(txt_loginCreate_ID.Text, txt_loginCreate_PW.Text, txt_loginCreate_Info.Text, eLOGIN_LEVEL.NONE))
        {
          MessageBox.Show("Create Fail.");
          return;
        }
        MessageBox.Show("Create ID Success.");
      }
    }

    private void txt_loginCreate_ID_Click(object sender, EventArgs e)
    {
      if (CVo.g_frmLogin.chk_login_keypad.Checked)
      {
        CVo.g_frmKeypadEnglish.SetTextBox(txt_loginCreate_ID);
        CVo.g_frmKeypadEnglish.ShowDialog("ID");
      }
    }

    private void txt_loginCreate_PW_Click(object sender, EventArgs e)
    {
      if (CVo.g_frmLogin.chk_login_keypad.Checked)
      {
        CVo.g_frmKeypadEnglish.SetTextBox(txt_loginCreate_PW);
        CVo.g_frmKeypadEnglish.ShowDialog("PASSWORD");
      }
    }

    private void txt_loginCreate_CfPW_Click(object sender, EventArgs e)
    {
      if (CVo.g_frmLogin.chk_login_keypad.Checked)
      {
        CVo.g_frmKeypadEnglish.SetTextBox(txt_loginCreate_CfPW);
        CVo.g_frmKeypadEnglish.ShowDialog("PASSWORD CONFIRM");
      }
    }

    private void txt_loginCreate_Info_Click(object sender, EventArgs e)
    {
      if (CVo.g_frmLogin.chk_login_keypad.Checked)
      {
        CVo.g_frmKeypadEnglish.SetTextBox(txt_loginCreate_Info);
        CVo.g_frmKeypadEnglish.ShowDialog("PASSWORD");
      }
    }


  }
}
