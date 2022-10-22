using Microsoft.EntityFrameworkCore;

namespace UsersApi.Data
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options): base(options) {}
        //Mudar a classe Users para User
        public DbSet<Users> Users { get; set; }
        public DbSet<UsersType> UsersType { get; set; }
    }
}
