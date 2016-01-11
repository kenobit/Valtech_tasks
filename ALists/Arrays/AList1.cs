using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public class AList1 : IArrays
    {
        #region Variable area
        private int[] aList;
        private int lastIndex;
        #endregion

        /// <summary>
        /// Constructor
        /// </summary>
        public AList1()
        {
            aList = new int[10];
            lastIndex = -1;
        }
        /// <summary>
        /// Constructor with parameters
        /// init from int[] arr
        /// </summary>
        /// <param name="arr">init source</param>

        public AList1(int[] array)
        {
            if (array == null)
            {
                throw new ArgumentException();
            }

            lastIndex = -1;
            aList = new int[10];
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

                return lastIndex + 1;
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

            int[] tempArray = new int[lastIndex + 2];
            bool inserted = false;

            for (int i = 0; i < lastIndex + 1; i++)
            {
                tempArray[i] = aList[i];
            }

            aList = new int[tempArray.Length];
            lastIndex++;

            for (int i = 0; i < lastIndex; i++)
            {
                if (i == index)
                {
                    aList[i] = value;
                    inserted = true;
                }

                if (inserted)
                {
                    aList[i + 1] = tempArray[i];
                }
                else
                {
                    aList[i] = tempArray[i];
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

            lastIndex++;
            int[] tempArray = new int[lastIndex + 1];
            tempArray[0] = value;

            for (int i = 1; i < lastIndex + 1; i++)
            {
                tempArray[i] = aList[i - 1];
            }

            for (int i = 0; i < tempArray.Length; i++)
            {
                aList[i] = tempArray[i];
            }
        }

        /// <summary>
        /// Clear aList
        /// </summary>
        public void Clear()
        {
            aList = new int[10];
            lastIndex = -1;
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
            int deleted = aList[index];

            for (int i = 0; i < lastIndex; i++)
            {
                if (i == index)
                {
                    deleted = aList[i];
                    isDeleted = true;
                }

                if (isDeleted)
                {
                    tempArray[i] = aList[i + 1];
                }
                else
                {
                    tempArray[i] = aList[i];
                }
            }

            aList = new int[tempArray.Length];

            for (int i = 0; i < lastIndex; i++)
            {
                aList[i] = tempArray[i];
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

            int deleted = aList[0];

            for (int i = 1; i < lastIndex + 1; i++)
            {
                aList[i - 1] = aList[i];
            }

            aList[lastIndex] = 0;
            lastIndex--;

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

            return aList[index];
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

            int[] tempArray = new int[(lastIndex + 1) / 2];

            for (int i = 0; i < (lastIndex + 1) / 2; i++)
            {
                tempArray[i] = aList[(lastIndex + 1) / 2 - i - 1];
            }

            for (int i = 0; i < (lastIndex + 1) / 2; i++)
            {
                aList[i] = tempArray[i];
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

            lastIndex = array.Length - 1;

            for (int i = 0; i < array.Length; i++)
            {
                aList[i] = array[i];
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

            int result = aList[0];

            for (int i = 0; i < lastIndex + 1; i++)
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

            int result = aList[0];
            int resultI = 0;

            for (int i = 0; i < lastIndex + 1; i++)
            {
                if (result < aList[i])
                {
                    resultI = i;
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

            int result = aList[0];

            for (int i = 0; i < lastIndex + 1; i++)
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

            int result = aList[0];
            int resultI = 0;

            for (int i = 0; i < lastIndex + 1; i++)
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

            int[] tempArray = new int[lastIndex + 1];

            for (int i = 0; i < lastIndex + 1; i++)
            {
                tempArray[i] = aList[lastIndex - i];
            }

            for (int i = 0; i < lastIndex + 1; i++)
            {
                aList[i] = tempArray[i];
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

            aList[index] = value;
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

            for (int i = 0; i < lastIndex + 1; i++)
            {
                for (int j = 0; j < lastIndex + 1; j++)
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

            int[] tempArray = new int[lastIndex + 1];

            for (int i = 0; i < tempArray.Length; i++)
            {
                tempArray[i] = aList[i];
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

            for (int i = 0; i <= lastIndex; i++)
            {
                result += aList[i] + " ";
            }

            return result;
        }
    }
}
