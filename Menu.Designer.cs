namespace GymSystem
{
    partial class Menu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            panelMenu = new Panel();
            bttnHome = new Button();
            bttnMembership = new Button();
            bttnMember = new Button();
            bttnInstructor = new Button();
            imageList1 = new ImageList(components);
            pictureBox1 = new PictureBox();
            panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(250, 695);
            panelMenu.TabIndex = 0;
            panelMenu.Paint += panelMenu_Paint;
            // 
            // bttnHome
            // 
            bttnHome.Location = new Point(0, 542);
            bttnHome.Name = "bttnHome";
            bttnHome.Size = new Size(250, 154);
            bttnHome.TabIndex = 4;
            bttnHome.Text = "Home";
            bttnHome.UseVisualStyleBackColor = true;
            bttnHome.Click += bttnHome_Click;
            // 
            // bttnMembership
            // 
            bttnMembership.Location = new Point(0, 392);
            bttnMembership.Name = "bttnMembership";
            bttnMembership.Size = new Size(250, 154);
            bttnMembership.TabIndex = 3;
            bttnMembership.Text = "Memberships";
            bttnMembership.UseVisualStyleBackColor = true;
            bttnMembership.Click += bttnMembership_Click;
            // 
            // bttnMember
            // 
            bttnMember.Location = new Point(0, 244);
            bttnMember.Name = "bttnMember";
            bttnMember.Size = new Size(250, 154);
            bttnMember.TabIndex = 2;
            bttnMember.Text = "Members";
            bttnMember.UseVisualStyleBackColor = true;
            bttnMember.Click += bttnMember_Click;
            // 
            // bttnInstructor
            // 
            bttnInstructor.Location = new Point(0, 96);
            bttnInstructor.Name = "bttnInstructor";
            bttnInstructor.Size = new Size(250, 154);
            bttnInstructor.TabIndex = 1;
            bttnInstructor.Text = "Instructors";
            bttnInstructor.UseVisualStyleBackColor = true;
            bttnInstructor.Click += bttnInstructor_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "logo.png");
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo1;
            pictureBox1.Location = new Point(0, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(250, 98);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1118, 695);
            Controls.Add(panelMenu);
            Name = "Menu";
            Text = "Menu";
            panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Button bttnMembership;
        private Button bttnMember;
        private Button bttnInstructor;
        private Button bttnHome;
        private ImageList imageList1;
        private PictureBox pictureBox1;
    }
}