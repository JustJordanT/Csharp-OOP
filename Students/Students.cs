using System;
using System.Globalization;
using System.IO.Pipes;

namespace Students
{
    public class Students
    {
        public string name;
        public string major;
        private double gpa;

        public Students(string aName, double aGpa, string aMajor = "Not Yet Chosen")
        {
            name = aName;
            major = aMajor;
            Gpa = aGpa;
        }

        public double Gpa
        {
            get => gpa;
            set
            {
                if (value <= 4.0)
                {
                    gpa = value;
                }
                else
                {
                    gpa = 0.0;
                }

                ;
            }
            
        }
        
        

        public bool HasHonors()
        {
            // Console.WriteLine(gpa >= 3.5 ? "Has Honors" : "NA"); >> This is almost like pythonic magic methods
            if (gpa >= 3.5)
            {
                Console.WriteLine("Has Honors");
            }
            else
            {
                Console.WriteLine("NA");
            }

            return false;
        }

        public bool IsStem()
        {
            switch (major)
            {
                case "Computer Science":
                case "Engineering":
                case "Mathematics":
                case "Physics":
                    return true;
                default:
                    return false;
            }
            /*
             *if (major is "Computer Science")
            {
                return true;
            }
            else if (major is "Engineering")
            {
                return true;
            }
            else if (major is "Mathematics")
            {
                return true;
            }
            else if (major is "Physics")
            {
                return true;
            }
            return false;
             */
        }
    }
}