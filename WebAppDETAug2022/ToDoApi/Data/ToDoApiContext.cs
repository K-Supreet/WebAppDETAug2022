using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ToDoApi.Models;

namespace ToDoApi.Data
{
    public class ToDoApiContext : DbContext
    {
        public ToDoApiContext(DbContextOptions<ToDoApiContext> options)
            : base(options)
        {
        }

        public DbSet<ToDoApi.Models.TodoItem> TodoItem { get; set; } = default!;
    }
}
