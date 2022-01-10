using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1hdfh.Models;

namespace WebApplication1hdfh.Data
{
    public class AppDbContent:IdentityDbContext
    {
        public AppDbContent(DbContextOptions options) : base(options)
        {

        }


        public DbSet<Header> Headers { get; set; }
        public DbSet<Product> Products { get; set; }


    }
}
