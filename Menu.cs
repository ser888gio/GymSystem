namespace GymSystem
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void bttnInstructor_Click(object sender, EventArgs e)
        {
            Instructor instructorForm = new Instructor();
            instructorForm.Show();
        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {
        }

        private void bttnMember_Click(object sender, EventArgs e)
        {
            Member memberForm = new Member();
            memberForm.Show();
        }

        private void bttnMembership_Click(object sender, EventArgs e)
        {
            Membership membershipForm = new Membership();
            membershipForm.Show();
        }

        private void bttnHome_Click(object sender, EventArgs e)
        {
        }
    }
}