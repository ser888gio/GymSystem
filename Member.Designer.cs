namespace GymSystem
{
    partial class Member
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
            bttnDelete = new Button();
            bttnMembership = new Button();
            bttnMember = new Button();
            bttnInstructor = new Button();
            bttnEdit = new Button();
            bttnAdd = new Button();
            lblListInstr = new Label();
            dataGridInstructors = new DataGridView();
            dateTDoB = new DateTimePicker();
            lblDoB = new Label();
            txtBoxPhone = new TextBox();
            lblPhone = new Label();
            cbGender = new ComboBox();
            lblGender = new Label();
            txtBoxSurname = new TextBox();
            lblSurname = new Label();
            txtBoxName = new TextBox();
            lblName = new Label();
            lblManageInstructors = new Label();
            panelMenu = new Panel();
            pictureBox1 = new PictureBox();
            bttnHome = new Button();
            dateTJoinDate = new DateTimePicker();
            lblJD = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridInstructors).BeginInit();
            panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // bttnDelete
            // 
            bttnDelete.Location = new Point(730, 220);
            bttnDelete.Name = "bttnDelete";
            bttnDelete.Size = new Size(85, 41);
            bttnDelete.TabIndex = 38;
            bttnDelete.Text = "Delete";
            bttnDelete.UseVisualStyleBackColor = true;
            // 
            // bttnMembership
            // 
            bttnMembership.Location = new Point(0, 392);
            bttnMembership.Name = "bttnMembership";
            bttnMembership.Size = new Size(250, 154);
            bttnMembership.TabIndex = 3;
            bttnMembership.Text = "Memberships";
            bttnMembership.UseVisualStyleBackColor = true;
            // 
            // bttnMember
            // 
            bttnMember.Location = new Point(0, 244);
            bttnMember.Name = "bttnMember";
            bttnMember.Size = new Size(250, 154);
            bttnMember.TabIndex = 2;
            bttnMember.Text = "Members";
            bttnMember.UseVisualStyleBackColor = true;
            // 
            // bttnInstructor
            // 
            bttnInstructor.Location = new Point(0, 96);
            bttnInstructor.Name = "bttnInstructor";
            bttnInstructor.Size = new Size(250, 154);
            bttnInstructor.TabIndex = 1;
            bttnInstructor.Text = "Instructors";
            bttnInstructor.UseVisualStyleBackColor = true;
            // 
            // bttnEdit
            // 
            bttnEdit.Location = new Point(575, 222);
            bttnEdit.Name = "bttnEdit";
            bttnEdit.Size = new Size(85, 41);
            bttnEdit.TabIndex = 37;
            bttnEdit.Text = "Edit";
            bttnEdit.UseVisualStyleBackColor = true;
            // 
            // bttnAdd
            // 
            bttnAdd.Location = new Point(410, 222);
            bttnAdd.Name = "bttnAdd";
            bttnAdd.Size = new Size(85, 41);
            bttnAdd.TabIndex = 36;
            bttnAdd.Text = "Add";
            bttnAdd.UseVisualStyleBackColor = true;
            // 
            // lblListInstr
            // 
            lblListInstr.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblListInstr.Location = new Point(578, 264);
            lblListInstr.Name = "lblListInstr";
            lblListInstr.Size = new Size(187, 42);
            lblListInstr.TabIndex = 35;
            lblListInstr.Text = "List of Members";
            // 
            // dataGridInstructors
            // 
            dataGridInstructors.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridInstructors.Location = new Point(345, 309);
            dataGridInstructors.Name = "dataGridInstructors";
            dataGridInstructors.RowHeadersWidth = 51;
            dataGridInstructors.RowTemplate.Height = 29;
            dataGridInstructors.Size = new Size(672, 293);
            dataGridInstructors.TabIndex = 34;
            // 
            // dateTDoB
            // 
            dateTDoB.Location = new Point(730, 161);
            dateTDoB.Name = "dateTDoB";
            dateTDoB.Size = new Size(250, 27);
            dateTDoB.TabIndex = 33;
            // 
            // lblDoB
            // 
            lblDoB.AutoSize = true;
            lblDoB.Location = new Point(730, 123);
            lblDoB.Name = "lblDoB";
            lblDoB.Size = new Size(94, 20);
            lblDoB.TabIndex = 32;
            lblDoB.Text = "Date of Birth";
            // 
            // txtBoxPhone
            // 
            txtBoxPhone.Location = new Point(327, 161);
            txtBoxPhone.Name = "txtBoxPhone";
            txtBoxPhone.Size = new Size(125, 27);
            txtBoxPhone.TabIndex = 31;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(327, 123);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(50, 20);
            lblPhone.TabIndex = 30;
            lblPhone.Text = "Phone";
            // 
            // cbGender
            // 
            cbGender.FormattingEnabled = true;
            cbGender.Items.AddRange(new object[] { "Male", "Female" });
            cbGender.Location = new Point(517, 154);
            cbGender.Name = "cbGender";
            cbGender.Size = new Size(151, 28);
            cbGender.TabIndex = 27;
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Location = new Point(517, 116);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(57, 20);
            lblGender.TabIndex = 26;
            lblGender.Text = "Gender";
            // 
            // txtBoxSurname
            // 
            txtBoxSurname.Location = new Point(517, 53);
            txtBoxSurname.Name = "txtBoxSurname";
            txtBoxSurname.Size = new Size(125, 27);
            txtBoxSurname.TabIndex = 25;
            // 
            // lblSurname
            // 
            lblSurname.AutoSize = true;
            lblSurname.Location = new Point(517, 15);
            lblSurname.Name = "lblSurname";
            lblSurname.Size = new Size(67, 20);
            lblSurname.TabIndex = 24;
            lblSurname.Text = "Surname";
            // 
            // txtBoxName
            // 
            txtBoxName.Location = new Point(327, 53);
            txtBoxName.Name = "txtBoxName";
            txtBoxName.Size = new Size(125, 27);
            txtBoxName.TabIndex = 23;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(327, 15);
            lblName.Name = "lblName";
            lblName.Size = new Size(49, 20);
            lblName.TabIndex = 22;
            lblName.Text = "Name";
            // 
            // lblManageInstructors
            // 
            lblManageInstructors.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblManageInstructors.Location = new Point(327, -63);
            lblManageInstructors.Name = "lblManageInstructors";
            lblManageInstructors.Size = new Size(187, 42);
            lblManageInstructors.TabIndex = 21;
            lblManageInstructors.Text = "Manage Instructors";
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(128, 128, 255);
            panelMenu.Controls.Add(pictureBox1);
            panelMenu.Controls.Add(bttnHome);
            panelMenu.Controls.Add(bttnMembership);
            panelMenu.Controls.Add(bttnMember);
            panelMenu.Controls.Add(bttnInstructor);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(250, 695);
            panelMenu.TabIndex = 20;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo1;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(250, 98);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // bttnHome
            // 
            bttnHome.Location = new Point(0, 542);
            bttnHome.Name = "bttnHome";
            bttnHome.Size = new Size(250, 154);
            bttnHome.TabIndex = 4;
            bttnHome.Text = "Home";
            bttnHome.UseVisualStyleBackColor = true;
            // 
            // dateTJoinDate
            // 
            dateTJoinDate.Location = new Point(721, 47);
            dateTJoinDate.Name = "dateTJoinDate";
            dateTJoinDate.Size = new Size(250, 27);
            dateTJoinDate.TabIndex = 40;
            // 
            // lblJD
            // 
            lblJD.AutoSize = true;
            lblJD.Location = new Point(721, 9);
            lblJD.Name = "lblJD";
            lblJD.Size = new Size(71, 20);
            lblJD.TabIndex = 39;
            lblJD.Text = "Join Date";
            // 
            // Member
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1104, 695);
            Controls.Add(dateTJoinDate);
            Controls.Add(lblJD);
            Controls.Add(bttnDelete);
            Controls.Add(bttnEdit);
            Controls.Add(bttnAdd);
            Controls.Add(lblListInstr);
            Controls.Add(dataGridInstructors);
            Controls.Add(dateTDoB);
            Controls.Add(lblDoB);
            Controls.Add(txtBoxPhone);
            Controls.Add(lblPhone);
            Controls.Add(cbGender);
            Controls.Add(lblGender);
            Controls.Add(txtBoxSurname);
            Controls.Add(lblSurname);
            Controls.Add(txtBoxName);
            Controls.Add(lblName);
            Controls.Add(lblManageInstructors);
            Controls.Add(panelMenu);
            Name = "Member";
            Text = "Member";
            ((System.ComponentModel.ISupportInitialize)dataGridInstructors).EndInit();
            panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bttnDelete;
        private Button bttnMembership;
        private Button bttnMember;
        private Button bttnInstructor;
        private Button bttnEdit;
        private Button bttnAdd;
        private Label lblListInstr;
        private DataGridView dataGridInstructors;
        private DateTimePicker dateTDoB;
        private Label lblDoB;
        private TextBox txtBoxPhone;
        private Label lblPhone;
        private ComboBox cbGender;
        private Label lblGender;
        private TextBox txtBoxSurname;
        private Label lblSurname;
        private TextBox txtBoxName;
        private Label lblName;
        private Label lblManageInstructors;
        private Panel panelMenu;
        private PictureBox pictureBox1;
        private Button bttnHome;
        private DateTimePicker dateTJoinDate;
        private Label lblJD;
    }
}