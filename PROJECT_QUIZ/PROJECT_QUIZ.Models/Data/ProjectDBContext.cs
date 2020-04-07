using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PROJECT_QUIZ.Models.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PROJECT_QUIZ.Models.Data
{
    public class ProjectDBContext : IdentityDbContext<Person>
    {
        public ProjectDBContext(DbContextOptions<ProjectDBContext> options)
          : base(options)
        {

            //Via een service provider kan UserManager/Rolemanger geconfigureerd worden.
        }

        public virtual DbSet<Quiz> Quizzes { get; set; }
        public virtual DbSet<Questions> Questions { get; set; }
        public virtual DbSet<Answers> Answers { get; set; }
        public virtual DbSet<History> Histories { get; set; }
        //public virtual DbSet<Person> Persons { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder); //must voor identity

            modelBuilder.Entity<Answers>(entity =>
            {
                entity.HasKey(e => new { e.AnswerID });
            });
            modelBuilder.Entity<Questions>(entity =>
            {
                entity.HasKey(e => new { e.QuestionID });
            });
            //modelBuilder.Entity<Person>().HasMany(p => p.Roles).WithOne().HasForeignKey(p => p.UserId).IsRequired();

            //modelBuilder.Entity<Person>().Ignore(t => t.ImgUrl);


        }
    }
}
