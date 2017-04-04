using Microsoft.EntityFrameworkCore;
using Repo.EF.Models;

namespace Repo.EF
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<Status> Status { get; set; }
    }
}
