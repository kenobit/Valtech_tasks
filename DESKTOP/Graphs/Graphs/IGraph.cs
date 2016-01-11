using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphs
{
    public interface IGraph
    {
        void AddNode(string city);
        void AddLink(string from, string to, int weight);
        void DelNode(string city);
        void DelLink(string from, string to);
        string[] ToArray();
        List<string> Way(string from, string to);
    }
}
