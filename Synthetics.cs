using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPartA
{
    static class Synthetics
    {
        static int i = 0;
        static int countCourses = 0;
        static int countAssignments = 0;
        static int countStudents = 0;
        static int countTrainers = 0;
        public static void AddSynthetics()
        {
            if (ObjectLists.Courses.Count > 0)
                countCourses = ObjectLists.Courses.Count;
            if (ObjectLists.Students.Count > 0)
                countStudents = ObjectLists.Students.Count;
            if (ObjectLists.Assignments.Count > 0)
                countAssignments = ObjectLists.Assignments.Count;
            if (ObjectLists.Trainers.Count > 0)
                countTrainers = ObjectLists.Trainers.Count;



            if (i == 0)
            {
                GenList<Course>.AddValue(ObjectLists.Courses, new Course("course1 title", "course1 stream", "course1 type",
                Convert.ToDateTime("2020-1-1").Date, Convert.ToDateTime("2020-5-5").Date));
                GenList<Course>.AddValue(ObjectLists.Courses, new Course("course2 title", "course2 stream", "course2 type",
                    Convert.ToDateTime("2020-1-1"), Convert.ToDateTime("2020-5-5")));

                GenList<Student>.AddValue(ObjectLists.Students, new Student("student1 lastname", "student1 firstname",
                    Convert.ToDateTime("1991-1-1").Date, 2000));
                GenList<Student>.AddValue(ObjectLists.Students, new Student("student2 lastname", "student2 firstname",
                    Convert.ToDateTime("1995-1-1").Date, 2001));
                GenList<Student>.AddValue(ObjectLists.Students, new Student("student3 lastname", "student3 firstname",
                    Convert.ToDateTime("1992-1-1").Date, 2002));

                GenList<Trainer>.AddValue(ObjectLists.Trainers, new Trainer("trainer1 lastname", "trainer1 firstname", "subject tr1"));
                GenList<Trainer>.AddValue(ObjectLists.Trainers, new Trainer("trainer2 lastname", "trainer2 firstname", "subject tr2"));

                GenList<Assignment>.AddValue(ObjectLists.Assignments, new Assignment("ass1 title", "ass1 description",
                    Convert.ToDateTime("2020-3-3").Date, 100, 100));
                GenList<Assignment>.AddValue(ObjectLists.Assignments, new Assignment("ass2 title", "ass2 description",
                    Convert.ToDateTime("2020-4-4").Date, 100, 100));
                GenList<Assignment>.AddValue(ObjectLists.Assignments, new Assignment("ass3 title", "ass3 description",
                    Convert.ToDateTime("2020-5-5").Date, 100, 100));
                GenList<Assignment>.AddValue(ObjectLists.Assignments, new Assignment("ass3 title", "ass3 description",
                    Convert.ToDateTime("2020-6-6").Date, 100, 100));


                ObjectLists.Courses[countCourses].CourseAssignments.Add(ObjectLists.Assignments[countAssignments].ID);
                ObjectLists.Courses[countCourses].CourseAssignments.Add(ObjectLists.Assignments[countAssignments+1].ID);
                ObjectLists.Courses[countCourses + 1].CourseAssignments.Add(ObjectLists.Assignments[countAssignments+2].ID);
                ObjectLists.Courses[countCourses + 1].CourseAssignments.Add(ObjectLists.Assignments[countAssignments+3].ID);
                ObjectLists.Courses[countCourses].CourseStudents.Add(ObjectLists.Students[countStudents].ID);
                ObjectLists.Courses[countCourses].CourseStudents.Add(ObjectLists.Students[countStudents+1].ID);
                ObjectLists.Courses[countCourses+1].CourseStudents.Add(ObjectLists.Students[countStudents+2].ID);
                ObjectLists.Courses[countCourses].CourseTrainers.Add(ObjectLists.Trainers[countTrainers].ID);
                ObjectLists.Courses[countCourses+1].CourseTrainers.Add(ObjectLists.Trainers[countTrainers+1].ID);
                ObjectLists.Students[countStudents].StudentAssignments.Add(ObjectLists.Assignments[countAssignments].ID);
                ObjectLists.Students[countStudents].StudentAssignments.Add(ObjectLists.Assignments[countAssignments+1].ID);
                ObjectLists.Students[countStudents+1].StudentAssignments.Add(ObjectLists.Assignments[countAssignments+2].ID);
                ObjectLists.Students[countStudents+1].StudentAssignments.Add(ObjectLists.Assignments[countAssignments+3].ID);

                Helper.printString("Synthetics were successfully added!");
                i++;
            } else
            {
                Helper.printString("You cant add synthetics more than once!");
            }
            
        }
        
    }
}
