using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashCode
{
    public class Person
    {
        private static int ID = 0;
        private int id;
        private string firstName;
        private string lastName;
        private int age;
        public Person next;

        public int Id
        {
            get
            {
                return this.id;
            }
        }
        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            set
            {
                this.firstName = value;
            }
        }
        public string LastName
        {
            get
            {
                return this.lastName;
            }
            set
            {
                this.lastName = value;
            }
        }
        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if (value <= 0 || value >= 100)
                {
                    throw new Exception("Age can't be less than zero and more than 100");
                }
                this.age = value;
            }
        }

        public Person(string fName, string lName, int age)
        {
            this.id = ++ID;
            this.FirstName = fName;
            this.LastName = lName;
            this.Age = age;
            this.next = null;
        }

        public override int GetHashCode()
        {
            int hash = 0,step = 42;
            string str = this.firstName + this.lastName + "I hope this sh*t will be unique" + this.age;

            foreach (char item in str)
            {
                hash = (step * hash + item) % 997;
            }

            return hash;
        }

        //public override int GetHashCode()
        //{
        //    return this.Id;
        //}

        public override string ToString()
        {
            return this.firstName + " " + this.lastName + " " + this.age;
        }

        public override bool Equals( object obj)
        {
            Person person = obj as Person;
            return (this.lastName == person.LastName && this.firstName == person.FirstName && this.age == person.Age);
        }
    }
}
