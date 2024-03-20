namespace Base.FORM.COMMON
{
  partial class FRMKeypad_English
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      this.panel1 = new System.Windows.Forms.Panel();
      this.btn_keyPadEnglish_clear = new System.Windows.Forms.Button();
      this.btn_keyPadEnglish_close = new System.Windows.Forms.Button();
      this.txt_keyPadEnglish_text = new System.Windows.Forms.TextBox();
      this.pnl_keyPadEnglish_Key = new System.Windows.Forms.Panel();
      this.timer_keyPadEnglish_Display = new System.Windows.Forms.Timer(this.components);
      this.panel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.btn_keyPadEnglish_clear);
      this.panel1.Controls.Add(this.btn_keyPadEnglish_close);
      this.panel1.Controls.Add(this.txt_keyPadEnglish_text);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel1.Location = new System.Drawing.Point(0, 0);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(884, 60);
      this.panel1.TabIndex = 1;
      // 
      // btn_keyPadEnglish_clear
      // 
      this.btn_keyPadEnglish_clear.Location = new System.Drawing.Point(725, 30);
      this.btn_keyPadEnglish_clear.Name = "btn_keyPadEnglish_clear";
      this.btn_keyPadEnglish_clear.Size = new System.Drawing.Size(75, 23);
      this.btn_keyPadEnglish_clear.TabIndex = 2;
      this.btn_keyPadEnglish_clear.Text = "CLEAR";
      this.btn_keyPadEnglish_clear.UseVisualStyleBackColor = true;
      this.btn_keyPadEnglish_clear.Click += new System.EventHandler(this.btn_keyPadEnglish_clear_Click);
      // 
      // btn_keyPadEnglish_close
      // 
      this.btn_keyPadEnglish_close.Location = new System.Drawing.Point(806, 30);
      this.btn_keyPadEnglish_close.Name = "btn_keyPadEnglish_close";
      this.btn_keyPadEnglish_close.Size = new System.Drawing.Size(75, 23);
      this.btn_keyPadEnglish_close.TabIndex = 1;
      this.btn_keyPadEnglish_close.Text = "CLOSE";
      this.btn_keyPadEnglish_close.UseVisualStyleBackColor = true;
      this.btn_keyPadEnglish_close.Click += new System.EventHandler(this.btn_keyPadEnglish_close_Click);
      // 
      // txt_keyPadEnglish_text
      // 
      this.txt_keyPadEnglish_text.Location = new System.Drawing.Point(3, 3);
      this.txt_keyPadEnglish_text.Name = "txt_keyPadEnglish_text";
      this.txt_keyPadEnglish_text.ReadOnly = true;
      this.txt_keyPadEnglish_text.Size = new System.Drawing.Size(878, 21);
      this.txt_keyPadEnglish_text.TabIndex = 0;
      // 
      // pnl_keyPadEnglish_Key
      // 
      this.pnl_keyPadEnglish_Key.Dock = System.Windows.Forms.DockStyle.Fill;
      this.pnl_keyPadEnglish_Key.Location = new System.Drawing.Point(0, 60);
      this.pnl_keyPadEnglish_Key.Name = "pnl_keyPadEnglish_Key";
      this.pnl_keyPadEnglish_Key.Size = new System.Drawing.Size(884, 302);
      this.pnl_keyPadEnglish_Key.TabIndex = 2;
      // 
      // timer_keyPadEnglish_Display
      // 
      this.timer_keyPadEnglish_Display.Enabled = true;
      this.timer_keyPadEnglish_Display.Interval = 10;
      this.timer_keyPadEnglish_Display.Tick += new System.EventHandler(this.timer_keyPadEnglish_Display_Tick);
      // 
      // FRMKeypad_English
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.ClientSize = new System.Drawing.Size(884, 362);
      this.ControlBox = false;
      this.Controls.Add(this.pnl_keyPadEnglish_Key);
      this.Controls.Add(this.panel1);
      this.KeyPreview = true;
      this.Name = "FRMKeypad_English";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "FRMKeypad_English";
      this.TopMost = true;
      this.Activated += new System.EventHandler(this.FRMKeypad_English_Activated);
      this.Load += new System.EventHandler(this.FRMKeypad_English_Load);
      this.Shown += new System.EventHandler(this.FRMKeypad_English_Shown);
      this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FRMKeypad_English_KeyDown);
      this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FRMKeypad_English_KeyPress);
      this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FRMKeypad_English_KeyUp);
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Panel pnl_keyPadEnglish_Key;
    public System.Windows.Forms.TextBox txt_keyPadEnglish_text;
    private System.Windows.Forms.Button btn_keyPadEnglish_clear;
    private System.Windows.Forms.Button btn_keyPadEnglish_close;
    public System.Windows.Forms.Timer timer_keyPadEnglish_Display;

  }
}