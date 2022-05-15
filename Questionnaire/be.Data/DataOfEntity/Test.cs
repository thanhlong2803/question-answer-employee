namespace be.Data
{
    public class Test
    {
        public long TestId { get; set; }
        public string Name { get; set; }
        public DateTime CreateBy => DateTime.Now;
        public DateTime CreateDate => DateTime.Now;

        public ICollection<Test_Question_Mapping> Test_Question_Mappings { get; set; }
    }
}
