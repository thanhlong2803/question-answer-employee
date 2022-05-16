namespace be.Data.Model
{
    public class TestQuestionVo
    {
        public long TestId { get; set; }
        public string Name { get; set; }
        public ICollection<QuestionVo> Questions { get; set; }
    }
}
