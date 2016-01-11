using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class LListR : IArrays
    {
        Node RootNode;

        /// <summary>
        /// Constructor with parameters
        /// init from int[] arr
        /// </summary>
        /// <param name="array">init source</param>
        public LListR(int[] array)
        {
            if (array == null)
            {
                throw new ArgumentException();
            }

            this.Init(array);
        }

        /// <summary>
        /// Constructor
        /// </summary>
        public LListR()
        {

        }
        /// <summary>
        /// Get length of LList
        /// </summary>
        public int Size
        {
            get
            {
                try
                {
                    int count = 1;
                    Node tempNode = RootNode;

                    while (tempNode.Next != RootNode)
                    {
                        count++;
                        tempNode = tempNode.Next;
                    }

                    return count;
                }
                catch (NullReferenceException)
                {
                    throw;
                }
            }
        }

        public void AddEnd(int value)
        {
            throw new NotImplementedException();
        }

        public void AddPosition(int value, int index)
        {
            throw new NotImplementedException();
        }

        public void AddStart(int value)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public int DeleteEnd()
        {
            throw new NotImplementedException();
        }

        public int DeletePos(int index)
        {
            throw new NotImplementedException();
        }

        public int DeleteStart()
        {
            throw new NotImplementedException();
        }

        public int Get(int index)
        {
            throw new NotImplementedException();
        }

        public void HalfReverse()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// initialise from the array
        /// </summary>
        /// <param name="array"></param>
        public void Init(int[] array)
        {
            if (array.Length == 0)
            {
                throw new ArgumentException();
            }

            RootNode = new Node(array[0]);
            Node outputNode = RootNode;
            Node tempNode;

            for (int i = 1; i < array.Length; i++)
            {
                tempNode = new Node(array[i]);
                outputNode.Next = tempNode;
                outputNode.Next.Prev = outputNode;
                outputNode = tempNode;
                if (array.Length == i + 1)
                {
                    outputNode.Next = RootNode;
                    RootNode.Prev = outputNode;
                }
            }
        }

        /// <summary>
        /// Max value
        /// </summary>
        /// <returns>value</returns>
        public int Max()
        {
            Node tempNode = RootNode;
            int max = tempNode.Value;

            for (int i = 0; i < this.Size; i++)
            {
                if (max < tempNode.Value)
                {
                    max = tempNode.Value;
                }

                tempNode = tempNode.Next;
            }

            return max;
        }

        /// <summary>
        /// Max value index
        /// </summary>
        /// <returns>index</returns>
        public int MaxIndex()
        {
            Node tempNode = RootNode;
            int max = tempNode.Value;
            int maxIndex = 0;

            for (int i = 0; i < this.Size; i++)
            {
                if (max < tempNode.Value)
                {
                    max = tempNode.Value;
                    maxIndex = i;
                }
                tempNode = tempNode.Next;
            }

            return maxIndex;
        }

        /// <summary>
        /// Min value
        /// </summary>
        /// <returns>value</returns>
        public int Min()
        {
            Node tempNode = RootNode;
            int min = tempNode.Value;

            for (int i = 0; i < this.Size; i++)
            {
                if (min > tempNode.Value)
                {
                    min = tempNode.Value;
                }

                tempNode = tempNode.Next;
            }

            return min;
        }

        /// <summary>
        /// Min value index
        /// </summary>
        /// <returns>index</returns>
        public int MinIndex()
        {
            Node tempNode = RootNode;
            int min = tempNode.Value;
            int minIndex = 0;

            for (int i = 0; i < this.Size; i++)
            {
                if (min > tempNode.Value)
                {
                    min = tempNode.Value;
                    minIndex = i;
                }
                tempNode = tempNode.Next;
            }

            return minIndex;
        }

        public void Reverse()
        {
            throw new NotImplementedException();
        }

        public void Set(int value, int index)
        {
            throw new NotImplementedException();
        }

        public void Sort()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// ToArray()
        /// </summary>
        /// <returns>int[]</returns>
        public int[] ToArray()
        {
            if (this.Size == 0)
            {
                throw new NullReferenceException();
            }

            int[] tempArray = new int[this.Size];
            Node tempNode = RootNode;
            tempArray[0] = tempNode.Value;

            for (int i = 1; i < this.Size; i++)
            {
                tempNode = tempNode.Next;
                tempArray[i] = tempNode.Value;
            }

            return tempArray;
        }

        /// <summary>
        /// Override ToString method
        /// </summary>
        /// <returns>string</returns>
        public override string ToString()
        {
            if (this.Size == 0)
            {
                throw new NullReferenceException();
            }

            Node tempNode = RootNode;
            string str = "";

            for (int i = 0; i < this.Size; i++)
            {
                str += tempNode.Value + " ";
                tempNode = tempNode.Next;
            }

            return str;
        }
    }
}
