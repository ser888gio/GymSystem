using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymSystem
{
    public partial class Instructor : Form
    {
        Functions Con;
        public Instructor()
        {
            InitializeComponent();
            Con = new Functions();
            ShowInstructor();
        }

        private ComboBox GetCbExperience()
        {
            return cbExperience;
        }

        private void ShowInstructor()
        {
            string Query = "SELECT * FROM Instructor";
            dataGridInstructors.DataSource = Con.GetData(Query);
        }


        private void bttnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtBoxName.Text == "" || txtBoxSurname.Text == "" || txtBoxPhone.Text == "" || cbExperience.SelectedIndex == -1 || cbExperience.SelectedIndex == -1)
                {
                    MessageBox.Show("Data is missing");
                }
                else
                {
                    string Name = txtBoxName.Text;
                    string Surname = txtBoxSurname.Text;
                    string Gender = cbGender.SelectedItem.ToString();
                    string Phone = txtBoxPhone.Text;
                    string Experience = cbExperience.SelectedItem.ToString();

                    string Query = "UPDATE Instructor SET Name = '{0}',Surname = '{1}', Gender = '{2}',Phone = '{3}', Experience =  '{4}', Date_of_Birth ='{5}' WHERE ID = {7}";
                    Query = string.Format(Query, Name, Surname, Gender, Phone, Experience, dTPickDoB.Value.Date);
                    Con.setData(Query);
                    ShowInstructor();
                    MessageBox.Show("Instructor data updated succesfully");
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void bttnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtBoxName.Text == "" || txtBoxSurname.Text == "" || txtBoxPhone.Text == "" || cbExperience.SelectedIndex == -1 || cbExperience.SelectedIndex == -1)
                {
                    MessageBox.Show("Data is missing");
                }
                else
                {
                    string Name = txtBoxName.Text;
                    string Surname = txtBoxSurname.Text;
                    string Gender = cbGender.SelectedItem.ToString();
                    string Phone = txtBoxPhone.Text;
                    string Experience = cbExperience.SelectedItem.ToString();

                    string Query = "INSERT INTO Instructor VALUES('{0}','{1}', '{2}', '{3}', '{4}', '{5}')";
                    Query = string.Format(Query, Name, Surname, Gender, Phone, Experience, dTPickDoB.Value.Date);
                    Con.setData(Query);
                    ShowInstructor();
                    MessageBox.Show("Instructor added succesfully");
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        int Key = 0;
       
        private void dataGridInstructors_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int instructorCount = dataGridInstructors.RowCount;
            if (instructorCount > 0)
            {
                txtBoxName.Text = dataGridInstructors.SelectedRows[0].Cells[1].Value.ToString();
                txtBoxSurname.Text = dataGridInstructors.SelectedRows[0].Cells[2].Value.ToString();
                cbGender.SelectedItem = dataGridInstructors.SelectedRows[0].Cells[3].Value.ToString();
                txtBoxPhone.Text = dataGridInstructors.SelectedRows[0].Cells[4].Value.ToString();
                cbExperience.SelectedItem = dataGridInstructors.SelectedRows[0].Cells[5].Value.ToString();
                dTPickDoB.Text = dataGridInstructors.SelectedRows[0].Cells[6].Value.ToString();
            }
                

            if (txtBoxName.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(dataGridInstructors.SelectedRows[0].Cells[0].Value.ToString());
            }
        }
    }
}
