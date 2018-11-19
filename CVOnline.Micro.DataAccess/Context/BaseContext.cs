using CVOnline.Micro.DataAccess.Models;
using CVOnline.Micro.MyModel;
using CVOnline.MicroMyModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVOnline.Micro.DataAccess.Context
{
  public class BaseContext : DbContext
    {
        public BaseContext() : base("CVOnline.Micro") { }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Districts> Districts { get; set; }
        public DbSet<History_Client> History_Clients { get; set; }
        public DbSet<Interview> Interviews { get; set; }
        public DbSet<Job_Creator> Job_Creators { get; set; }
        public DbSet<Job_Detail> Job_Details { get; set; }
        public DbSet<Provinces> Provincies { get; set; }
        public DbSet<Regencies> Regencies { get; set; }
        public DbSet<Villages> Villages { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Search> Searchs { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<Education_Level> Education_Levels { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<Client_Education> Client_Educations { get; set; }
    }
}
