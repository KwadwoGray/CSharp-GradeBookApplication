using System;

namespace GradeBook.GradeBooks {
    public class RankedGradeBook : BaseGradeBook {

        public RankedGradeBook(string name) : base(name) {
            this.Name = name;
            Type = Enums.GradeBookType.Ranked;
    
        }

        public override char GetLetterGrade(double averageGrade)
        {
            //return base.GetLetterGrade(averageGrade);
            if (Students.Count < 5) {
                throw new ArgumentException("Need more than 5 students");
            }
            return 'F';
        }
    }
}

