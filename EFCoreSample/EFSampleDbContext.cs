using EFCoreSample.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreSample
{
    public class EFSampleDbContext : DbContext
    {
        //public EFSampleDbContext() : base()
        //{

        //}
        //public EFSampleDbContext(DbContextOptions<EFSampleDbContext> options):base(options)
        //{

        //}

        public DbSet<Student> Students { get; set; }
        public DbSet<Score> Scores { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DECAGONNET006;Database=EFSample;Trusted_Connection=True; Encrypt=False;");
        }
    }
}
