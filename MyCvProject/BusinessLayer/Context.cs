using EntityLayer.Concrate;
using Microsoft.EntityFrameworkCore;
using MyCvProjectEntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=ONURBAHSI; database=MyCV; uid=sa; pwd=12345");
        }

        public DbSet<About> Abouts { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Comment> Comments { get; set; }

        public DbSet<Contact> Contacts { get; set; }

        public DbSet<MyProject> MyProjects { get; set; }

		public DbSet<User> Users { get; set; }

        public DbSet<NewsletterPerson> NewsletterPersons { get; set; }

		public DbSet<Like> Likes { get; set; }

        public DbSet<ProjectCategory> ProjectCategories { get; set; }

        public DbSet<AboutMe> AboutsMe { get; set; }

        public DbSet<CompanyWorkFor> CompaniesWorkFor { get; set; }

		public DbSet<Ability> Abilities { get; set; }
	}
}