using Microsoft.EntityFrameworkCore;
using MyFirstRestWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstRestWebAPI.Data
{
    public class MyFirstRestWebAPIContext: DbContext
    {
        public MyFirstRestWebAPIContext(DbContextOptions<MyFirstRestWebAPIContext> opt) : base(opt)
        {

        }

        public DbSet<Command> Commands { get; set; }
    }
}
