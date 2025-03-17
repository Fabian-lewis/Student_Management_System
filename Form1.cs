namespace StudentManagementSystem
{
    public partial class DashboardForm : Form
    {
        
        public DashboardForm()
        {
            
            InitializeComponent();
        }
        private void DashboardForm_Load(object sender, EventArgs e)
        {
            DatabaseHelper.InitializeDatabase();
            MessageBox.Show("Database initialized");
        }

        private void btnStudents_Click(object sender, EventArgs e)
        {
            {
                StudentsForm studentsForm = new StudentsForm();
                studentsForm.Show();
               // OpenForm(new StudentsForm());
            }
        }

        private void OpenForm(Form form)
            {
                pnlMain.Controls.Clear();
                form.TopLevel = false;
                form.Dock = DockStyle.Fill;
                pnlMain.Controls.Add(form);
                form.Show();
            }
    }
}
