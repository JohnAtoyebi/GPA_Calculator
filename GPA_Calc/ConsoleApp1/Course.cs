using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPA
{
    public class Course
    {
        public string CourseCode { get; set; }

        public int Score { get; set; }
        public int CourseUnit { get; set; }

        public int GradeUnit { get; set; }

        public string Grade { get; set; }

        public string Remark { get; set; }

    }
}
