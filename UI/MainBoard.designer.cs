namespace UI
{
    partial class MainBoard_frm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainBoard_frm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tasks1_lbl = new System.Windows.Forms.Label();
            this.department_lbl = new System.Windows.Forms.Label();
            this.managers_lbl = new System.Windows.Forms.Label();
            this.uesrs_lbl = new System.Windows.Forms.Label();
            this.edit_btn = new System.Windows.Forms.Button();
            this.add_btn = new System.Windows.Forms.Button();
            this.delete_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.welcome_lbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.task_btn = new System.Windows.Forms.Button();
            this.employeesManagers_lbl = new System.Windows.Forms.Label();
            this.taskEmployee_btn = new System.Windows.Forms.Button();
            this.department_btn = new System.Windows.Forms.Button();
            this.projectEmployee_btn = new System.Windows.Forms.Button();
            this.manager_btn = new System.Windows.Forms.Button();
            this.tasksEmployee_lbl = new System.Windows.Forms.Label();
            this.project_btn = new System.Windows.Forms.Button();
            this.administrator_btn = new System.Windows.Forms.Button();
            this.tasks_lbl = new System.Windows.Forms.Label();
            this.projectsEmployee_lbl = new System.Windows.Forms.Label();
            this.currentTypeOfUser_lbl = new System.Windows.Forms.Label();
            this.administrators_lbl = new System.Windows.Forms.Label();
            this.departments_lbl = new System.Windows.Forms.Label();
            this.admins_lbl = new System.Windows.Forms.Label();
            this.projects_lbl = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.currentUser_lbl = new System.Windows.Forms.Label();
            this.logOut_btn = new System.Windows.Forms.Button();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.name_lbl = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.tasks1_lbl);
            this.groupBox1.Controls.Add(this.department_lbl);
            this.groupBox1.Controls.Add(this.managers_lbl);
            this.groupBox1.Controls.Add(this.uesrs_lbl);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(138, 576);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // tasks1_lbl
            // 
            this.tasks1_lbl.Location = new System.Drawing.Point(0, 0);
            this.tasks1_lbl.Name = "tasks1_lbl";
            this.tasks1_lbl.Size = new System.Drawing.Size(100, 23);
            this.tasks1_lbl.TabIndex = 0;
            // 
            // department_lbl
            // 
            this.department_lbl.AutoSize = true;
            this.department_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.department_lbl.Location = new System.Drawing.Point(12, 233);
            this.department_lbl.Name = "department_lbl";
            this.department_lbl.Size = new System.Drawing.Size(104, 18);
            this.department_lbl.TabIndex = 2;
            this.department_lbl.Text = "Departments";
            this.department_lbl.Visible = false;
            // 
            // managers_lbl
            // 
            this.managers_lbl.AutoSize = true;
            this.managers_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.managers_lbl.Location = new System.Drawing.Point(9, 122);
            this.managers_lbl.Name = "managers_lbl";
            this.managers_lbl.Size = new System.Drawing.Size(82, 18);
            this.managers_lbl.TabIndex = 3;
            this.managers_lbl.Text = "Managers";
            // 
            // uesrs_lbl
            // 
            this.uesrs_lbl.AutoSize = true;
            this.uesrs_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uesrs_lbl.Location = new System.Drawing.Point(9, 50);
            this.uesrs_lbl.Name = "uesrs_lbl";
            this.uesrs_lbl.Size = new System.Drawing.Size(65, 18);
            this.uesrs_lbl.TabIndex = 2;
            this.uesrs_lbl.Text = "USERS";
            this.uesrs_lbl.Visible = false;
            // 
            // edit_btn
            // 
            this.edit_btn.Enabled = false;
            this.edit_btn.Location = new System.Drawing.Point(308, 79);
            this.edit_btn.Name = "edit_btn";
            this.edit_btn.Size = new System.Drawing.Size(92, 38);
            this.edit_btn.TabIndex = 28;
            this.edit_btn.Text = "Edit";
            this.edit_btn.UseVisualStyleBackColor = true;
            // 
            // add_btn
            // 
            this.add_btn.Location = new System.Drawing.Point(198, 79);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(95, 38);
            this.add_btn.TabIndex = 29;
            this.add_btn.Text = "New";
            this.add_btn.UseVisualStyleBackColor = true;
            // 
            // delete_btn
            // 
            this.delete_btn.Location = new System.Drawing.Point(418, 79);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(98, 38);
            this.delete_btn.TabIndex = 30;
            this.delete_btn.Text = "Delete";
            this.delete_btn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(829, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 18);
            this.label1.TabIndex = 27;
            this.label1.Text = "User: ";
            // 
            // welcome_lbl
            // 
            this.welcome_lbl.AutoSize = true;
            this.welcome_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcome_lbl.ForeColor = System.Drawing.SystemColors.Highlight;
            this.welcome_lbl.Location = new System.Drawing.Point(206, 41);
            this.welcome_lbl.Name = "welcome_lbl";
            this.welcome_lbl.Size = new System.Drawing.Size(91, 24);
            this.welcome_lbl.TabIndex = 26;
            this.welcome_lbl.Text = "Welcome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(883, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 18);
            this.label3.TabIndex = 25;
            this.label3.Text = "Current User";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(886, 224);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 35);
            this.button1.TabIndex = 24;
            this.button1.Text = "Log Out";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // groupBox
            // 
            this.groupBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox.Controls.Add(this.task_btn);
            this.groupBox.Controls.Add(this.employeesManagers_lbl);
            this.groupBox.Controls.Add(this.taskEmployee_btn);
            this.groupBox.Controls.Add(this.department_btn);
            this.groupBox.Controls.Add(this.projectEmployee_btn);
            this.groupBox.Controls.Add(this.manager_btn);
            this.groupBox.Controls.Add(this.tasksEmployee_lbl);
            this.groupBox.Controls.Add(this.project_btn);
            this.groupBox.Controls.Add(this.administrator_btn);
            this.groupBox.Controls.Add(this.tasks_lbl);
            this.groupBox.Controls.Add(this.projectsEmployee_lbl);
            this.groupBox.Controls.Add(this.currentTypeOfUser_lbl);
            this.groupBox.Controls.Add(this.administrators_lbl);
            this.groupBox.Controls.Add(this.departments_lbl);
            this.groupBox.Controls.Add(this.admins_lbl);
            this.groupBox.Controls.Add(this.projects_lbl);
            this.groupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox.Location = new System.Drawing.Point(-5, -10);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(179, 600);
            this.groupBox.TabIndex = 31;
            this.groupBox.TabStop = false;
            // 
            // task_btn
            // 
            this.task_btn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.task_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.task_btn.Image = ((System.Drawing.Image)(resources.GetObject("task_btn.Image")));
            this.task_btn.Location = new System.Drawing.Point(47, 194);
            this.task_btn.Name = "task_btn";
            this.task_btn.Size = new System.Drawing.Size(81, 67);
            this.task_btn.TabIndex = 40;
            this.task_btn.UseVisualStyleBackColor = true;
            this.task_btn.Click += new System.EventHandler(this.task_btn_Click);
            // 
            // employeesManagers_lbl
            // 
            this.employeesManagers_lbl.AutoSize = true;
            this.employeesManagers_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeesManagers_lbl.Location = new System.Drawing.Point(44, 264);
            this.employeesManagers_lbl.Name = "employeesManagers_lbl";
            this.employeesManagers_lbl.Size = new System.Drawing.Size(93, 18);
            this.employeesManagers_lbl.TabIndex = 8;
            this.employeesManagers_lbl.Text = "MANAGERS";
            // 
            // taskEmployee_btn
            // 
            this.taskEmployee_btn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.taskEmployee_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.taskEmployee_btn.Image = ((System.Drawing.Image)(resources.GetObject("taskEmployee_btn.Image")));
            this.taskEmployee_btn.Location = new System.Drawing.Point(47, 194);
            this.taskEmployee_btn.Name = "taskEmployee_btn";
            this.taskEmployee_btn.Size = new System.Drawing.Size(81, 67);
            this.taskEmployee_btn.TabIndex = 39;
            this.taskEmployee_btn.UseVisualStyleBackColor = true;
            this.taskEmployee_btn.Click += new System.EventHandler(this.task_btn_Click);
            // 
            // department_btn
            // 
            this.department_btn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.department_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.department_btn.Image = ((System.Drawing.Image)(resources.GetObject("department_btn.Image")));
            this.department_btn.Location = new System.Drawing.Point(47, 194);
            this.department_btn.Name = "department_btn";
            this.department_btn.Size = new System.Drawing.Size(81, 67);
            this.department_btn.TabIndex = 38;
            this.department_btn.UseVisualStyleBackColor = true;
            this.department_btn.Click += new System.EventHandler(this.department_btn_Click);
            // 
            // projectEmployee_btn
            // 
            this.projectEmployee_btn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.projectEmployee_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.projectEmployee_btn.Image = ((System.Drawing.Image)(resources.GetObject("projectEmployee_btn.Image")));
            this.projectEmployee_btn.Location = new System.Drawing.Point(47, 89);
            this.projectEmployee_btn.Name = "projectEmployee_btn";
            this.projectEmployee_btn.Size = new System.Drawing.Size(81, 67);
            this.projectEmployee_btn.TabIndex = 41;
            this.projectEmployee_btn.UseVisualStyleBackColor = true;
            this.projectEmployee_btn.Click += new System.EventHandler(this.projectEmployee_btn_Click);
            // 
            // manager_btn
            // 
            this.manager_btn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.manager_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.manager_btn.Image = ((System.Drawing.Image)(resources.GetObject("manager_btn.Image")));
            this.manager_btn.Location = new System.Drawing.Point(47, 194);
            this.manager_btn.Name = "manager_btn";
            this.manager_btn.Size = new System.Drawing.Size(81, 67);
            this.manager_btn.TabIndex = 60;
            this.manager_btn.UseVisualStyleBackColor = true;
            this.manager_btn.Click += new System.EventHandler(this.manager_btn_Click);
            // 
            // tasksEmployee_lbl
            // 
            this.tasksEmployee_lbl.AutoSize = true;
            this.tasksEmployee_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tasksEmployee_lbl.Location = new System.Drawing.Point(56, 264);
            this.tasksEmployee_lbl.Name = "tasksEmployee_lbl";
            this.tasksEmployee_lbl.Size = new System.Drawing.Size(56, 18);
            this.tasksEmployee_lbl.TabIndex = 36;
            this.tasksEmployee_lbl.Text = "TASKS";
            // 
            // project_btn
            // 
            this.project_btn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.project_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.project_btn.Image = ((System.Drawing.Image)(resources.GetObject("project_btn.Image")));
            this.project_btn.Location = new System.Drawing.Point(47, 88);
            this.project_btn.Name = "project_btn";
            this.project_btn.Size = new System.Drawing.Size(81, 67);
            this.project_btn.TabIndex = 40;
            this.project_btn.UseVisualStyleBackColor = true;
            this.project_btn.Click += new System.EventHandler(this.project_btn_Click);
            // 
            // administrator_btn
            // 
            this.administrator_btn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.administrator_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.administrator_btn.Image = ((System.Drawing.Image)(resources.GetObject("administrator_btn.Image")));
            this.administrator_btn.Location = new System.Drawing.Point(47, 88);
            this.administrator_btn.Name = "administrator_btn";
            this.administrator_btn.Size = new System.Drawing.Size(81, 67);
            this.administrator_btn.TabIndex = 41;
            this.administrator_btn.UseVisualStyleBackColor = true;
            this.administrator_btn.Click += new System.EventHandler(this.administrator_btn_Click);
            // 
            // tasks_lbl
            // 
            this.tasks_lbl.AutoSize = true;
            this.tasks_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tasks_lbl.Location = new System.Drawing.Point(56, 264);
            this.tasks_lbl.Name = "tasks_lbl";
            this.tasks_lbl.Size = new System.Drawing.Size(56, 18);
            this.tasks_lbl.TabIndex = 8;
            this.tasks_lbl.Text = "TASKS";
            this.tasks_lbl.Visible = false;
            // 
            // projectsEmployee_lbl
            // 
            this.projectsEmployee_lbl.AutoSize = true;
            this.projectsEmployee_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projectsEmployee_lbl.Location = new System.Drawing.Point(44, 158);
            this.projectsEmployee_lbl.Name = "projectsEmployee_lbl";
            this.projectsEmployee_lbl.Size = new System.Drawing.Size(89, 18);
            this.projectsEmployee_lbl.TabIndex = 35;
            this.projectsEmployee_lbl.Text = "PROJECTS";
            // 
            // currentTypeOfUser_lbl
            // 
            this.currentTypeOfUser_lbl.AutoSize = true;
            this.currentTypeOfUser_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentTypeOfUser_lbl.Location = new System.Drawing.Point(18, 46);
            this.currentTypeOfUser_lbl.Name = "currentTypeOfUser_lbl";
            this.currentTypeOfUser_lbl.Size = new System.Drawing.Size(151, 18);
            this.currentTypeOfUser_lbl.TabIndex = 13;
            this.currentTypeOfUser_lbl.Text = "currentTypeOfUser";
            // 
            // administrators_lbl
            // 
            this.administrators_lbl.Location = new System.Drawing.Point(0, 0);
            this.administrators_lbl.Name = "administrators_lbl";
            this.administrators_lbl.Size = new System.Drawing.Size(100, 23);
            this.administrators_lbl.TabIndex = 27;
            // 
            // departments_lbl
            // 
            this.departments_lbl.AutoSize = true;
            this.departments_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.departments_lbl.Location = new System.Drawing.Point(35, 264);
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
            this.admins_lbl.Location = new System.Drawing.Point(17, 158);
            this.admins_lbl.Name = "admins_lbl";
            this.admins_lbl.Size = new System.Drawing.Size(139, 18);
            this.admins_lbl.TabIndex = 2;
            this.admins_lbl.Text = "ADMINISTRATORS";
            this.admins_lbl.Visible = false;
            // 
            // projects_lbl
            // 
            this.projects_lbl.AutoSize = true;
            this.projects_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projects_lbl.Location = new System.Drawing.Point(44, 158);
            this.projects_lbl.Name = "projects_lbl";
            this.projects_lbl.Size = new System.Drawing.Size(89, 18);
            this.projects_lbl.TabIndex = 2;
            this.projects_lbl.Text = "PROJECTS";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(797, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 18);
            this.label7.TabIndex = 34;
            this.label7.Text = "User: ";
            // 
            // currentUser_lbl
            // 
            this.currentUser_lbl.AutoSize = true;
            this.currentUser_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentUser_lbl.ForeColor = System.Drawing.SystemColors.Highlight;
            this.currentUser_lbl.Location = new System.Drawing.Point(851, 41);
            this.currentUser_lbl.Name = "currentUser_lbl";
            this.currentUser_lbl.Size = new System.Drawing.Size(105, 18);
            this.currentUser_lbl.TabIndex = 33;
            this.currentUser_lbl.Text = "Current User";
            // 
            // logOut_btn
            // 
            this.logOut_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOut_btn.Location = new System.Drawing.Point(854, 79);
            this.logOut_btn.Name = "logOut_btn";
            this.logOut_btn.Size = new System.Drawing.Size(87, 35);
            this.logOut_btn.TabIndex = 32;
            this.logOut_btn.Text = "Log Out";
            this.logOut_btn.UseVisualStyleBackColor = true;
            this.logOut_btn.Click += new System.EventHandler(this.logOut_btn_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(984, 24);
            this.menuStrip.TabIndex = 53;
            this.menuStrip.Text = "menuStrip1";
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
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // name_lbl
            // 
            this.name_lbl.AutoSize = true;
            this.name_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_lbl.ForeColor = System.Drawing.SystemColors.Highlight;
            this.name_lbl.Location = new System.Drawing.Point(305, 45);
            this.name_lbl.Name = "name_lbl";
            this.name_lbl.Size = new System.Drawing.Size(105, 18);
            this.name_lbl.TabIndex = 54;
            this.name_lbl.Text = "Current User";
            // 
            // MainBoard_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.name_lbl);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.currentUser_lbl);
            this.Controls.Add(this.logOut_btn);
            this.Controls.Add(this.edit_btn);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.welcome_lbl);
            this.Controls.Add(this.groupBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainBoard_frm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainBoard";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label tasks1_lbl;
        private System.Windows.Forms.Label department_lbl;
        private System.Windows.Forms.Label managers_lbl;
        private System.Windows.Forms.Label uesrs_lbl;
        private System.Windows.Forms.Button edit_btn;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label welcome_lbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Label administrators_lbl;
        private System.Windows.Forms.Label currentTypeOfUser_lbl;
        private System.Windows.Forms.Label tasks_lbl;
        private System.Windows.Forms.Label departments_lbl;
        private System.Windows.Forms.Label admins_lbl;
        private System.Windows.Forms.Label projects_lbl;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label currentUser_lbl;
        private System.Windows.Forms.Button logOut_btn;
        private System.Windows.Forms.Label tasksEmployee_lbl;
        private System.Windows.Forms.Label projectsEmployee_lbl;
        private System.Windows.Forms.Button taskEmployee_btn;
        private System.Windows.Forms.Button project_btn;
        private System.Windows.Forms.Button administrator_btn;
        private System.Windows.Forms.Button department_btn;
        private System.Windows.Forms.Button projectEmployee_btn;
        private System.Windows.Forms.Button task_btn;
        private System.Windows.Forms.Button manager_btn;
        private System.Windows.Forms.Label employeesManagers_lbl;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label name_lbl;
    }
}