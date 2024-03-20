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
  public static class CManageLog
  {
    public static void DebugTrace(string strData)
    {
      System.Diagnostics.Debug.WriteLine(strData);
    }
    public static void CreateFolder()
    {
      List<string> arrFolder = new List<string>();
      arrFolder.Clear();
      arrFolder.Add(CVo.PATH_CURRENT + CVo.PATH_LOG);
      arrFolder.Add(CVo.PATH_CURRENT + CVo.PATH_LOG_UI);
      arrFolder.Add(CVo.PATH_CURRENT + CVo.PATH_LOG_SYSTEM);
      arrFolder.Add(CVo.PATH_CURRENT + CVo.PATH_LOG_MODEL);
      arrFolder.Add(CVo.PATH_CURRENT + CVo.PATH_LOG_ALARM);
      try
      {
        for (int i = 0; i < arrFolder.Count; i++)
        {
          if (!Directory.Exists(arrFolder[i])) { Directory.CreateDirectory(arrFolder[i]); }
        }
      }
      catch (Exception ex)
      {
        DebugTrace("CManageLog::CreateFolder: " + ex.Message);
      }
    }
  }
}
