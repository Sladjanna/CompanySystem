namespace UI.Admin
{
    partial class AdminBoard_frm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminBoard_frm));
            this.dataGVUsers2 = new System.Windows.Forms.DataGridView();
            this.edit_btn = new System.Windows.Forms.Button();
            this.add_btn = new System.Windows.Forms.Button();
            this.currentUser_lbl = new System.Windows.Forms.Label();
            this.logOut_btn = new System.Windows.Forms.Button();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.administrator_btn = new System.Windows.Forms.Button();
            this.currentTypeOfUser_lbl = new System.Windows.Forms.Label();
            this.departments_lbl = new System.Windows.Forms.Label();
            this.admins_lbl = new System.Windows.Forms.Label();
            this.department_btn = new System.Windows.Forms.Button();
            this.allUsers_rb = new System.Windows.Forms.RadioButton();
            this.administrators_rb = new System.Windows.Forms.RadioButton();
            this.managers_rb = new System.Windows.Forms.RadioButton();
            this.employees_rb = new System.Windows.Forms.RadioButton();
            this.loadUsers_gb = new System.Windows.Forms.GroupBox();
            this.promoteToManager_btn = new System.Windows.Forms.Button();
            this.department_cmb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGVUsers = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Birthday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeOfUserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DepartmentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVUsers2)).BeginInit();
            this.groupBox.SuspendLayout();
            this.loadUsers_gb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGVUsers2
            // 
            this.dataGVUsers2.Location = new System.Drawing.Point(0, 0);
            this.dataGVUsers2.Name = "dataGVUsers2";
            this.dataGVUsers2.Size = new System.Drawing.Size(240, 150);
            this.dataGVUsers2.TabIndex = 0;
            // 
            // edit_btn
            // 
            this.edit_btn.Enabled = false;
            this.edit_btn.Location = new System.Drawing.Point(306, 38);
            this.edit_btn.Name = "edit_btn";
            this.edit_btn.Size = new System.Drawing.Size(92, 38);
            this.edit_btn.TabIndex = 31;
            this.edit_btn.Text = "Edit Users";
            this.edit_btn.UseVisualStyleBackColor = true;
            this.edit_btn.Click += new System.EventHandler(this.edit_btn_Click);
            // 
            // add_btn
            // 
            this.add_btn.Location = new System.Drawing.Point(196, 38);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(95, 38);
            this.add_btn.TabIndex = 32;
            this.add_btn.Text = "New User";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // currentUser_lbl
            // 
            this.currentUser_lbl.AutoSize = true;
            this.currentUser_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentUser_lbl.ForeColor = System.Drawing.SystemColors.Highlight;
            this.currentUser_lbl.Location = new System.Drawing.Point(741, 47);
            this.currentUser_lbl.Name = "currentUser_lbl";
            this.currentUser_lbl.Size = new System.Drawing.Size(105, 18);
            this.currentUser_lbl.TabIndex = 36;
            this.currentUser_lbl.Text = "Current User";
            // 
            // logOut_btn
            // 
            this.logOut_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOut_btn.Location = new System.Drawing.Point(889, 41);
            this.logOut_btn.Name = "logOut_btn";
            this.logOut_btn.Size = new System.Drawing.Size(87, 35);
            this.logOut_btn.TabIndex = 35;
            this.logOut_btn.Text = "Log Out";
            this.logOut_btn.UseVisualStyleBackColor = true;
            this.logOut_btn.Click += new System.EventHandler(this.logOut_btn_Click);
            // 
            // groupBox
            // 
            this.groupBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox.Controls.Add(this.administrator_btn);
            this.groupBox.Controls.Add(this.currentTypeOfUser_lbl);
            this.groupBox.Controls.Add(this.departments_lbl);
            this.groupBox.Controls.Add(this.admins_lbl);
            this.groupBox.Controls.Add(this.department_btn);
            this.groupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox.Location = new System.Drawing.Point(-5, -10);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(179, 600);
            this.groupBox.TabIndex = 38;
            this.groupBox.TabStop = false;
            // 
            // administrator_btn
            // 
            this.administrator_btn.Enabled = false;
            this.administrator_btn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.administrator_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.administrator_btn.Image = ((System.Drawing.Image)(resources.GetObject("administrator_btn.Image")));
            this.administrator_btn.Location = new System.Drawing.Point(42, 106);
            this.administrator_btn.Name = "administrator_btn";
            this.administrator_btn.Size = new System.Drawing.Size(81, 67);
            this.administrator_btn.TabIndex = 42;
            this.administrator_btn.UseVisualStyleBackColor = true;
            // 
            // currentTypeOfUser_lbl
            // 
            this.currentTypeOfUser_lbl.AutoSize = true;
            this.currentTypeOfUser_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentTypeOfUser_lbl.Location = new System.Drawing.Point(14, 62);
            this.currentTypeOfUser_lbl.Name = "currentTypeOfUser_lbl";
            this.currentTypeOfUser_lbl.Size = new System.Drawing.Size(151, 18);
            this.currentTypeOfUser_lbl.TabIndex = 13;
            this.currentTypeOfUser_lbl.Text = "currentTypeOfUser";
            // 
            // departments_lbl
            // 
            this.departments_lbl.AutoSize = true;
            this.departments_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.departments_lbl.Location = new System.Drawing.Point(17, 281);
            this.departments_lbl.Name = "departments_lbl";
            this.departments_lbl.Size = new System.Drawing.Size(121, 18);
            this.departments_lbl.TabIndex = 2;
            this.departments_lbl.Text = "DEPARTMENTS";
            this.departments_lbl.Visible = false;
            // 
            // admins_lbl
            // 
            this.admins_lbl.AutoSize = true;
            this.admins_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admins_lbl.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.admins_lbl.Location = new System.Drawing.Point(11, 176);
            this.admins_lbl.Name = "admins_lbl";
            this.admins_lbl.Size = new System.Drawing.Size(139, 18);
            this.admins_lbl.TabIndex = 2;
            this.admins_lbl.Text = "ADMINISTRATORS";
            this.admins_lbl.Visible = false;
            // 
            // department_btn
            // 
            this.department_btn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.department_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.department_btn.Image = ((System.Drawing.Image)(resources.GetObject("department_btn.Image")));
            this.department_btn.Location = new System.Drawing.Point(42, 211);
            this.department_btn.Name = "department_btn";
            this.department_btn.Size = new System.Drawing.Size(81, 67);
            this.department_btn.TabIndex = 38;
            this.department_btn.UseVisualStyleBackColor = true;
            this.department_btn.Click += new System.EventHandler(this.department_btn_Click);
            // 
            // allUsers_rb
            // 
            this.allUsers_rb.AutoSize = true;
            this.allUsers_rb.Location = new System.Drawing.Point(15, 14);
            this.allUsers_rb.Name = "allUsers_rb";
            this.allUsers_rb.Size = new System.Drawing.Size(66, 17);
            this.allUsers_rb.TabIndex = 40;
            this.allUsers_rb.TabStop = true;
            this.allUsers_rb.Text = "All Users";
            this.allUsers_rb.UseVisualStyleBackColor = true;
            this.allUsers_rb.CheckedChanged += new System.EventHandler(this.allUsers_rb_CheckedChanged);
            // 
            // administrators_rb
            // 
            this.administrators_rb.AutoSize = true;
            this.administrators_rb.Location = new System.Drawing.Point(111, 14);
            this.administrators_rb.Name = "administrators_rb";
            this.administrators_rb.Size = new System.Drawing.Size(90, 17);
            this.administrators_rb.TabIndex = 41;
            this.administrators_rb.TabStop = true;
            this.administrators_rb.Text = "Administrators";
            this.administrators_rb.UseVisualStyleBackColor = true;
            this.administrators_rb.CheckedChanged += new System.EventHandler(this.administrators_rb_CheckedChanged);
            // 
            // managers_rb
            // 
            this.managers_rb.AutoSize = true;
            this.managers_rb.Location = new System.Drawing.Point(224, 14);
            this.managers_rb.Name = "managers_rb";
            this.managers_rb.Size = new System.Drawing.Size(72, 17);
            this.managers_rb.TabIndex = 42;
            this.managers_rb.TabStop = true;
            this.managers_rb.Text = "Managers";
            this.managers_rb.UseVisualStyleBackColor = true;
            this.managers_rb.CheckedChanged += new System.EventHandler(this.managers_rb_CheckedChanged);
            // 
            // employees_rb
            // 
            this.employees_rb.AutoSize = true;
            this.employees_rb.Location = new System.Drawing.Point(342, 14);
            this.employees_rb.Name = "employees_rb";
            this.employees_rb.Size = new System.Drawing.Size(76, 17);
            this.employees_rb.TabIndex = 43;
            this.employees_rb.TabStop = true;
            this.employees_rb.Text = "Employees";
            this.employees_rb.UseVisualStyleBackColor = true;
            this.employees_rb.CheckedChanged += new System.EventHandler(this.employees_rb_CheckedChanged);
            // 
            // loadUsers_gb
            // 
            this.loadUsers_gb.Controls.Add(this.allUsers_rb);
            this.loadUsers_gb.Controls.Add(this.employees_rb);
            this.loadUsers_gb.Controls.Add(this.administrators_rb);
            this.loadUsers_gb.Controls.Add(this.managers_rb);
            this.loadUsers_gb.Location = new System.Drawing.Point(196, 82);
            this.loadUsers_gb.Name = "loadUsers_gb";
            this.loadUsers_gb.Size = new System.Drawing.Size(442, 35);
            this.loadUsers_gb.TabIndex = 44;
            this.loadUsers_gb.TabStop = false;
            // 
            // promoteToManager_btn
            // 
            this.promoteToManager_btn.Enabled = false;
            this.promoteToManager_btn.Location = new System.Drawing.Point(416, 38);
            this.promoteToManager_btn.Name = "promoteToManager_btn";
            this.promoteToManager_btn.Size = new System.Drawing.Size(117, 38);
            this.promoteToManager_btn.TabIndex = 45;
            this.promoteToManager_btn.Text = "Promote To Manager";
            this.promoteToManager_btn.UseVisualStyleBackColor = true;
            this.promoteToManager_btn.Click += new System.EventHandler(this.promoteToManager_Click);
            // 
            // department_cmb
            // 
            this.department_cmb.Location = new System.Drawing.Point(813, 92);
            this.department_cmb.Name = "department_cmb";
            this.department_cmb.Size = new System.Drawing.Size(165, 21);
            this.department_cmb.TabIndex = 49;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(677, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 47;
            this.label1.Text = "Working in Department";
            // 
            // dataGVUsers
            // 
            this.dataGVUsers.AllowUserToAddRows = false;
            this.dataGVUsers.AllowUserToDeleteRows = false;
            this.dataGVUsers.AllowUserToResizeColumns = false;
            this.dataGVUsers.AutoGenerateColumns = false;
            this.dataGVUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGVUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.FirstName,
            this.dataGridViewTextBoxColumn5,
            this.Birthday,
            this.dataGridViewTextBoxColumn6,
            this.TypeOfUserID,
            this.DepartmentID});
            this.dataGVUsers.DataSource = this.userBindingSource;
            this.dataGVUsers.Location = new System.Drawing.Point(196, 137);
            this.dataGVUsers.Name = "dataGVUsers";
            this.dataGVUsers.ReadOnly = true;
            this.dataGVUsers.RowHeadersVisible = false;
            this.dataGVUsers.Size = new System.Drawing.Size(780, 312);
            this.dataGVUsers.TabIndex = 48;
            this.dataGVUsers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGVUsers_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "UserName";
            this.dataGridViewTextBoxColumn2.HeaderText = "UserName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Password";
            this.dataGridViewTextBoxColumn3.HeaderText = "Password";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // FirstName
            // 
            this.FirstName.DataPropertyName = "FirstName";
            this.FirstName.HeaderText = "First Name";
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "LastName";
            this.dataGridViewTextBoxColumn5.HeaderText = "LastName";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // Birthday
            // 
            this.Birthday.DataPropertyName = "Birthday";
            this.Birthday.HeaderText = "Birthday";
            this.Birthday.Name = "Birthday";
            this.Birthday.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Gender";
            this.dataGridViewTextBoxColumn6.HeaderText = "Gender";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // TypeOfUserID
            // 
            this.TypeOfUserID.DataPropertyName = "TypeOfUserID";
            this.TypeOfUserID.HeaderText = "TypeOfUserID";
            this.TypeOfUserID.Name = "TypeOfUserID";
            this.TypeOfUserID.ReadOnly = true;
            // 
            // DepartmentID
            // 
            this.DepartmentID.DataPropertyName = "DepartmentID";
            this.DepartmentID.HeaderText = "DepartmentID";
            this.DepartmentID.Name = "DepartmentID";
            this.DepartmentID.ReadOnly = true;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(Model.User);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(677, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 18);
            this.label2.TabIndex = 50;
            this.label2.Text = "User: ";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(984, 24);
            this.menuStrip1.TabIndex = 51;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // AdminBoard_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGVUsers);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.department_cmb);
            this.Controls.Add(this.promoteToManager_btn);
            this.Controls.Add(this.loadUsers_gb);
            this.Controls.Add(this.currentUser_lbl);
            this.Controls.Add(this.logOut_btn);
            this.Controls.Add(this.edit_btn);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.groupBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AdminBoard_frm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Board";
            ((System.ComponentModel.ISupportInitialize)(this.dataGVUsers2)).EndInit();
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.loadUsers_gb.ResumeLayout(false);
            this.loadUsers_gb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGVUsers2;
        private System.Windows.Forms.Button edit_btn;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Label currentUser_lbl;
        private System.Windows.Forms.Button logOut_btn;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Label currentTypeOfUser_lbl;
        private System.Windows.Forms.Label departments_lbl;
        private System.Windows.Forms.Label admins_lbl;
        private System.Windows.Forms.RadioButton allUsers_rb;
        private System.Windows.Forms.RadioButton administrators_rb;
        private System.Windows.Forms.RadioButton managers_rb;
        private System.Windows.Forms.RadioButton employees_rb;
        private System.Windows.Forms.GroupBox loadUsers_gb;
        private System.Windows.Forms.Button promoteToManager_btn;
        private System.Windows.Forms.ComboBox department_cmb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.DataGridView dataGVUsers;
        private System.Windows.Forms.Label label2;
        //  private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        //   private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        //   private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        //    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.Button administrator_btn;
        private System.Windows.Forms.Button department_btn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Birthday;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeOfUserID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepartmentID;
    }
}