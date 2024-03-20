namespace Base.FORM
{
  partial class FRMBase
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
      this.mns_base_manu = new System.Windows.Forms.MenuStrip();
      this.menu_file = new System.Windows.Forms.ToolStripMenuItem();
      this.menu_setting = new System.Windows.Forms.ToolStripMenuItem();
      this.menu_manual = new System.Windows.Forms.ToolStripMenuItem();
      this.menu_exit = new System.Windows.Forms.ToolStripMenuItem();
      this.menu_test = new System.Windows.Forms.ToolStripMenuItem();
      this.pnl_base_top = new System.Windows.Forms.Panel();
      this.pnl_base_bottom = new System.Windows.Forms.Panel();
      this.pnl_base_left = new System.Windows.Forms.Panel();
      this.pnl_base_main = new System.Windows.Forms.Panel();
      this.timer_base_display = new System.Windows.Forms.Timer(this.components);
      this.mns_base_manu.SuspendLayout();
      this.SuspendLayout();
      // 
      // mns_base_manu
      // 
      this.mns_base_manu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_file,
            this.menu_setting,
            this.menu_manual,
            this.menu_exit,
            this.menu_test});
      this.mns_base_manu.Location = new System.Drawing.Point(0, 0);
      this.mns_base_manu.Name = "mns_base_manu";
      this.mns_base_manu.Size = new System.Drawing.Size(1264, 24);
      this.mns_base_manu.TabIndex = 0;
      this.mns_base_manu.Text = "menuStrip1";
      // 
      // menu_file
      // 
      this.menu_file.Name = "menu_file";
      this.menu_file.Size = new System.Drawing.Size(51, 20);
      this.menu_file.Text = "File(&F)";
      // 
      // menu_setting
      // 
      this.menu_setting.Name = "menu_setting";
      this.menu_setting.Size = new System.Drawing.Size(72, 20);
      this.menu_setting.Text = "Setting(&S)";
      // 
      // menu_manual
      // 
      this.menu_manual.Name = "menu_manual";
      this.menu_manual.Size = new System.Drawing.Size(78, 20);
      this.menu_manual.Text = "Manual(&M)";
      // 
      // menu_exit
      // 
      this.menu_exit.Name = "menu_exit";
      this.menu_exit.Size = new System.Drawing.Size(53, 20);
      this.menu_exit.Text = "Exit(&X)";
      // 
      // menu_test
      // 
      this.menu_test.Name = "menu_test";
      this.menu_test.Size = new System.Drawing.Size(54, 20);
      this.menu_test.Text = "Test(&T)";
      // 
      // pnl_base_top
      // 
      this.pnl_base_top.Dock = System.Windows.Forms.DockStyle.Top;
      this.pnl_base_top.Location = new System.Drawing.Point(0, 24);
      this.pnl_base_top.Name = "pnl_base_top";
      this.pnl_base_top.Size = new System.Drawing.Size(1264, 50);
      this.pnl_base_top.TabIndex = 1;
      // 
      // pnl_base_bottom
      // 
      this.pnl_base_bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.pnl_base_bottom.Location = new System.Drawing.Point(0, 936);
      this.pnl_base_bottom.Name = "pnl_base_bottom";
      this.pnl_base_bottom.Size = new System.Drawing.Size(1264, 50);
      this.pnl_base_bottom.TabIndex = 2;
      // 
      // pnl_base_left
      // 
      this.pnl_base_left.Dock = System.Windows.Forms.DockStyle.Left;
      this.pnl_base_left.Location = new System.Drawing.Point(0, 74);
      this.pnl_base_left.Name = "pnl_base_left";
      this.pnl_base_left.Size = new System.Drawing.Size(200, 862);
      this.pnl_base_left.TabIndex = 3;
      // 
      // pnl_base_main
      // 
      this.pnl_base_main.Dock = System.Windows.Forms.DockStyle.Fill;
      this.pnl_base_main.Location = new System.Drawing.Point(200, 74);
      this.pnl_base_main.Name = "pnl_base_main";
      this.pnl_base_main.Size = new System.Drawing.Size(1064, 862);
      this.pnl_base_main.TabIndex = 4;
      // 
      // timer_base_display
      // 
      this.timer_base_display.Enabled = true;
      this.timer_base_display.Interval = 50;
      this.timer_base_display.Tick += new System.EventHandler(this.timer_base_display_Tick);
      // 
      // FRMBase
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.BackColor = System.Drawing.Color.Black;
      this.ClientSize = new System.Drawing.Size(1264, 986);
      this.Controls.Add(this.pnl_base_main);
      this.Controls.Add(this.pnl_base_left);
      this.Controls.Add(this.pnl_base_bottom);
      this.Controls.Add(this.pnl_base_top);
      this.Controls.Add(this.mns_base_manu);
      this.ForeColor = System.Drawing.Color.White;
      this.KeyPreview = true;
      this.MainMenuStrip = this.mns_base_manu;
      this.Name = "FRMBase";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Project";
      this.Load += new System.EventHandler(this.FRMBase_Load);
      this.mns_base_manu.ResumeLayout(false);
      this.mns_base_manu.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.MenuStrip mns_base_manu;
    private System.Windows.Forms.ToolStripMenuItem menu_file;
    private System.Windows.Forms.ToolStripMenuItem menu_setting;
    private System.Windows.Forms.ToolStripMenuItem menu_manual;
    private System.Windows.Forms.ToolStripMenuItem menu_exit;
    private System.Windows.Forms.ToolStripMenuItem menu_test;
    private System.Windows.Forms.Panel pnl_base_top;
    private System.Windows.Forms.Panel pnl_base_bottom;
    private System.Windows.Forms.Panel pnl_base_left;
    private System.Windows.Forms.Panel pnl_base_main;
    private System.Windows.Forms.Timer timer_base_display;
  }
}