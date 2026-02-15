using System.Collections.Generic;
using System.Linq;

namespace StudentGradeManagementSystem
{
    public class StudentManager
    {
        private Dictionary<string, int> students = new Dictionary<string, int>();

        public void AddOrUpdateStudent(string name, int grade)
        {
            students[name] = grade;
        }

        public bool ContainsStudent(string name)
        {
            return students.ContainsKey(name);
        }

        public int GetGrade(string name)
        {
            return students[name];
        }

        public Dictionary<string, int> GetAllStudents()
        {
            return students;
        }

        public double GetAverage()
        {
            return students.Values.Average();
        }

        public int GetMax()
        {
            return students.Values.Max();
        }

        public int GetMin()
        {
            return students.Values.Min();
        }

        public int Count => students.Count;
    }
}