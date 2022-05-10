using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm_3
{
    public class Professor
    {
        private string firstName;
        private string lastName;
        private string department;
        private string lNumber;

        private static string[] departments = { "CS", "MATH", "HEALTH", "WR" };

        public Professor()
        {
            this.firstName = "Jane";
            this.lastName = "Doe";
            this.department = departments[0];
            this.lNumber = "L00000000";
        }
        public Professor(string firstName, string lastName, string department, string lNumber)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            if (departments.Contains(department))
                this.department = department;
            else
                this.department = departments[0];
            lNumber = lNumber.ToUpper();
            if (lNumber[0] == 'L' && lNumber.Length == 9)
                this.lNumber = lNumber;
            else
                this.lNumber = "L00000000";
        }

        public string FirstName
        {
            get { return this.firstName; }
            set { this.firstName = value; }
        }
        public string LastName
        {
            get { return this.lastName; }
            set { this.lastName = value; }
        }
        public string Department
        { 
            get { return this.department; } 
            set 
            {
                if (departments.Contains(value))
                    this.department = value;
                else
                    throw new ArgumentException("That is not a department.");
            }            
        }
        public string LNumber
        {
            get { return this.lNumber; }
            set 
            {
                if (value[0] == 'L' && value.Length == 9)
                    this.lNumber = value;
                else
                    throw new ArgumentException("L Numbers must be 9 characters long and start with an L");

            }
        }

        public override string ToString()
        {
            return String.Format("First Name: {0}, Last Name: {1}, Department: {2}, L-Number: {3}", firstName, lastName, department, lNumber);
        }
    }
}
