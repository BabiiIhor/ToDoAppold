using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ToDoApp.Models
{
    public class Task
    {
        public string Name { get; set; }
        public string Deskription { get; set; }
        public Guid TaskId { get; set; }
        public State State { get; set; }
        public Profile Profile { get; set; }

    }
}