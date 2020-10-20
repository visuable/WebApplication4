using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication4.Models;

namespace WebApplication4
{
    public class AppContext : DbContext
    {
        public DbSet<UserModel> Users { get; set; }
        public AppContext(DbContextOptions options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
