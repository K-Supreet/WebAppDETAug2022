using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcDemo.Models;

namespace MvcDemo.Data
{
    public class MvcDemoContext : DbContext
    {
        public MvcDemoContext (DbContextOptions<MvcDemoContext> options)
            : base(options)
        {
        }

        public DbSet<MvcDemo.Models.Booking> Booking { get; set; } = default!;

        public DbSet<MvcDemo.Models.Friend>? Friend { get; set; }



    }
}
