namespace GymSystem
{
    partial class Instructor
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
            panelMenu = new Panel();
            pictureBox1 = new PictureBox();
            bttnHome = new Button();
            bttnMembership = new Button();
            bttnMember = new Button();
            bttnInstructor = new Button();
            lblManageInstructors = new Label();
            lblName = new Label();
            txtBoxName = new TextBox();
            txtBoxSurname = new TextBox();
            lblSurname = new Label();
            lblGender = new Label();
            cbGender = new ComboBox();
            cbExperience = new ComboBox();
            lblExperience = new Label();
            txtBoxPhone = new TextBox();
            lblPhone = new Label();
            lblDoB = new Label();
            dTPickDoB = new DateTimePicker();
            dataGridInstructors = new DataGridView();
            lblListInstr = new Label();
            bttnAdd = new Button();
            bttnEdit = new Button();
            bttnDelete = new Button();
            panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridInstructors).BeginInit();
            SuspendLayout();
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
            panelMenu.Margin = new Padding(3, 2, 3, 2);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(219, 521);
            panelMenu.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo1;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(219, 74);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // bttnHome
            // 
            bttnHome.Location = new Point(0, 406);
            bttnHome.Margin = new Padding(3, 2, 3, 2);
            bttnHome.Name = "bttnHome";
            bttnHome.Size = new Size(219, 116);
            bttnHome.TabIndex = 4;
            bttnHome.Text = "Home";
            bttnHome.UseVisualStyleBackColor = true;
            // 
            // bttnMembership
            // 
            bttnMembership.Location = new Point(0, 294);
            bttnMembership.Margin = new Padding(3, 2, 3, 2);
            bttnMembership.Name = "bttnMembership";
            bttnMembership.Size = new Size(219, 116);
            bttnMembership.TabIndex = 3;
            bttnMembership.Text = "Memberships";
            bttnMembership.UseVisualStyleBackColor = true;
            // 
            // bttnMember
            // 
            bttnMember.Location = new Point(0, 183);
            bttnMember.Margin = new Padding(3, 2, 3, 2);
            bttnMember.Name = "bttnMember";
            bttnMember.Size = new Size(219, 116);
            bttnMember.TabIndex = 2;
            bttnMember.Text = "Members";
            bttnMember.UseVisualStyleBackColor = true;
            // 
            // bttnInstructor
            // 
            bttnInstructor.Location = new Point(0, 72);
            bttnInstructor.Margin = new Padding(3, 2, 3, 2);
            bttnInstructor.Name = "bttnInstructor";
            bttnInstructor.Size = new Size(219, 116);
            bttnInstructor.TabIndex = 1;
            bttnInstructor.Text = "Instructors";
            bttnInstructor.UseVisualStyleBackColor = true;
            // 
            // lblManageInstructors
            // 
            lblManageInstructors.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblManageInstructors.Location = new Point(298, 14);
            lblManageInstructors.Name = "lblManageInstructors";
            lblManageInstructors.Size = new Size(164, 32);
            lblManageInstructors.TabIndex = 2;
            lblManageInstructors.Text = "Manage Instructors";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(298, 72);
            lblName.Name = "lblName";
            lblName.Size = new Size(39, 15);
            lblName.TabIndex = 3;
            lblName.Text = "Name";
            // 
            // txtBoxName
            // 
            txtBoxName.Location = new Point(298, 100);
            txtBoxName.Margin = new Padding(3, 2, 3, 2);
            txtBoxName.Name = "txtBoxName";
            txtBoxName.Size = new Size(110, 23);
            txtBoxName.TabIndex = 4;
            // 
            // txtBoxSurname
            // 
            txtBoxSurname.Location = new Point(464, 100);
            txtBoxSurname.Margin = new Padding(3, 2, 3, 2);
            txtBoxSurname.Name = "txtBoxSurname";
            txtBoxSurname.Size = new Size(110, 23);
            txtBoxSurname.TabIndex = 6;
            // 
            // lblSurname
            // 
            lblSurname.AutoSize = true;
            lblSurname.Location = new Point(464, 72);
            lblSurname.Name = "lblSurname";
            lblSurname.Size = new Size(54, 15);
            lblSurname.TabIndex = 5;
            lblSurname.Text = "Surname";
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Location = new Point(650, 72);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(45, 15);
            lblGender.TabIndex = 7;
            lblGender.Text = "Gender";
            // 
            // cbGender
            // 
            cbGender.FormattingEnabled = true;
            cbGender.Items.AddRange(new object[] { "Male", "Female" });
            cbGender.Location = new Point(650, 100);
            cbGender.Margin = new Padding(3, 2, 3, 2);
            cbGender.Name = "cbGender";
            cbGender.Size = new Size(133, 23);
            cbGender.TabIndex = 8;
            // 
            // cbExperience
            // 
            cbExperience.FormattingEnabled = true;
            cbExperience.Items.AddRange(new object[] { "Junior", "Medior", "Senior" });
            cbExperience.Location = new Point(298, 182);
            cbExperience.Margin = new Padding(3, 2, 3, 2);
            cbExperience.Name = "cbExperience";
            cbExperience.Size = new Size(133, 23);
            cbExperience.TabIndex = 10;
            // 
            // lblExperience
            // 
            lblExperience.AutoSize = true;
            lblExperience.Location = new Point(298, 153);
            lblExperience.Name = "lblExperience";
            lblExperience.Size = new Size(64, 15);
            lblExperience.TabIndex = 9;
            lblExperience.Text = "Experience";
            // 
            // txtBoxPhone
            // 
            txtBoxPhone.Location = new Point(480, 182);
            txtBoxPhone.Margin = new Padding(3, 2, 3, 2);
            txtBoxPhone.Name = "txtBoxPhone";
            txtBoxPhone.Size = new Size(110, 23);
            txtBoxPhone.TabIndex = 12;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(480, 153);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(41, 15);
            lblPhone.TabIndex = 11;
            lblPhone.Text = "Phone";
            // 
            // lblDoB
            // 
            lblDoB.AutoSize = true;
            lblDoB.Location = new Point(650, 153);
            lblDoB.Name = "lblDoB";
            lblDoB.Size = new Size(73, 15);
            lblDoB.TabIndex = 13;
            lblDoB.Text = "Date of Birth";
            // 
            // dTPickDoB
            // 
            dTPickDoB.CustomFormat = "yyyy-MM-dd";
            dTPickDoB.Format = DateTimePickerFormat.Short;
            dTPickDoB.Location = new Point(650, 182);
            dTPickDoB.Margin = new Padding(3, 2, 3, 2);
            dTPickDoB.Name = "dTPickDoB";
            dTPickDoB.Size = new Size(219, 23);
            dTPickDoB.TabIndex = 14;
            dTPickDoB.Value = new DateTime(2023, 12, 30, 0, 0, 0, 0);
            // 
            // dataGridInstructors
            // 
            dataGridInstructors.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridInstructors.Location = new Point(313, 292);
            dataGridInstructors.Margin = new Padding(3, 2, 3, 2);
            dataGridInstructors.Name = "dataGridInstructors";
            dataGridInstructors.RowHeadersWidth = 51;
            dataGridInstructors.RowTemplate.Height = 29;
            dataGridInstructors.Size = new Size(588, 220);
            dataGridInstructors.TabIndex = 15;
            dataGridInstructors.CellContentClick += dataGridInstructors_CellContentClick_1;
            // 
            // lblListInstr
            // 
            lblListInstr.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblListInstr.Location = new Point(517, 259);
            lblListInstr.Name = "lblListInstr";
            lblListInstr.Size = new Size(164, 32);
            lblListInstr.TabIndex = 16;
            lblListInstr.Text = "List of Instructors";
            // 
            // bttnAdd
            // 
            bttnAdd.Location = new Point(370, 227);
            bttnAdd.Margin = new Padding(3, 2, 3, 2);
            bttnAdd.Name = "bttnAdd";
            bttnAdd.Size = new Size(74, 31);
            bttnAdd.TabIndex = 17;
            bttnAdd.Text = "Add";
            bttnAdd.UseVisualStyleBackColor = true;
            bttnAdd.Click += bttnAdd_Click;
            // 
            // bttnEdit
            // 
            bttnEdit.Location = new Point(514, 227);
            bttnEdit.Margin = new Padding(3, 2, 3, 2);
            bttnEdit.Name = "bttnEdit";
            bttnEdit.Size = new Size(74, 31);
            bttnEdit.TabIndex = 18;
            bttnEdit.Text = "Edit";
            bttnEdit.UseVisualStyleBackColor = true;
            bttnEdit.Click += bttnEdit_Click;
            // 
            // bttnDelete
            // 
            bttnDelete.Location = new Point(650, 226);
            bttnDelete.Margin = new Padding(3, 2, 3, 2);
            bttnDelete.Name = "bttnDelete";
            bttnDelete.Size = new Size(74, 31);
            bttnDelete.TabIndex = 19;
            bttnDelete.Text = "Delete";
            bttnDelete.UseVisualStyleBackColor = true;
            // 
            // Instructor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(962, 521);
            Controls.Add(bttnDelete);
            Controls.Add(bttnEdit);
            Controls.Add(bttnAdd);
            Controls.Add(lblListInstr);
            Controls.Add(dataGridInstructors);
            Controls.Add(dTPickDoB);
            Controls.Add(lblDoB);
            Controls.Add(txtBoxPhone);
            Controls.Add(lblPhone);
            Controls.Add(cbExperience);
            Controls.Add(lblExperience);
            Controls.Add(cbGender);
            Controls.Add(lblGender);
            Controls.Add(txtBoxSurname);
            Controls.Add(lblSurname);
            Controls.Add(txtBoxName);
            Controls.Add(lblName);
            Controls.Add(lblManageInstructors);
            Controls.Add(panelMenu);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Instructor";
            Text = "Instructor";
            panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridInstructors).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelMenu;
        private Button bttnHome;
        private Button bttnMembership;
        private Button bttnMember;
        private Button bttnInstructor;
        private Label lblManageInstructors;
        private Label lblName;
        private TextBox txtBoxName;
        private TextBox txtBoxSurname;
        private Label lblSurname;
        private Label lblGender;
        private ComboBox cbGender;
        private ComboBox cbExperience;
        private Label lblExperience;
        private TextBox txtBoxPhone;
        private Label lblPhone;
        private Label lblDoB;
        private DateTimePicker dTPickDoB;
        private DataGridView dataGridInstructors;
        private Label lblListInstr;
        private PictureBox pictureBox1;
        private Button bttnAdd;
        private Button bttnEdit;
        private Button bttnDelete;
    }
}