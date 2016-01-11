using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public class AList2 : IArrays
    {
        #region Variable area
        private int firstIndex;
        private int lastIndex;
        private int[] aList;
        #endregion

        /// <summary>
        /// Constructor
        /// </summary>
        public AList2()
        {
            aList = new int[30];
        }

        public AList2(int[] array)
        {
            if (array == null)
            {
                throw new ArgumentException();
            }

            firstIndex = 15;
            lastIndex = 15;
            aList = new int[30];
            this.Init(array);
        }

        /// <summary>
        /// Get length of aList
        /// </summary>
        public int Size
        {
            get
            {

                if (this.aList == null)
                {
                    throw new NullReferenceException();
                }

                return lastIndex - firstIndex + 1;
            }
        }

        /// <summary>
        /// Add value in end position
        /// </summary>
        /// <param name="value"> int variable</param>
        public void AddEnd(int value)
        {
            if (this.aList == null)
            {
                throw new NullReferenceException();
            }

            aList[lastIndex + 1] = value;
            lastIndex++;
        }

        /// <summary>
        /// Add value in the index position
        /// </summary>
        /// <param name="value"> int variable</param>
        /// <param name="index"> position</param>
        public void AddPosition(int value, int index)
        {
            if (this.aList == null)
            {
                throw new NullReferenceException();
            }

            if (index < 0 || index >= this.Size)
            {
                throw new ArgumentException();
            }

            int[] tempArray = new int[lastIndex + 1];
            bool inserted = false;

            for (int i = firstIndex; i < lastIndex + 1; i++)
            {
                tempArray[i - firstIndex] = aList[i];
            }

            lastIndex++;

            for (int i = firstIndex; i < lastIndex; i++)
            {
                if (i == index + firstIndex)
                {
                    aList[i] = value;
                    inserted = true;
                }

                if (inserted)
                {
                    aList[i + 1] = tempArray[i - firstIndex];
                }
                else
                {
                    aList[i] = tempArray[i - firstIndex];
                }
            }
        }

        /// <summary>
        /// Add value in the start position
        /// </summary>
        /// <param name="value"></param>
        public void AddStart(int value)
        {
            if (this.aList == null)
            {
                throw new NullReferenceException();
            }

            aList[--firstIndex] = value;
        }

        /// <summary>
        /// Clear aList
        /// </summary>
        public void Clear()
        {
            aList = new int[30];
            firstIndex = 15;
            lastIndex = 15;
        }

        /// <summary>
        /// Delete value from the end position
        /// </summary>
        /// <returns></returns>
        public int DeleteEnd()
        {
            if (this.aList == null)
            {
                throw new NullReferenceException();
            }

            int deleted = aList[lastIndex];
            aList[lastIndex] = 0;
            lastIndex--;

            return deleted;
        }

        /// <summary>
        /// Delete value from the index position
        /// </summary>
        /// <param name="index"></param>
        /// <returns>deleted value</returns>
        public int DeletePos(int index)
        {
            if (this.aList == null)
            {
                throw new NullReferenceException();
            }

            if (index < 0 || index >= this.Size)
            {
                throw new ArgumentException();
            }

            int[] tempArray = new int[lastIndex];
            bool isDeleted = false;
            int deleted = aList[index + firstIndex];

            for (int i = firstIndex; i < lastIndex; i++)
            {
                if (i == index + firstIndex)
                {
                    isDeleted = true;
                }

                if (isDeleted)
                {
                    tempArray[i - firstIndex] = aList[i + 1];
                }
                else
                {
                    tempArray[i - firstIndex] = aList[i];
                }
            }

            aList = new int[tempArray.Length];

            for (int i = firstIndex; i < lastIndex; i++)
            {
                aList[i] = tempArray[i - firstIndex];
            }
            lastIndex--;

            return deleted;
        }

        /// <summary>
        /// Delete value from the start position
        /// </summary>
        /// <returns></returns>
        public int DeleteStart()
        {
            if (this.aList == null)
            {
                throw new NullReferenceException();
            }

            int deleted = aList[firstIndex];
            aList[firstIndex] = 0;
            firstIndex++;

            return deleted;
        }

        /// <summary>
        /// Get value from the index position
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public int Get(int index)
        {
            if (this.aList == null)
            {
                throw new NullReferenceException();
            }

            if (index < 0 || index >= this.Size)
            {
                throw new ArgumentException();
            }

            return aList[firstIndex + index];
        }

        /// <summary>
        /// Half reverse 
        /// </summary>
        public void HalfReverse()
        {
            if (this.aList == null)
            {
                throw new NullReferenceException();
            }

            int[] tempArray = new int[this.Size / 2];

            for (int i = 0; i < this.Size / 2; i++)
            {
                tempArray[i] = aList[this.Size / 2 - i + firstIndex - 1];
            }

            for (int i = firstIndex; i < (this.Size / 2) + firstIndex; i++)
            {
                aList[i] = tempArray[i - firstIndex];
            }
        }

        /// <summary>
        /// initialise from the array
        /// </summary>
        /// <param name="array"></param>
        public void Init(int[] array)
        {
            if (array == null)
            {
                throw new ArgumentException();
            }

            firstIndex = 15;
            lastIndex = 15;
            int half = array.Length / 2;
            firstIndex -= half;
            lastIndex = firstIndex + array.Length - 1;

            for (int i = firstIndex; i < lastIndex + 1; i++)
            {
                aList[i] = array[i - firstIndex];
            }
        }

        /// <summary>
        /// Max value
        /// </summary>
        /// <returns>value</returns>
        public int Max()
        {
            if (this.aList == null)
            {
                throw new NullReferenceException();
            }

            int result = aList[firstIndex];

            for (int i = firstIndex; i < lastIndex + 1; i++)
            {
                if (result < aList[i])
                {
                    result = aList[i];
                }
            }

            return result;
        }

        /// <summary>
        /// Max value
        /// </summary>
        /// <returns>index</returns>
        public int MaxIndex()
        {
            if (this.aList == null)
            {
                throw new NullReferenceException();
            }

            int result = aList[firstIndex];
            int resultI = 0;

            for (int i = firstIndex; i < lastIndex + 1; i++)
            {
                if (result < aList[i])
                {
                    resultI = i - firstIndex;
                    result = aList[i];
                }
            }

            return resultI;
        }

        /// <summary>
        /// Min value
        /// </summary>
        /// <returns>value</returns>
        public int Min()
        {
            if (this.aList == null)
            {
                throw new NullReferenceException();
            }

            int result = aList[firstIndex];

            for (int i = firstIndex; i < lastIndex + 1; i++)
            {
                if (result > aList[i])
                {
                    result = aList[i];
                }
            }

            return result;
        }

        /// <summary>
        /// Min value 
        /// </summary>
        /// <returns>index</returns>
        public int MinIndex()
        {
            if (this.aList == null)
            {
                throw new NullReferenceException();
            }

            int result = aList[firstIndex];
            int resultI = 0;

            for (int i = firstIndex; i < lastIndex + 1; i++)
            {
                if (result > aList[i])
                {
                    resultI = i;
                    result = aList[i];
                }
            }

            return resultI;
        }

        /// <summary>
        /// Reverse values
        /// </summary>
        public void Reverse()
        {
            if (this.aList == null)
            {
                throw new NullReferenceException();
            }

            int[] tempArray = new int[this.Size];

            for (int i = 0; i < this.Size; i++)
            {
                tempArray[i] = aList[lastIndex - i];
            }

            for (int i = firstIndex; i < lastIndex + 1; i++)
            {
                aList[i] = tempArray[i - firstIndex];
            }
        }

        /// <summary>
        /// Set value in the index position
        /// </summary>
        /// <param name="value"></param>
        /// <param name="index"></param>
        public void Set(int value, int index)
        {
            if (this.aList == null)
            {
                throw new NullReferenceException();
            }

            if (index < 0 || index >= this.Size)
            {
                throw new ArgumentException();
            }

            aList[firstIndex + index] = value;
        }

        /// <summary>
        /// Bubble sort
        /// </summary>
        public void Sort()
        {
            if (this.aList == null)
            {
                throw new NullReferenceException();
            }

            int tempValue = 0;

            for (int i = firstIndex; i < lastIndex + 1; i++)
            {
                for (int j = firstIndex; j < lastIndex + 1; j++)
                {
                    if (aList[i] < aList[j])
                    {
                        tempValue = aList[i];
                        aList[i] = aList[j];
                        aList[j] = tempValue;
                    }
                }
            }
        }

        /// <summary>
        /// ToArray()
        /// </summary>
        /// <returns>int[]</returns>
        public int[] ToArray()
        {
            if (this.aList == null)
            {
                throw new NullReferenceException();
            }

            int[] tempArray = new int[this.Size];

            for (int i = firstIndex; i < lastIndex + 1; i++)
            {
                tempArray[i - firstIndex] = aList[i];
            }

            return tempArray;
        }

        public override string ToString()
        {
            if (this.aList == null)
            {
                throw new NullReferenceException();
            }

            string result = "";

            for (int i = firstIndex; i < lastIndex + 1; i++)
            {
                result += aList[i] + " ";
            }

            return result;
        }
    }
}
