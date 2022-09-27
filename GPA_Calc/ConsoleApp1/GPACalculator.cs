using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace GPA
{
    public class GPACalculator
    {
        string coursecode;
        int score;
        int courseunit;
        List<Course> courses = new List<Course>();


        public static Course GradingSystem(Course course)
        {
            if (course.Score >= 70)
            {
                course.GradeUnit = 5;
                course.Remark = "Excellent";
                course.Grade = "A";
            }
            else if (course.Score >= 60 && course.Score <= 69)
            {
                course.GradeUnit = 4;
                course.Remark = "Very Good";
                course.Grade = "B";
            }
            else if (course.Score >= 50 && course.Score <= 59)
            {
                course.GradeUnit = 3;
                course.Remark = "Good";
                course.Grade = "C";
            }
            else if (course.Score >= 45 && course.Score <= 49)
            {
                course.GradeUnit = 2;
                course.Remark = "Fair";
                course.Grade = "D";
            }
            else if (course.Score >= 40 && course.Score <= 44)
            {
                course.GradeUnit = 1;
                course.Remark = "poor";
                course.Grade = "E";
            }
            else if (course.Score <= 39)
            {
                course.GradeUnit = 0;
                course.Remark = "Fail";
                course.Grade = "F";
            }
            return course;
        }


        public static double Calculator(List<Course> course)
        {
            double weightPoint = 0;
            double TotalWeightPoint = 0;
            double TotalCourseUnit = 0;

            foreach (var item in course)
            {
                weightPoint = item.CourseUnit * item.GradeUnit;
                TotalWeightPoint += weightPoint;
                TotalCourseUnit += item.CourseUnit;
            }

            double GPA = TotalWeightPoint / TotalCourseUnit;
            double RoundGPA = Math.Round(GPA, 2);
            return RoundGPA;
        }

    }
}
