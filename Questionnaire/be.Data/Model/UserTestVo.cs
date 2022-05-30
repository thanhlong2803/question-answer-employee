namespace be.Data.Model
{
    public class UserTestVo
    {
        public long UserId { get; set; }
        public string Fistname { get; set; }
        public string Lastname { get; set; }

        public string Fullname => Fistname + Lastname;
        public List<TestQuestionVo> TestQuestionVos { get; set; }
    }
    public class Authentication
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
