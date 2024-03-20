using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;

using Base.FORM;
using Base.FORM.Side_Panel;
using Base.FORM.Main_Panel;
using Base.FORM.COMMON;


namespace Base.Value
{
  public enum eDSP_MAIN
  { 
    SAMPLE = -1,
    LOGIN = 0,
    COUNT
  };//Ex) CVo.g_DSPMain = eDSP_MAIN

  public enum eDSP_BOTTOM
  { 
    BOTTOM = 0,
    COUNT
  }//Ex) CVo.g_DSPBottom = eDSP_BOTTOM

  public enum eDSP_LEFT
  { 
    LEFT = 0,
    COUNT
  };//Ex) CVo.g_DSPLeft = eDSP_LEFT

  public enum eDSP_TOP
  { 
    TOP = 0,
    COUNT
  };//Ex) CVo.g_DSPTop = eDSP_TOP

  public enum eLOGIN_LEVEL
  {
    DEVELOPER = 0,
    MASTER,
    ENGINEER,
    OPEARATOR,
    VIEWER,
    NONE,
    COUNT
  };//Ex) CVo.g_USER = eLOGIN_LEVEL

  public enum eUserInfo
  { 
    ID = 0,
    PW,
    INFO,
    LEVEL,
    COUNT
  };//Ex) CVo.USER_INFO[0].Split(',')[(int)eUserInfo]

  public static class CVo
  {
    #region Login
    public const string SUPER_ID = "SUPER";
    public const string SUPER_PW = "0000";
    public static eLOGIN_LEVEL g_USER = eLOGIN_LEVEL.NONE;
    #endregion

    #region Form
    //COMMON
    public static FRMKeypad_English g_frmKeypadEnglish = new FRMKeypad_English(); //KeyBoard
    public static FRMLoginCreate g_frmUserCreate = new FRMLoginCreate(); //CreateID
    public static FRMLoginManager g_frmUserManager = new FRMLoginManager(); //Manage ID

    //Mother
    public static FRMBase g_frmBase = null;                 //Form Mother 

    //TOP
    public static FRMTop g_frmTop = new FRMTop();           //Form Top 

    //LEFT
    public static FRMLeft g_frmLeft = new FRMLeft();        //Form Left 

    //BOTTOM
    public static FRMBottom g_frmBottom = new FRMBottom();  //Form Bottom 

    //MAIN
    public static FRMLogin g_frmLogin = new FRMLogin(); //Login
    #endregion

    #region FormStatus
    public static eDSP_MAIN g_DSPMain = eDSP_MAIN.LOGIN;
    public static eDSP_BOTTOM g_DSPBottom = eDSP_BOTTOM.BOTTOM;
    public static eDSP_LEFT g_DSPLeft = eDSP_LEFT.LEFT;
    public static eDSP_TOP g_DSPTop = eDSP_TOP.TOP;
    #endregion

    #region Path
    ///////////////////////////////////////////////////////////////////////////////////////////////////////
    ///////////////////////////////////////////////////////////////////////////////////////////////////////
    //Ex) 
    //string strPath = PATH_CURRENT + PATH_LOG;
    ///////////////////////////////////////////////////////////////////////////////////////////////////////
    ///////////////////////////////////////////////////////////////////////////////////////////////////////
    public static string PATH_CURRENT = Directory.GetCurrentDirectory();
    public const string PATH_CONFIG = "\\" + "Config";
    public const string PATH_SYSTEM = PATH_CONFIG + "\\" + "System";
    public const string PATH_MODEL = PATH_CONFIG + "\\" + "Model";
    public const string PATH_MODULE = PATH_CONFIG + "\\" + "Module";
    public const string PATH_LABEL = PATH_CONFIG + "\\" + "Label";
    public const string PATH_USER = PATH_CONFIG + "\\" + "User";

    public const string PATH_LOG = PATH_CONFIG + "\\" + "Log";
    public const string PATH_LOG_UI = PATH_LOG + "\\" + "UI";
    public const string PATH_LOG_SYSTEM = PATH_LOG + "\\" + "SYSTEM";
    public const string PATH_LOG_MODEL = PATH_LOG + "\\" + "MODEL";
    public const string PATH_LOG_ALARM = PATH_LOG + "\\" + "ALARM";
    #endregion

    #region Thread

    #endregion

    #region Parameter System
    public static List<string> USER_INFO = new List<string>(); // User Infomation -> format: ID,PW,INFO,LEVEL
    #endregion
  }
}
