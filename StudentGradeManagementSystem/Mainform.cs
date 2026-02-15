using System;
using System.Windows.Forms;

namespace StudentGradeManagementSystem
{
    public partial class Mainform : Form
    {
        private StudentManager manager = new StudentManager();

        public Mainform()
        {
            InitializeComponent();
        }

        private GradeCategory GetCategory(int grade)
        {
            if (grade < 50) return GradeCategory.Fail;
            if (grade < 65) return GradeCategory.Pass;
            if (grade < 75) return GradeCategory.Merit;
            return GradeCategory.Distinction;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();

            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Enter student name");
                return;
            }

            if (!int.TryParse(txtGrade.Text, out int grade))
            {
                MessageBox.Show("Invalid grade");
                return;
            }

            if (grade < 0 || grade > 100)
            {
                MessageBox.Show("Grade must be 0–100");
                return;
            }

            manager.AddOrUpdateStudent(name, grade);

            MessageBox.Show("Student added/updated");

            txtName.Clear();
            txtGrade.Clear();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            lstStudents.Items.Clear();

            foreach (var s in manager.GetAllStudents())
            {
                var category = GetCategory(s.Value);
                lstStudents.Items.Add($"{s.Key} — {s.Value} ({category})");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();

            if (manager.ContainsStudent(name))
            {
                int grade = manager.GetGrade(name);
                var category = GetCategory(grade);
                MessageBox.Show($"{name}: {grade} ({category})");
            }
            else
            {
                MessageBox.Show("Student not found");
            }
        }

        private void btnAverage_Click(object sender, EventArgs e)
        {
            if (manager.Count == 0)
            {
                MessageBox.Show("No students available");
                return;
            }

            double avg = manager.GetAverage();
            MessageBox.Show($"Average Grade: {avg:F2}");
        }

        private void btnHighLow_Click(object sender, EventArgs e)
        {
            if (manager.Count == 0)
            {
                MessageBox.Show("No students available");
                return;
            }

            int max = manager.GetMax();
            int min = manager.GetMin();

            MessageBox.Show($"Highest: {max}\nLowest: {min}");
        }
    }
}