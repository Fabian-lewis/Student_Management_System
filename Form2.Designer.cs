namespace StudentManagementSystem
{
    partial class StudentsForm
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
            btnRegisterStudent = new Button();
            label1 = new Label();
            txtName = new TextBox();
            txtEmail = new TextBox();
            label2 = new Label();
            dataGridViewStudents = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStudents).BeginInit();
            SuspendLayout();
            // 
            // btnRegisterStudent
            // 
            btnRegisterStudent.Location = new Point(98, 173);
            btnRegisterStudent.Name = "btnRegisterStudent";
            btnRegisterStudent.Size = new Size(119, 60);
            btnRegisterStudent.TabIndex = 0;
            btnRegisterStudent.Text = "Register Student";
            btnRegisterStudent.UseVisualStyleBackColor = true;
            btnRegisterStudent.Click += btnRegisterStudent_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 28);
            label1.Name = "label1";
            label1.Size = new Size(125, 25);
            label1.TabIndex = 1;
            label1.Text = "Student Name";
            // 
            // txtName
            // 
            txtName.Location = new Point(188, 28);
            txtName.Name = "txtName";
            txtName.Size = new Size(150, 31);
            txtName.TabIndex = 2;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(188, 88);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(150, 31);
            txtEmail.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 88);
            label2.Name = "label2";
            label2.Size = new Size(120, 25);
            label2.TabIndex = 3;
            label2.Text = "Student Email";
            // 
            // dataGridViewStudents
            // 
            dataGridViewStudents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewStudents.Location = new Point(388, 28);
            dataGridViewStudents.Name = "dataGridViewStudents";
            dataGridViewStudents.ReadOnly = true;
            dataGridViewStudents.RowHeadersWidth = 62;
            dataGridViewStudents.Size = new Size(385, 297);
            dataGridViewStudents.TabIndex = 5;
            // 
            // StudentsForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridViewStudents);
            Controls.Add(txtEmail);
            Controls.Add(label2);
            Controls.Add(txtName);
            Controls.Add(label1);
            Controls.Add(btnRegisterStudent);
            Name = "StudentsForm";
            Text = "StudentsForm";
            Load += StudentsForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewStudents).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRegisterStudent;
        private Label label1;
        private TextBox txtName;
        private TextBox txtEmail;
        private Label label2;
        private DataGridView dataGridViewStudents;
    }
}