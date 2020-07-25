using Microsoft.EntityFrameworkCore;

//github.com/johnhinz/InClassJuly25EFCore.git

namespace School
{
    public class SchoolContext : DbContext
    {
        public DbSet<StudentPoco> Students { get; set; }
        public DbSet<CoursePoco> Course { get; set; }
        public DbSet<TeacherPoco> Teacher { get; set; }
        public DbSet<MarkPoco> Mark { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=HAYME-NITRO\HUMBERBRIDGING;Initial Catalog=School_DB;Integrated Security=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MarkPoco>(
                entity => 
                entity.HasKey(entity => new { entity.CourseId, entity.StudentId }));

            base.OnModelCreating(modelBuilder);
        }
    }
}


//docs.microsoft.com/en-us/ef/core/modeling/relationships?tabs=fluent-api%2Cfluent-api-simple-key%2Csimple-key