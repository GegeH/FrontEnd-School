using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace HW.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Role { get; set; } // 0 : student, 1 : teacher
        public string Password { get; set; }
        public int Login { get; set; } // 0: not logged in, 1: is doing testing 

        public int Progress { get; set; } // how many tests already completed
        public int CorrectNumber { get; set; } // how many tests is correct
    }
}