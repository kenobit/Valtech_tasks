using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;

namespace HashCode
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonHashCode PHC = new PersonHashCode();
            

            Person alex = new Person("Olexandr", "Bohuslavskyi", 27);
            Person olex = new Person("Olexandr", "Bohuslavskyi", 29);
            Person Ken = new Person("Ken", "Block", 38);
            Person ass = new Person("Ken", "Block", 38);
            Person Homer = new Person("Homer", "Simpson", 64);

            PHC.Add(alex);
            PHC.Add(olex);
            PHC.Add(Ken);
            PHC.Add(ass);
            PHC.Add(Homer);



            Console.WriteLine(Homer.GetHashCode());
            Console.WriteLine(alex.GetHashCode());
            Console.WriteLine(olex.GetHashCode());
            Console.WriteLine(Ken.GetHashCode());
            Console.WriteLine(ass.GetHashCode());
            Console.WriteLine(PHC.Size());
            Console.ReadLine();
        }
    }
}
