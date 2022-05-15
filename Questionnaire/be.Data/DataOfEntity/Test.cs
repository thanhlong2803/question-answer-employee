namespace be.Data
{
    public class Test
    {
        public long TestId { get; set; }
        public string Name { get; set; }
        public DateTime CreateBy => DateTime.Now;
        public DateTime CreateDate => DateTime.Now;
    }
}
