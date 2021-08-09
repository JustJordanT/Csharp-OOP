using System;

namespace AccessModifiers
{
    class Program
    {
        public class Person
        {
            private DateTime _birthdate;

            public void SetBirthDate(DateTime birthDate)
            {
                _birthdate = birthDate;
            }

            public DateTime GetBirthDate()
            {
                return _birthdate;
            }
        }
        
        static void Main(string[] args)
        {
            var person = new Person();
            person.SetBirthDate(new DateTime(1900,1,1));
            Console.WriteLine(person.GetBirthDate());
        }
    }
}