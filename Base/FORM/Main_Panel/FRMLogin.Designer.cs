namespace Base.FORM.Main_Panel
{
  partial class FRMLogin
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
      this.lbl_login_ID = new System.Windows.Forms.Label();
      this.txt_login_ID = new System.Windows.Forms.TextBox();
      this.txt_login_PW = new System.Windows.Forms.TextBox();
      this.lbl_login_PW = new System.Windows.Forms.Label();
      this.btn_login_login = new System.Windows.Forms.Button();
      this.btn_login_createID = new System.Windows.Forms.Button();
      this.btn_login_manageID = new System.Windows.Forms.Button();
      this.chk_login_keypad = new System.Windows.Forms.CheckBox();
      this.SuspendLayout();
      // 
      // lbl_login_ID
      // 
      this.lbl_login_ID.AutoSize = true;
      this.lbl_login_ID.Font = new System.Drawing.Font("Gulim", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.lbl_login_ID.Location = new System.Drawing.Point(73, 368);
      this.lbl_login_ID.Name = "lbl_login_ID";
      this.lbl_login_ID.Size = new System.Drawing.Size(112, 64);
      this.lbl_login_ID.TabIndex = 0;
      this.lbl_login_ID.Text = "ID:";
      // 
      // txt_login_ID
      // 
      this.txt_login_ID.Font = new System.Drawing.Font("Gulim", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.txt_login_ID.Location = new System.Drawing.Point(236, 365);
      this.txt_login_ID.Name = "txt_login_ID";
      this.txt_login_ID.Size = new System.Drawing.Size(474, 81);
      this.txt_login_ID.TabIndex = 2;
      this.txt_login_ID.Click += new System.EventHandler(this.txt_login_ID_Click);
      // 
      // txt_login_PW
      // 
      this.txt_login_PW.Font = new System.Drawing.Font("Gulim", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.txt_login_PW.Location = new System.Drawing.Point(236, 452);
      this.txt_login_PW.Name = "txt_login_PW";
      this.txt_login_PW.Size = new System.Drawing.Size(474, 81);
      this.txt_login_PW.TabIndex = 4;
      this.txt_login_PW.UseSystemPasswordChar = true;
      // 
      // lbl_login_PW
      // 
      this.lbl_login_PW.AutoSize = true;
      this.lbl_login_PW.Font = new System.Drawing.Font("Gulim", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.lbl_login_PW.Location = new System.Drawing.Point(38, 455);
      this.lbl_login_PW.Name = "lbl_login_PW";
      this.lbl_login_PW.Size = new System.Drawing.Size(147, 64);
      this.lbl_login_PW.TabIndex = 3;
      this.lbl_login_PW.Text = "PW:";
      // 
      // btn_login_login
      // 
      this.btn_login_login.BackColor = System.Drawing.Color.LightGray;
      this.btn_login_login.Font = new System.Drawing.Font("Gulim", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.btn_login_login.ForeColor = System.Drawing.Color.Black;
      this.btn_login_login.Location = new System.Drawing.Point(716, 365);
      this.btn_login_login.Name = "btn_login_login";
      this.btn_login_login.Size = new System.Drawing.Size(315, 168);
      this.btn_login_login.TabIndex = 5;
      this.btn_login_login.Text = "LOGIN";
      this.btn_login_login.UseVisualStyleBackColor = false;
      this.btn_login_login.Click += new System.EventHandler(this.btn_login_login_Click);
      // 
      // btn_login_createID
      // 
      this.btn_login_createID.BackColor = System.Drawing.Color.LightGray;
      this.btn_login_createID.Font = new System.Drawing.Font("Gulim", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.btn_login_createID.ForeColor = System.Drawing.Color.Black;
      this.btn_login_createID.Location = new System.Drawing.Point(236, 539);
      this.btn_login_createID.Name = "btn_login_createID";
      this.btn_login_createID.Size = new System.Drawing.Size(315, 90);
      this.btn_login_createID.TabIndex = 6;
      this.btn_login_createID.Text = "CREATE";
      this.btn_login_createID.UseVisualStyleBackColor = false;
      this.btn_login_createID.Click += new System.EventHandler(this.btn_login_createID_Click);
      // 
      // btn_login_manageID
      // 
      this.btn_login_manageID.BackColor = System.Drawing.Color.LightGray;
      this.btn_login_manageID.Font = new System.Drawing.Font("Gulim", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.btn_login_manageID.ForeColor = System.Drawing.Color.Black;
      this.btn_login_manageID.Location = new System.Drawing.Point(716, 539);
      this.btn_login_manageID.Name = "btn_login_manageID";
      this.btn_login_manageID.Size = new System.Drawing.Size(315, 90);
      this.btn_login_manageID.TabIndex = 7;
      this.btn_login_manageID.Text = "MANAGE";
      this.btn_login_manageID.UseVisualStyleBackColor = false;
      this.btn_login_manageID.Click += new System.EventHandler(this.btn_login_manageID_Click);
      // 
      // chk_login_keypad
      // 
      this.chk_login_keypad.AutoSize = true;
      this.chk_login_keypad.Location = new System.Drawing.Point(935, 834);
      this.chk_login_keypad.Name = "chk_login_keypad";
      this.chk_login_keypad.Size = new System.Drawing.Size(117, 16);
      this.chk_login_keypad.TabIndex = 8;
      this.chk_login_keypad.Text = "Virtual Keyboard";
      this.chk_login_keypad.UseVisualStyleBackColor = true;
      // 
      // FRMLogin
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.Black;
      this.ClientSize = new System.Drawing.Size(1064, 862);
      this.Controls.Add(this.chk_login_keypad);
      this.Controls.Add(this.btn_login_manageID);
      this.Controls.Add(this.btn_login_createID);
      this.Controls.Add(this.btn_login_login);
      this.Controls.Add(this.txt_login_PW);
      this.Controls.Add(this.lbl_login_PW);
      this.Controls.Add(this.txt_login_ID);
      this.Controls.Add(this.lbl_login_ID);
      this.ForeColor = System.Drawing.Color.White;
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.KeyPreview = true;
      this.Name = "FRMLogin";
      this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
      this.Text = "FRMLogin";
      this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FRMLogin_KeyPress);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label lbl_login_ID;
    private System.Windows.Forms.TextBox txt_login_ID;
    private System.Windows.Forms.TextBox txt_login_PW;
    private System.Windows.Forms.Label lbl_login_PW;
    private System.Windows.Forms.Button btn_login_login;
    private System.Windows.Forms.Button btn_login_createID;
    private System.Windows.Forms.Button btn_login_manageID;
    public System.Windows.Forms.CheckBox chk_login_keypad;
  }
}