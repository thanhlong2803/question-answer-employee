namespace be.Data
{
    public class Question 
    {
        public long QuestionId { get; set; } 
        public string QuestionName { get; set; }

        public ICollection<Opition> Opitions { get; set; }
        public ICollection<Test_Question_Mapping> Test_Question_Mappings { get; set; }
    }
}
