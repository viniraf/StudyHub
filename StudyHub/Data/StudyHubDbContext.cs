using Microsoft.EntityFrameworkCore;
using StudyHub.Models;

namespace StudyHub.Data
{
    public class StudyHubDbContext : DbContext
    {
        public StudyHubDbContext(DbContextOptions<StudyHubDbContext> options) : base(options)
        {
        }

        public DbSet<StudyGroupModel> StudyGroup { get; set; }
        public DbSet<UserModel> User { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<StudyGroupModel>()
        //        .HasOne(sg => sg.CreateUser)
        //        .WithMany(u => u.CreatedGroups)
        //        .HasForeignKey(sg => sg.CreateUserId)
        //        .OnDelete(DeleteBehavior.Restrict);

        //    base.OnModelCreating(modelBuilder);
        //}
    }
}
