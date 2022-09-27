using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPA
{
    public class GPATable
    {
        public static int tableWidth = 100;
        //public static void PrintTable()
        //{
        //    Console.Clear();
        //    PrintLine();
        //    PrintRow("Column 1", "Column 2", "Column 3", "Column 4");
        //    PrintLine();
        //    PrintRow("", "", "", "");
        //    PrintRow("", "", "", "");
        //    PrintLine();
        //    Console.ReadLine();
        //}
        public static void PrintLine()
        {
            Console.WriteLine(new string('-', tableWidth));
        }
        public static void PrintRow(params string[] columns)
        {
            int width = (tableWidth - columns.Length) / columns.Length;
            string row = "|";
            foreach (string column in columns)
            {
                row += AlignCentre(column, width) + "|";
            }
            Console.WriteLine(row);
        }
        public static string AlignCentre(string text, int width)
        {
            text = text.Length > width ? text.Substring(0, width - 3) + "..." : text;
            if (string.IsNullOrEmpty(text))
            {
                return new string(' ', width);
            }
            else
            {
                return text.PadRight(width - (width - text.Length) / 2).PadLeft(width);
            }
        }
        public static void MakeDynamicTable(List<Course> savedCourses)
        {
            Console.Clear();
            Console.WriteLine("Suraj GPA");
            GPATable.PrintLine();
            GPATable.PrintRow("COURSE & CODE", "COURSE-UNIT", "GRADE", "GRADE-UNIT", "REMARK");
            GPATable.PrintLine();
            foreach (var course in savedCourses)
            {
                GPATable.PrintRow(course.CourseCode, course.CourseUnit.ToString(), course.Grade.ToString(), course.GradeUnit.ToString(), course.Remark);
            }
            GPATable.PrintLine();
            var GPA = GPACalculator.Calculator(savedCourses);
            Console.WriteLine($"Your GPA is: {GPA}");
        }
    }
}
