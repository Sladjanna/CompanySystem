namespace UI
{
    partial class login_frm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login_frm));
            this.login_lbl = new System.Windows.Forms.Label();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.login_btn = new System.Windows.Forms.Button();
            this.register_lbl = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.password_lbl = new System.Windows.Forms.Label();
            this.username_lbl = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.tip = new System.Windows.Forms.ToolTip(this.components);
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // login_lbl
            // 
            this.login_lbl.AutoSize = true;
            this.login_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(37)))), ((int)(((byte)(83)))));
            this.login_lbl.Location = new System.Drawing.Point(86, 26);
            this.login_lbl.Name = "login_lbl";
            this.login_lbl.Size = new System.Drawing.Size(82, 25);
            this.login_lbl.TabIndex = 6;
            this.login_lbl.Text = "LOG IN";
            // 
            // GroupBox1
            // 
            this.GroupBox1.BackColor = System.Drawing.Color.White;
            this.GroupBox1.Controls.Add(this.login_btn);
            this.GroupBox1.Controls.Add(this.register_lbl);
            this.GroupBox1.Controls.Add(this.tbPassword);
            this.GroupBox1.Controls.Add(this.tbUserName);
            this.GroupBox1.Controls.Add(this.password_lbl);
            this.GroupBox1.Controls.Add(this.username_lbl);
            this.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox1.Location = new System.Drawing.Point(82, 54);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(299, 270);
            this.GroupBox1.TabIndex = 7;
            this.GroupBox1.TabStop = false;
            // 
            // login_btn
            // 
            this.login_btn.Location = new System.Drawing.Point(93, 173);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(100, 40);
            this.login_btn.TabIndex = 4;
            this.login_btn.Text = "LOG IN";
            this.login_btn.UseVisualStyleBackColor = true;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // register_lbl
            // 
            this.register_lbl.AutoSize = true;
            this.register_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_lbl.Location = new System.Drawing.Point(92, 232);
            this.register_lbl.Name = "register_lbl";
            this.register_lbl.Size = new System.Drawing.Size(115, 16);
            this.register_lbl.TabIndex = 2;
            this.register_lbl.Text = "Register new user";
            this.register_lbl.Click += new System.EventHandler(this.register_lbl_Click);
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(93, 121);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(100, 22);
            this.tbPassword.TabIndex = 2;
            this.tbPassword.Text = "admin";
            // 
            // tbUserName
            // 
            this.tbUserName.Location = new System.Drawing.Point(93, 49);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(100, 22);
            this.tbUserName.TabIndex = 1;
            this.tbUserName.Text = "admin";
            // 
            // password_lbl
            // 
            this.password_lbl.AutoSize = true;
            this.password_lbl.Location = new System.Drawing.Point(92, 102);
            this.password_lbl.Name = "password_lbl";
            this.password_lbl.Size = new System.Drawing.Size(68, 16);
            this.password_lbl.TabIndex = 3;
            this.password_lbl.Text = "Password";
            // 
            // username_lbl
            // 
            this.username_lbl.AutoSize = true;
            this.username_lbl.Location = new System.Drawing.Point(90, 30);
            this.username_lbl.Name = "username_lbl";
            this.username_lbl.Size = new System.Drawing.Size(71, 16);
            this.username_lbl.TabIndex = 2;
            this.username_lbl.Text = "Username";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // login_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 340);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.login_lbl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "login_frm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label login_lbl;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Label register_lbl;

        internal System.Windows.Forms.TextBox tbPassword;
        internal System.Windows.Forms.TextBox tbUserName;
        internal System.Windows.Forms.Label password_lbl;
        internal System.Windows.Forms.Label username_lbl;
        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.ToolTip tip;
    }
}