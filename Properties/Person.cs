using System;

namespace Properties
{
    public class Person
    {


        public string Name { get; set; }
        public string UserName { get; set; }
        private DateTime BirthDate { get; set; }
        public Person(DateTime birthDate)
        {
            BirthDate = birthDate;
        }
        public  int Age
        {
            get
            {
                var timeSpan = DateTime.Today - BirthDate;
                var years = timeSpan.Days / 365;

                return years;
            }
            
        }
    }
}