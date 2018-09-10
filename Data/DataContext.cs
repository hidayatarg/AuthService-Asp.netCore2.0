using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASPcoreAuth.API.Models;
using Microsoft.EntityFrameworkCore;

namespace ASPcoreAuth.API.Data
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<Value> Values { get; set; }
    }
}
