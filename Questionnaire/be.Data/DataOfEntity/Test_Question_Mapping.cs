namespace be.Data
{
    public class Test_Question_Mapping
    {
        public long Id { get; set; }
        public long TestId { get; set; }
        public long QuestionId { get; set; }

        public ICollection<Question> Questions { get; set; }
        public ICollection<Test> Tests { get; set; }
    }
}
