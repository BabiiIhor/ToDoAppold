using System;

namespace ToDoApp.Models
{
    public class Profile
    {
        public Guid ProfileId{ get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Roles[] Roles { get; set; }
    }
}