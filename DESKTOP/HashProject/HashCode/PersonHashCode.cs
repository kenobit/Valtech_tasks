using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashCode
{
    public class PersonHashCode
    {
        public List<Person>[] Table = new List<Person>[997];

        public void Add(Person newPerson)
        {
            if (Table[newPerson.GetHashCode()] == null)
            {
                List<Person> p = new List<Person>();
                p.Add(newPerson);
                Table[newPerson.GetHashCode()] = p;
            }
            else
            {
                if (!Table[newPerson.GetHashCode()].Contains(newPerson))
                {
                    Table[newPerson.GetHashCode()].Add(newPerson);
                }
            }
        }

        public void Delete(int hash)
        {
            if (Table.Length == 0)
            {
                throw new ArgumentException("Main list is empty.");
            }
            if (Table[hash] == null)
            {
                throw new ArgumentException("Person with this hash code doesn't exists");
            }
            else
            {
                Table[hash].Clear();
            }
        }

        public Person[] Toarray()
        {
            if (Table.Length == 0)
            {
                throw new ArgumentException("Main list is empty.");
            }
            List<Person> lst = new List<Person>();
            foreach (List<Person> items in Table)
            {
                if (items != null)
                {
                    foreach (Person item in items)
                    {
                        lst.Add(item);
                    }
                }
            }
            return lst.ToArray();
        }

        public Person Get(int hash)
        {
            return this.Table[hash].First();
        }

        public void Clear()
        {
            Table = new List<Person>[997];
        }

        public int Size()
        {
            int counter = 0;
            foreach (List<Person> items in Table)
            {
                if (items != null)
                {
                    foreach (Person item in items)
                    {
                        counter++;
                    }
                }
                else
                {
                }
            }
            return counter;
        }
    }
}
