using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public class LList2 : IArrays
    {
        private Node RootNode;

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

                    while (tempNode.Next != null)
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
        public Node LastNode
        {
            get
            {
                try
                {
                    Node temp = RootNode;
                    Node last = new Node();
                    while (temp != null)
                    {
                        if (temp.Next == null)
                        {
                            last = temp;
                            break;
                        }
                        temp = temp.Next;
                    }
                    return last;
                }
                catch (NullReferenceException)
                {
                    throw;
                }
            }
        }
        /// <summary>
        /// Constructor with parameters
        /// init from int[] arr
        /// </summary>
        /// <param name="array">init source</param>
        public LList2(int[] array)
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
        public LList2()
        {

        }

        /// <summary>
        /// Add value in end position
        /// </summary>
        /// <param name="value"> int variable</param>
        public void AddEnd(int value)
        {

            Node currentNode = RootNode;
            int size = this.Size;

            for (int i = 0; i < size; i++)
            {
                if (size == i + 1)
                {
                    currentNode.Next = new Node(value);
                    currentNode.Next.Prev = currentNode;
                }
                currentNode = currentNode.Next;
            }
        }

        /// <summary>
        /// Add value in the index position
        /// </summary>
        /// <param name="value"> int variable</param>
        /// <param name="index"> position</param>
        public void AddPosition(int value, int index)
        {
            if (this.Size <= index)
            {
                throw new IndexOutOfRangeException();
            }

            Node currentNode = RootNode;
            //Node prevLink;
            for (int i = 0; i < this.Size; i++)
            {
                if (index - 1 == i)
                {
                    Node positionNode = new Node(value, currentNode, currentNode.Next);
                    positionNode.Prev = currentNode;
                    currentNode.Next = positionNode;
                }
                else
                {
                    currentNode = currentNode.Next;
                }
            }
        }

        /// <summary>
        /// Add value in the start position
        /// </summary>
        /// <param name="value"></param>
        public void AddStart(int value)
        {
            Node tempNode = new Node(value, RootNode);
            this.RootNode.Prev = tempNode;
            this.RootNode = tempNode;
        }

        /// <summary>
        /// Clear LList
        /// </summary>
        public void Clear()
        {
            this.RootNode = new Node();
        }

        /// <summary>
        /// Delete value from the end position
        /// </summary>
        /// <returns></returns>
        public int DeleteEnd()
        {
            Node tempNode = RootNode;
            int res = 0;

            for (int i = 0; i < this.Size; i++)
            {
                if (this.Size == i + 2)
                {
                    res = tempNode.Next.Value;
                    tempNode.Next = null;
                    break;
                }
                else
                {
                    tempNode = tempNode.Next;
                }
            }

            return res;
        }

        /// <summary>
        /// Delete value from the index position
        /// </summary>
        /// <param name="index"></param>
        /// <returns>deleted value</returns>
        public int DeletePos(int index)
        {
            if (this.Size <= index || index < 0)
            {
                throw new IndexOutOfRangeException();
            }

            int res = 0;

            if (index != 0)
            {
                Node tempNode = RootNode;

                for (int i = 0; i < this.Size; i++)
                {
                    if (i == index - 1)
                    {
                        res = tempNode.Next.Value;
                        tempNode.Next = tempNode.Next.Next;
                        break;
                    }
                    else
                    {
                        tempNode = tempNode.Next;
                    }
                }
            }
            else
            {
                res = this.DeleteStart();
            }

            return res;
        }

        /// <summary>
        /// Delete value from the start position
        /// </summary>
        /// <returns></returns>
        public int DeleteStart()
        {
            int res = RootNode.Value;
            RootNode = RootNode.Next;
            return res;
        }

        /// <summary>
        /// Get value from the index position
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public int Get(int index)
        {
            if (this.Size <= index)
            {
                throw new IndexOutOfRangeException();
            }

            Node tempNode = RootNode;
            int res = 0;

            for (int i = 0; i < this.Size; i++)
            {
                if (index == i)
                {
                    res = tempNode.Value;
                }

                tempNode = tempNode.Next;
            }

            return res;
        }

        /// <summary>
        /// Half reverse 
        /// </summary>
        public void HalfReverse() // NOT IMPLEMENTED
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
                    tempNode = outputNode;
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

        /// <summary>
        /// Reverse values
        /// </summary>
        public void Reverse()
        {
            Node temp = RootNode;
            bool flag = true;

            while (flag)
            {
                Node next = temp.Next;
                Node prev = temp.Prev;
                temp.Next = prev;
                temp.Prev = next;

                if (next != null)
                {
                    temp = next;
                }
                else
                {
                    flag = false;
                }
            }
            RootNode = temp;
        }

        /// <summary>
        /// Set value in the index position
        /// </summary>
        /// <param name="value"></param>
        /// <param name="index"></param>
        public void Set(int value, int index)
        {
            if (this.Size <= index)
            {
                throw new IndexOutOfRangeException();
            }

            Node tempNode = RootNode;

            for (int i = 0; i < this.Size; i++)
            {
                if (index == i)
                {
                    tempNode.Value = value;
                }
                tempNode = tempNode.Next;
            }
        }

        /// <summary>
        /// Bubble sort
        /// </summary>
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
