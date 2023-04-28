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
            if (averageGrade < 5)
                throw new InvalidOperationException("Ranked-grading requires a minimum of 5 students to work");

            if (averageGrade <= 20)
            {
                return 'A';
            }
            else if (averageGrade >= 21 && averageGrade <= 40)
            { 
                return 'B'; 
            
            }
            else if (averageGrade >= 41 && averageGrade <= 60)
            {
                return 'C';

            }

            else if (averageGrade >= 61 && averageGrade <= 80)
            {
                return 'D';

            }
            return 'F';
        }
    }
}
