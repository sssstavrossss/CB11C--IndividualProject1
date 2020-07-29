using Microsoft.SqlServer.Server;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPartA
{
    static class Init
    {
        
        public static void InitProject()
        {

            Console.WriteLine("Individual Project 1, Part A, Stavros Vasileiadis");
            Console.WriteLine("Type the number you see at the menu to perform each action");
            Console.WriteLine("Dates should be put like this format: 2020-5-5");
            Console.WriteLine(" ");

            int pref1;
            int pref2 = 0;
            int pref3 = 22;
            int pref4 = 22;
            int pref5 = -1;
            int pref6 = -2;
            int pref7 = -2;
            int count = 0;
            bool hold = true;
            DateTime date = new DateTime();
            

            do
            {

                Console.WriteLine(" ");
                pref1 = Helper.getNumber("your choise", 1); // key 1 = basic choices 

                if (pref1==25)
                {
                    Synthetics.AddSynthetics();
                    continue;
                }

                if (pref1==4)
                {
                    Console.WriteLine(" ");
                    do
                    {
                        pref4 = Helper.getNumber("if you want to exit app and check submition dates of students", 5); // key 5 = exit app
                    } while (pref4 != 21 && pref4 != 22);

                    if (pref4 == 21)
                    {
                        Helper.printString("Bye!");
                        break;
                    }
                    else if (pref4 == 22)
                    {
                        continue;
                    }

                } else
                {
                    do
                    {
                        Console.WriteLine(" ");

                        pref3 = 22;

                        if (pref1 == 1)
                        {

                            pref2 = Helper.getNumber("your choise", 2); // key 2 = add data
                            hold = true;

                            if (pref2 == 5)
                            {
                                Console.WriteLine(" ");
                                GenList<Course>.AddValue(ObjectLists.Courses, new Course());
                                count = ObjectLists.Courses.Count;
                                if (count>1)
                                {
                                    for (int i = 0; i < count-1; i++)
                                    {
                                        if (ObjectLists.Courses[count-1].EndDate == ObjectLists.Courses[i].EndDate)
                                            if (ObjectLists.Courses[count - 1].StartDate == ObjectLists.Courses[i].StartDate)
                                                if (ObjectLists.Courses[count - 1].Title == ObjectLists.Courses[i].Title)
                                                    if (ObjectLists.Courses[count - 1].Type == ObjectLists.Courses[i].Type)
                                                        if (ObjectLists.Courses[count - 1].Stream == ObjectLists.Courses[i].Stream)
                                                            hold = false;
                                    }
                                }
                                if (hold)
                                {
                                    Helper.printString("Course added successfully!");
                                }
                                else if (hold == false)
                                {
                                    Helper.printString("Course exists already!");
                                    ObjectLists.Courses.RemoveAt(count-1);
                                }
                            }
                            else if (pref2 == 6)
                            {
                                Console.WriteLine(" ");
                                GenList<Student>.AddValue(ObjectLists.Students, new Student());
                                count = ObjectLists.Students.Count;
                                if (count > 1)
                                {
                                    for (int i = 0; i < count-1; i++)
                                    {
                                        if (ObjectLists.Students[count - 1].FirstName == ObjectLists.Students[i].FirstName)
                                            if (ObjectLists.Students[count - 1].LastName == ObjectLists.Students[i].LastName)
                                                if (ObjectLists.Students[count - 1].DateOfBirth == ObjectLists.Students[i].DateOfBirth)
                                                    if (ObjectLists.Students[count - 1].TuitionFees == ObjectLists.Students[i].TuitionFees)
                                                        hold = false;
                                                    else
                                                        hold = true;
                                    }
                                }
                                if (hold == true)
                                {
                                    Helper.printString("Student added successfully!");
                                }
                                else if (hold == false)
                                {
                                    Helper.printString("Student exists already!");
                                    ObjectLists.Students.RemoveAt(count-1);
                                }
                            }
                            else if (pref2 == 7)
                            {
                                Console.WriteLine(" ");
                                GenList<Trainer>.AddValue(ObjectLists.Trainers, new Trainer());
                                count = ObjectLists.Trainers.Count;
                                if (count > 1)
                                {
                                    for (int i = 0; i < count-1; i++)
                                    {
                                        if (ObjectLists.Trainers[count - 1].FirstName == ObjectLists.Trainers[i].FirstName)
                                            if (ObjectLists.Trainers[count - 1].LastName == ObjectLists.Trainers[i].LastName)
                                                if (ObjectLists.Trainers[count - 1].Subject == ObjectLists.Trainers[i].Subject)
                                                     hold = false;
                                    }
                                }
                                if (hold)
                                {
                                    Helper.printString("Trainer added successfully!");
                                }
                                else if (hold == false)
                                {
                                    Helper.printString("Trainer exists already!");
                                    ObjectLists.Trainers.RemoveAt(count-1);
                                }
                            }
                            else if (pref2 == 8)
                            {
                                Console.WriteLine(" ");
                                GenList<Assignment>.AddValue(ObjectLists.Assignments, new Assignment());
                                count = ObjectLists.Assignments.Count;
                                if (count > 1)
                                {
                                    for (int i = 0; i < count -1; i++)
                                    {
                                        if (ObjectLists.Assignments[count - 1].Title == ObjectLists.Assignments[i].Title)
                                            if (ObjectLists.Assignments[count - 1].OralMark == ObjectLists.Assignments[i].OralMark)
                                                if (ObjectLists.Assignments[count - 1].TotalMark == ObjectLists.Assignments[i].TotalMark)
                                                    if (ObjectLists.Assignments[count - 1].SubDateTime == ObjectLists.Assignments[i].SubDateTime)
                                                        if (ObjectLists.Assignments[count - 1].Description == ObjectLists.Assignments[i].Description)
                                                            hold = false;
                                    }
                                }
                                if (hold)
                                {
                                    Helper.printString("Assignment added successfully!");
                                }
                                else if (hold == false)
                                {
                                    Helper.printString("Assignment exists already!");
                                    ObjectLists.Assignments.RemoveAt(count-1);
                                }
                            }

                        }
                        else if (pref1 == 2)
                        {
                            Console.WriteLine(" ");
                            pref2 = Helper.getNumber("your choise", 3); // key 3 = assign data
                            //printString("9. Assign student(s) to course(s)");
                            //printString("10. Assign trainer(s) to course(s)");
                            //printString("11. Assign assignment(s) to course(s)");
                            //printString("12. Assign assignment(s) to student(s)");
                            if (pref2 == 9)
                            {
                                if (ObjectLists.Courses.Count > 0)
                                {
                                    Helper.printString("To which course would you like to assign the students?");
                                    foreach (var item in ObjectLists.Courses)
                                    {
                                        Helper.printString($"{item.ID}. Course title: {item.Title}");
                                    }
                                    pref5 = Helper.getNumber("your choice", 6); // key = 6, to take proper values from courses.count
                                    if (ObjectLists.Students.Count > 0)
                                    {
                                        do
                                        {
                                            foreach (var item in ObjectLists.Students)
                                            {
                                                Helper.printString($"{item.ID}. Student name: {item.FirstName} {item.LastName}, " +
                                                    $"date of birth: {item.DateOfBirth.Date}");
                                            }
                                            Helper.printString("-1 to stop assigning students to this course");
                                            pref6 = Helper.getNumber("your choice", 7); // key = 7, to take proper values from students.count
                                            if (ObjectLists.Courses[pref5 - 1].CourseStudents.Contains(pref6))
                                            {
                                                Helper.printString("Student aldeady assigned to this Course!");
                                            }
                                            else if (!ObjectLists.Courses[pref5 - 1].CourseStudents.Contains(pref6) && pref6 != -1)
                                            {
                                                ObjectLists.Courses[pref5 - 1].CourseStudents.Add(pref6);
                                                Helper.printString("Student assigned!");
                                            }
                                        } while (pref6 != -1);
                                    }
                                    else
                                    {
                                        Helper.printString("There are no students yet!");
                                    }

                                }
                                else
                                {
                                    Helper.printString("There are no courses yet!");
                                }

                            }
                            else if (pref2 == 10)
                            {
                                Console.WriteLine(" ");
                                if (ObjectLists.Courses.Count > 0)
                                {
                                    Helper.printString("To which course would you like to assign the trainers?");
                                    foreach (var item in ObjectLists.Courses)
                                    {
                                        Helper.printString($"{item.ID}. Course title: {item.Title}");
                                    }
                                    pref5 = Helper.getNumber("your choice", 6); // key = 6, to take proper values from courses.count
                                    if (ObjectLists.Trainers.Count > 0)
                                    {
                                        do
                                        {
                                            foreach (var item in ObjectLists.Trainers)
                                            {
                                                Helper.printString($"{item.ID}. Trainer name: {item.FirstName} {item.LastName}, " +
                                                    $"subject: {item.Subject}");
                                            }
                                            Helper.printString("-1 to stop assigning trainers to this course");
                                            pref6 = Helper.getNumber("your choice", 8); // key = 8, to take proper values from trainers.count
                                            if (ObjectLists.Courses[pref5 - 1].CourseTrainers.Contains(pref6))
                                            {
                                                Helper.printString("Trainer aldeady assigned to this Course!");
                                            }
                                            else if (!ObjectLists.Courses[pref5 - 1].CourseTrainers.Contains(pref6) && pref6 != -1)
                                            {
                                                ObjectLists.Courses[pref5 - 1].CourseTrainers.Add(pref6);
                                                Helper.printString("Trainner assigned!");
                                            }
                                        } while (pref6 != -1);
                                    }
                                    else
                                    {
                                        Helper.printString("There are no trainers yet!");
                                    }

                                }
                                else
                                {
                                    Helper.printString("There are no courses yet!");
                                }

                            }
                            else if (pref2 == 11 || pref2 == 12)
                            {
                                Console.WriteLine(" ");
                                if (pref2 == 11)
                                {
                                    if (ObjectLists.Courses.Count > 0)
                                    {
                                        Helper.printString("To which course would you like to assign the trainers?");
                                        foreach (var item in ObjectLists.Courses)
                                        {
                                            Helper.printString($"{item.ID}. Course title: {item.Title}");
                                        }
                                        pref5 = Helper.getNumber("your choice", 6); // key = 6, to take proper values from courses.count
                                        if (ObjectLists.Assignments.Count > 0)
                                        {
                                            do
                                            {
                                                foreach (var item in ObjectLists.Assignments)
                                                {
                                                    Helper.printString($"{item.ID}. Assignment name: {item.Title}");
                                                }
                                                Helper.printString("-1 to stop assigning trainers to this course");
                                                pref6 = Helper.getNumber("your choice", 9);
                                                // key = 9, to take proper values from assignments.count
                                                if (ObjectLists.Courses[pref5 - 1].CourseAssignments.Contains(pref6))
                                                {
                                                    Helper.printString("Assignment aldeady assigned to this Course!");
                                                }
                                                else if (!ObjectLists.Courses[pref5 - 1].CourseAssignments.Contains(pref6) && pref6 != -1)
                                                {
                                                    ObjectLists.Courses[pref5 - 1].CourseAssignments.Add(pref6);
                                                    Helper.printString("Assignment assigned!");
                                                }
                                            } while (pref6 != -1);
                                        }
                                        else
                                        {
                                            Helper.printString("There are no assignments yet!");
                                        }

                                    }
                                    else
                                    {
                                        Helper.printString("There are no courses yet!");
                                    }
                                }
                                else if (pref2 == 12)
                                {
                                    Console.WriteLine(" ");
                                    if (ObjectLists.Students.Count > 0)
                                    {
                                        Helper.printString("To which student would you like to assign the trainers?");
                                        foreach (var item in ObjectLists.Students)
                                        {
                                            Helper.printString($"{item.ID}. Student name: {item.FirstName} {item.LastName}");
                                        }
                                        pref5 = Helper.getNumber("your choice", 6); // key = 6, to take proper values from courses.count
                                        if (ObjectLists.Assignments.Count > 0)
                                        {
                                            do
                                            {
                                                foreach (var item in ObjectLists.Assignments)
                                                {
                                                    Helper.printString($"{item.ID}. Assignment name: {item.Title}");
                                                }
                                                Helper.printString("-1 to stop assigning trainers to this course");
                                                pref6 = Helper.getNumber("your choice", 9);
                                                // key = 9, to take proper values from assignments.count
                                                if (ObjectLists.Students[pref5 - 1].StudentAssignments.Contains(pref6))
                                                {
                                                    Helper.printString("Assignment aldeady assigned to this Course!");
                                                }
                                                else if (!ObjectLists.Students[pref5 - 1].StudentAssignments.Contains(pref6) && pref6 != -1)
                                                {
                                                    ObjectLists.Students[pref5 - 1].StudentAssignments.Add(pref6);
                                                    Helper.printString("Assignment assigned!");
                                                }
                                            } while (pref6 != -1);
                                        }
                                        else
                                        {
                                            Helper.printString("There are no assignments yet!");
                                        }

                                    }
                                    else
                                    {
                                        Helper.printString("There are no students yet!");
                                    }
                                }
                            }

                        }
                        else if (pref1 == 3)
                        {
                            Console.WriteLine(" ");
                            pref2 = Helper.getNumber("your choise", 4); // key 4 = prints
                            //printString("13. Print all courses");
                            //printString("14. Print all students");
                            //printString("15. Print all trainers");
                            //printString("16. Print all assignments");
                            //printString("17. Print all students per course");
                            //printString("18. Print all trainers per course");
                            //printString("19. Print all assignments per course");
                            //printString("20. Print all assignments per student");
                            //printString("24. Print students that attend more than 1 course");
                            if (pref2 == 13)
                            {
                                Console.WriteLine(" ");
                                if (ObjectLists.Courses.Count > 0)
                                {
                                    foreach (var item in ObjectLists.Courses)

                                        Helper.printString($"{item.ID}. Course name: {item.Title}, stream: {item.Stream}, type: {item.Type}," +
                                        $" start date: {item.StartDate.Date}, end date: {item.EndDate.Date}");
                                }
                                else
                                {
                                    Helper.printString("There are no courses yet!");
                                }
                            }
                            else if (pref2 == 14)
                            {
                                Console.WriteLine(" ");
                                if (ObjectLists.Students.Count > 0)
                                {
                                    foreach (var item in ObjectLists.Students)
                                    {
                                        Helper.printString($"{item.ID}. Student name: {item.FirstName} {item.LastName}, date of bith {item.DateOfBirth.Date} " +
                                            $" tuition fees: {item.TuitionFees}");
                                    }
                                }
                                else
                                {
                                    Helper.printString("There are no students yet!");
                                }
                            }
                            else if (pref2 == 15)
                            {
                                Console.WriteLine(" ");
                                if (ObjectLists.Trainers.Count > 0)
                                {
                                    foreach (var item in ObjectLists.Trainers)
                                    {
                                        Helper.printString($"{item.ID}. Trainer name: {item.FirstName} {item.LastName}, subject: {item.Subject}");
                                    }
                                }
                                else
                                {
                                    Helper.printString("There are no trainers yet!");
                                }
                            }
                            else if (pref2 == 16)
                            {
                                Console.WriteLine(" ");
                                if (ObjectLists.Assignments.Count > 0)
                                {
                                    foreach (var item in ObjectLists.Assignments)
                                    {
                                        Helper.printString($"{item.ID}. Assignment title: {item.Title}, description: {item.Description}" +
                                            $" submission date: {item.SubDateTime.Date}, oral mark: {item.OralMark}, total mark: {item.TotalMark}");
                                    }
                                }
                                else
                                {
                                    Helper.printString("There are no assignments yet!");
                                }
                            }
                            else if (pref2 == 17)
                            {
                                Console.WriteLine(" ");
                                if (ObjectLists.Students.Count > 0)
                                {
                                    if (ObjectLists.Courses.Count > 0)
                                    {

                                        Helper.printString("To which course would you like to see assigned students?");
                                        foreach (var item in ObjectLists.Courses)
                                        {
                                            Helper.printString($"{item.ID}. Course title: {item.Title}");
                                        }
                                        pref7 = Helper.getNumber("your choice", 6); // key = 6, to take proper values from courses.count

                                        foreach (var item in ObjectLists.Students)
                                        {
                                            if (ObjectLists.Courses[pref7 - 1].CourseStudents.Contains(item.ID))
                                                Helper.printString($"{item.ID}. Student name: {item.FirstName} {item.LastName}, " +
                                                    $"date of bith {item.DateOfBirth.Date}, tuition fees: {item.TuitionFees}");
                                        }
                                    }
                                    else
                                    {
                                        Helper.printString("There are no courses yet!");
                                    }

                                }
                                else
                                {
                                    Helper.printString("There are no students yet!");
                                }
                            }
                            else if (pref2 == 18)
                            {
                                Console.WriteLine(" ");
                                if (ObjectLists.Trainers.Count > 0)
                                {
                                    if (ObjectLists.Courses.Count > 0)
                                    {

                                        Helper.printString("To which course would you like to see assigned students?");
                                        foreach (var item in ObjectLists.Courses)
                                        {
                                            Helper.printString($"{item.ID}. Course title: {item.Title}");
                                        }
                                        pref7 = Helper.getNumber("your choice", 6); // key = 6, to take proper values from courses.count

                                        foreach (var item in ObjectLists.Trainers)
                                        {
                                            if (ObjectLists.Courses[pref7 - 1].CourseTrainers.Contains(item.ID))
                                                Helper.printString($"{item.ID}. Trainer name: {item.FirstName} {item.LastName}, " +
                                                    $"subject {item.Subject}");
                                        }
                                    }
                                    else
                                    {
                                        Helper.printString("There are no courses yet!");
                                    }

                                }
                                else
                                {
                                    Helper.printString("There are no trainers yet!");
                                }
                            }
                            else if (pref2 == 19)
                            {
                                Console.WriteLine(" ");
                                if (ObjectLists.Assignments.Count > 0)
                                {
                                    if (ObjectLists.Courses.Count > 0)
                                    {

                                        Helper.printString("To which course would you like to see assigned students?");
                                        foreach (var item in ObjectLists.Courses)
                                        {
                                            Helper.printString($"{item.ID}. Course title: {item.Title}");
                                        }
                                        pref7 = Helper.getNumber("your choice", 6); // key = 6, to take proper values from courses.count

                                        foreach (var item in ObjectLists.Assignments)
                                        {
                                            if (ObjectLists.Courses[pref7 - 1].CourseAssignments.Contains(item.ID))
                                                Helper.printString($"{item.ID}. Assignment title: {item.Title}, description: {item.Description}" +
                                                    $" submission date: {item.SubDateTime.Date}, oral mark: {item.OralMark}, total mark: {item.TotalMark}");
                                        }
                                    }
                                    else
                                    {
                                        Helper.printString("There are no courses yet!");
                                    }

                                }
                                else
                                {
                                    Helper.printString("There are no assignments yet!");
                                }
                            }
                            else if (pref2 == 20)
                            {
                                Console.WriteLine(" ");
                                if (ObjectLists.Assignments.Count > 0)
                                {
                                    if (ObjectLists.Students.Count > 0)
                                    {

                                        Helper.printString("To which student would you like to see assigned assignments?");
                                        foreach (var item in ObjectLists.Students)
                                        {
                                            Helper.printString($"{item.ID}. Student name: {item.LastName} {item.FirstName}, birth: {item.DateOfBirth.Date}");
                                        }
                                        pref7 = Helper.getNumber("your choice", 7); // key = 7, to take proper values from students.count

                                        foreach (var item in ObjectLists.Assignments)
                                        {
                                            if (ObjectLists.Students[pref7 - 1].StudentAssignments.Contains(item.ID))
                                                Helper.printString($"{item.ID}. Assignment title: {item.Title}, description: {item.Description}" +
                                                    $" submission date: {item.SubDateTime.Date}, oral mark: {item.OralMark}, total mark: {item.TotalMark}");
                                        }
                                    }
                                    else
                                    {
                                        Helper.printString("There are no students yet!");
                                    }

                                }
                                else
                                {
                                    Helper.printString("There are no assignments yet!");
                                }
                            }
                            else if (pref2 == 24)
                            {
                                Console.WriteLine(" ");
                                if (ObjectLists.Students.Count > 0)
                                {
                                    if (ObjectLists.Courses.Count > 0)
                                    {

                                        foreach (var item in ObjectLists.Students)
                                        {
                                            int contains = 0;
                                            foreach (var item2 in ObjectLists.Courses)
                                            {
                                                if (item2.CourseStudents.Contains(item.ID))
                                                    contains++;
                                            }
                                            if (contains >= 2)
                                                Helper.printString($"{item.ID} Student name: {item.FirstName} {item.LastName}" +
                                                    $" date of birth: {item.DateOfBirth.Date}");

                                        }
                                    }
                                    else
                                    {
                                        Helper.printString("There are no courses yet!");
                                    }

                                }
                                else
                                {
                                    Helper.printString("There are no students yet!");
                                }
                            }
                        }

                        if (pref2 == 23)
                        {
                            do
                            {
                                pref3 = Helper.getNumber("if you want to return to main menu", 5); // key 5 = exit sub app
                            } while (pref3 != 21 && pref3 != 22);

                        }

                        if (pref3 == 21)
                        {
                            break;
                        }
                        else if (pref3 == 22)
                        {
                            continue;
                        }

                    } while (pref3 != 21);

                    continue;
                }

            } while(pref4!= 21);

            do
            {
                Console.WriteLine(" ");

                if (ObjectLists.Assignments.Count > 0)
                {
                    if (ObjectLists.Students.Count > 0)
                    {
                        Helper.printString("Do you want to check student's assignment due date?");
                        pref4 = Helper.getNumber("your choice", 5);
                        if (pref4 == 21)
                        {
                            date = Helper.getDate("date you want to check");
                            while (!date.DayOfWeek.ToString().Equals("Monday"))
                            {
                                date = date.AddDays(-1);
                            }
                            foreach (var item in ObjectLists.Students)
                            {
                                foreach (var item2 in ObjectLists.Assignments)
                                {
                                    if (item.StudentAssignments.Contains(item2.ID))
                                        if (item2.SubDateTime >= date && item2.SubDateTime <= date.AddDays(5))
                                            Helper.printString($"Student: {item.FirstName} {item.LastName}");
                                }
                            }
                        }
                    } else {
                        Helper.printString("There are no sutdents yet! Bye!");
                        pref4 = -1;
                    }
                } else
                {
                    Helper.printString("There are no assignments yet! Bye!");
                    pref4 = -1;
                }
                if (pref4 == 22)
                {
                    Helper.printString("Bye");
                }
                
            } while (pref4 == 21);

        }
    }
}
