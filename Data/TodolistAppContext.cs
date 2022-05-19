using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TodolistApp.Model;

namespace TodolistApp.Data
{
    public class TodolistAppContext : DbContext
    {
        public TodolistAppContext (DbContextOptions<TodolistAppContext> options)
            : base(options)
        {
        }

        public DbSet<TodolistApp.Model.Todo>? Todo { get; set; }
    }
}
