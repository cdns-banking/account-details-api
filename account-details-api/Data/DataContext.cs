using account_details_api.Model;
using Microsoft.EntityFrameworkCore;

namespace account_details_api.Data
{
    public  class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<AccountDeatils> AccountDeatils { get; set; }
    }
}
