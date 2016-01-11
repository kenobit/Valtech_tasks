using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTreeLink bt = new BinaryTreeLink();
            bt.Add(0);
            Console.WriteLine(bt);
            bt.Add(1);
            Console.WriteLine(bt);
            bt.Add(2);
            Console.WriteLine(bt);
            bt.Add(3);
            Console.WriteLine(bt);
            bt.Add(4);
            Console.WriteLine(bt);
            bt.Add(5);
            Console.WriteLine(bt);
            bt.Add(6);
            Console.WriteLine(bt);
            bt.Add(7);
            Console.WriteLine(bt);
            bt.Add(8);
            Console.WriteLine(bt);
            bt.Add(9);
            Console.WriteLine(bt);

            Console.ReadLine();
        }
    }
}
