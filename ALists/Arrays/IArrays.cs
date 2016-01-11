using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    interface IArrays
    {
        void Clear();
        void Init(int[] array);
        int[] ToArray();
        void AddStart(int value);
        void AddEnd(int value);
        void AddPosition(int value, int index);
        int DeleteStart();
        int DeleteEnd();
        int DeletePos(int index);
        int Min();
        int Max();
        int MinIndex();
        int MaxIndex();
        void Reverse();
        void HalfReverse();
        void Set(int value, int index);
        int Get(int index);
        void Sort();

    }
}
