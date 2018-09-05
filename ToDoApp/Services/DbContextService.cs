using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ToDoApp.Controllers.Context;

namespace ToDoApp.Services
{
    public class DbContextService
    {
        public static ToDoContext db { get; set; } = new ToDoContext();
       // public static ToDoContext db = new ToDoContext();

    }
}