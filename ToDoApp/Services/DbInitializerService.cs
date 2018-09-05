using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using ToDoApp.Controllers.Context;
using ToDoApp.Models;

namespace ToDoApp.Services
{
    public class DbInitializerService : DropCreateDatabaseAlways<ToDoContext>
    {
        protected override void Seed(ToDoContext db)
        {
            db.Profiles.Add(new Profile { FirstName = "Ihor", LastName = "Babii", ProfileId = new Guid(), Roles = new[] { Roles.Admin, Roles.User } });
            for (int i = 0; i < 20; i++)
            {
                db.Tasks.Add(new Task { Deskription = $"Some deskription {i}", Name = $"Task {i}", Profile = db.Profiles.FirstOrDefault(), State = State.InProgres, TaskId = new Guid() });
            }
            for (int i = 0; i < 20; i++)
            {
                db.Tasks.Add(new Task { Deskription = $"Some deskription {i+35}", Name = $"Task {i+35}", Profile = db.Profiles.FirstOrDefault(), State = State.Completed, TaskId = new Guid() });
            }
            base.Seed(db);
        }
    }
}