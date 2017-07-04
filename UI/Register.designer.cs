namespace CompanySystem
{
    partial class Register_frm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register_frm));
            this.register_lbl = new System.Windows.Forms.Label();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.save_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.department_lbl = new System.Windows.Forms.Label();
            this.dateOfBirth_pck = new System.Windows.Forms.DateTimePicker();
            this.dateOfBirth_lbl = new System.Windows.Forms.Label();
            this.gender_lbl = new System.Windows.Forms.Label();
            this.female_rbtn = new System.Windows.Forms.RadioButton();
            this.male_rbtn = new System.Windows.Forms.RadioButton();
            this.lastName_txt = new System.Windows.Forms.TextBox();
            this.prezime_lbl = new System.Windows.Forms.Label();
            this.ime_lbl = new System.Windows.Forms.Label();
            this.Password_lbl = new System.Windows.Forms.Label();
            this.username_lbl = new System.Windows.Forms.Label();
            this.username_txt = new System.Windows.Forms.TextBox();
            this.password_txt = new System.Windows.Forms.TextBox();
            this.firstName_lbl = new System.Windows.Forms.TextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.department_cbox = new System.Windows.Forms.ComboBox();
            this.typeOfUser_cbox = new System.Windows.Forms.ComboBox();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // register_lbl
            // 
            this.register_lbl.AutoSize = true;
            this.register_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(37)))), ((int)(((byte)(83)))));
            this.register_lbl.Location = new System.Drawing.Point(74, 24);
            this.register_lbl.Name = "register_lbl";
            this.register_lbl.Size = new System.Drawing.Size(118, 25);
            this.register_lbl.TabIndex = 3;
            this.register_lbl.Text = "REGISTER";
            // 
            // GroupBox1
            // 
            this.GroupBox1.BackColor = System.Drawing.Color.White;
            this.GroupBox1.Controls.Add(this.typeOfUser_cbox);
            this.GroupBox1.Controls.Add(this.department_cbox);
            this.GroupBox1.Controls.Add(this.cancel_btn);
            this.GroupBox1.Controls.Add(this.save_btn);
            this.GroupBox1.Controls.Add(this.label1);
            this.GroupBox1.Controls.Add(this.department_lbl);
            this.GroupBox1.Controls.Add(this.dateOfBirth_pck);
            this.GroupBox1.Controls.Add(this.dateOfBirth_lbl);
            this.GroupBox1.Controls.Add(this.gender_lbl);
            this.GroupBox1.Controls.Add(this.female_rbtn);
            this.GroupBox1.Controls.Add(this.male_rbtn);
            this.GroupBox1.Controls.Add(this.lastName_txt);
            this.GroupBox1.Controls.Add(this.prezime_lbl);
            this.GroupBox1.Controls.Add(this.ime_lbl);
            this.GroupBox1.Controls.Add(this.Password_lbl);
            this.GroupBox1.Controls.Add(this.username_lbl);
            this.GroupBox1.Controls.Add(this.username_txt);
            this.GroupBox1.Controls.Add(this.password_txt);
            this.GroupBox1.Controls.Add(this.firstName_lbl);
            this.GroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox1.Location = new System.Drawing.Point(79, 63);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(366, 442);
            this.GroupBox1.TabIndex = 4;
            this.GroupBox1.TabStop = false;
            // 
            // cancel_btn
            // 
            this.cancel_btn.Location = new System.Drawing.Point(191, 372);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(92, 37);
            this.cancel_btn.TabIndex = 19;
            this.cancel_btn.Text = "CANCEL";
            this.cancel_btn.UseVisualStyleBackColor = true;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // save_btn
            // 
            this.save_btn.Location = new System.Drawing.Point(48, 372);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(92, 37);
            this.save_btn.TabIndex = 4;
            this.save_btn.Text = "SAVE";
            this.save_btn.UseVisualStyleBackColor = true;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 311);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "Type Of User";
            // 
            // department_lbl
            // 
            this.department_lbl.AutoSize = true;
            this.department_lbl.Location = new System.Drawing.Point(49, 273);
            this.department_lbl.Name = "department_lbl";
            this.department_lbl.Size = new System.Drawing.Size(78, 16);
            this.department_lbl.TabIndex = 16;
            this.department_lbl.Text = "Department";
            // 
            // dateOfBirth_pck
            // 
            this.dateOfBirth_pck.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateOfBirth_pck.Location = new System.Drawing.Point(153, 224);
            this.dateOfBirth_pck.MaxDate = new System.DateTime(2200, 12, 31, 0, 0, 0, 0);
            this.dateOfBirth_pck.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dateOfBirth_pck.Name = "dateOfBirth_pck";
            this.dateOfBirth_pck.Size = new System.Drawing.Size(130, 22);
            this.dateOfBirth_pck.TabIndex = 15;
            this.dateOfBirth_pck.Value = new System.DateTime(2017, 5, 30, 0, 0, 0, 0);
            // 
            // dateOfBirth_lbl
            // 
            this.dateOfBirth_lbl.AutoSize = true;
            this.dateOfBirth_lbl.Location = new System.Drawing.Point(49, 224);
            this.dateOfBirth_lbl.Name = "dateOfBirth_lbl";
            this.dateOfBirth_lbl.Size = new System.Drawing.Size(79, 16);
            this.dateOfBirth_lbl.TabIndex = 14;
            this.dateOfBirth_lbl.Text = "Date of birth";
            // 
            // gender_lbl
            // 
            this.gender_lbl.AutoSize = true;
            this.gender_lbl.Location = new System.Drawing.Point(69, 186);
            this.gender_lbl.Name = "gender_lbl";
            this.gender_lbl.Size = new System.Drawing.Size(53, 16);
            this.gender_lbl.TabIndex = 13;
            this.gender_lbl.Text = "Gender";
            // 
            // female_rbtn
            // 
            this.female_rbtn.AutoSize = true;
            this.female_rbtn.Location = new System.Drawing.Point(224, 184);
            this.female_rbtn.Name = "female_rbtn";
            this.female_rbtn.Size = new System.Drawing.Size(72, 20);
            this.female_rbtn.TabIndex = 12;
            this.female_rbtn.TabStop = true;
            this.female_rbtn.Text = "Female";
            this.female_rbtn.UseVisualStyleBackColor = true;
            // 
            // male_rbtn
            // 
            this.male_rbtn.AutoSize = true;
            this.male_rbtn.Location = new System.Drawing.Point(149, 184);
            this.male_rbtn.Name = "male_rbtn";
            this.male_rbtn.Size = new System.Drawing.Size(56, 20);
            this.male_rbtn.TabIndex = 4;
            this.male_rbtn.TabStop = true;
            this.male_rbtn.Text = "Male";
            this.male_rbtn.UseVisualStyleBackColor = true;
            // 
            // lastName_txt
            // 
            this.lastName_txt.Location = new System.Drawing.Point(149, 143);
            this.lastName_txt.Name = "lastName_txt";
            this.lastName_txt.Size = new System.Drawing.Size(134, 22);
            this.lastName_txt.TabIndex = 11;
            // 
            // prezime_lbl
            // 
            this.prezime_lbl.AutoSize = true;
            this.prezime_lbl.Location = new System.Drawing.Point(49, 146);
            this.prezime_lbl.Name = "prezime_lbl";
            this.prezime_lbl.Size = new System.Drawing.Size(73, 16);
            this.prezime_lbl.TabIndex = 4;
            this.prezime_lbl.Text = "Last Name";
            // 
            // ime_lbl
            // 
            this.ime_lbl.AutoSize = true;
            this.ime_lbl.Location = new System.Drawing.Point(49, 107);
            this.ime_lbl.Name = "ime_lbl";
            this.ime_lbl.Size = new System.Drawing.Size(73, 16);
            this.ime_lbl.TabIndex = 5;
            this.ime_lbl.Text = "First Name";
            // 
            // Password_lbl
            // 
            this.Password_lbl.AutoSize = true;
            this.Password_lbl.Location = new System.Drawing.Point(49, 72);
            this.Password_lbl.Name = "Password_lbl";
            this.Password_lbl.Size = new System.Drawing.Size(68, 16);
            this.Password_lbl.TabIndex = 6;
            this.Password_lbl.Text = "Password";
            // 
            // username_lbl
            // 
            this.username_lbl.AutoSize = true;
            this.username_lbl.Location = new System.Drawing.Point(45, 23);
            this.username_lbl.Name = "username_lbl";
            this.username_lbl.Size = new System.Drawing.Size(71, 16);
            this.username_lbl.TabIndex = 7;
            this.username_lbl.Text = "Username";
            // 
            // username_txt
            // 
            this.username_txt.Location = new System.Drawing.Point(149, 20);
            this.username_txt.Name = "username_txt";
            this.username_txt.Size = new System.Drawing.Size(134, 22);
            this.username_txt.TabIndex = 8;
            // 
            // password_txt
            // 
            this.password_txt.Location = new System.Drawing.Point(149, 69);
            this.password_txt.Name = "password_txt";
            this.password_txt.Size = new System.Drawing.Size(134, 22);
            this.password_txt.TabIndex = 9;
            // 
            // firstName_lbl
            // 
            this.firstName_lbl.Location = new System.Drawing.Point(149, 104);
            this.firstName_lbl.Name = "firstName_lbl";
            this.firstName_lbl.Size = new System.Drawing.Size(134, 22);
            this.firstName_lbl.TabIndex = 10;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // department_cbox
            // 
            this.department_cbox.FormattingEnabled = true;
            this.department_cbox.Location = new System.Drawing.Point(153, 270);
            this.department_cbox.Name = "department_cbox";
            this.department_cbox.Size = new System.Drawing.Size(130, 24);
            this.department_cbox.TabIndex = 18;
            // 
            // typeOfUser_cbox
            // 
            this.typeOfUser_cbox.FormattingEnabled = true;
            this.typeOfUser_cbox.Location = new System.Drawing.Point(153, 308);
            this.typeOfUser_cbox.Name = "typeOfUser_cbox";
            this.typeOfUser_cbox.Size = new System.Drawing.Size(130, 24);
            this.typeOfUser_cbox.TabIndex = 55;
            // 
            // Register_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 561);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.register_lbl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Register_frm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label register_lbl;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Button cancel_btn;
        internal System.Windows.Forms.Button save_btn;
        internal System.Windows.Forms.Label department_lbl;
        internal System.Windows.Forms.DateTimePicker dateOfBirth_pck;
        internal System.Windows.Forms.Label dateOfBirth_lbl;
        internal System.Windows.Forms.Label gender_lbl;
        internal System.Windows.Forms.RadioButton female_rbtn;
        internal System.Windows.Forms.RadioButton male_rbtn;
        internal System.Windows.Forms.TextBox lastName_txt;
        internal System.Windows.Forms.Label prezime_lbl;
        internal System.Windows.Forms.Label ime_lbl;
        internal System.Windows.Forms.Label Password_lbl;
        internal System.Windows.Forms.Label username_lbl;
        internal System.Windows.Forms.TextBox username_txt;
        internal System.Windows.Forms.TextBox password_txt;
        internal System.Windows.Forms.TextBox firstName_lbl;
        private System.Windows.Forms.ErrorProvider errorProvider;
        internal System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox department_cbox;
        private System.Windows.Forms.ComboBox typeOfUser_cbox;
    }
}