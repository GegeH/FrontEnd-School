using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace HW.Models
{
    public class Person
    {
        // use Id to log in
        public int Id { get; set; }
      //  public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Role { get; set; } // 0 : student, 1 : teacher
        public string Password { get; set; }

       // initial to 0 if it is in a database
        public int Progress { get; set; } // how many tests already completed
        public int CorrectNumber { get; set; } // how many tests is correct

    }
}