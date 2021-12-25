using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;

namespace DyDx_Academy.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<IdentityRole>().HasData(
                new {Id = Guid.NewGuid().ToString(), Name="Admin", NormalizedName="ADMIN"},
                new {Id = Guid.NewGuid().ToString(), Name="Member", NormalizedName="MEMBER"}
            );

            builder.Entity<Instructor_Course>().HasKey(am => new
            {
                am.InstructorId,
                am.CourseId
            });
            builder.Entity<Instructor_Course>().HasOne(m => m.Courses).WithMany(am => am.Instructor_Course).HasForeignKey(m => m.CourseId);
            base.OnModelCreating(builder);
            builder.Entity<Instructor_Course>().HasOne(m => m.Instructors).WithMany(am => am.Instructor_Course).HasForeignKey(m => m.InstructorId);
            base.OnModelCreating(builder);

            base.OnModelCreating(builder);
        }

        public DbSet<Instructors> Instructors { get; set; }
        public DbSet<Courses> Courses { get; set; }

        public DbSet<Instructor_Course> Instructor_Course { get; set; }
        public DbSet<Account_Order> Account_Orders { get; set; }

        //order related tables

        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }


    }
}
