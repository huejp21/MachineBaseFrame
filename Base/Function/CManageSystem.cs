using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Diagnostics;

using Base.Value;
namespace Base.Function
{
  public static class CManageSystem
  {
    public static void CreateFolder()
    {
      List<string> arrFolder = new List<string>();
      arrFolder.Clear();
      arrFolder.Add(CVo.PATH_CURRENT + CVo.PATH_CONFIG);
      arrFolder.Add(CVo.PATH_CURRENT + CVo.PATH_SYSTEM);
      arrFolder.Add(CVo.PATH_CURRENT + CVo.PATH_MODULE);
      arrFolder.Add(CVo.PATH_CURRENT + CVo.PATH_LABEL);
      arrFolder.Add(CVo.PATH_CURRENT + CVo.PATH_USER);
      try
      {
        for (int i = 0; i < arrFolder.Count; i++)
        {
          if (!Directory.Exists(arrFolder[i])) { Directory.CreateDirectory(arrFolder[i]); }
        }
      }
      catch (Exception ex)
      {
        CManageLog.DebugTrace("CManageSystem::CreateFolder: " + ex.Message);
      }
    }

    public static bool AddUserInfo(string strID, string strPW, string strInfo, eLOGIN_LEVEL eLevel)
    {
      string PATH = CVo.PATH_CURRENT + CVo.PATH_USER + "\\USER.txt";
      string strAddLine = strID + "," + strPW + "," + strInfo + "," + eLevel.ToString() + "\n\r";
      List<string> arrAllLine = new List<string>();
      List<string> arrID = new List<string>();
      arrID.Clear();
      arrAllLine.Clear();

      //Check null
      if (strID.Trim().CompareTo("") == 0) { return false; }
      if (strPW.Trim().CompareTo("") == 0) { return false; }
      if (strInfo.Trim().CompareTo("") == 0) { return false; }

      //Check Blank Space
      if (strID.Trim().CompareTo(strID) != 0) { return false; }
      if (strPW.Trim().CompareTo(strPW) != 0) { return false; }
      if (strInfo.Trim().CompareTo(strInfo) != 0) { return false; }

      //Check Block Word
      System.Text.RegularExpressions.Regex AllowWord = new System.Text.RegularExpressions.Regex(@"[a-zA-Z0-9_]");
      for (int i = 0; i < strID.Length; i++)
      {
        if (!AllowWord.IsMatch(string.Format("{0}", strID[i]))) { return false; }
      }
      for (int i = 0; i < strPW.Length; i++)
      {
        if (!AllowWord.IsMatch(string.Format("{0}", strPW[i]))) { return false; }
      }
      for (int i = 0; i < strInfo.Length; i++)
      {
        if (!AllowWord.IsMatch(string.Format("{0}", strInfo[i]))) { return false; }
      }

      //Check Exist File
      try
      {
        if (File.Exists(PATH))
        {
          foreach (string strData in File.ReadLines(PATH))
          {
            if (strData.Trim().Replace(",", "").CompareTo("") != 0)
            {
              arrAllLine.Add(strData);
            }
          }
        }
        else 
        {
          FileInfo fi = new FileInfo(PATH);
          fi.Create(); 
        }
      }
      catch (Exception ex)
      {
        CManageLog.DebugTrace("CManageSystem::AddUserInfo: " + ex.Message);
        return false;
      }
      
      //Check Exist ID
      bool bExist = false;
      if (arrAllLine.Count != 0)
      {
        for (int i = 0; i < arrAllLine.Count; i++)
        {
          arrID.Add(arrAllLine[i].Split(',')[0].Trim());
        }
        for (int i = 0; i < arrID.Count; i++)
        {
          if (strID.CompareTo(arrID[i]) == 0) { bExist = true; break; }
        }
      }
      else 
      {
        bExist = false;
      }
      if (bExist) { return false; }

      //Add User Info
      arrAllLine.Add(strAddLine);
      string[] strDataAllLine = new string[arrAllLine.Count];
      for (int i = 0; i < arrAllLine.Count; i++)
      {
        strDataAllLine[i] = arrAllLine[i];
      }

      //Save User Info
      try
      {
        System.IO.File.WriteAllLines(PATH, strDataAllLine);
      }
      catch (Exception ex)
      {
        CManageLog.DebugTrace("CManageSystem::AddUserInfo: " + ex.Message);
        return false;
      }

      //Update User Info
      if (!LoadUserInfo())
      {
        return false;
      }
      return true;
    }

    public static bool LoadUserInfo()
    {
      string PATH = CVo.PATH_CURRENT + CVo.PATH_USER + "\\USER.txt";
      CVo.USER_INFO.Clear();
      try
      {
        if (File.Exists(PATH))
        {
          foreach (string strData in File.ReadLines(PATH))
          {
            if (strData.Trim().Replace(",","").CompareTo("") != 0)
            {
              CVo.USER_INFO.Add(strData);
            }
          }
        }
        else
        {
          FileInfo fi = new FileInfo(PATH);
          fi.Create();
        }
      }
      catch (Exception ex)
      {
        CManageLog.DebugTrace("CManageSystem::LoadUserInfo: " + ex.Message);
        return false;
      }
      return true;
    }

    public static bool UpdateUserInfo(string strID, string strPW_New, string strInfo_New, eLOGIN_LEVEL eLevel_New)
    {
      if (0 >= CVo.USER_INFO.Count) { return false; }
      bool bExist = false;
      int nIndex = -1;
      for (int i = 0; i < CVo.USER_INFO.Count; i++)
      {
        if (CVo.USER_INFO[i].Split(',')[(int)eUserInfo.ID].CompareTo(strID) == 0)
        {
          bExist = true;
          nIndex = i;
          break;
        }
      }
      if (!bExist) { return false; }
      if (nIndex == -1) { return false; }
      string strAddLine = strID + "," + strPW_New + "," + strInfo_New + "," + eLevel_New.ToString() + "\n\r";
      CVo.USER_INFO.RemoveAt(nIndex);
      CVo.USER_INFO.Insert(nIndex, strAddLine);

      //Save User Info
      string PATH = CVo.PATH_CURRENT + CVo.PATH_USER + "\\USER.txt";
      try
      {
        System.IO.File.WriteAllLines(PATH, CVo.USER_INFO);
      }
      catch (Exception ex)
      {
        CManageLog.DebugTrace("CManageSystem::UpdateUserInfo: " + ex.Message);
        return false;
      }

      return true;
    }

    public static bool DeleteUserInfo(string strID)
    {
      string PATH = CVo.PATH_CURRENT + CVo.PATH_USER + "\\USER.txt";
      if (!LoadUserInfo()) { return false; }
      int nIndex = -1;
      if (CVo.USER_INFO.Count == 0) { return false; }
      for (int i = 0; i < CVo.USER_INFO.Count; i++)
      {
        if (CVo.USER_INFO[i].Split(',')[(int)eUserInfo.ID].CompareTo(strID) == 0)
        {
          nIndex = i;
          break;
        }
      }
      if (nIndex == -1) { return false; }
      CVo.USER_INFO.RemoveAt(nIndex);
      string[] strDataAllLine = new string[CVo.USER_INFO.Count];
      for (int i = 0; i < CVo.USER_INFO.Count; i++)
      {
        strDataAllLine[i] = CVo.USER_INFO[i];
      }

      try
      {
        System.IO.File.WriteAllLines(PATH, strDataAllLine);
      }
      catch (Exception ex)
      {
        CManageLog.DebugTrace("CManageSystem::DeleteUserInfo: " + ex.Message);
        return false;
      }

      return true;
    }
  }
}
