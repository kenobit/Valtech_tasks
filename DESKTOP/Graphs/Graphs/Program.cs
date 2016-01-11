using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphs
{
    class Program
    {
        static void Main(string[] args)
        {
            Graph1 g = new Graph1();
            g.AddNode("c1");
            g.AddNode("c2");
            g.AddNode("c3");
            g.AddNode("c4");
            g.AddNode("c5");
            g.AddNode("c6");
            g.AddNode("c7");
            g.AddLink("c1", "c2", 3);
            g.AddLink("c1", "c3", 4);
            g.AddLink("c2", "c6", 4);
            g.AddLink("c3", "c5", 8);
            g.AddLink("c4", "c7", 5);
            g.AddLink("c5", "c2", 6);
            g.AddLink("c5", "c4", 8);

            Console.WriteLine(g);
            foreach (string item in g.Way("c1", "c1"))
            {
                Console.Write(item + " ");
            }
            Console.ReadLine();
        }
    }

}
