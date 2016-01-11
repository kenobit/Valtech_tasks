using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphs
{
    public class Graph1 : IGraph
    {
        public string[] nodes;
        public int[,] links;

        public Graph1()
        {
            this.nodes = new string[0];
            this.links = new int[0, 0];
        }

        private void ResizePlus()
        {
            if (this.links.GetLength(0) == 0)
            {
                this.links = new int[1, 1];
            }
            else
            {
                int[,] temp2d = new int[this.nodes.Length, this.nodes.Length];

                for (int i = 0; i < this.links.GetLength(0); i++)
                {
                    for (int j = 0; j < this.links.GetLength(1); j++)
                    {
                        temp2d[i, j] = this.links[i, j];
                    }
                }

                this.links = new int[this.nodes.Length, this.nodes.Length];

                for (int i = 0; i < this.links.GetLength(0); i++)
                {
                    for (int j = 0; j < this.links.GetLength(1); j++)
                    {
                        this.links[i, j] = temp2d[i, j];
                    }
                }
            }
        }
        private void ResizeMinus(string city)
        {
            if (!this.nodes.Contains(city)) { throw new ArgumentException("Array doesnt have {0} value", city); }
            else
            {
                int removeIndex = Array.IndexOf(this.nodes, city);
                int[,] tempLinks = new int[this.nodes.Length - 1, this.nodes.Length - 1];
                int newI = 0;
                int newJ = 0;

                for (int i = 0; i < links.GetLength(0); i++)
                {
                    if (i != removeIndex)
                    {
                        newJ = 0;
                        for (int j = 0; j < this.links.GetLength(1); j++)
                        {
                            if (j != removeIndex)
                            {
                                tempLinks[newI, newJ] = this.links[i, j];
                                newJ++;
                            }
                        }
                        newI++;
                    }
                }

                this.links = new int[this.nodes.Length - 1, this.nodes.Length - 1];

                for (int i = 0; i < tempLinks.GetLength(0); i++)
                {
                    for (int j = 0; j < tempLinks.GetLength(1); j++)
                    {
                        this.links[i, j] = tempLinks[i, j];
                    }
                }
            }
        }

        public void AddNode(string city)
        {
            if (city == "" || city.Length < 1) { throw new ArgumentException("City length can't be less than 1 sign!"); }

            int size = nodes.Length + 1;
            string[] temp = new string[size];

            for (int i = 0; i < size - 1; i++)
            {
                temp[i] = nodes[i];
            }

            this.nodes = new string[size];

            for (int i = 0; i < size - 1; i++)
            {
                nodes[i] = temp[i];
            }

            this.nodes[size - 1] = city;

            ResizePlus();
        }

        public void AddLink(string from, string to, int weight)
        {
            if (weight <= 0) { throw new ArgumentException("Weight argument can't be less than one!"); }
            if (this.nodes.Length == 0 || this.links.Length == 0) { throw new Exception("Array doesn't contains any graphs for linking!"); }
            if (this.nodes.Contains(from) && this.nodes.Contains(to))
            {
                int indFrom = Array.IndexOf(this.nodes, from);
                int indTo = Array.IndexOf(this.nodes, to);
                this.links[indFrom, indTo] = weight;
            }
            else { throw new ArgumentException(@"Arguments 'from' or 'to' doesn't exist!"); }
        }

        public void DelNode(string city)
        {
            if (!this.nodes.Contains(city)) { throw new ArgumentException("Array doesnt have {0} value", city); }

            int size = this.nodes.Length;
            string[] temp = new string[size];

            ResizeMinus(city);

            for (int i = 0; i < size; i++)
            {
                temp[i] = this.nodes[i];
            }

            this.nodes = new string[size - 1];
            bool deleted = false;

            for (int i = 0; i < size - 1; i++)
            {
                if (city == temp[i])
                {
                    deleted = true;
                }
                if (deleted)
                {
                    this.nodes[i] = temp[i + 1];
                }
                else { this.nodes[i] = temp[i]; }
            }
        }

        public void DelLink(string from, string to)
        {
            if (this.nodes.Contains(from) && this.nodes.Contains(to))
            {
                int indFrom = Array.IndexOf(this.nodes, from);
                int indTo = Array.IndexOf(this.nodes, to);
                this.links[indFrom, indTo] = 0;
            }
            else { throw new ArgumentException(@"Arguments 'from' or 'to' doesn't exist!"); }
        }

        public string[] ToArray()
        {
            if (this.nodes == null) { throw new NullReferenceException("Array doesn't exists"); }
            if (this.nodes.Length == 0) { throw new NullReferenceException("Array doesn't contains any graphs"); }

            return nodes;
        }

        public List<string> Way(string from, string to)
        {
            List<string> resultList = new List<string>();
            resultList.Add(from);
            int fromIndex = Array.IndexOf(nodes, from);
            int toIndex = Array.IndexOf(nodes, to);
            List<int> linksFrom = GetLinks(fromIndex);

            bool flag = false;
            if (!linksFrom.Contains(toIndex))
            {
                resultList.AddRange(Find(linksFrom, toIndex, out flag));
            }

            resultList.Add(to);
            return resultList;
        }

        private List<string> Find(List<int> links, int toIndex, out bool flag)
        {
            flag = false;
            List<string> resultList = new List<string>();

            for (int i = 0; i < links.Count; i++)
            {
                List<int> lst = GetLinks(links[i]);
                if (lst.Count != 0)
                {
                    if (!lst.Contains(toIndex))
                    {
                        List<string> List = Find(lst, toIndex, out flag);
                        if (flag)
                        {
                            resultList.Add(this.nodes[links[i]]);
                        }
                        resultList.AddRange(List);
                    }
                    else
                    {
                        flag = true;
                        resultList.Add(this.nodes[links[i]]);
                        break;
                    }
                }
            }

            return resultList;
        }

        private List<int> GetLinks(int fromIndex)
        {
            List<int> linksFrom = new List<int>();

            for (int i = 0; i < links.GetLength(0); i++)
            {
                if (links[fromIndex, i] != 0)
                {
                    linksFrom.Add(i);
                }
            }

            return linksFrom;
        }

        public override string ToString()
        {
            if (this.nodes == null) { throw new NullReferenceException("Array doesn't exists"); }
            if (this.nodes.Length == 0) { throw new InvalidOperationException("Array doesn't contains any graphs"); }

            string result = "";

            foreach (string item in nodes)
            {
                result += item + " \n";
            }

            return result;
        }

        public void OutputConnections()
        {
            for (int i = 0; i < links.GetLength(0); i++)
            {
                for (int j = 0; j < links.GetLength(1); j++)
                {
                    if (links[i, j] != 0)
                    {
                        Console.WriteLine(i + " -> " + j);
                    }
                }
            }
        }
    }
}
