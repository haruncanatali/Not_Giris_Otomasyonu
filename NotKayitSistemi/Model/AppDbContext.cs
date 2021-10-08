using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotKayitSistemi.Model
{
    public class AppDbContext:DbContext
    {
        public DbSet<Scholar> Tbl_Scholar { get; set; }
        public DbSet<Student> Tbl_Student { get; set; }
        public DbSet<Request> Tbl_Request { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ScholarMap());
            modelBuilder.Configurations.Add(new StudentMap());
            modelBuilder.Configurations.Add(new RequestMap());
        }
    }
}
