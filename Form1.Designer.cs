namespace StudentManagementSystem
{
    partial class DashboardForm
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
            pnlSideBar = new Panel();
            pnlMain = new Panel();
            button5 = new Button();
            btnGrades = new Button();
            btnEnrollStudents = new Button();
            btnCourses = new Button();
            btnStudents = new Button();
            pnlSideBar.SuspendLayout();
            SuspendLayout();
            // 
            // pnlSideBar
            // 
            pnlSideBar.BackColor = Color.Maroon;
            pnlSideBar.Controls.Add(pnlMain);
            pnlSideBar.Controls.Add(button5);
            pnlSideBar.Controls.Add(btnGrades);
            pnlSideBar.Controls.Add(btnEnrollStudents);
            pnlSideBar.Controls.Add(btnCourses);
            pnlSideBar.Controls.Add(btnStudents);
            pnlSideBar.Location = new Point(3, 0);
            pnlSideBar.Name = "pnlSideBar";
            pnlSideBar.Size = new Size(200, 460);
            pnlSideBar.TabIndex = 0;
            // 
            // pnlMain
            // 
            pnlMain.BackColor = Color.White;
            pnlMain.Location = new Point(203, 0);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(593, 447);
            pnlMain.TabIndex = 1;
            // 
            // button5
            // 
            button5.Location = new Point(0, 381);
            button5.Name = "button5";
            button5.Size = new Size(197, 66);
            button5.TabIndex = 5;
            button5.Text = "button5";
            button5.UseVisualStyleBackColor = true;
            // 
            // btnGrades
            // 
            btnGrades.FlatStyle = FlatStyle.Flat;
            btnGrades.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGrades.Location = new Point(0, 295);
            btnGrades.Name = "btnGrades";
            btnGrades.Size = new Size(197, 66);
            btnGrades.TabIndex = 4;
            btnGrades.Text = "Record Grades";
            btnGrades.UseVisualStyleBackColor = true;
            // 
            // btnEnrollStudents
            // 
            btnEnrollStudents.FlatStyle = FlatStyle.Flat;
            btnEnrollStudents.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEnrollStudents.Location = new Point(0, 202);
            btnEnrollStudents.Name = "btnEnrollStudents";
            btnEnrollStudents.Size = new Size(197, 66);
            btnEnrollStudents.TabIndex = 3;
            btnEnrollStudents.Text = "Enroll Students";
            btnEnrollStudents.UseVisualStyleBackColor = true;
            // 
            // btnCourses
            // 
            btnCourses.FlatStyle = FlatStyle.Flat;
            btnCourses.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCourses.Location = new Point(0, 113);
            btnCourses.Name = "btnCourses";
            btnCourses.Size = new Size(197, 66);
            btnCourses.TabIndex = 2;
            btnCourses.Text = "Manage Courses";
            btnCourses.UseVisualStyleBackColor = true;
            // 
            // btnStudents
            // 
            btnStudents.FlatStyle = FlatStyle.Flat;
            btnStudents.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStudents.Location = new Point(0, 23);
            btnStudents.Name = "btnStudents";
            btnStudents.Size = new Size(197, 66);
            btnStudents.TabIndex = 1;
            btnStudents.Text = "Manage Student";
            btnStudents.UseVisualStyleBackColor = true;
            btnStudents.Click += btnStudents_Click;
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HotTrack;
            ClientSize = new Size(800, 450);
            Controls.Add(pnlSideBar);
            Name = "DashboardForm";
            Text = "Dashboard";
            pnlSideBar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlSideBar;
        private Button button5;
        private Button btnGrades;
        private Button btnEnrollStudents;
        private Button btnCourses;
        private Button btnStudents;
        private Panel pnlMain;
    }
}
