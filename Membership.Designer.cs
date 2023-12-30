namespace GymSystem
{
    partial class Membership
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
            pictureBox1 = new PictureBox();
            bttnHome = new Button();
            bttnDelete = new Button();
            bttnAdd = new Button();
            lblListMembership = new Label();
            dataGridInstructors = new DataGridView();
            txtBoxDuration = new TextBox();
            bttnMembership = new Button();
            bttnMember = new Button();
            bttnEdit = new Button();
            lblDuration = new Label();
            lblPrice = new Label();
            txtBoxName = new TextBox();
            lblName = new Label();
            lblManageInstructors = new Label();
            panelMenu = new Panel();
            bttnInstructor = new Button();
            txtBoxPrice = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridInstructors).BeginInit();
            panelMenu.SuspendLayout();
            SuspendLayout();
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
            // bttnDelete
            // 
            bttnDelete.Location = new Point(810, 207);
            bttnDelete.Name = "bttnDelete";
            bttnDelete.Size = new Size(85, 41);
            bttnDelete.TabIndex = 57;
            bttnDelete.Text = "Delete";
            bttnDelete.UseVisualStyleBackColor = true;
            // 
            // bttnAdd
            // 
            bttnAdd.Location = new Point(490, 209);
            bttnAdd.Name = "bttnAdd";
            bttnAdd.Size = new Size(85, 41);
            bttnAdd.TabIndex = 55;
            bttnAdd.Text = "Add";
            bttnAdd.UseVisualStyleBackColor = true;
            // 
            // lblListMembership
            // 
            lblListMembership.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblListMembership.Location = new Point(638, 295);
            lblListMembership.Name = "lblListMembership";
            lblListMembership.Size = new Size(187, 42);
            lblListMembership.TabIndex = 54;
            lblListMembership.Text = "List of Memberships";
            // 
            // dataGridInstructors
            // 
            dataGridInstructors.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridInstructors.Location = new Point(405, 340);
            dataGridInstructors.Name = "dataGridInstructors";
            dataGridInstructors.RowHeadersWidth = 51;
            dataGridInstructors.RowTemplate.Height = 29;
            dataGridInstructors.Size = new Size(672, 293);
            dataGridInstructors.TabIndex = 53;
            // 
            // txtBoxDuration
            // 
            txtBoxDuration.Location = new Point(899, 134);
            txtBoxDuration.Name = "txtBoxDuration";
            txtBoxDuration.Size = new Size(125, 27);
            txtBoxDuration.TabIndex = 50;
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
            // bttnEdit
            // 
            bttnEdit.Location = new Point(655, 209);
            bttnEdit.Name = "bttnEdit";
            bttnEdit.Size = new Size(85, 41);
            bttnEdit.TabIndex = 56;
            bttnEdit.Text = "Edit";
            bttnEdit.UseVisualStyleBackColor = true;
            // 
            // lblDuration
            // 
            lblDuration.AutoSize = true;
            lblDuration.Location = new Point(899, 96);
            lblDuration.Name = "lblDuration";
            lblDuration.Size = new Size(146, 20);
            lblDuration.TabIndex = 49;
            lblDuration.Text = "Duration (in months)";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(638, 96);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(41, 20);
            lblPrice.TabIndex = 45;
            lblPrice.Text = "Price";
            // 
            // txtBoxName
            // 
            txtBoxName.Location = new Point(378, 134);
            txtBoxName.Name = "txtBoxName";
            txtBoxName.Size = new Size(125, 27);
            txtBoxName.TabIndex = 44;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(378, 96);
            lblName.Name = "lblName";
            lblName.Size = new Size(49, 20);
            lblName.TabIndex = 43;
            lblName.Text = "Name";
            // 
            // lblManageInstructors
            // 
            lblManageInstructors.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblManageInstructors.Location = new Point(596, 24);
            lblManageInstructors.Name = "lblManageInstructors";
            lblManageInstructors.Size = new Size(229, 42);
            lblManageInstructors.TabIndex = 42;
            lblManageInstructors.Text = "Manage Memberships";
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
            panelMenu.Size = new Size(250, 617);
            panelMenu.TabIndex = 41;
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
            // txtBoxPrice
            // 
            txtBoxPrice.Location = new Point(638, 134);
            txtBoxPrice.Name = "txtBoxPrice";
            txtBoxPrice.Size = new Size(125, 27);
            txtBoxPrice.TabIndex = 46;
            // 
            // Membership
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1137, 617);
            Controls.Add(bttnDelete);
            Controls.Add(bttnAdd);
            Controls.Add(lblListMembership);
            Controls.Add(dataGridInstructors);
            Controls.Add(txtBoxDuration);
            Controls.Add(bttnEdit);
            Controls.Add(lblDuration);
            Controls.Add(lblPrice);
            Controls.Add(txtBoxName);
            Controls.Add(lblName);
            Controls.Add(lblManageInstructors);
            Controls.Add(panelMenu);
            Controls.Add(txtBoxPrice);
            Name = "Membership";
            Text = "Membership";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridInstructors).EndInit();
            panelMenu.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button bttnHome;
        private Button bttnDelete;
        private Button bttnAdd;
        private Label lblListMembership;
        private DataGridView dataGridInstructors;
        private TextBox txtBoxDuration;
        private Button bttnMembership;
        private Button bttnMember;
        private Button bttnEdit;
        private Label lblDuration;
        private Label lblPrice;
        private TextBox txtBoxName;
        private Label lblName;
        private Label lblManageInstructors;
        private Panel panelMenu;
        private Button bttnInstructor;
        private TextBox txtBoxPrice;
    }
}