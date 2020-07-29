using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPartA
{
    static class Helper
    {
        public static string getString(string message)
        {
           
            string str;
            string subStr = "";
            string spacebar = " ";
            do
            {
                Console.WriteLine($"please type {message}");
                str = Console.ReadLine().Trim();
            } while (str == "" || str == " ");

            while (str.IndexOf(" ") > 0)
            {
                subStr = subStr + str.Substring(0, str.IndexOf(" ")) + spacebar;
                str = str.Substring(str.IndexOf(" ")).Trim();
            }

            str = subStr + str;

            return str;

        }

        public static DateTime getDate(string message)
        {
            string str;
            DateTime date;
            do
            {
                Console.WriteLine($"please type {message}");
                str = Console.ReadLine();
            } while (!DateTime.TryParse(str, out date));
            return date;
            
        }

        public static int getNumber(string message, int key = 0)
        {
            string str;
            int number;
            bool flag = true;

            do
            {

                Console.WriteLine($"Please type {message}");
                if (key == 1)
                {
                    printString("1. Add Data");
                    printString("2. Assign Data");
                    printString("3. Print Data");
                    printString("4. Exit main Menu / Get student submition dates");
                    printString("25. Add synthetic data");
                } else if (key == 2)
                {
                    printString("5. Add Course");
                    printString("6. Add Student");
                    printString("7. Add Trainer");
                    printString("8. Add Assignment");
                    printString("23. Return to main menu");
                }
                else if (key == 3)
                {
                    printString("9. Assign student(s) to course(s)");
                    printString("10. Assign trainer(s) to course(s)");
                    printString("11. Assign assignment(s) to course(s)");
                    printString("12. Assign assignment(s) to student(s)");
                    printString("23. Return to main menu");
                } else if (key == 4)
                {
                    printString("13. Print all courses");
                    printString("14. Print all students");
                    printString("15. Print all trainers");
                    printString("16. Print all assignments");
                    printString("17. Print all students per course");
                    printString("18. Print all trainers per course");
                    printString("19. Print all assignments per course");
                    printString("20. Print all assignments per student");
                    printString("24. Print students that attend more than 1 course");
                    printString("23. Return to main menu");
                } else if (key == 5)
                {
                    printString("21. Yes");
                    printString("22. No");
                }

                str = Console.ReadLine();

                if (key == 0)
                    flag = (!int.TryParse(str, out number) && number < 0);
                else if (key == 1)
                    flag = (!int.TryParse(str, out number) && number != 1 && number != 2 && number != 3 && number != 4 && number != 25);
                else if (key == 2)
                    flag = (!int.TryParse(str, out number) && number != 23 && number != 5 && number != 6 && number != 7 && number != 8);
                else if (key == 3)
                    flag = (!int.TryParse(str, out number) && number != 23 && number != 9 && number != 10 && number != 11 && number != 12);
                else if (key == 4)
                    flag = (!int.TryParse(str, out number) && number != 23 && number != 13 && number != 14 && number != 15 && number != 16
                                && number != 17 && number != 18 && number != 19 && number != 20 && number != 24);
                else if (key == 5)
                    flag = (!int.TryParse(str, out number) && number != 21 && number != 22);
                else if (key == 6)
                    flag = (!int.TryParse(str, out number) && number < 0 && number > ObjectLists.Courses.Count);
                else if (key == 7)
                    flag = (!int.TryParse(str, out number) && number < -1 && number > ObjectLists.Students.Count);
                else if (key == 8)
                    flag = (!int.TryParse(str, out number) && number < -1 && number > ObjectLists.Trainers.Count);
                else
                    flag = (!int.TryParse(str, out number) && number < -1 && number > ObjectLists.Assignments.Count);

            } while (flag);
            
            return number;
            
        }

        public static void printString(string str)
        {
            Console.WriteLine(str);
        }
        
    }

}
