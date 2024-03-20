namespace Base.FORM.COMMON
{
  partial class FRMLoginManager
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
      this.list_loginManager_ID = new System.Windows.Forms.ListBox();
      this.group_loginManager_ID = new System.Windows.Forms.GroupBox();
      this.group_loginManager_Information = new System.Windows.Forms.GroupBox();
      this.btn_loginManager_Close = new System.Windows.Forms.Button();
      this.btn_loginManager_Change = new System.Windows.Forms.Button();
      this.lbl_loginManager_LEVEL = new System.Windows.Forms.Label();
      this.lbl_loginManager_INFO = new System.Windows.Forms.Label();
      this.lbl_loginManager_PWC = new System.Windows.Forms.Label();
      this.lbl_loginManager_PW = new System.Windows.Forms.Label();
      this.cb_loginManager_LEVEL = new System.Windows.Forms.ComboBox();
      this.txt_loginManager_INFO = new System.Windows.Forms.TextBox();
      this.txt_loginManager_PWC = new System.Windows.Forms.TextBox();
      this.txt_loginManager_PW = new System.Windows.Forms.TextBox();
      this.txt_loginManager_ID = new System.Windows.Forms.TextBox();
      this.lbl_loginManager_ID = new System.Windows.Forms.Label();
      this.btn_loginManager_Delete = new System.Windows.Forms.Button();
      this.group_loginManager_ID.SuspendLayout();
      this.group_loginManager_Information.SuspendLayout();
      this.SuspendLayout();
      // 
      // list_loginManager_ID
      // 
      this.list_loginManager_ID.Font = new System.Drawing.Font("Gulim", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.list_loginManager_ID.FormattingEnabled = true;
      this.list_loginManager_ID.ItemHeight = 27;
      this.list_loginManager_ID.Location = new System.Drawing.Point(6, 30);
      this.list_loginManager_ID.Name = "list_loginManager_ID";
      this.list_loginManager_ID.ScrollAlwaysVisible = true;
      this.list_loginManager_ID.Size = new System.Drawing.Size(301, 436);
      this.list_loginManager_ID.TabIndex = 0;
      this.list_loginManager_ID.Click += new System.EventHandler(this.list_loginManager_ID_Click);
      // 
      // group_loginManager_ID
      // 
      this.group_loginManager_ID.Controls.Add(this.list_loginManager_ID);
      this.group_loginManager_ID.Font = new System.Drawing.Font("Gulim", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.group_loginManager_ID.ForeColor = System.Drawing.Color.White;
      this.group_loginManager_ID.Location = new System.Drawing.Point(12, 12);
      this.group_loginManager_ID.Name = "group_loginManager_ID";
      this.group_loginManager_ID.Size = new System.Drawing.Size(315, 477);
      this.group_loginManager_ID.TabIndex = 1;
      this.group_loginManager_ID.TabStop = false;
      this.group_loginManager_ID.Text = "USER LIST";
      // 
      // group_loginManager_Information
      // 
      this.group_loginManager_Information.Controls.Add(this.btn_loginManager_Delete);
      this.group_loginManager_Information.Controls.Add(this.btn_loginManager_Close);
      this.group_loginManager_Information.Controls.Add(this.btn_loginManager_Change);
      this.group_loginManager_Information.Controls.Add(this.lbl_loginManager_LEVEL);
      this.group_loginManager_Information.Controls.Add(this.lbl_loginManager_INFO);
      this.group_loginManager_Information.Controls.Add(this.lbl_loginManager_PWC);
      this.group_loginManager_Information.Controls.Add(this.lbl_loginManager_PW);
      this.group_loginManager_Information.Controls.Add(this.cb_loginManager_LEVEL);
      this.group_loginManager_Information.Controls.Add(this.txt_loginManager_INFO);
      this.group_loginManager_Information.Controls.Add(this.txt_loginManager_PWC);
      this.group_loginManager_Information.Controls.Add(this.txt_loginManager_PW);
      this.group_loginManager_Information.Controls.Add(this.txt_loginManager_ID);
      this.group_loginManager_Information.Controls.Add(this.lbl_loginManager_ID);
      this.group_loginManager_Information.Font = new System.Drawing.Font("Gulim", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.group_loginManager_Information.ForeColor = System.Drawing.Color.White;
      this.group_loginManager_Information.Location = new System.Drawing.Point(333, 12);
      this.group_loginManager_Information.Name = "group_loginManager_Information";
      this.group_loginManager_Information.Size = new System.Drawing.Size(576, 477);
      this.group_loginManager_Information.TabIndex = 2;
      this.group_loginManager_Information.TabStop = false;
      this.group_loginManager_Information.Text = "Information";
      // 
      // btn_loginManager_Close
      // 
      this.btn_loginManager_Close.BackColor = System.Drawing.Color.LightGray;
      this.btn_loginManager_Close.Font = new System.Drawing.Font("Gulim", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.btn_loginManager_Close.ForeColor = System.Drawing.Color.Black;
      this.btn_loginManager_Close.Location = new System.Drawing.Point(410, 368);
      this.btn_loginManager_Close.Name = "btn_loginManager_Close";
      this.btn_loginManager_Close.Size = new System.Drawing.Size(160, 98);
      this.btn_loginManager_Close.TabIndex = 11;
      this.btn_loginManager_Close.Text = "Close";
      this.btn_loginManager_Close.UseVisualStyleBackColor = false;
      this.btn_loginManager_Close.Click += new System.EventHandler(this.btn_loginManager_Close_Click);
      // 
      // btn_loginManager_Change
      // 
      this.btn_loginManager_Change.BackColor = System.Drawing.Color.LightGray;
      this.btn_loginManager_Change.Font = new System.Drawing.Font("Gulim", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.btn_loginManager_Change.ForeColor = System.Drawing.Color.Black;
      this.btn_loginManager_Change.Location = new System.Drawing.Point(244, 368);
      this.btn_loginManager_Change.Name = "btn_loginManager_Change";
      this.btn_loginManager_Change.Size = new System.Drawing.Size(160, 98);
      this.btn_loginManager_Change.TabIndex = 10;
      this.btn_loginManager_Change.Text = "Change";
      this.btn_loginManager_Change.UseVisualStyleBackColor = false;
      this.btn_loginManager_Change.Click += new System.EventHandler(this.btn_loginManager_Change_Click);
      // 
      // lbl_loginManager_LEVEL
      // 
      this.lbl_loginManager_LEVEL.AutoSize = true;
      this.lbl_loginManager_LEVEL.Font = new System.Drawing.Font("Gulim", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.lbl_loginManager_LEVEL.Location = new System.Drawing.Point(16, 314);
      this.lbl_loginManager_LEVEL.Name = "lbl_loginManager_LEVEL";
      this.lbl_loginManager_LEVEL.Size = new System.Drawing.Size(183, 48);
      this.lbl_loginManager_LEVEL.TabIndex = 9;
      this.lbl_loginManager_LEVEL.Text = "LEVEL:";
      // 
      // lbl_loginManager_INFO
      // 
      this.lbl_loginManager_INFO.AutoSize = true;
      this.lbl_loginManager_INFO.Font = new System.Drawing.Font("Gulim", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.lbl_loginManager_INFO.Location = new System.Drawing.Point(72, 252);
      this.lbl_loginManager_INFO.Name = "lbl_loginManager_INFO";
      this.lbl_loginManager_INFO.Size = new System.Drawing.Size(127, 48);
      this.lbl_loginManager_INFO.TabIndex = 8;
      this.lbl_loginManager_INFO.Text = "Info:";
      // 
      // lbl_loginManager_PWC
      // 
      this.lbl_loginManager_PWC.AutoSize = true;
      this.lbl_loginManager_PWC.Font = new System.Drawing.Font("Gulim", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.lbl_loginManager_PWC.Location = new System.Drawing.Point(30, 183);
      this.lbl_loginManager_PWC.Name = "lbl_loginManager_PWC";
      this.lbl_loginManager_PWC.Size = new System.Drawing.Size(169, 48);
      this.lbl_loginManager_PWC.TabIndex = 7;
      this.lbl_loginManager_PWC.Text = "PW/C:";
      // 
      // lbl_loginManager_PW
      // 
      this.lbl_loginManager_PW.AutoSize = true;
      this.lbl_loginManager_PW.Font = new System.Drawing.Font("Gulim", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.lbl_loginManager_PW.Location = new System.Drawing.Point(86, 114);
      this.lbl_loginManager_PW.Name = "lbl_loginManager_PW";
      this.lbl_loginManager_PW.Size = new System.Drawing.Size(113, 48);
      this.lbl_loginManager_PW.TabIndex = 6;
      this.lbl_loginManager_PW.Text = "PW:";
      // 
      // cb_loginManager_LEVEL
      // 
      this.cb_loginManager_LEVEL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cb_loginManager_LEVEL.Font = new System.Drawing.Font("Gulim", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.cb_loginManager_LEVEL.FormattingEnabled = true;
      this.cb_loginManager_LEVEL.Location = new System.Drawing.Point(205, 306);
      this.cb_loginManager_LEVEL.Name = "cb_loginManager_LEVEL";
      this.cb_loginManager_LEVEL.Size = new System.Drawing.Size(365, 56);
      this.cb_loginManager_LEVEL.TabIndex = 5;
      // 
      // txt_loginManager_INFO
      // 
      this.txt_loginManager_INFO.Font = new System.Drawing.Font("Gulim", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.txt_loginManager_INFO.Location = new System.Drawing.Point(205, 237);
      this.txt_loginManager_INFO.Name = "txt_loginManager_INFO";
      this.txt_loginManager_INFO.Size = new System.Drawing.Size(365, 63);
      this.txt_loginManager_INFO.TabIndex = 4;
      // 
      // txt_loginManager_PWC
      // 
      this.txt_loginManager_PWC.Font = new System.Drawing.Font("Gulim", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.txt_loginManager_PWC.Location = new System.Drawing.Point(205, 168);
      this.txt_loginManager_PWC.Name = "txt_loginManager_PWC";
      this.txt_loginManager_PWC.Size = new System.Drawing.Size(365, 63);
      this.txt_loginManager_PWC.TabIndex = 3;
      this.txt_loginManager_PWC.UseSystemPasswordChar = true;
      // 
      // txt_loginManager_PW
      // 
      this.txt_loginManager_PW.Font = new System.Drawing.Font("Gulim", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.txt_loginManager_PW.Location = new System.Drawing.Point(205, 99);
      this.txt_loginManager_PW.Name = "txt_loginManager_PW";
      this.txt_loginManager_PW.Size = new System.Drawing.Size(365, 63);
      this.txt_loginManager_PW.TabIndex = 2;
      this.txt_loginManager_PW.UseSystemPasswordChar = true;
      // 
      // txt_loginManager_ID
      // 
      this.txt_loginManager_ID.Font = new System.Drawing.Font("Gulim", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.txt_loginManager_ID.Location = new System.Drawing.Point(205, 30);
      this.txt_loginManager_ID.Name = "txt_loginManager_ID";
      this.txt_loginManager_ID.Size = new System.Drawing.Size(365, 63);
      this.txt_loginManager_ID.TabIndex = 1;
      // 
      // lbl_loginManager_ID
      // 
      this.lbl_loginManager_ID.AutoSize = true;
      this.lbl_loginManager_ID.Font = new System.Drawing.Font("Gulim", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.lbl_loginManager_ID.Location = new System.Drawing.Point(112, 45);
      this.lbl_loginManager_ID.Name = "lbl_loginManager_ID";
      this.lbl_loginManager_ID.Size = new System.Drawing.Size(87, 48);
      this.lbl_loginManager_ID.TabIndex = 0;
      this.lbl_loginManager_ID.Text = "ID:";
      // 
      // btn_loginManager_Delete
      // 
      this.btn_loginManager_Delete.BackColor = System.Drawing.Color.LightGray;
      this.btn_loginManager_Delete.Font = new System.Drawing.Font("Gulim", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.btn_loginManager_Delete.ForeColor = System.Drawing.Color.Black;
      this.btn_loginManager_Delete.Location = new System.Drawing.Point(78, 368);
      this.btn_loginManager_Delete.Name = "btn_loginManager_Delete";
      this.btn_loginManager_Delete.Size = new System.Drawing.Size(160, 98);
      this.btn_loginManager_Delete.TabIndex = 12;
      this.btn_loginManager_Delete.Text = "Delete";
      this.btn_loginManager_Delete.UseVisualStyleBackColor = false;
      // 
      // FRMLoginManager
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.BackColor = System.Drawing.Color.Black;
      this.ClientSize = new System.Drawing.Size(917, 501);
      this.ControlBox = false;
      this.Controls.Add(this.group_loginManager_Information);
      this.Controls.Add(this.group_loginManager_ID);
      this.Name = "FRMLoginManager";
      this.Text = "Manager";
      this.Load += new System.EventHandler(this.FRMLoginManager_Load);
      this.Shown += new System.EventHandler(this.FRMLoginManager_Shown);
      this.group_loginManager_ID.ResumeLayout(false);
      this.group_loginManager_Information.ResumeLayout(false);
      this.group_loginManager_Information.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.ListBox list_loginManager_ID;
    private System.Windows.Forms.GroupBox group_loginManager_ID;
    private System.Windows.Forms.GroupBox group_loginManager_Information;
    private System.Windows.Forms.Label lbl_loginManager_ID;
    private System.Windows.Forms.Label lbl_loginManager_LEVEL;
    private System.Windows.Forms.Label lbl_loginManager_INFO;
    private System.Windows.Forms.Label lbl_loginManager_PWC;
    private System.Windows.Forms.Label lbl_loginManager_PW;
    private System.Windows.Forms.ComboBox cb_loginManager_LEVEL;
    private System.Windows.Forms.TextBox txt_loginManager_INFO;
    private System.Windows.Forms.TextBox txt_loginManager_PWC;
    private System.Windows.Forms.TextBox txt_loginManager_PW;
    private System.Windows.Forms.TextBox txt_loginManager_ID;
    private System.Windows.Forms.Button btn_loginManager_Close;
    private System.Windows.Forms.Button btn_loginManager_Change;
    private System.Windows.Forms.Button btn_loginManager_Delete;
  }
}