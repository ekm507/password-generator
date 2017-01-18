namespace Password_Generator
{
    partial class Form1
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
            this.txtchars = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnstop = new MaterialSkin.Controls.MaterialRaisedButton();
            this.checkautosave = new MaterialSkin.Controls.MaterialCheckBox();
            this.btnsave = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.lblpasscount = new MaterialSkin.Controls.MaterialLabel();
            this.listpass = new System.Windows.Forms.ListBox();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.numtimeout = new System.Windows.Forms.NumericUpDown();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.txtlengh = new System.Windows.Forms.NumericUpDown();
            this.btnclear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numtimeout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtlengh)).BeginInit();
            this.SuspendLayout();
            // 
            // txtchars
            // 
            this.txtchars.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtchars.Depth = 0;
            this.txtchars.Hint = "";
            this.txtchars.Location = new System.Drawing.Point(61, 84);
            this.txtchars.MaxLength = 32767;
            this.txtchars.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtchars.Name = "txtchars";
            this.txtchars.PasswordChar = '\0';
            this.txtchars.SelectedText = "";
            this.txtchars.SelectionLength = 0;
            this.txtchars.SelectionStart = 0;
            this.txtchars.Size = new System.Drawing.Size(640, 23);
            this.txtchars.TabIndex = 1;
            this.txtchars.TabStop = false;
            this.txtchars.Text = "123456789/*-=|+!@#$%^&*()abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            this.txtchars.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(7, 84);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(48, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Chars";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(7, 119);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(82, 19);
            this.materialLabel2.TabIndex = 0;
            this.materialLabel2.Text = "Pass lengh";
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.AutoSize = true;
            this.materialRaisedButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Icon = null;
            this.materialRaisedButton1.Location = new System.Drawing.Point(7, 205);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(64, 36);
            this.materialRaisedButton1.TabIndex = 5;
            this.materialRaisedButton1.Text = "Start";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // btnstop
            // 
            this.btnstop.AutoSize = true;
            this.btnstop.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnstop.Depth = 0;
            this.btnstop.Icon = null;
            this.btnstop.Location = new System.Drawing.Point(77, 205);
            this.btnstop.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnstop.Name = "btnstop";
            this.btnstop.Primary = true;
            this.btnstop.Size = new System.Drawing.Size(56, 36);
            this.btnstop.TabIndex = 6;
            this.btnstop.Text = "Stop";
            this.btnstop.UseVisualStyleBackColor = true;
            this.btnstop.Click += new System.EventHandler(this.btnstop_Click);
            // 
            // checkautosave
            // 
            this.checkautosave.AutoSize = true;
            this.checkautosave.Depth = 0;
            this.checkautosave.Font = new System.Drawing.Font("Roboto", 10F);
            this.checkautosave.Location = new System.Drawing.Point(7, 171);
            this.checkautosave.Margin = new System.Windows.Forms.Padding(0);
            this.checkautosave.MouseLocation = new System.Drawing.Point(-1, -1);
            this.checkautosave.MouseState = MaterialSkin.MouseState.HOVER;
            this.checkautosave.Name = "checkautosave";
            this.checkautosave.Ripple = true;
            this.checkautosave.Size = new System.Drawing.Size(92, 30);
            this.checkautosave.TabIndex = 4;
            this.checkautosave.Text = "Auto Save";
            this.checkautosave.UseVisualStyleBackColor = true;
            // 
            // btnsave
            // 
            this.btnsave.AutoSize = true;
            this.btnsave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnsave.Depth = 0;
            this.btnsave.Icon = null;
            this.btnsave.Location = new System.Drawing.Point(7, 247);
            this.btnsave.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnsave.Name = "btnsave";
            this.btnsave.Primary = true;
            this.btnsave.Size = new System.Drawing.Size(140, 36);
            this.btnsave.TabIndex = 7;
            this.btnsave.Text = "Save PassWords";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(2, 286);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(151, 19);
            this.materialLabel3.TabIndex = 0;
            this.materialLabel3.Text = "Created Passwords : ";
            // 
            // lblpasscount
            // 
            this.lblpasscount.AutoSize = true;
            this.lblpasscount.Depth = 0;
            this.lblpasscount.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblpasscount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblpasscount.Location = new System.Drawing.Point(12, 309);
            this.lblpasscount.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblpasscount.Name = "lblpasscount";
            this.lblpasscount.Size = new System.Drawing.Size(17, 19);
            this.lblpasscount.TabIndex = 0;
            this.lblpasscount.Text = "0";
            this.lblpasscount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listpass
            // 
            this.listpass.FormattingEnabled = true;
            this.listpass.Location = new System.Drawing.Point(153, 137);
            this.listpass.Name = "listpass";
            this.listpass.Size = new System.Drawing.Size(548, 173);
            this.listpass.TabIndex = 0;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(150, 116);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(89, 19);
            this.materialLabel4.TabIndex = 0;
            this.materialLabel4.Text = "PassWord : ";
            // 
            // numtimeout
            // 
            this.numtimeout.Location = new System.Drawing.Point(87, 144);
            this.numtimeout.Name = "numtimeout";
            this.numtimeout.Size = new System.Drawing.Size(60, 20);
            this.numtimeout.TabIndex = 3;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(7, 144);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(74, 19);
            this.materialLabel5.TabIndex = 0;
            this.materialLabel5.Text = "Time Out:";
            // 
            // txtlengh
            // 
            this.txtlengh.Location = new System.Drawing.Point(95, 119);
            this.txtlengh.Name = "txtlengh";
            this.txtlengh.Size = new System.Drawing.Size(52, 20);
            this.txtlengh.TabIndex = 2;
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.Color.Transparent;
            this.btnclear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclear.Location = new System.Drawing.Point(153, 312);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(548, 23);
            this.btnclear.TabIndex = 0;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 339);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.txtlengh);
            this.Controls.Add(this.numtimeout);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.listpass);
            this.Controls.Add(this.lblpasscount);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.checkautosave);
            this.Controls.Add(this.btnstop);
            this.Controls.Add(this.materialRaisedButton1);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.txtchars);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Password Generator                                                               " +
    "               Code By: ErfanKH & MPCL5";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numtimeout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtlengh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField txtchars;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private MaterialSkin.Controls.MaterialRaisedButton btnstop;
        private MaterialSkin.Controls.MaterialCheckBox checkautosave;
        private MaterialSkin.Controls.MaterialRaisedButton btnsave;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel lblpasscount;
        private System.Windows.Forms.ListBox listpass;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private System.Windows.Forms.NumericUpDown numtimeout;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private System.Windows.Forms.NumericUpDown txtlengh;
        private System.Windows.Forms.Button btnclear;
    }
}

