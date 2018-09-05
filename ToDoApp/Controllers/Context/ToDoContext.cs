using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using ToDoApp.Models;

namespace ToDoApp.Controllers.Context
{
    public class ToDoContext : DbContext
    {
        public DbSet<Task> Tasks { get; set; }
        public DbSet<Profile> Profiles { get; set; }
    }
}