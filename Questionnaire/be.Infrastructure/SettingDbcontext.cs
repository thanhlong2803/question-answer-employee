using be.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure
{
    public class SettingDbcontext : DbContext
    {
        public SettingDbcontext(DbContextOptions<SettingDbcontext> options)
            : base(options)
        {

        }
        public DbSet<Opition> Opition { get; set; }
        public DbSet<Question> Question { get; set; }
        public DbSet<Test> Test { get; set; }
        public DbSet<Test_Question_Mapping> Test_Question_Mapping { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<User_Test_Mapping> User_Test_Mapping { get; set; }
    }
}
