using System;
using System.Data.SQLite;
using System.Windows.Forms.VisualStyles;

public class DatabaseHelper
{
    private static readonly string connectionString = "Data Source=students.db;Version=3;";

    // Initialize database tables
    public static void InitializeDatabase()
    {
        using (var connection = new SQLiteConnection(connectionString))
        {
            connection.Open();

            string createStudentsTable = @"
                CREATE TABLE IF NOT EXISTS Students (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Name TEXT NOT NULL,
                    Email TEXT UNIQUE NOT NULL
                );";

            string createCoursesTable = @"
                CREATE TABLE IF NOT EXISTS Courses (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    CourseName TEXT NOT NULL UNIQUE
                );";

            string createUnitsTable = @"
                CREATE TABLE IF NOT EXISTS Units (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    UnitName TEXT NOT NULL,
                    CourseId INTEGER NOT NULL,
                    FOREIGN KEY (CourseId) REFERENCES Courses(Id)
                );";

            string createMarksTable = @"
                CREATE TABLE IF NOT EXISTS Marks (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    StudentId INTEGER NOT NULL,
                    UnitId INTEGER NOT NULL,
                    AssignmentMarks INTEGER,
                    CATMarks INTEGER,
                    FOREIGN KEY (StudentId) REFERENCES Students(Id),
                    FOREIGN KEY (UnitId) REFERENCES Units(Id)
                );";

            using (var command = new SQLiteCommand(connection))
            {
                command.CommandText = createStudentsTable;
                command.ExecuteNonQuery();

                command.CommandText = createCoursesTable;
                command.ExecuteNonQuery();

                command.CommandText = createUnitsTable;
                command.ExecuteNonQuery();

                command.CommandText = createMarksTable;
                command.ExecuteNonQuery();
            }
        }
    }

    // Register a student
    public static void RegisterStudent(string name, string email)
    {
        using (var connection = new SQLiteConnection(connectionString))
        {
            connection.Open();
            string query = "INSERT INTO Students (Name, Email) VALUES (@Name, @Email)";
            using (var command = new SQLiteCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Name", name.ToUpper());
                command.Parameters.AddWithValue("@Email", email);
                command.ExecuteNonQuery();
            }
        }
    }
    // Get Students from DB
    public static List<(int Id, string Name, string Email)> GetRegisteredStudents()
    {
        List<(int Id, string Name, string Email)> students = new List<(int, string, string)>();

        using (var connection = new SQLiteConnection(connectionString))
        {
            connection.Open();
            string query = "SELECT * FROM Students";

            using (var command = new SQLiteCommand(query, connection))
            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    int id = reader.GetInt32(0);
                    string name = reader.GetString(1);
                    string email = reader.GetString(2);

                    students.Add((id, name, email));
                }
            }
        }

        return students;
    }
    // Register a new course
    public static void RegisterCourse(string name)
    {
        using (var connection = new SQLiteConnection(connectionString))
        {
            connection.Open();
            string query = "INSERT into Courses (Name) Values (@Name)";
            using (var command = new SQLiteCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Name", name.ToUpper());
                command.ExecuteNonQuery();
            }
        }
    }
    // Register a new unit
    public static void RegisterUnit(string name, int courseId)
    {
        using (var connection = new SQLiteConnection(connectionString))
        {
            connection.Open();
            string query = "INSERT into Units (UnitName, CourseId) Values (@Name, @CourseId)";
            using (var command = new SQLiteCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Name", name.ToUpper());
                command.Parameters.AddWithValue("@CourseId", courseId);
                command.ExecuteNonQuery();
            }
        }
    }
    // Register Student Marks
    public static void RegisterStudentMarks(int studentId, int unitId, int assigmentMarks, int catMarks)
    {
        using (var connection = new SQLiteConnection(connectionString))
        {
            connection.Open();
            string query = "INSERT into Marks (StudentId, UnitId, AssignmentMarks, CatMarks) Values (@StudentId, @UnitId, @AssignmentMarks, @CatMarks)";
            using (var command = new SQLiteCommand(query, connection))
            {
                command.Parameters.AddWithValue("@StudentId", studentId);
                command.Parameters.AddWithValue("@UnitId", unitId);
                command.Parameters.AddWithValue("@AssigmentMarks", assigmentMarks);
                command.Parameters.AddWithValue("@CatMarks", catMarks);

                command.ExecuteNonQuery();
            }
        }
    }
}
