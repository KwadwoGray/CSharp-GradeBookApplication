using System;
using System.Collections.Generic;


namespace GradeBook.GradeBooks {
    public class RankedGradeBook : BaseGradeBook {

        public RankedGradeBook(string name) : base(name) {
            this.Name = name;
            Type = Enums.GradeBookType.Ranked;
    
        }

        public override char GetLetterGrade(double averageGrade)
        {
            double gradeThreshold = Students.Count * 0.2;
            List<double> allGrades = new List<double>();

            allGrades = GetStudentsGrades(Students);
            allGrades.Sort();
            
            if (Students.Count < 5) {
                throw new InvalidOperationException("Ranked grading requires a minimum of 5 students");
            }

            double AGradeThreshold = allGrades[(int)Math.Ceiling(gradeThreshold)];

            if (averageGrade > AGradeThreshold){
                return 'A';
            }

            return 'F';

            //return base.GetLetterGrade(averageGrade);
        }

        private List<double> GetStudentsGrades(List<Student> students)
        {
            List<double> studentGrades = new List<double>();
            foreach (var student in students) {
                studentGrades.Add(student.AverageGrade);
            }
            return studentGrades;
        }
    }
}

