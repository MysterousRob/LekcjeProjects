using ConsoleaApp1;
using System;

namespace ConsoleaApp1
{
    public class Person
    {
        public Person()
        {

        }

        public Person(string firstname, string lastname, DateTime birthdate)
        {
            this.FirstName = firstname;
            this.LastName = lastname;
            this.BirthDate = birthdate;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }

        public string GetFullName()
        {
            return $"{FirstName} {LastName}";
        }

        public int GetAge()
        {
            DateTime today = DateTime.Today;
            int age = today.Year - BirthDate.Year;
            return age;
        }


        public bool IsAdult()
        {
            return GetAge() >= 18;
        }
    }
}

