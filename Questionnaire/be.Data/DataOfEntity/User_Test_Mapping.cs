namespace be.Data
{
    public class User_Test_Mapping
    {
        public long Id { get; set; }
        public long UserId { get; set; }
        public long TestId { get; set; }
        public int TestHour { get; set; }
        public double Score { get; set; }

        public virtual User User { get; set; }
        public virtual Test Test { get; set; }
    }
}
