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
  public static class CManageJob
  {
    public static void CreateFolder()
    {
      List<string> arrFolder = new List<string>();
      arrFolder.Clear();
      arrFolder.Add(CVo.PATH_CURRENT + CVo.PATH_MODEL);
      try
      {
        for (int i = 0; i < arrFolder.Count; i++)
        {
          if (!Directory.Exists(arrFolder[i])) { Directory.CreateDirectory(arrFolder[i]); }
        }
      }
      catch (Exception ex)
      {
        CManageLog.DebugTrace("CManageJob::CreateFolder: " + ex.Message);
      }

    }
  }
}
