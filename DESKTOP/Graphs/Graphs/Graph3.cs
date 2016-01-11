using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphs
{
    public class Graph3:IGraph
    {
        public class Node
        {
            public string City;
            public Link[] links;
            bool marked;
        }

        public class Link
        {
            public Node To;
            public Node From;
            public int distance;
        }

        public Node[] nodes;

        public void AddNode(string city)
        {
            throw new NotImplementedException();
        }

        public void AddLink(string from, string to, int weight)
        {
            throw new NotImplementedException();
        }

        public void DelNode(string city)
        {
            throw new NotImplementedException();
        }

        public void DelLink(string from, string to)
        {
            throw new NotImplementedException();
        }

        public string[] ToArray()
        {
            throw new NotImplementedException();
        }

        public List<string> Way(string from, string to)
        {
            throw new NotImplementedException();
        }
    }
}
