using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQExercises
{
    public class User
    {
        public string FirstName;
        public string LastName;
        public int Age;

        public User(string firstname, string lastname, int age)
        {
            FirstName = firstname;
            LastName = lastname;
            Age = age;

        }
    }
}
