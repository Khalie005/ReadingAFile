using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace FrmLab1
{
    public partial class FrmRegistration : Form
    {
        public FrmRegistration()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    if (string.IsNullOrWhiteSpace(txtStudentNo.Text) || !Regex.IsMatch(txtStudentNo.Text, @"^\d+$"))
                    {
                        MessageBox.Show("Please enter a Student Number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtStudentNo.Focus();
                        return;
                    }

                    if (string.IsNullOrWhiteSpace(txtLastName.Text) || !Regex.IsMatch(txtLastName.Text, @"^[a-zA-Z\s]+$"))
                    {
                        MessageBox.Show("Please enter a Last Name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtLastName.Focus();
                        return;
                    }

                    if (string.IsNullOrWhiteSpace(txtFirstName.Text) || !Regex.IsMatch(txtFirstName.Text, @"^[a-zA-Z\s]+$"))
                    {
                        MessageBox.Show("Please enter a First Name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtFirstName.Focus();
                        return;
                    }

                    if (string.IsNullOrWhiteSpace(txtMI.Text) || !Regex.IsMatch(txtMI.Text, @"^[a-zA-Z\s]+$"))
                    {
                        MessageBox.Show("Please enter a Middle Initial.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtMI.Focus();
                        return;
                    }

                    if (string.IsNullOrWhiteSpace(cbProgram.Text) || cbProgram.SelectedIndex == -1)

                    {
                        MessageBox.Show("Please select a Program.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        cbProgram.Focus();
                        return;
                    }

                    if (string.IsNullOrWhiteSpace(txtAge.Text) || !Regex.IsMatch(txtAge.Text, @"^\d+$"))
                    {
                        MessageBox.Show("Please enter your Age.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtAge.Focus();
                        return;
                    }

                    if (!int.TryParse(txtAge.Text, out int age))
                    {
                        MessageBox.Show("Age must be a valid number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtAge.Focus();
                        return;
                    }

                    if (string.IsNullOrWhiteSpace(cbGender.Text) || cbGender.SelectedIndex == -1)
                    {
                        MessageBox.Show("Please select a Gender.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        cbGender.Focus();
                        return;
                    }

                    if (string.IsNullOrWhiteSpace(txtContactNo.Text) || !Regex.IsMatch(txtContactNo.Text, @"^\d{1,12}$"))
                    {
                        MessageBox.Show("Please enter a Contact Number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtContactNo.Focus();
                        return;
                    }

                    string fileName = txtStudentNo.Text + ".txt";
                    string[] studentInfo = new string[]

                    {
                    "Student No.: " + txtStudentNo.Text,
                    "Full Name: " + txtLastName.Text + ", " + txtFirstName.Text + " " + txtMI.Text + ".",
                    "Program: " + cbProgram.Text,
                    "Gender: " + cbGender.Text,
                    "Age: " + txtAge.Text,
                    "Birthday: " + dtpPicker.Value.ToString("yyyy-MM-dd"),
                    "Contact No.: " + txtContactNo.Text
                    };

                    string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                    string fullPath = Path.Combine(docPath, fileName);
                    using (StreamWriter writer = new StreamWriter(fullPath))
                    {

                        foreach (string line in studentInfo)
                        {
                            writer.WriteLine(line);
                        }
                    }

                    MessageBox.Show("Registration text file successfully created!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An unexpected error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cbGender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnRecords_Click(object sender, EventArgs e)
        {
            FrmStudentRecord recordForm = new FrmStudentRecord();
            this.Hide();
            recordForm.ShowDialog();
            this.Show();
        }
    }
}
 