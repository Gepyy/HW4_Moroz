using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace HW4_Moroz
{
    public class User
    {
        public bool DoYouBaby = false;
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; }
        public Gender Gender { get; set; }
        public User()
        {
            FirstName = "Hordii";
            LastName = "Moroz";
            Age = 300;
            Gender = Gender.mechanic; 
        }
        public User(int age)
        {
            Age = age;
            if(Age <= 10)
            {
                DoYouBaby = true;
            }
        }

        public override string ToString()
        {
            if(DoYouBaby)
            {
                return $"Hi, my name is {FirstName} and last name {LastName}. I am baby. I am {Gender}.";
            }
            else
            {
                return $"Hi, my name is {FirstName} and last name {LastName}. I am {Age} years old. I am {Gender}.";
            }
        }
    }
}
