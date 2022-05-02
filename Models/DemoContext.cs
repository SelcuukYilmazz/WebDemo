using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebDemo.Models
{
    public class DemoContext : DbContext
    {
        public DbSet<UserModel> Users { get; set;}
        public DbSet<QuizModel> Quiz { get; set; }
        public DbSet<ResultModel> Result { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options) => options.UseSqlite(@"Data Source=QuizWeb.db");
    }
}
