using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPartA
{
    static class ObjectLists
    {

        private static List<Course> _courses = new List<Course>();
        public static List<Course> Courses { get { return _courses; } private set { } }

        private static List<Student> _students = new List<Student>();
        public static List<Student> Students { get { return _students; } private set { } }

        public static List<Assignment> _assignments = new List<Assignment>();
        public static List<Assignment> Assignments { get { return _assignments; } private set { } }

        private static List<Trainer> _trainers = new List<Trainer>();
        public static List<Trainer> Trainers { get { return _trainers; } private set { } }

    }
}
