namespace GradeBook.GradeBooks {
    public class RankedGradeBook : BaseGradeBook {

        public RankedGradeBook(string name) : base(name) {
            this.Name = name;
            Type = Enums.GradeBookType.Ranked;
        }
    }
}