using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public class AList0 : IArrays
    {
        #region Variable area
        private int[] aList;
        #endregion

        /// <summary>
        /// Constructor
        /// </summary>
        public AList0()
        {
            this.aList = new int[0];
        }

        /// <summary>
        /// Constructor with parameters
        /// init from int[] arr
        /// </summary>
        /// <param name="array">init source</param>
        public AList0(int[] array)
        {
            if (array == null)
            {
                throw new ArgumentNullException();
            }

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

                return this.aList.Length;
            }
        }

        /// <summary>
        /// Add value in end position
        /// </summary>
        /// <param name="value"> int variable</param>
        public void AddEnd(int value)
        {
            int[] tempArray = new int[aList.Length + 1];

            for (int i = 0; i < aList.Length; i++)
            {
                tempArray[i] = aList[i];
            }

            aList = new int[tempArray.Length];

            for (int i = 0; i < aList.Length; i++)
            {
                aList[i] = tempArray[i];
            }

            aList[aList.Length - 1] = value;
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

            if (index < 0)
            {
                throw new ArgumentException();
            }

            int[] tempArray = new int[aList.Length + 1];
            bool inserted = false;

            for (int i = 0; i < aList.Length; i++)
            {
                tempArray[i] = aList[i];
            }

            aList = new int[tempArray.Length];

            for (int i = 0; i < aList.Length - 1; i++)
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
            int[] tempArray = new int[aList.Length + 1];

            for (int i = 0; i < aList.Length; i++)
            {
                tempArray[i] = aList[i];
            }

            aList = new int[tempArray.Length];
            aList[0] = value;

            for (int i = 0; i < aList.Length - 1; i++)
            {
                aList[i + 1] = tempArray[i];
            }
        }

        /// <summary>
        /// Clear aList
        /// </summary>
        public void Clear()
        {
            this.aList = new int[0];
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

            int deleted = 0;
            deleted = aList[aList.Length - 1];
            int[] tempArray = new int[aList.Length - 1];

            for (int i = 0; i < tempArray.Length; i++)
            {
                tempArray[i] = aList[i];
            }

            aList = new int[tempArray.Length];

            for (int i = 0; i < aList.Length; i++)
            {
                aList[i] = tempArray[i];
            }

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

            int[] tempArray = new int[aList.Length - 1];
            bool isDeleted = false;
            int deleted = aList[index];

            for (int i = 0; i < aList.Length - 1; i++)
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

            for (int i = 0; i < aList.Length; i++)
            {
                aList[i] = tempArray[i];
            }

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

            int deleted = 0;
            deleted = aList[0];
            int[] tempArray = new int[aList.Length - 1];

            for (int i = 0; i < tempArray.Length; i++)
            {
                tempArray[i] = aList[i + 1];
            }

            aList = new int[tempArray.Length];

            for (int i = 0; i < aList.Length; i++)
            {
                aList[i] = tempArray[i];
            }

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

            return this.aList[index];
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

            int[] tempArray = new int[aList.Length / 2];

            for (int i = 0; i < aList.Length / 2; i++)
            {
                tempArray[i] = aList[aList.Length / 2 - i - 1];
            }

            for (int i = 0; i < aList.Length / 2; i++)
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

            aList = new int[array.Length];

            for (int i = 0; i < aList.Length; i++)
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

            for (int i = 0; i < aList.Length; i++)
            {
                if (aList[i] > result)
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

            int result = 0; ;
            int tempVal = aList[0];

            for (int i = 0; i < aList.Length; i++)
            {
                if (aList[i] > tempVal)
                {
                    tempVal = aList[i];
                    result = i;
                }
            }

            return result;
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

            for (int i = 0; i < aList.Length; i++)
            {
                if (aList[i] < result)
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

            int result = 0; ;
            int tempVal = aList[0];

            for (int i = 0; i < aList.Length; i++)
            {
                if (aList[i] < tempVal)
                {
                    tempVal = aList[i];
                    result = i;
                }
            }

            return result;
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

            int[] tempArray = new int[aList.Length];

            for (int i = 0; i < aList.Length; i++)
            {
                tempArray[i] = aList[aList.Length - i - 1];
            }

            for (int i = 0; i < aList.Length; i++)
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

            this.aList[index] = value;
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

            for (int i = 0; i < aList.Length; i++)
            {
                for (int j = 0; j < aList.Length; j++)
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

            return this.aList;
        }

        /// <summary>
        /// Override ToString method
        /// </summary>
        /// <returns>string</returns>
        public override string ToString()
        {
            if (this.aList == null)
            {
                throw new NullReferenceException();
            }

            string str = "";

            foreach (int item in this.aList)
            {
                str += item + " ";
            }

            return str;
        }
    }
}