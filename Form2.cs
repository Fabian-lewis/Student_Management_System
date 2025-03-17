using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagementSystem
{
    public partial class StudentsForm : Form
    {
        public StudentsForm()
        {
            InitializeComponent();
        }

        private void StudentsForm_Load(object sender, EventArgs e)
        {
            LoadStudents();

        }
        private void LoadStudents()
        {
            dataGridViewStudents.Columns.Clear(); // Clear existing columns to avoid duplication

            // Define columns
            dataGridViewStudents.Columns.Add("Id", "Student ID");
            dataGridViewStudents.Columns.Add("Name", "Name");
            dataGridViewStudents.Columns.Add("Email", "Email");

            var students = DatabaseHelper.GetRegisteredStudents();
            dataGridViewStudents.Rows.Clear();

            foreach (var student in students)
            {
                dataGridViewStudents.Rows.Add(student.Id, student.Name, student.Email);
            }
        }


        private void btnRegisterStudent_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string email = txtEmail.Text;
            DatabaseHelper.RegisterStudent(name, email);
            MessageBox.Show("Student Registered Successfully");

        }
    }
}
