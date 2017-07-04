namespace UI.Admin
{
    partial class Departments_frm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Departments_frm));
            this.newDepartment_btn = new System.Windows.Forms.Button();
            this.editDepartment_btn = new System.Windows.Forms.Button();
            this.deleteDepartment = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.departments_lbl = new System.Windows.Forms.Label();
            this.currentTypeOfUser_lbl = new System.Windows.Forms.Label();
            this.administrator_btn = new System.Windows.Forms.Button();
            this.admins_lbl = new System.Windows.Forms.Label();
            this.department_btn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.currentUser_lbl = new System.Windows.Forms.Label();
            this.logOut_btn = new System.Windows.Forms.Button();
            this.departmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGVDepartments = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CompanyID = new System.Windows.Forms.DataGridViewTextBoxColumn();
     //       this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Active = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVDepartments)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // newDepartment_btn
            // 
            this.newDepartment_btn.Location = new System.Drawing.Point(188, 63);
            this.newDepartment_btn.Name = "newDepartment_btn";
            this.newDepartment_btn.Size = new System.Drawing.Size(94, 38);
            this.newDepartment_btn.TabIndex = 5;
            this.newDepartment_btn.Text = "New Department";
            this.newDepartment_btn.UseVisualStyleBackColor = true;
            this.newDepartment_btn.Click += new System.EventHandler(this.NewDepartment_btn_Click);
            // 
            // editDepartment_btn
            // 
            this.editDepartment_btn.Enabled = false;
            this.editDepartment_btn.Location = new System.Drawing.Point(298, 63);
            this.editDepartment_btn.Name = "editDepartment_btn";
            this.editDepartment_btn.Size = new System.Drawing.Size(94, 38);
            this.editDepartment_btn.TabIndex = 13;
            this.editDepartment_btn.Text = "Edit";
            this.editDepartment_btn.UseVisualStyleBackColor = true;
            this.editDepartment_btn.Click += new System.EventHandler(this.editDepartment_btn_Click);
            // 
            // deleteDepartment
            // 
            this.deleteDepartment.Enabled = false;
            this.deleteDepartment.Location = new System.Drawing.Point(406, 63);
            this.deleteDepartment.Name = "deleteDepartment";
            this.deleteDepartment.Size = new System.Drawing.Size(94, 38);
            this.deleteDepartment.TabIndex = 14;
            this.deleteDepartment.Text = "Delete";
            this.deleteDepartment.UseVisualStyleBackColor = true;
            this.deleteDepartment.Click += new System.EventHandler(this.deleteDepartment_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox2.Controls.Add(this.departments_lbl);
            this.groupBox2.Controls.Add(this.currentTypeOfUser_lbl);
            this.groupBox2.Controls.Add(this.administrator_btn);
            this.groupBox2.Controls.Add(this.admins_lbl);
            this.groupBox2.Controls.Add(this.department_btn);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(-5, -10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(179, 600);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            // 
            // departments_lbl
            // 
            this.departments_lbl.AutoSize = true;
            this.departments_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.departments_lbl.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.departments_lbl.Location = new System.Drawing.Point(30, 273);
            this.departments_lbl.Name = "departments_lbl";
            this.departments_lbl.Size = new System.Drawing.Size(121, 18);
            this.departments_lbl.TabIndex = 41;
            this.departments_lbl.Text = "DEPARTMENTS";
            this.departments_lbl.Visible = false;
            // 
            // currentTypeOfUser_lbl
            // 
            this.currentTypeOfUser_lbl.AutoSize = true;
            this.currentTypeOfUser_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentTypeOfUser_lbl.Location = new System.Drawing.Point(12, 47);
            this.currentTypeOfUser_lbl.Name = "currentTypeOfUser_lbl";
            this.currentTypeOfUser_lbl.Size = new System.Drawing.Size(151, 18);
            this.currentTypeOfUser_lbl.TabIndex = 41;
            this.currentTypeOfUser_lbl.Text = "currentTypeOfUser";
            // 
            // administrator_btn
            // 
            this.administrator_btn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.administrator_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.administrator_btn.Image = ((System.Drawing.Image)(resources.GetObject("administrator_btn.Image")));
            this.administrator_btn.Location = new System.Drawing.Point(45, 97);
            this.administrator_btn.Name = "administrator_btn";
            this.administrator_btn.Size = new System.Drawing.Size(81, 67);
            this.administrator_btn.TabIndex = 41;
            this.administrator_btn.UseVisualStyleBackColor = true;
            this.administrator_btn.Click += new System.EventHandler(this.administator_btn_Click);
            // 
            // admins_lbl
            // 
            this.admins_lbl.AutoSize = true;
            this.admins_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admins_lbl.Location = new System.Drawing.Point(14, 167);
            this.admins_lbl.Name = "admins_lbl";
            this.admins_lbl.Size = new System.Drawing.Size(139, 18);
            this.admins_lbl.TabIndex = 2;
            this.admins_lbl.Text = "ADMINISTRATORS";
            // 
            // department_btn
            // 
            this.department_btn.Enabled = false;
            this.department_btn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.department_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.department_btn.Image = ((System.Drawing.Image)(resources.GetObject("department_btn.Image")));
            this.department_btn.Location = new System.Drawing.Point(45, 203);
            this.department_btn.Name = "department_btn";
            this.department_btn.Size = new System.Drawing.Size(81, 67);
            this.department_btn.TabIndex = 38;
            this.department_btn.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(797, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 18);
            this.label7.TabIndex = 40;
            this.label7.Text = "User: ";
            // 
            // currentUser_lbl
            // 
            this.currentUser_lbl.AutoSize = true;
            this.currentUser_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentUser_lbl.ForeColor = System.Drawing.SystemColors.Highlight;
            this.currentUser_lbl.Location = new System.Drawing.Point(851, 39);
            this.currentUser_lbl.Name = "currentUser_lbl";
            this.currentUser_lbl.Size = new System.Drawing.Size(105, 18);
            this.currentUser_lbl.TabIndex = 39;
            this.currentUser_lbl.Text = "Current User";
            // 
            // logOut_btn
            // 
            this.logOut_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOut_btn.Location = new System.Drawing.Point(854, 65);
            this.logOut_btn.Name = "logOut_btn";
            this.logOut_btn.Size = new System.Drawing.Size(87, 35);
            this.logOut_btn.TabIndex = 38;
            this.logOut_btn.Text = "Log Out";
            this.logOut_btn.UseVisualStyleBackColor = true;
            this.logOut_btn.Click += new System.EventHandler(this.logOut_btn_Click);
            // 
            // departmentBindingSource
            // 
            this.departmentBindingSource.DataSource = typeof(Model.Department);
            // 
            // dataGVDepartments
            // 
            this.dataGVDepartments.AllowUserToAddRows = false;
            this.dataGVDepartments.AllowUserToDeleteRows = false;
            this.dataGVDepartments.AutoGenerateColumns = false;
            this.dataGVDepartments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGVDepartments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVDepartments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.CompanyID,
            //this.Name,
            this.Description,
            this.Active});
            this.dataGVDepartments.DataSource = this.departmentBindingSource;
            this.dataGVDepartments.Location = new System.Drawing.Point(188, 126);
            this.dataGVDepartments.Name = "dataGVDepartments";
            this.dataGVDepartments.ReadOnly = true;
            this.dataGVDepartments.RowHeadersVisible = false;
            this.dataGVDepartments.Size = new System.Drawing.Size(753, 330);
            this.dataGVDepartments.TabIndex = 41;
            this.dataGVDepartments.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGVDepartments_CellClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(984, 24);
            this.menuStrip1.TabIndex = 52;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.closeToolStripMenuItem.Text = "Close";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // CompanyID
            // 
            this.CompanyID.DataPropertyName = "CompanyID";
            this.CompanyID.HeaderText = "CompanyID";
            this.CompanyID.Name = "CompanyID";
            this.CompanyID.ReadOnly = true;
            this.CompanyID.Visible = false;
            // 
            // Name
            // 
       //     this.Name.DataPropertyName = "Name";
      //      this.Name.HeaderText = "Name";
       //     this.Name.Name = "Name";
       //     this.Name.ReadOnly = true;
            // 
            // Description
            // 
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // Active
            // 
            this.Active.DataPropertyName = "Active";
            this.Active.FillWeight = 51.16974F;
            this.Active.HeaderText = "Active";
            this.Active.MinimumWidth = 15;
            this.Active.Name = "Active";
            this.Active.ReadOnly = true;
            // 
            // Departments_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dataGVDepartments);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.currentUser_lbl);
            this.Controls.Add(this.logOut_btn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.deleteDepartment);
            this.Controls.Add(this.editDepartment_btn);
            this.Controls.Add(this.newDepartment_btn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
          //  this.Name = "Departments_frm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DepartmentBoard";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVDepartments)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button newDepartment_btn;
        private System.Windows.Forms.Button editDepartment_btn;
        private System.Windows.Forms.Button deleteDepartment;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label admins_lbl;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label currentUser_lbl;
        private System.Windows.Forms.Button logOut_btn;
        private System.Windows.Forms.Label currentTypeOfUser_lbl;
        private System.Windows.Forms.Label departments_lbl;
        private System.Windows.Forms.BindingSource departmentBindingSource;
        private System.Windows.Forms.DataGridView dataGVDepartments;
        private System.Windows.Forms.Button administrator_btn;
        private System.Windows.Forms.Button department_btn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompanyID;
   //     private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Active;
    }
}