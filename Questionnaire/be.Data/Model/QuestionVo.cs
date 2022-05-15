namespace be.Data.Model
{
    public class QuestionVo
    {
        public long QuestionId { get; set; }
        public string QuestionName { get; set; }

        public ICollection<OpitionVo> Opitions { get; set; }
    }
}
