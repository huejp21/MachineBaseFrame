using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;

using Base.Value;
using Base.Function;

namespace Base.FORM
{
  public partial class FRMBase : Form
  {
    
    public FRMBase()
    {
      InitializeComponent();
      CVo.g_frmBase = this;
    }

    private void FRMBase_Load(object sender, EventArgs e)
    {
      CManageSystem.CreateFolder();
      CManageJob.CreateFolder();
      CManageLog.CreateFolder();

      CVo.g_frmTop.TopLevel = false;
      CVo.g_frmTop.Parent = this;
      this.pnl_base_top.Controls.Add(CVo.g_frmTop);
      CVo.g_frmTop.Hide();

      CVo.g_frmLeft.TopLevel = false;
      CVo.g_frmLeft.Parent = this;
      this.pnl_base_left.Controls.Add(CVo.g_frmLeft);
      CVo.g_frmLeft.Hide();

      CVo.g_frmBottom.TopLevel = false;
      CVo.g_frmBottom.Parent = this;
      this.pnl_base_bottom.Controls.Add(CVo.g_frmBottom);
      CVo.g_frmBottom.Hide();

      CVo.g_frmLogin.TopLevel = false;
      CVo.g_frmLogin.Parent = this;
      this.pnl_base_main.Controls.Add(CVo.g_frmLogin);
      CVo.g_frmLogin.Hide();

      CVo.g_DSPTop = eDSP_TOP.TOP;
      CVo.g_DSPLeft = eDSP_LEFT.LEFT;
      CVo.g_DSPBottom = eDSP_BOTTOM.BOTTOM;
      CVo.g_DSPMain = eDSP_MAIN.LOGIN; 
    }

    private void timer_base_display_Tick(object sender, EventArgs e)
    {
      switch (CVo.g_DSPMain)
      {
        case eDSP_MAIN.LOGIN:
          CVo.g_frmLogin.Show();
          break;
        default:
          CVo.g_frmLogin.Hide();
          break;
      }//Main Display

      switch (CVo.g_DSPBottom)
      {
        case eDSP_BOTTOM.BOTTOM:
          CVo.g_frmBottom.Show();
          break;
        default:
          CVo.g_frmBottom.Hide();
          break;
      }

      switch (CVo.g_DSPLeft)
      {
        case eDSP_LEFT.LEFT:
          CVo.g_frmLeft.Show();
          break;
        default:
          CVo.g_frmLeft.Hide();
          break;
      }

      switch (CVo.g_DSPTop)
      {
        case eDSP_TOP.TOP:
          CVo.g_frmTop.Show();
          break;
        default:
          CVo.g_frmTop.Hide();
          break;
      }
    }
  }
}
