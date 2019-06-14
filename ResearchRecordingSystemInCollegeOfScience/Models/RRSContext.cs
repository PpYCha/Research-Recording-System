using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace ResearchRecordingSystemInCollegeOfScience
{
    public class RRSContext : DbContext
    {

        public RRSContext()
            : base("RRSContext")

        {
            Database.SetInitializer<RRSContext>(new RRSDbInitializer());
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<RRSContext, Migrations.Configuration>(useSuppliedContext: true));
        }

        public DbSet<UserAccount> UserAccounts { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<ResearchBook> ResearchBooks { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Borrow> Borrows { get; set; }
        public DbSet<Classifacation> Classifacations { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserAccount>().HasKey(k => k.UserId)
                .Property(p => p.UserId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            modelBuilder.Entity<Course>().HasKey(k => k.CourseId)
                .Property(p => p.CourseId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            modelBuilder.Entity<ResearchBook>().HasKey(k => k.ThesisTitleId)
                .Property(p => p.ThesisTitleId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            modelBuilder.Entity<Author>().HasKey(k => k.AuthorId)
                   .Property(p => p.AuthorId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            modelBuilder.Entity<Borrow>().HasKey(k => k.BorrowerId)
                  .Property(p => p.BorrowerId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            modelBuilder.Entity<Classifacation>().HasKey(k => k.ClassificationId)
                .Property(p => p.ClassificationId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

        }
    }

}
