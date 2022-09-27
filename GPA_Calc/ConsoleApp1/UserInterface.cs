using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace GPA
{
    public class UserInterface
    {


        public void Interface()
        {

            Console.WriteLine("Hello Students");
            Console.WriteLine("Do you want to enter your courses and calculate your GPA? enter \"Yes\" or \"No\" ");
            var command = Console.ReadLine().ToUpper().Trim();

            Console.Clear();


            var savedCourses = new List<Course>();

            if (command == "YES")
            {
                string controller;
                do
                {
                    Course NewCourse = new Course();
                    while (true)
                    {
                        Console.WriteLine("Enter your CourseCode in this format \"MTS101\"");
                        var result = Console.ReadLine().ToUpper().Trim();

                        var value = Validator.CourseCodeChecker(result);
                        if (value == true)
                        {
                            NewCourse.CourseCode = result;
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Input a valid CourseCode in this format \"MTS101\"");
                            continue;
                        }
                        break;
                    };


                    while (true)
                    {
                        Console.WriteLine("Enter your CourseScore: ");
                        var result2 = Console.ReadLine();

                        var value = Validator.ScoreChecker(result2);

                        if (value == true)
                        {
                            NewCourse.Score = Convert.ToInt32(result2);
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Input a valid Score");
                            continue;
                        }
                        break;
                    };




                    while (true)
                    {
                        Console.WriteLine("Enter your CourseUnit: ");
                        var result3 = Console.ReadLine();
                        var value = Validator.CourseUnitChecker(result3);
                        if (value == true)
                        {
                            NewCourse.CourseUnit = Convert.ToInt32(result3);
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Input a valid course unit");
                            continue;
                        }
                        break;
                    }

                    var GetGrades = GPACalculator.GradingSystem(NewCourse);
                    savedCourses.Add(GetGrades);

                    Console.WriteLine("Do you want to add to the table? Input yesd to continue or no to stop");
                    controller = Console.ReadLine().ToLower().Trim();
                    if (controller == "no") break;

                } while (controller == "yes");

                GPATable.MakeDynamicTable(savedCourses);
            }
        }
    }
}
