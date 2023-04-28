using GradeBook.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeBook.GradeBooks
{
    public class RankedGradeBook : BaseGradeBook
    {
        public RankedGradeBook(string name) : base(name)
        {
            Type = GradeBookType.Ranked;
        }

        public override char GetLetterGrade(double averageGrade)
        {
            if (Students.Count < 5)
            {
                throw new InvalidOperationException("You must have at least 5 students to do ranked grading.");
            }
            var threshold = (int)Math.Ceiling(Students.Count * 0.2);
            var grades = Students.OrderByDescending(e => e.AverageGrade).Select(e => e.AverageGrade).ToList();

            if (averageGrade >= grades[threshold - 1])
                return 'A';
            if (averageGrade >= grades[(threshold * 2) - 1])
                return 'B';
            if (averageGrade >= grades[(threshold * 3) - 1])
                return 'C';
            if (averageGrade >= grades[(threshold * 4) - 1])
                return 'D';
            return 'F';
            //if (averageGrade <= 5)
            //    throw new InvalidOperationException("Ranked-grading requires a minimum of 5 students to work");

            //if (averageGrade <= 20)
            //{
            //    return 'A';
            //}
            //else if (averageGrade >= 21 && averageGrade <= 40)
            //{ 
            //    return 'B'; 

            //}
            //else if (averageGrade >= 41 && averageGrade <= 60)
            //{
            //    return 'C';

            //}

            //else if (averageGrade >= 61 && averageGrade <= 80)
            //{
            //    return 'D';

            //}
            //return 'F';
        }
    }
}
