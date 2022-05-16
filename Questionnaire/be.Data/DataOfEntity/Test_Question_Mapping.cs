namespace be.Data
{
    public class Test_Question_Mapping
    {
        public long Id { get; set; }
        public long TestId { get; set; }
        public long QuestionId { get; set; }

        public virtual Question Question { get; set; }
        public virtual Test Test { get; set; }
    }
}
