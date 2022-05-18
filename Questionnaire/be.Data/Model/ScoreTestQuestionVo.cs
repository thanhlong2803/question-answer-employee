namespace be.Data.Model
{
    public class ScoreTestQuestionVo
    {
        public long UserId { get; set; }
        public long TestId { get; set; }
        public string Name { get; set; }
        public ScoreQuestionVo Questions { get; set; }
    }

    public class ScoreQuestionVo
    {
        public long QuestionId { get; set; }
        public string QuestionName { get; set; }

        public ICollection<ScoreOpitionVo> Opitions { get; set; }
    }

    public class ScoreOpitionVo
    {
        public long OpitionId { get; set; }
        public long QuestionId { get; set; }
        public string OpitionName { get; set; }
        public bool IsCorrect { get; set; }
    }
}

