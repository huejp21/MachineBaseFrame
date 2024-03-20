using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Base.FORM.COMMON
{
  public partial class FRMKeypad_English : Form
  {
    public enum eEDIT_TYPE
    {
      eTEXTBOX = 0,
      Count
    };
    private eEDIT_TYPE m_eType = eEDIT_TYPE.eTEXTBOX;
    private object m_editControl = null;

    private int m_Location = 0;
    private int m_nWidth = 800;
    private int m_nHeight = 400;
    private bool m_IsShift = false;

    private List<System.Windows.Forms.Button> m_listKey = new List<System.Windows.Forms.Button>();

    private string[] m_strKeyName1 = new string[] { "btn_apostrophe", "btn_num1", "btn_num2", "btn_num3", "btn_num4", "btn_num5", "btn_num6", "btn_num7", "btn_num8", "btn_num9", "btn_num0", "btn_dash", "btn_equals", "btn_backspace" };
    private string[] m_strKeyName2 = new string[] { "btn_tap", "btn_q", "btn_w", "btn_e", "btn_r", "btn_t", "btn_y", "btn_u", "btn_i", "btn_o", "btn_p", "btn_SLbracket", "btn_SRbracket", "btn_backslash" };
    private string[] m_strKeyName3 = new string[] { "btn_caps", "btn_a", "btn_s", "btn_d", "btn_f", "btn_g", "btn_h", "btn_j", "btn_k", "btn_l", "btn_semicolon", "btn_quotation", "btn_enter" };
    private string[] m_strKeyName4 = new string[] { "btn_shift1", "btn_z", "btn_x", "btn_c", "btn_v", "btn_b", "btn_n", "btn_m", "btn_comma", "btn_period", "btn_slash", "btn_shift2" };
    private string[] m_strKeyName5 = new string[] { "btn_ctrl1", "btn_win1", "btn_alt1", "btn_space", "btn_changeLanguage", "btn_ctrl2" };

    private string[] m_strKeySmall_1 = new string[] { "`", "1", "2", "3", "4", "5", "6", "7", "8", "9", "0", "-", "=", "BS" };
    private string[] m_strKeySmall_2 = new string[] { "Tab", "q", "w", "e", "r", "t", "y", "u", "i", "o", "p", "[", "]", "\\" };
    private string[] m_strKeySmall_3 = new string[] { "Caps", "a", "s", "d", "f", "g", "h", "j", "k", "l", ";", "'", "Enter" };
    private string[] m_strKeySmall_4 = new string[] { "Shift", "z", "x", "c", "v", "b", "n", "m", ",", ".", "/", "Shift" };
    private string[] m_strKeySmall_5 = new string[] { "Ctrl", "Win", "Alt", "Space", "C/L", "Ctrl" };

    private string[] m_strKeyCapital_1 = new string[] { "~", "!", "@", "#", "$", "%", "^", "&&", "*", "(", ")", "_", "+", "BS" };
    private string[] m_strKeyCapital_2 = new string[] { "Tab", "Q", "W", "E", "R", "T", "Y", "U", "I", "O", "P", "{", "}", "|" };
    private string[] m_strKeyCapital_3 = new string[] { "Caps", "A", "S", "D", "F", "G", "H", "J", "K", "L", ":", "\"", "Enter" };
    private string[] m_strKeyCapital_4 = new string[] { "Shift", "Z", "X", "C", "V", "B", "N", "M", "<", ">", "?", "Shift" };
    private string[] m_strKeyCapital_5 = new string[] { "Ctrl", "Win", "Alt", "Space", "C/L", "Ctrl" };

    private int FindIndex(string strBtnName)
    {
      for (int i = 0; i < m_listKey.Count; i++)
      {
        if (m_listKey[i].Name.CompareTo(strBtnName) == 0) { return i; }
      }
      return -1;
    }
    public FRMKeypad_English()
    {
      InitializeComponent();
    }

    private void FRMKeypad_English_Load(object sender, EventArgs e)
    {
      timer_keyPadEnglish_Display.Enabled = false;
      timer_keyPadEnglish_Display.Enabled = true;
      //Keys
      m_nWidth = this.pnl_keyPadEnglish_Key.Size.Width;
      m_nHeight = this.pnl_keyPadEnglish_Key.Size.Height;
      int nBtnHeight = m_nHeight / 5;
      int nBtnWidth = 0;
      int nIndex = 0;
      System.Windows.Forms.Button btn = null;

      m_listKey.Clear();
      nIndex = 0;
      nBtnWidth = m_nWidth / m_strKeySmall_1.Length;
      for (int i = 0; i < m_strKeySmall_1.Length; i++)
      {
        btn = new System.Windows.Forms.Button();
        btn.Name = m_strKeyName1[i];
        btn.Text = m_strKeySmall_1[i];
        btn.Location = new System.Drawing.Point(0 + (nBtnWidth * i), 0 + (nBtnHeight * 0));
        btn.Parent = this;
        btn.Size = new System.Drawing.Size(nBtnWidth, nBtnHeight);
        btn.Tag = "";
        btn.BackColor = Color.Black;
        btn.ForeColor = Color.White;
        btn.Font = new Font("Tahoma", 10F, FontStyle.Bold);
        btn.Margin = new Padding(0, 0, 0, 0);
        btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btn.FlatAppearance.BorderSize = 0;
        btn.Click += new System.EventHandler(this.KEY_Click);
        btn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.KEY_MouseDown);
        btn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.KEY_MouseUp);
        m_listKey.Add(btn);
        this.pnl_keyPadEnglish_Key.Controls.Add(btn);
      }

      nIndex = m_strKeySmall_1.Length;
      nBtnWidth = m_nWidth / m_strKeySmall_2.Length;
      for (int i = 0; i < m_strKeySmall_2.Length; i++)
      {
        btn = new System.Windows.Forms.Button();
        btn.Name = m_strKeyName2[i];
        btn.Text = m_strKeySmall_2[i];
        btn.Location = new System.Drawing.Point(0 + (nBtnWidth * i), 0 + (nBtnHeight * 1));
        btn.Parent = this;
        btn.Size = new System.Drawing.Size(nBtnWidth, nBtnHeight);
        btn.Tag = "";
        btn.BackColor = Color.Black;
        btn.ForeColor = Color.White;
        btn.Font = new Font("Tahoma", 10F, FontStyle.Bold);
        btn.Margin = new Padding(0, 0, 0, 0);
        btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btn.FlatAppearance.BorderSize = 0;
        btn.Click += new System.EventHandler(this.KEY_Click);
        btn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.KEY_MouseDown);
        btn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.KEY_MouseUp);
        m_listKey.Add(btn);
        this.pnl_keyPadEnglish_Key.Controls.Add(btn);
      }

      nIndex = m_strKeySmall_1.Length + m_strKeySmall_2.Length;
      nBtnWidth = m_nWidth / m_strKeySmall_3.Length;
      for (int i = 0; i < m_strKeySmall_3.Length; i++)
      {
        btn = new System.Windows.Forms.Button();
        btn.Name = m_strKeyName3[i];
        btn.Text = m_strKeySmall_3[i];
        btn.Location = new System.Drawing.Point(0 + (nBtnWidth * i), 0 + (nBtnHeight * 2));
        btn.Parent = this;
        btn.Size = new System.Drawing.Size(nBtnWidth, nBtnHeight);
        btn.Tag = "";
        btn.BackColor = Color.Black;
        btn.ForeColor = Color.White;
        btn.Font = new Font("Tahoma", 10F, FontStyle.Bold);
        btn.Margin = new Padding(0, 0, 0, 0);
        btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btn.FlatAppearance.BorderSize = 0;
        btn.Click += new System.EventHandler(this.KEY_Click);
        btn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.KEY_MouseDown);
        btn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.KEY_MouseUp);
        m_listKey.Add(btn);
        this.pnl_keyPadEnglish_Key.Controls.Add(btn);
      }

      nIndex = m_strKeySmall_1.Length + m_strKeySmall_2.Length + m_strKeySmall_3.Length;
      nBtnWidth = m_nWidth / m_strKeySmall_4.Length;
      for (int i = 0; i < m_strKeySmall_4.Length; i++)
      {
        btn = new System.Windows.Forms.Button();
        btn.Name = m_strKeyName4[i];
        btn.Text = m_strKeySmall_4[i];
        btn.Location = new System.Drawing.Point(0 + (nBtnWidth * i), 0 + (nBtnHeight * 3));
        btn.Parent = this;
        btn.Size = new System.Drawing.Size(nBtnWidth, nBtnHeight);
        btn.Tag = "";
        btn.BackColor = Color.Black;
        btn.ForeColor = Color.White;
        btn.Font = new Font("Tahoma", 10F, FontStyle.Bold);
        btn.Margin = new Padding(0, 0, 0, 0);
        btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btn.FlatAppearance.BorderSize = 0;
        btn.Click += new System.EventHandler(this.KEY_Click);
        btn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.KEY_MouseDown);
        btn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.KEY_MouseUp);
        m_listKey.Add(btn);
        this.pnl_keyPadEnglish_Key.Controls.Add(btn);
      }

      nIndex = m_strKeySmall_1.Length + m_strKeySmall_2.Length + m_strKeySmall_3.Length + m_strKeySmall_4.Length;
      nBtnWidth = m_nWidth / m_strKeySmall_5.Length;
      for (int i = 0; i < m_strKeySmall_5.Length; i++)
      {
        btn = new System.Windows.Forms.Button();
        btn.Name = m_strKeyName5[i];
        btn.Text = m_strKeySmall_5[i];
        btn.Location = new System.Drawing.Point(0 + (nBtnWidth * i), 0 + (nBtnHeight * 4));
        btn.Parent = this;
        btn.Size = new System.Drawing.Size(nBtnWidth, nBtnHeight);
        btn.Tag = "";
        btn.BackColor = Color.Black;
        btn.ForeColor = Color.White;
        btn.Font = new Font("Tahoma", 10F, FontStyle.Bold);
        btn.Margin = new Padding(0, 0, 0, 0);
        btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btn.FlatAppearance.BorderSize = 0;
        btn.Click += new System.EventHandler(this.KEY_Click);
        btn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.KEY_MouseDown);
        btn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.KEY_MouseUp);
        m_listKey.Add(btn);
        this.pnl_keyPadEnglish_Key.Controls.Add(btn);
      }
    }

    private void KEY_Click(object sender, EventArgs e)
    {
      string strText = txt_keyPadEnglish_text.Text;

      string strName = ((System.Windows.Forms.Button)sender).Name;
      bool bCapital = Control.IsKeyLocked(Keys.CapsLock) && m_IsShift;

      if (m_listKey.Count <= 0) { return; }
      switch (strName)
      {
        case "btn_backspace": // <- btn_backspace
          if (strText.CompareTo("") == 0) { return; }
          else
          {
            strText = strText.Substring(0, strText.Length - 1);
          }
          break;
        case "btn_enter": // Enter btn_enter
          switch (m_eType)
          {
            case eEDIT_TYPE.eTEXTBOX:
              ((System.Windows.Forms.TextBox)m_editControl).Text = strText;
              ((System.Windows.Forms.TextBox)m_editControl).Focus();
              ((System.Windows.Forms.TextBox)m_editControl).Select(((System.Windows.Forms.TextBox)m_editControl).Text.Length, ((System.Windows.Forms.TextBox)m_editControl).Text.Length);
              this.Hide();
              break;
            default:
              break;
          }
          break;
        case "btn_space": //Space btn_space
          strText += " ";
          break;
        case "btn_apostrophe": // ` btn_apostrophe
        case "btn_num1": // 1 btn_num1
        case "btn_num2": // 2 btn_num2
        case "btn_num3": // 3 btn_num3
        case "btn_num4": // 4 btn_num4
        case "btn_num5": // 5 btn_num5
        case "btn_num6": // 6 btn_num6
        case "btn_num7": // 7 btn_num7
        case "btn_num8": // 8 btn_num8
        case "btn_num9": // 9 btn_num9
        case "btn_num0": // 0 btn_num0
        case "btn_dash": // - btn_dash
        case "btn_equals": // = btn_equals
        case "btn_q": //Q btn_q
        case "btn_w": //W btn_w
        case "btn_e": //E btn_e
        case "btn_r": //R btn_r
        case "btn_t": //T btn_t
        case "btn_y": //Y btn_y
        case "btn_u": //U btn_u
        case "btn_i": //I btn_i
        case "btn_o": //O btn_o
        case "btn_p": //P btn_p
        case "btn_a": //A btn_a
        case "btn_s": //S btn_s
        case "btn_d": //D btn_d
        case "btn_f": //F btn_f
        case "btn_g": //G btn_g
        case "btn_h": //H btn_h
        case "btn_j": //J btn_j
        case "btn_k": //K btn_k
        case "btn_l": //L btn_l
        case "btn_z": //Z btn_z
        case "btn_x": //X btn_x
        case "btn_c": //C btn_c
        case "btn_v": //V btn_v
        case "btn_b": //B btn_b
        case "btn_n": //N btn_n
        case "btn_m": //M btn_m
        case "btn_SLbracket": //LeftSquareBracket btn_SLbracket
        case "btn_SRbracket": //RightSquareBracket btn_SRbracket
        case "btn_backslash": //BackSlash btn_backslash
        case "btn_semicolon": //Semicolon btn_semicolon
        case "btn_quotation": //Quotation btn_quotation
        case "btn_comma": //Comma  btn_comma
        case "btn_period": //Period btn_period
        case "btn_slash": //Slash btn_slash
          strText += ((System.Windows.Forms.Button)sender).Text;
          break;
        case "btn_shift1": //Shift btn_shift1
        case "btn_shift2": //Shift btn_shift2
        case "btn_ctrl1": // Ctrl btn_ctrl1
        case "btn_ctrl2":// Ctrl btn_ctrl2
        case "btn_win1": // Win btn_win1
        case "btn_alt1": //Alt btn_alt1
        case "btn_changeLanguage": //ChangeLanguage btn_changeLanguage
        default:
          break;
      }
      txt_keyPadEnglish_text.Text = strText;
      txt_keyPadEnglish_text.Focus();
      txt_keyPadEnglish_text.Select(txt_keyPadEnglish_text.Text.Length, txt_keyPadEnglish_text.Text.Length);
    }

    private void KEY_MouseDown(object sender, MouseEventArgs e)
    {
      string strName = ((System.Windows.Forms.Button)sender).Name;

      if (m_listKey.Count <= 0) { return; }
      switch (strName)
      {
        case "btn_shift1": //Shift btn_shift1
          if (0 <= FindIndex("btn_shift1")) { m_listKey[FindIndex("btn_shift1")].ForeColor = Color.Lime; }
          m_IsShift = true;
          break;
        case "btn_shift2": //Shift btn_shift2
          if (0 <= FindIndex("btn_shift2")) { m_listKey[FindIndex("btn_shift2")].ForeColor = Color.Lime; }
          m_IsShift = true;
          break;
        case "btn_apostrophe": // ` btn_apostrophe
          if (0 <= FindIndex("btn_apostrophe")) { m_listKey[FindIndex("btn_apostrophe")].ForeColor = Color.Lime; }
          break;
        case "btn_num1": // 1 btn_num1
          if (0 <= FindIndex("btn_num1")) { m_listKey[FindIndex("btn_num1")].ForeColor = Color.Lime; }
          break;
        case "btn_num2": // 2 btn_num2
          if (0 <= FindIndex("btn_num2")) { m_listKey[FindIndex("btn_num2")].ForeColor = Color.Lime; }
          break;
        case "btn_num3": // 3 btn_num3
          if (0 <= FindIndex("btn_num3")) { m_listKey[FindIndex("btn_num3")].ForeColor = Color.Lime; }
          break;
        case "btn_num4": // 4 btn_num4
          if (0 <= FindIndex("btn_num4")) { m_listKey[FindIndex("btn_num4")].ForeColor = Color.Lime; }
          break;
        case "btn_num5": // 5 btn_num5
          if (0 <= FindIndex("btn_num5")) { m_listKey[FindIndex("btn_num5")].ForeColor = Color.Lime; }
          break;
        case "btn_num6": // 6 btn_num6
          if (0 <= FindIndex("btn_num6")) { m_listKey[FindIndex("btn_num6")].ForeColor = Color.Lime; }
          break;
        case "btn_num7": // 7 btn_num7
          if (0 <= FindIndex("btn_num7")) { m_listKey[FindIndex("btn_num7")].ForeColor = Color.Lime; }
          break;
        case "btn_num8": // 8 btn_num8
          if (0 <= FindIndex("btn_num8")) { m_listKey[FindIndex("btn_num8")].ForeColor = Color.Lime; }
          break;
        case "btn_num9": // 9 btn_num9
          if (0 <= FindIndex("btn_num9")) { m_listKey[FindIndex("btn_num9")].ForeColor = Color.Lime; }
          break;
        case "btn_num0": // 0 btn_num0
          if (0 <= FindIndex("btn_num0")) { m_listKey[FindIndex("btn_num0")].ForeColor = Color.Lime; }
          break;
        case "btn_dash": // - btn_dash
          if (0 <= FindIndex("btn_dash")) { m_listKey[FindIndex("btn_dash")].ForeColor = Color.Lime; }
          break;
        case "btn_equals": // = btn_equals
          if (0 <= FindIndex("btn_equals")) { m_listKey[FindIndex("btn_equals")].ForeColor = Color.Lime; }
          break;
        case "btn_backspace": // <- btn_backspace
          if (0 <= FindIndex("btn_backspace")) { m_listKey[FindIndex("btn_backspace")].ForeColor = Color.Lime; }
          break;
        case "btn_ctrl1": // Ctrl btn_ctrl1
          if (0 <= FindIndex("btn_ctrl1")) { m_listKey[FindIndex("btn_ctrl1")].ForeColor = Color.Lime; }
          break;
        case "btn_ctrl2":// Ctrl btn_ctrl2
          if (0 <= FindIndex("btn_ctrl2")) { m_listKey[FindIndex("btn_ctrl2")].ForeColor = Color.Lime; }
          break;
        case "btn_win1": // Win btn_win1
          if (0 <= FindIndex("btn_win1")) { m_listKey[FindIndex("btn_win1")].ForeColor = Color.Lime; }
          break;
        case "btn_alt1": //Alt btn_alt1
          if (0 <= FindIndex("btn_alt1")) { m_listKey[FindIndex("btn_alt1")].ForeColor = Color.Lime; }
          break;
        case "btn_space": //Space btn_space
          if (0 <= FindIndex("btn_space")) { m_listKey[FindIndex("btn_space")].ForeColor = Color.Lime; }
          break;
        case "btn_changeLanguage": //ChangeLanguage btn_changeLanguage
          if (0 <= FindIndex("btn_changeLanguage")) { m_listKey[FindIndex("btn_changeLanguage")].ForeColor = Color.Lime; }
          break;
        case "btn_q": //Q btn_q
          if (0 <= FindIndex("btn_q")) { m_listKey[FindIndex("btn_q")].ForeColor = Color.Lime; }
          break;
        case "btn_w": //W btn_w
          if (0 <= FindIndex("btn_w")) { m_listKey[FindIndex("btn_w")].ForeColor = Color.Lime; }
          break;
        case "btn_e": //E btn_e
          if (0 <= FindIndex("btn_e")) { m_listKey[FindIndex("btn_e")].ForeColor = Color.Lime; }
          break;
        case "btn_r": //R btn_r
          if (0 <= FindIndex("btn_r")) { m_listKey[FindIndex("btn_r")].ForeColor = Color.Lime; }
          break;
        case "btn_t": //T btn_t
          if (0 <= FindIndex("btn_t")) { m_listKey[FindIndex("btn_t")].ForeColor = Color.Lime; }
          break;
        case "btn_y": //Y btn_y
          if (0 <= FindIndex("btn_y")) { m_listKey[FindIndex("btn_y")].ForeColor = Color.Lime; }
          break;
        case "btn_u": //U btn_u
          if (0 <= FindIndex("btn_u")) { m_listKey[FindIndex("btn_u")].ForeColor = Color.Lime; }
          break;
        case "btn_i": //I btn_i
          if (0 <= FindIndex("btn_i")) { m_listKey[FindIndex("btn_i")].ForeColor = Color.Lime; }
          break;
        case "btn_o": //O btn_o
          if (0 <= FindIndex("btn_o")) { m_listKey[FindIndex("btn_o")].ForeColor = Color.Lime; }
          break;
        case "btn_p": //P btn_p
          if (0 <= FindIndex("btn_p")) { m_listKey[FindIndex("btn_p")].ForeColor = Color.Lime; }
          break;
        case "btn_a": //A btn_a
          if (0 <= FindIndex("btn_a")) { m_listKey[FindIndex("btn_a")].ForeColor = Color.Lime; }
          break;
        case "btn_s": //S btn_s
          if (0 <= FindIndex("btn_s")) { m_listKey[FindIndex("btn_s")].ForeColor = Color.Lime; }
          break;
        case "btn_d": //D btn_d
          if (0 <= FindIndex("btn_d")) { m_listKey[FindIndex("btn_d")].ForeColor = Color.Lime; }
          break;
        case "btn_f": //F btn_f
          if (0 <= FindIndex("btn_f")) { m_listKey[FindIndex("btn_f")].ForeColor = Color.Lime; }
          break;
        case "btn_g": //G btn_g
          if (0 <= FindIndex("btn_g")) { m_listKey[FindIndex("btn_g")].ForeColor = Color.Lime; }
          break;
        case "btn_h": //H btn_h
          if (0 <= FindIndex("btn_h")) { m_listKey[FindIndex("btn_h")].ForeColor = Color.Lime; }
          break;
        case "btn_j": //J btn_j
          if (0 <= FindIndex("btn_j")) { m_listKey[FindIndex("btn_j")].ForeColor = Color.Lime; }
          break;
        case "btn_k": //K btn_k
          if (0 <= FindIndex("btn_k")) { m_listKey[FindIndex("btn_k")].ForeColor = Color.Lime; }
          break;
        case "btn_l": //L btn_l
          if (0 <= FindIndex("btn_l")) { m_listKey[FindIndex("btn_l")].ForeColor = Color.Lime; }
          break;
        case "btn_z": //Z btn_z
          if (0 <= FindIndex("btn_z")) { m_listKey[FindIndex("btn_z")].ForeColor = Color.Lime; }
          break;
        case "btn_x": //X btn_x
          if (0 <= FindIndex("btn_x")) { m_listKey[FindIndex("btn_x")].ForeColor = Color.Lime; }
          break;
        case "btn_c": //C btn_c
          if (0 <= FindIndex("btn_c")) { m_listKey[FindIndex("btn_c")].ForeColor = Color.Lime; }
          break;
        case "btn_v": //V btn_v
          if (0 <= FindIndex("btn_v")) { m_listKey[FindIndex("btn_v")].ForeColor = Color.Lime; }
          break;
        case "btn_b": //B btn_b
          if (0 <= FindIndex("btn_b")) { m_listKey[FindIndex("btn_b")].ForeColor = Color.Lime; }
          break;
        case "btn_n": //N btn_n
          if (0 <= FindIndex("btn_n")) { m_listKey[FindIndex("btn_n")].ForeColor = Color.Lime; }
          break;
        case "btn_m": //M btn_m
          if (0 <= FindIndex("btn_m")) { m_listKey[FindIndex("btn_m")].ForeColor = Color.Lime; }
          break;
        case "btn_SLbracket": //LeftSquareBracket btn_SLbracket
          if (0 <= FindIndex("btn_SLbracket")) { m_listKey[FindIndex("btn_SLbracket")].ForeColor = Color.Lime; }
          break;
        case "btn_SRbracket": //RightSquareBracket btn_SRbracket
          if (0 <= FindIndex("btn_SRbracket")) { m_listKey[FindIndex("btn_SRbracket")].ForeColor = Color.Lime; }
          break;
        case "btn_backslash": //BackSlash btn_backslash
          if (0 <= FindIndex("btn_backslash")) { m_listKey[FindIndex("btn_backslash")].ForeColor = Color.Lime; }
          break;
        case "btn_semicolon": //Semicolon btn_semicolon
          if (0 <= FindIndex("btn_semicolon")) { m_listKey[FindIndex("btn_semicolon")].ForeColor = Color.Lime; }
          break;
        case "btn_quotation": //Quotation btn_quotation
          if (0 <= FindIndex("btn_quotation")) { m_listKey[FindIndex("btn_quotation")].ForeColor = Color.Lime; }
          break;
        case "btn_enter": // Enter btn_enter
          if (0 <= FindIndex("btn_enter")) { m_listKey[FindIndex("btn_enter")].ForeColor = Color.Lime; }
          break;
        case "btn_comma": //Comma  btn_comma
          if (0 <= FindIndex("btn_comma")) { m_listKey[FindIndex("btn_comma")].ForeColor = Color.Lime; }
          break;
        case "btn_period": //Period btn_period
          if (0 <= FindIndex("btn_period")) { m_listKey[FindIndex("btn_period")].ForeColor = Color.Lime; }
          break;
        case "btn_slash": //Slash btn_slash
          if (0 <= FindIndex("btn_slash")) { m_listKey[FindIndex("btn_slash")].ForeColor = Color.Lime; }
          break;
        default:
          break;
      }
    }

    private void KEY_MouseUp(object sender, MouseEventArgs e)
    {
      string strName = ((System.Windows.Forms.Button)sender).Name;

      if (m_listKey.Count <= 0) { return; }
      switch (strName)
      {
        case "btn_shift1": //Shift btn_shift1
          if (0 <= FindIndex("btn_shift1")) { m_listKey[FindIndex("btn_shift1")].ForeColor = Color.White; }
          m_IsShift = false;
          break;
        case "btn_shift2": //Shift btn_shift2
          if (0 <= FindIndex("btn_shift2")) { m_listKey[FindIndex("btn_shift2")].ForeColor = Color.White; }
          m_IsShift = false;
          break;
        case "btn_apostrophe": // ` btn_apostrophe
          if (0 <= FindIndex("btn_apostrophe")) { m_listKey[FindIndex("btn_apostrophe")].ForeColor = Color.White; }
          break;
        case "btn_num1": // 1 btn_num1
          if (0 <= FindIndex("btn_num1")) { m_listKey[FindIndex("btn_num1")].ForeColor = Color.White; }
          break;
        case "btn_num2": // 2 btn_num2
          if (0 <= FindIndex("btn_num2")) { m_listKey[FindIndex("btn_num2")].ForeColor = Color.White; }
          break;
        case "btn_num3": // 3 btn_num3
          if (0 <= FindIndex("btn_num3")) { m_listKey[FindIndex("btn_num3")].ForeColor = Color.White; }
          break;
        case "btn_num4": // 4 btn_num4
          if (0 <= FindIndex("btn_num4")) { m_listKey[FindIndex("btn_num4")].ForeColor = Color.White; }
          break;
        case "btn_num5": // 5 btn_num5
          if (0 <= FindIndex("btn_num5")) { m_listKey[FindIndex("btn_num5")].ForeColor = Color.White; }
          break;
        case "btn_num6": // 6 btn_num6
          if (0 <= FindIndex("btn_num6")) { m_listKey[FindIndex("btn_num6")].ForeColor = Color.White; }
          break;
        case "btn_num7": // 7 btn_num7
          if (0 <= FindIndex("btn_num7")) { m_listKey[FindIndex("btn_num7")].ForeColor = Color.White; }
          break;
        case "btn_num8": // 8 btn_num8
          if (0 <= FindIndex("btn_num8")) { m_listKey[FindIndex("btn_num8")].ForeColor = Color.White; }
          break;
        case "btn_num9": // 9 btn_num9
          if (0 <= FindIndex("btn_num9")) { m_listKey[FindIndex("btn_num9")].ForeColor = Color.White; }
          break;
        case "btn_num0": // 0 btn_num0
          if (0 <= FindIndex("btn_num0")) { m_listKey[FindIndex("btn_num0")].ForeColor = Color.White; }
          break;
        case "btn_dash": // - btn_dash
          if (0 <= FindIndex("btn_dash")) { m_listKey[FindIndex("btn_dash")].ForeColor = Color.White; }
          break;
        case "btn_equals": // = btn_equals
          if (0 <= FindIndex("btn_equals")) { m_listKey[FindIndex("btn_equals")].ForeColor = Color.White; }
          break;
        case "btn_backspace": // <- btn_backspace
          if (0 <= FindIndex("btn_backspace")) { m_listKey[FindIndex("btn_backspace")].ForeColor = Color.White; }
          break;
        case "btn_ctrl1": // Ctrl btn_ctrl1
          if (0 <= FindIndex("btn_ctrl1")) { m_listKey[FindIndex("btn_ctrl1")].ForeColor = Color.White; }
          break;
        case "btn_ctrl2":// Ctrl btn_ctrl2
          if (0 <= FindIndex("btn_ctrl2")) { m_listKey[FindIndex("btn_ctrl2")].ForeColor = Color.White; }
          break;
        case "btn_win1": // Win btn_win1
          if (0 <= FindIndex("btn_win1")) { m_listKey[FindIndex("btn_win1")].ForeColor = Color.White; }
          break;
        case "btn_alt1": //Alt btn_alt1
          if (0 <= FindIndex("btn_alt1")) { m_listKey[FindIndex("btn_alt1")].ForeColor = Color.White; }
          break;
        case "btn_space": //Space btn_space
          if (0 <= FindIndex("btn_space")) { m_listKey[FindIndex("btn_space")].ForeColor = Color.White; }
          break;
        case "btn_changeLanguage": //ChangeLanguage btn_changeLanguage
          if (0 <= FindIndex("btn_changeLanguage")) { m_listKey[FindIndex("btn_changeLanguage")].ForeColor = Color.White; }
          break;
        case "btn_q": //Q btn_q
          if (0 <= FindIndex("btn_q")) { m_listKey[FindIndex("btn_q")].ForeColor = Color.White; }
          break;
        case "btn_w": //W btn_w
          if (0 <= FindIndex("btn_w")) { m_listKey[FindIndex("btn_w")].ForeColor = Color.White; }
          break;
        case "btn_e": //E btn_e
          if (0 <= FindIndex("btn_e")) { m_listKey[FindIndex("btn_e")].ForeColor = Color.White; }
          break;
        case "btn_r": //R btn_r
          if (0 <= FindIndex("btn_r")) { m_listKey[FindIndex("btn_r")].ForeColor = Color.White; }
          break;
        case "btn_t": //T btn_t
          if (0 <= FindIndex("btn_t")) { m_listKey[FindIndex("btn_t")].ForeColor = Color.White; }
          break;
        case "btn_y": //Y btn_y
          if (0 <= FindIndex("btn_y")) { m_listKey[FindIndex("btn_y")].ForeColor = Color.White; }
          break;
        case "btn_u": //U btn_u
          if (0 <= FindIndex("btn_u")) { m_listKey[FindIndex("btn_u")].ForeColor = Color.White; }
          break;
        case "btn_i": //I btn_i
          if (0 <= FindIndex("btn_i")) { m_listKey[FindIndex("btn_i")].ForeColor = Color.White; }
          break;
        case "btn_o": //O btn_o
          if (0 <= FindIndex("btn_o")) { m_listKey[FindIndex("btn_o")].ForeColor = Color.White; }
          break;
        case "btn_p": //P btn_p
          if (0 <= FindIndex("btn_p")) { m_listKey[FindIndex("btn_p")].ForeColor = Color.White; }
          break;
        case "btn_a": //A btn_a
          if (0 <= FindIndex("btn_a")) { m_listKey[FindIndex("btn_a")].ForeColor = Color.White; }
          break;
        case "btn_s": //S btn_s
          if (0 <= FindIndex("btn_s")) { m_listKey[FindIndex("btn_s")].ForeColor = Color.White; }
          break;
        case "btn_d": //D btn_d
          if (0 <= FindIndex("btn_d")) { m_listKey[FindIndex("btn_d")].ForeColor = Color.White; }
          break;
        case "btn_f": //F btn_f
          if (0 <= FindIndex("btn_f")) { m_listKey[FindIndex("btn_f")].ForeColor = Color.White; }
          break;
        case "btn_g": //G btn_g
          if (0 <= FindIndex("btn_g")) { m_listKey[FindIndex("btn_g")].ForeColor = Color.White; }
          break;
        case "btn_h": //H btn_h
          if (0 <= FindIndex("btn_h")) { m_listKey[FindIndex("btn_h")].ForeColor = Color.White; }
          break;
        case "btn_j": //J btn_j
          if (0 <= FindIndex("btn_j")) { m_listKey[FindIndex("btn_j")].ForeColor = Color.White; }
          break;
        case "btn_k": //K btn_k
          if (0 <= FindIndex("btn_k")) { m_listKey[FindIndex("btn_k")].ForeColor = Color.White; }
          break;
        case "btn_l": //L btn_l
          if (0 <= FindIndex("btn_l")) { m_listKey[FindIndex("btn_l")].ForeColor = Color.White; }
          break;
        case "btn_z": //Z btn_z
          if (0 <= FindIndex("btn_z")) { m_listKey[FindIndex("btn_z")].ForeColor = Color.White; }
          break;
        case "btn_x": //X btn_x
          if (0 <= FindIndex("btn_x")) { m_listKey[FindIndex("btn_x")].ForeColor = Color.White; }
          break;
        case "btn_c": //C btn_c
          if (0 <= FindIndex("btn_c")) { m_listKey[FindIndex("btn_c")].ForeColor = Color.White; }
          break;
        case "btn_v": //V btn_v
          if (0 <= FindIndex("btn_v")) { m_listKey[FindIndex("btn_v")].ForeColor = Color.White; }
          break;
        case "btn_b": //B btn_b
          if (0 <= FindIndex("btn_b")) { m_listKey[FindIndex("btn_b")].ForeColor = Color.White; }
          break;
        case "btn_n": //N btn_n
          if (0 <= FindIndex("btn_n")) { m_listKey[FindIndex("btn_n")].ForeColor = Color.White; }
          break;
        case "btn_m": //M btn_m
          if (0 <= FindIndex("btn_m")) { m_listKey[FindIndex("btn_m")].ForeColor = Color.White; }
          break;
        case "btn_SLbracket": //LeftSquareBracket btn_SLbracket
          if (0 <= FindIndex("btn_SLbracket")) { m_listKey[FindIndex("btn_SLbracket")].ForeColor = Color.White; }
          break;
        case "btn_SRbracket": //RightSquareBracket btn_SRbracket
          if (0 <= FindIndex("btn_SRbracket")) { m_listKey[FindIndex("btn_SRbracket")].ForeColor = Color.White; }
          break;
        case "btn_backslash": //BackSlash btn_backslash
          if (0 <= FindIndex("btn_backslash")) { m_listKey[FindIndex("btn_backslash")].ForeColor = Color.White; }
          break;
        case "btn_semicolon": //Semicolon btn_semicolon
          if (0 <= FindIndex("btn_semicolon")) { m_listKey[FindIndex("btn_semicolon")].ForeColor = Color.White; }
          break;
        case "btn_quotation": //Quotation btn_quotation
          if (0 <= FindIndex("btn_quotation")) { m_listKey[FindIndex("btn_quotation")].ForeColor = Color.White; }
          break;
        case "btn_enter": // Enter btn_enter
          if (0 <= FindIndex("btn_enter")) { m_listKey[FindIndex("btn_enter")].ForeColor = Color.White; }
          break;
        case "btn_comma": //Comma  btn_comma
          if (0 <= FindIndex("btn_comma")) { m_listKey[FindIndex("btn_comma")].ForeColor = Color.White; }
          break;
        case "btn_period": //Period btn_period
          if (0 <= FindIndex("btn_period")) { m_listKey[FindIndex("btn_period")].ForeColor = Color.White; }
          break;
        case "btn_slash": //Slash btn_slash
          if (0 <= FindIndex("btn_slash")) { m_listKey[FindIndex("btn_slash")].ForeColor = Color.White; }
          break;
        default:
          break;
      }
    }

    private void FRMKeypad_English_KeyDown(object sender, KeyEventArgs e)
    {
      string strData = e.KeyCode.ToString();
      if (m_listKey.Count <= 0) { return; }
      switch (strData)
      {
        case "ShiftKey":
          if (0 <= FindIndex("btn_shift1")) { m_listKey[FindIndex("btn_shift1")].ForeColor = Color.Lime; }
          if (0 <= FindIndex("btn_shift2")) { m_listKey[FindIndex("btn_shift2")].ForeColor = Color.Lime; }
          m_IsShift = true;
          break;
        case "Oemtilde": // ` btn_apostrophe
          if (0 <= FindIndex("btn_apostrophe")) { m_listKey[FindIndex("btn_apostrophe")].ForeColor = Color.Lime; }
          break;
        case "D1": // 1 btn_num1
          if (0 <= FindIndex("btn_num1")) { m_listKey[FindIndex("btn_num1")].ForeColor = Color.Lime; }
          break;
        case "D2": // 2 btn_num2
          if (0 <= FindIndex("btn_num2")) { m_listKey[FindIndex("btn_num2")].ForeColor = Color.Lime; }
          break;
        case "D3": // 3 btn_num3
          if (0 <= FindIndex("btn_num3")) { m_listKey[FindIndex("btn_num3")].ForeColor = Color.Lime; }
          break;
        case "D4": // 4 btn_num4
          if (0 <= FindIndex("btn_num4")) { m_listKey[FindIndex("btn_num4")].ForeColor = Color.Lime; }
          break;
        case "D5": // 5 btn_num5
          if (0 <= FindIndex("btn_num5")) { m_listKey[FindIndex("btn_num5")].ForeColor = Color.Lime; }
          break;
        case "D6": // 6 btn_num6
          if (0 <= FindIndex("btn_num6")) { m_listKey[FindIndex("btn_num6")].ForeColor = Color.Lime; }
          break;
        case "D7": // 7 btn_num7
          if (0 <= FindIndex("btn_num7")) { m_listKey[FindIndex("btn_num7")].ForeColor = Color.Lime; }
          break;
        case "D8": // 8 btn_num8
          if (0 <= FindIndex("btn_num8")) { m_listKey[FindIndex("btn_num8")].ForeColor = Color.Lime; }
          break;
        case "D9": // 9 btn_num9
          if (0 <= FindIndex("btn_num9")) { m_listKey[FindIndex("btn_num9")].ForeColor = Color.Lime; }
          break;
        case "D0": // 0 btn_num0
          if (0 <= FindIndex("btn_num0")) { m_listKey[FindIndex("btn_num0")].ForeColor = Color.Lime; }
          break;
        case "OemMinus": // - btn_dash
          if (0 <= FindIndex("btn_dash")) { m_listKey[FindIndex("btn_dash")].ForeColor = Color.Lime; }
          break;
        case "Oemplus": // = btn_equals
          if (0 <= FindIndex("btn_equals")) { m_listKey[FindIndex("btn_equals")].ForeColor = Color.Lime; }
          break;
        case "Back": // <- btn_backspace
          if (0 <= FindIndex("btn_backspace")) { m_listKey[FindIndex("btn_backspace")].ForeColor = Color.Lime; }
          break;
        case "ControlKey": // Ctrl btn_ctrl1 btn_ctrl2
          if (0 <= FindIndex("btn_ctrl1")) { m_listKey[FindIndex("btn_ctrl1")].ForeColor = Color.Lime; }
          if (0 <= FindIndex("btn_ctrl2")) { m_listKey[FindIndex("btn_ctrl2")].ForeColor = Color.Lime; }
          break;
        case "LWin": // Win btn_win1
        case "RWin":
          if (0 <= FindIndex("btn_win1")) { m_listKey[FindIndex("btn_win1")].ForeColor = Color.Lime; }
          break;
        case "Menu": //Alt btn_alt1
          if (0 <= FindIndex("btn_alt1")) { m_listKey[FindIndex("btn_alt1")].ForeColor = Color.Lime; }
          break;
        case "Space": //Space btn_space
          if (0 <= FindIndex("btn_space")) { m_listKey[FindIndex("btn_space")].ForeColor = Color.Lime; }
          break;
        case "KanaMode": //ChangeLanguage btn_changeLanguage
          if (0 <= FindIndex("btn_changeLanguage")) { m_listKey[FindIndex("btn_changeLanguage")].ForeColor = Color.Lime; }
          break;
        case "Q": //Q btn_q
          if (0 <= FindIndex("btn_q")) { m_listKey[FindIndex("btn_q")].ForeColor = Color.Lime; }
          break;
        case "W": //W btn_w
          if (0 <= FindIndex("btn_w")) { m_listKey[FindIndex("btn_w")].ForeColor = Color.Lime; }
          break;
        case "E": //E btn_e
          if (0 <= FindIndex("btn_e")) { m_listKey[FindIndex("btn_e")].ForeColor = Color.Lime; }
          break;
        case "R": //R btn_r
          if (0 <= FindIndex("btn_r")) { m_listKey[FindIndex("btn_r")].ForeColor = Color.Lime; }
          break;
        case "T": //T btn_t
          if (0 <= FindIndex("btn_t")) { m_listKey[FindIndex("btn_t")].ForeColor = Color.Lime; }
          break;
        case "Y": //Y btn_y
          if (0 <= FindIndex("btn_y")) { m_listKey[FindIndex("btn_y")].ForeColor = Color.Lime; }
          break;
        case "U": //U btn_u
          if (0 <= FindIndex("btn_u")) { m_listKey[FindIndex("btn_u")].ForeColor = Color.Lime; }
          break;
        case "I": //I btn_i
          if (0 <= FindIndex("btn_i")) { m_listKey[FindIndex("btn_i")].ForeColor = Color.Lime; }
          break;
        case "O": //O btn_o
          if (0 <= FindIndex("btn_o")) { m_listKey[FindIndex("btn_o")].ForeColor = Color.Lime; }
          break;
        case "P": //P btn_p
          if (0 <= FindIndex("btn_p")) { m_listKey[FindIndex("btn_p")].ForeColor = Color.Lime; }
          break;
        case "A": //A btn_a
          if (0 <= FindIndex("btn_a")) { m_listKey[FindIndex("btn_a")].ForeColor = Color.Lime; }
          break;
        case "S": //S btn_s
          if (0 <= FindIndex("btn_s")) { m_listKey[FindIndex("btn_s")].ForeColor = Color.Lime; }
          break;
        case "D": //D btn_d
          if (0 <= FindIndex("btn_d")) { m_listKey[FindIndex("btn_d")].ForeColor = Color.Lime; }
          break;
        case "F": //F btn_f
          if (0 <= FindIndex("btn_f")) { m_listKey[FindIndex("btn_f")].ForeColor = Color.Lime; }
          break;
        case "G": //G btn_g
          if (0 <= FindIndex("btn_g")) { m_listKey[FindIndex("btn_g")].ForeColor = Color.Lime; }
          break;
        case "H": //H btn_h
          if (0 <= FindIndex("btn_h")) { m_listKey[FindIndex("btn_h")].ForeColor = Color.Lime; }
          break;
        case "J": //J btn_j
          if (0 <= FindIndex("btn_j")) { m_listKey[FindIndex("btn_j")].ForeColor = Color.Lime; }
          break;
        case "K": //K btn_k
          if (0 <= FindIndex("btn_k")) { m_listKey[FindIndex("btn_k")].ForeColor = Color.Lime; }
          break;
        case "L": //L btn_l
          if (0 <= FindIndex("btn_l")) { m_listKey[FindIndex("btn_l")].ForeColor = Color.Lime; }
          break;
        case "Z": //Z btn_z
          if (0 <= FindIndex("btn_z")) { m_listKey[FindIndex("btn_z")].ForeColor = Color.Lime; }
          break;
        case "X": //X btn_x
          if (0 <= FindIndex("btn_x")) { m_listKey[FindIndex("btn_x")].ForeColor = Color.Lime; }
          break;
        case "C": //C btn_c
          if (0 <= FindIndex("btn_c")) { m_listKey[FindIndex("btn_c")].ForeColor = Color.Lime; }
          break;
        case "V": //V btn_v
          if (0 <= FindIndex("btn_v")) { m_listKey[FindIndex("btn_v")].ForeColor = Color.Lime; }
          break;
        case "B": //B btn_b
          if (0 <= FindIndex("btn_b")) { m_listKey[FindIndex("btn_b")].ForeColor = Color.Lime; }
          break;
        case "N": //N btn_n
          if (0 <= FindIndex("btn_n")) { m_listKey[FindIndex("btn_n")].ForeColor = Color.Lime; }
          break;
        case "M": //M btn_m
          if (0 <= FindIndex("btn_m")) { m_listKey[FindIndex("btn_m")].ForeColor = Color.Lime; }
          break;
        case "OemOpenBrackets": //LeftSquareBracket btn_SLbracket
          if (0 <= FindIndex("btn_SLbracket")) { m_listKey[FindIndex("btn_SLbracket")].ForeColor = Color.Lime; }
          break;
        case "Oem6": //RightSquareBracket btn_SRbracket
          if (0 <= FindIndex("btn_SRbracket")) { m_listKey[FindIndex("btn_SRbracket")].ForeColor = Color.Lime; }
          break;
        case "Oem5": //BackSlash btn_backslash
          if (0 <= FindIndex("btn_backslash")) { m_listKey[FindIndex("btn_backslash")].ForeColor = Color.Lime; }
          break;
        case "Oem1": //Semicolon btn_semicolon
          if (0 <= FindIndex("btn_semicolon")) { m_listKey[FindIndex("btn_semicolon")].ForeColor = Color.Lime; }
          break;
        case "Oem7": //Quotation btn_quotation
          if (0 <= FindIndex("btn_quotation")) { m_listKey[FindIndex("btn_quotation")].ForeColor = Color.Lime; }
          break;
        case "Return": // Enter btn_enter
          if (0 <= FindIndex("btn_enter")) { m_listKey[FindIndex("btn_enter")].ForeColor = Color.Lime; }
          break;
        case "Oemcomma": //Comma  btn_comma
          if (0 <= FindIndex("btn_comma")) { m_listKey[FindIndex("btn_comma")].ForeColor = Color.Lime; }
          break;
        case "OemPeriod": //Period btn_period
          if (0 <= FindIndex("btn_period")) { m_listKey[FindIndex("btn_period")].ForeColor = Color.Lime; }
          break;
        case "OemQuestion": //Slash btn_slash
          if (0 <= FindIndex("btn_slash")) { m_listKey[FindIndex("btn_slash")].ForeColor = Color.Lime; }
          break;
        default:
          break;
      }
    }

    private void FRMKeypad_English_KeyPress(object sender, KeyPressEventArgs e)
    {
      string strText = txt_keyPadEnglish_text.Text;
      string strData = e.KeyChar.ToString();
      if (strData.CompareTo("\b") == 0)
      {
        if (strText.CompareTo("") == 0) { return; }
        else
        {
          strText = strText.Substring(0, strText.Length - 1);
        }
      }
      else if (strData.CompareTo("\r") == 0)
      {
        switch (m_eType)
        {
          case eEDIT_TYPE.eTEXTBOX:
            ((System.Windows.Forms.TextBox)m_editControl).Text = strText;
              ((System.Windows.Forms.TextBox)m_editControl).Focus();
              ((System.Windows.Forms.TextBox)m_editControl).Select(((System.Windows.Forms.TextBox)m_editControl).Text.Length, ((System.Windows.Forms.TextBox)m_editControl).Text.Length);
              this.Hide();
            break;
          default:
            break;
        }
      }
      else
      {
        strText += strData;
      }
      txt_keyPadEnglish_text.Text = strText;
      txt_keyPadEnglish_text.Focus();
      txt_keyPadEnglish_text.Select(txt_keyPadEnglish_text.Text.Length, txt_keyPadEnglish_text.Text.Length);
    }

    private void FRMKeypad_English_KeyUp(object sender, KeyEventArgs e)
    {
      string strData = e.KeyCode.ToString();
      if (m_listKey.Count <= 0) { return; }
      switch (strData)
      {
        case "ShiftKey":
          if (0 <= FindIndex("btn_shift1")) { m_listKey[FindIndex("btn_shift1")].ForeColor = Color.White; }
          if (0 <= FindIndex("btn_shift2")) { m_listKey[FindIndex("btn_shift2")].ForeColor = Color.White; }
          m_IsShift = false;
          break;
        case "Oemtilde": // ` btn_apostrophe
          if (0 <= FindIndex("btn_apostrophe")) { m_listKey[FindIndex("btn_apostrophe")].ForeColor = Color.White; }
          break;
        case "D1": // 1 btn_num1
          if (0 <= FindIndex("btn_num1")) { m_listKey[FindIndex("btn_num1")].ForeColor = Color.White; }
          break;
        case "D2": // 2 btn_num2
          if (0 <= FindIndex("btn_num2")) { m_listKey[FindIndex("btn_num2")].ForeColor = Color.White; }
          break;
        case "D3": // 3 btn_num3
          if (0 <= FindIndex("btn_num3")) { m_listKey[FindIndex("btn_num3")].ForeColor = Color.White; }
          break;
        case "D4": // 4 btn_num4
          if (0 <= FindIndex("btn_num4")) { m_listKey[FindIndex("btn_num4")].ForeColor = Color.White; }
          break;
        case "D5": // 5 btn_num5
          if (0 <= FindIndex("btn_num5")) { m_listKey[FindIndex("btn_num5")].ForeColor = Color.White; }
          break;
        case "D6": // 6 btn_num6
          if (0 <= FindIndex("btn_num6")) { m_listKey[FindIndex("btn_num6")].ForeColor = Color.White; }
          break;
        case "D7": // 7 btn_num7
          if (0 <= FindIndex("btn_num7")) { m_listKey[FindIndex("btn_num7")].ForeColor = Color.White; }
          break;
        case "D8": // 8 btn_num8
          if (0 <= FindIndex("btn_num8")) { m_listKey[FindIndex("btn_num8")].ForeColor = Color.White; }
          break;
        case "D9": // 9 btn_num9
          if (0 <= FindIndex("btn_num9")) { m_listKey[FindIndex("btn_num9")].ForeColor = Color.White; }
          break;
        case "D0": // 0 btn_num0
          if (0 <= FindIndex("btn_num0")) { m_listKey[FindIndex("btn_num0")].ForeColor = Color.White; }
          break;
        case "OemMinus": // - btn_dash
          if (0 <= FindIndex("btn_dash")) { m_listKey[FindIndex("btn_dash")].ForeColor = Color.White; }
          break;
        case "Oemplus": // = btn_equals
          if (0 <= FindIndex("btn_equals")) { m_listKey[FindIndex("btn_equals")].ForeColor = Color.White; }
          break;
        case "Back": // <- btn_backspace
          if (0 <= FindIndex("btn_backspace")) { m_listKey[FindIndex("btn_backspace")].ForeColor = Color.White; }
          break;
        case "ControlKey": // Ctrl btn_ctrl1 btn_ctrl2
          if (0 <= FindIndex("btn_ctrl1")) { m_listKey[FindIndex("btn_ctrl1")].ForeColor = Color.White; }
          if (0 <= FindIndex("btn_ctrl2")) { m_listKey[FindIndex("btn_ctrl2")].ForeColor = Color.White; }
          break;
        case "LWin": // Win btn_win1
        case "RWin":
          if (0 <= FindIndex("btn_win1")) { m_listKey[FindIndex("btn_win1")].ForeColor = Color.White; }
          break;
        case "Menu": //Alt btn_alt1
          if (0 <= FindIndex("btn_alt1")) { m_listKey[FindIndex("btn_alt1")].ForeColor = Color.White; }
          break;
        case "Space": //Space btn_space
          if (0 <= FindIndex("btn_space")) { m_listKey[FindIndex("btn_space")].ForeColor = Color.White; }
          break;
        case "KanaMode": //ChangeLanguage btn_changeLanguage
          if (0 <= FindIndex("btn_changeLanguage")) { m_listKey[FindIndex("btn_changeLanguage")].ForeColor = Color.White; }
          break;
        case "Q": //Q btn_q
          if (0 <= FindIndex("btn_q")) { m_listKey[FindIndex("btn_q")].ForeColor = Color.White; }
          break;
        case "W": //W btn_w
          if (0 <= FindIndex("btn_w")) { m_listKey[FindIndex("btn_w")].ForeColor = Color.White; }
          break;
        case "E": //E btn_e
          if (0 <= FindIndex("btn_e")) { m_listKey[FindIndex("btn_e")].ForeColor = Color.White; }
          break;
        case "R": //R btn_r
          if (0 <= FindIndex("btn_r")) { m_listKey[FindIndex("btn_r")].ForeColor = Color.White; }
          break;
        case "T": //T btn_t
          if (0 <= FindIndex("btn_t")) { m_listKey[FindIndex("btn_t")].ForeColor = Color.White; }
          break;
        case "Y": //Y btn_y
          if (0 <= FindIndex("btn_y")) { m_listKey[FindIndex("btn_y")].ForeColor = Color.White; }
          break;
        case "U": //U btn_u
          if (0 <= FindIndex("btn_u")) { m_listKey[FindIndex("btn_u")].ForeColor = Color.White; }
          break;
        case "I": //I btn_i
          if (0 <= FindIndex("btn_i")) { m_listKey[FindIndex("btn_i")].ForeColor = Color.White; }
          break;
        case "O": //O btn_o
          if (0 <= FindIndex("btn_o")) { m_listKey[FindIndex("btn_o")].ForeColor = Color.White; }
          break;
        case "P": //P btn_p
          if (0 <= FindIndex("btn_p")) { m_listKey[FindIndex("btn_p")].ForeColor = Color.White; }
          break;
        case "A": //A btn_a
          if (0 <= FindIndex("btn_a")) { m_listKey[FindIndex("btn_a")].ForeColor = Color.White; }
          break;
        case "S": //S btn_s
          if (0 <= FindIndex("btn_s")) { m_listKey[FindIndex("btn_s")].ForeColor = Color.White; }
          break;
        case "D": //D btn_d
          if (0 <= FindIndex("btn_d")) { m_listKey[FindIndex("btn_d")].ForeColor = Color.White; }
          break;
        case "F": //F btn_f
          if (0 <= FindIndex("btn_f")) { m_listKey[FindIndex("btn_f")].ForeColor = Color.White; }
          break;
        case "G": //G btn_g
          if (0 <= FindIndex("btn_g")) { m_listKey[FindIndex("btn_g")].ForeColor = Color.White; }
          break;
        case "H": //H btn_h
          if (0 <= FindIndex("btn_h")) { m_listKey[FindIndex("btn_h")].ForeColor = Color.White; }
          break;
        case "J": //J btn_j
          if (0 <= FindIndex("btn_j")) { m_listKey[FindIndex("btn_j")].ForeColor = Color.White; }
          break;
        case "K": //K btn_k
          if (0 <= FindIndex("btn_k")) { m_listKey[FindIndex("btn_k")].ForeColor = Color.White; }
          break;
        case "L": //L btn_l
          if (0 <= FindIndex("btn_l")) { m_listKey[FindIndex("btn_l")].ForeColor = Color.White; }
          break;
        case "Z": //Z btn_z
          if (0 <= FindIndex("btn_z")) { m_listKey[FindIndex("btn_z")].ForeColor = Color.White; }
          break;
        case "X": //X btn_x
          if (0 <= FindIndex("btn_x")) { m_listKey[FindIndex("btn_x")].ForeColor = Color.White; }
          break;
        case "C": //C btn_c
          if (0 <= FindIndex("btn_c")) { m_listKey[FindIndex("btn_c")].ForeColor = Color.White; }
          break;
        case "V": //V btn_v
          if (0 <= FindIndex("btn_v")) { m_listKey[FindIndex("btn_v")].ForeColor = Color.White; }
          break;
        case "B": //B btn_b
          if (0 <= FindIndex("btn_b")) { m_listKey[FindIndex("btn_b")].ForeColor = Color.White; }
          break;
        case "N": //N btn_n
          if (0 <= FindIndex("btn_n")) { m_listKey[FindIndex("btn_n")].ForeColor = Color.White; }
          break;
        case "M": //M btn_m
          if (0 <= FindIndex("btn_m")) { m_listKey[FindIndex("btn_m")].ForeColor = Color.White; }
          break;
        case "OemOpenBrackets": //LeftSquareBracket btn_SLbracket
          if (0 <= FindIndex("btn_SLbracket")) { m_listKey[FindIndex("btn_SLbracket")].ForeColor = Color.White; }
          break;
        case "Oem6": //RightSquareBracket btn_SRbracket
          if (0 <= FindIndex("btn_SRbracket")) { m_listKey[FindIndex("btn_SRbracket")].ForeColor = Color.White; }
          break;
        case "Oem5": //BackSlash btn_backslash
          if (0 <= FindIndex("btn_backslash")) { m_listKey[FindIndex("btn_backslash")].ForeColor = Color.White; }
          break;
        case "Oem1": //Semicolon btn_semicolon
          if (0 <= FindIndex("btn_semicolon")) { m_listKey[FindIndex("btn_semicolon")].ForeColor = Color.White; }
          break;
        case "Oem7": //Quotation btn_quotation
          if (0 <= FindIndex("btn_quotation")) { m_listKey[FindIndex("btn_quotation")].ForeColor = Color.White; }
          break;
        case "Return": // Enter btn_enter
          if (0 <= FindIndex("btn_enter")) { m_listKey[FindIndex("btn_enter")].ForeColor = Color.White; }
          break;
        case "Oemcomma": //Comma  btn_comma
          if (0 <= FindIndex("btn_comma")) { m_listKey[FindIndex("btn_comma")].ForeColor = Color.White; }
          break;
        case "OemPeriod": //Period btn_period
          if (0 <= FindIndex("btn_period")) { m_listKey[FindIndex("btn_period")].ForeColor = Color.White; }
          break;
        case "OemQuestion": //Slash btn_slash
          if (0 <= FindIndex("btn_slash")) { m_listKey[FindIndex("btn_slash")].ForeColor = Color.White; }
          break;
        default:
          break;
      }
    }

    private void timer_keyPadEnglish_Display_Tick(object sender, EventArgs e)
    {
      if (m_listKey.Count <= 0) { return; }

      for (int i = 0; i < m_listKey.Count; i++)
      {
        if (m_listKey[i].Name.CompareTo("btn_caps") == 0)
        {
          m_listKey[i].ForeColor = Control.IsKeyLocked(Keys.CapsLock) ? Color.Lime : Color.White;
        }


        if (Control.IsKeyLocked(Keys.CapsLock) && m_IsShift)
        {
          for (int j = 0; j < m_strKeyName1.Length; j++)
          {
            if (m_listKey[i].Name.CompareTo(m_strKeyName1[j]) == 0) { m_listKey[i].Text = m_strKeySmall_1[j]; }
          }
          for (int j = 0; j < m_strKeyName2.Length; j++)
          {
            if (m_listKey[i].Name.CompareTo(m_strKeyName2[j]) == 0) { m_listKey[i].Text = m_strKeySmall_2[j]; }
          }
          for (int j = 0; j < m_strKeyName3.Length; j++)
          {
            if (m_listKey[i].Name.CompareTo(m_strKeyName3[j]) == 0) { m_listKey[i].Text = m_strKeySmall_3[j]; }
          }
          for (int j = 0; j < m_strKeyName4.Length; j++)
          {
            if (m_listKey[i].Name.CompareTo(m_strKeyName4[j]) == 0) { m_listKey[i].Text = m_strKeySmall_4[j]; }
          }
          for (int j = 0; j < m_strKeyName5.Length; j++)
          {
            if (m_listKey[i].Name.CompareTo(m_strKeyName5[j]) == 0) { m_listKey[i].Text = m_strKeySmall_5[j]; }
          }  
        }
        else if (Control.IsKeyLocked(Keys.CapsLock) && !m_IsShift)
        {
          for (int j = 0; j < m_strKeyName1.Length; j++)
          {
            if (m_listKey[i].Name.CompareTo(m_strKeyName1[j]) == 0) { m_listKey[i].Text = m_strKeyCapital_1[j]; }
          }
          for (int j = 0; j < m_strKeyName2.Length; j++)
          {
            if (m_listKey[i].Name.CompareTo(m_strKeyName2[j]) == 0) { m_listKey[i].Text = m_strKeyCapital_2[j]; }
          }
          for (int j = 0; j < m_strKeyName3.Length; j++)
          {
            if (m_listKey[i].Name.CompareTo(m_strKeyName3[j]) == 0) { m_listKey[i].Text = m_strKeyCapital_3[j]; }
          }
          for (int j = 0; j < m_strKeyName4.Length; j++)
          {
            if (m_listKey[i].Name.CompareTo(m_strKeyName4[j]) == 0) { m_listKey[i].Text = m_strKeyCapital_4[j]; }
          }
          for (int j = 0; j < m_strKeyName5.Length; j++)
          {
            if (m_listKey[i].Name.CompareTo(m_strKeyName5[j]) == 0) { m_listKey[i].Text = m_strKeyCapital_5[j]; }
          }  
        }
        else if (!Control.IsKeyLocked(Keys.CapsLock) && m_IsShift)
        {
          for (int j = 0; j < m_strKeyName1.Length; j++)
          {
            if (m_listKey[i].Name.CompareTo(m_strKeyName1[j]) == 0) { m_listKey[i].Text = m_strKeyCapital_1[j]; }
          }
          for (int j = 0; j < m_strKeyName2.Length; j++)
          {
            if (m_listKey[i].Name.CompareTo(m_strKeyName2[j]) == 0) { m_listKey[i].Text = m_strKeyCapital_2[j]; }
          }
          for (int j = 0; j < m_strKeyName3.Length; j++)
          {
            if (m_listKey[i].Name.CompareTo(m_strKeyName3[j]) == 0) { m_listKey[i].Text = m_strKeyCapital_3[j]; }
          }
          for (int j = 0; j < m_strKeyName4.Length; j++)
          {
            if (m_listKey[i].Name.CompareTo(m_strKeyName4[j]) == 0) { m_listKey[i].Text = m_strKeyCapital_4[j]; }
          }
          for (int j = 0; j < m_strKeyName5.Length; j++)
          {
            if (m_listKey[i].Name.CompareTo(m_strKeyName5[j]) == 0) { m_listKey[i].Text = m_strKeyCapital_5[j]; }
          }  
        }
        else if (!Control.IsKeyLocked(Keys.CapsLock) && !m_IsShift)
        {
          for (int j = 0; j < m_strKeyName1.Length; j++)
          {
            if (m_listKey[i].Name.CompareTo(m_strKeyName1[j]) == 0) { m_listKey[i].Text = m_strKeySmall_1[j]; }
          }
          for (int j = 0; j < m_strKeyName2.Length; j++)
          {
            if (m_listKey[i].Name.CompareTo(m_strKeyName2[j]) == 0) { m_listKey[i].Text = m_strKeySmall_2[j]; }
          }
          for (int j = 0; j < m_strKeyName3.Length; j++)
          {
            if (m_listKey[i].Name.CompareTo(m_strKeyName3[j]) == 0) { m_listKey[i].Text = m_strKeySmall_3[j]; }
          }
          for (int j = 0; j < m_strKeyName4.Length; j++)
          {
            if (m_listKey[i].Name.CompareTo(m_strKeyName4[j]) == 0) { m_listKey[i].Text = m_strKeySmall_4[j]; }
          }
          for (int j = 0; j < m_strKeyName5.Length; j++)
          {
            if (m_listKey[i].Name.CompareTo(m_strKeyName5[j]) == 0) { m_listKey[i].Text = m_strKeySmall_5[j]; }
          }  
        }
      }
    }

    private void FRMKeypad_English_Activated(object sender, EventArgs e)
    {
      txt_keyPadEnglish_text.Select(txt_keyPadEnglish_text.Text.Length, txt_keyPadEnglish_text.Text.Length);
    }

    private void btn_keyPadEnglish_clear_Click(object sender, EventArgs e)
    {
      txt_keyPadEnglish_text.Text = "";
      txt_keyPadEnglish_text.Select(txt_keyPadEnglish_text.Text.Length, txt_keyPadEnglish_text.Text.Length);
    }

    private void btn_keyPadEnglish_close_Click(object sender, EventArgs e)
    {
      this.Hide();
    }

    public void Show(string strTitle)
    {
      this.Text = strTitle;
      this.Show();
    }

    public void ShowDialog(string strTitle)
    {
      this.Text = strTitle;
      this.ShowDialog();
    }

    public void SetText(string strText)
    {
      txt_keyPadEnglish_text.Text = strText;
      txt_keyPadEnglish_text.Select(txt_keyPadEnglish_text.Text.Length, txt_keyPadEnglish_text.Text.Length);
    }

    public void SetTextBox(System.Windows.Forms.TextBox editControl)
    {
      m_eType = eEDIT_TYPE.eTEXTBOX;
      m_editControl = editControl;
      txt_keyPadEnglish_text.Text = editControl.Text;
      txt_keyPadEnglish_text.Select(txt_keyPadEnglish_text.Text.Length, txt_keyPadEnglish_text.Text.Length);
    }

    private void FRMKeypad_English_Shown(object sender, EventArgs e)
    {
      timer_keyPadEnglish_Display.Enabled = false;
      timer_keyPadEnglish_Display.Enabled = true;
    }
  }
}
