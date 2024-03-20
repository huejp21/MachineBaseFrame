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
  public partial class FRMLoginManager : Form
  {
    public FRMLoginManager()
    {
      InitializeComponent();
    }

    private bool UpdateList()
    {
      if (!CManageSystem.LoadUserInfo())
      {
        return false;
      }
      list_loginManager_ID.Items.Clear();
      for (int i = 0; i < CVo.USER_INFO.Count; i++)
      {
        list_loginManager_ID.Items.Add(CVo.USER_INFO[i].Split(',')[(int)eUserInfo.ID]);
      }
      return true;
    }

    private void FRMLoginManager_Load(object sender, EventArgs e)
    {
      cb_loginManager_LEVEL.Items.Clear();
      for (int i = 0; i < (int)eLOGIN_LEVEL.COUNT; i++)
			{
        if ((int)eLOGIN_LEVEL.DEVELOPER == i) { continue; }
        cb_loginManager_LEVEL.Items.Add(((eLOGIN_LEVEL)i).ToString());
			}
      cb_loginManager_LEVEL.SelectedIndex = 0;
    }

    private void FRMLoginManager_Shown(object sender, EventArgs e)
    {
      if (!UpdateList())
      {
        System.Windows.Forms.MessageBox.Show("Cannot Load User Information.");
        return;
      }
    }

    private void list_loginManager_ID_Click(object sender, EventArgs e)
    {
      int nIndex = list_loginManager_ID.SelectedIndex;
      if (nIndex >= CVo.USER_INFO.Count
        || nIndex < 0)
      {
        return;
      }
      txt_loginManager_ID.Text = CVo.USER_INFO[nIndex].Split(',')[(int)eUserInfo.ID];
      txt_loginManager_PW.Text = CVo.USER_INFO[nIndex].Split(',')[(int)eUserInfo.PW];
      txt_loginManager_PWC.Text = CVo.USER_INFO[nIndex].Split(',')[(int)eUserInfo.PW];
      txt_loginManager_INFO.Text = CVo.USER_INFO[nIndex].Split(',')[(int)eUserInfo.INFO];
      cb_loginManager_LEVEL.Text = CVo.USER_INFO[nIndex].Split(',')[(int)eUserInfo.LEVEL];
      
    }

    private void btn_loginManager_Close_Click(object sender, EventArgs e)
    {
      this.Hide();
    }

    private void btn_loginManager_Change_Click(object sender, EventArgs e)
    {
      string strID = txt_loginManager_ID.Text;
      string strPW = txt_loginManager_PW.Text;
      string strPWC = txt_loginManager_PWC.Text;
      string strINFO = txt_loginManager_INFO.Text;
      string strLEVEL = cb_loginManager_LEVEL.Text;

      //Check null
      if (strID.Trim().CompareTo("") == 0) 
      {
        MessageBox.Show("Please Enter ID.");
        return; 
      }

      if (strPW.Trim().CompareTo("") == 0
        || strPWC.Trim().CompareTo("") == 0)
      {
        MessageBox.Show("Please Enter Password.");
        return;
      }

      if (strPW.Trim().CompareTo(txt_loginManager_PWC.Text) != 0)
      {
        MessageBox.Show("Password does not match.");
        return;
      }

      //Check Blank Space
      if (strID.Trim().CompareTo(strID) != 0
        || strPW.Trim().CompareTo(strPW) != 0
        || strPWC.Trim().CompareTo(strPWC) != 0
        || strINFO.Trim().CompareTo(strINFO) != 0) 
      {
        MessageBox.Show("Spaces are not allowed.");
        return;
      }

      //Check Block Word
      System.Text.RegularExpressions.Regex AllowWord = new System.Text.RegularExpressions.Regex(@"[a-zA-Z0-9_]");
      for (int i = 0; i < strID.Length; i++)
      {
        if (!AllowWord.IsMatch(string.Format("{0}", strID[i])))
        {
          MessageBox.Show("Only numbers and letters are allowed.");
          return;
        }
      }
      for (int i = 0; i < strPW.Length; i++)
      {
        if (!AllowWord.IsMatch(string.Format("{0}", strPW[i])))
        {
          MessageBox.Show("Only numbers and letters are allowed.");
          return;
        }
      }
      for (int i = 0; i < strPWC.Length; i++)
      {
        if (!AllowWord.IsMatch(string.Format("{0}", strPWC[i])))
        {
          MessageBox.Show("Only numbers and letters are allowed.");
          return;
        }
      }
      for (int i = 0; i < strINFO.Length; i++)
      {
        if (!AllowWord.IsMatch(string.Format("{0}", strINFO[i])))
        {
          MessageBox.Show("Only numbers and letters are allowed.");
          return;
        }
      }

      eLOGIN_LEVEL NewLevel = eLOGIN_LEVEL.NONE;
      bool bExistLevel = false;
      for (int i = 0; i < (int)eLOGIN_LEVEL.COUNT; i++)
      {
        if (((eLOGIN_LEVEL)i).ToString().CompareTo(strLEVEL) == 0)
        {
          bExistLevel = true;
          NewLevel = (eLOGIN_LEVEL)i;
        }
      }

      if (!bExistLevel)
      {
          MessageBox.Show("Invalid setting LEVEL.");
          return;
      }

      if (!CManageSystem.UpdateUserInfo(strID, strPW, strINFO, NewLevel))
      {
        MessageBox.Show("Change Fail.");
        return;
      }

      if (!UpdateList())
      {
        System.Windows.Forms.MessageBox.Show("Cannot Load User Information.");
        return;
      }
      MessageBox.Show("Change Success.");
    }


  }
}
