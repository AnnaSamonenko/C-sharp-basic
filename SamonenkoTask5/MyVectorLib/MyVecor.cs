using System;

namespace MyVectorLib
{
    public class MyVector
    {
        private int[] _vector;
        public int StartIndex;
        public int EndIndex;
        public int Length;

        public MyVector(int startIndex, int size)
        {
            StartIndex = startIndex;
            EndIndex = startIndex + size;
            Length = size;
            _vector = new int[Length];
        }

        public int this[int newIndex]
        {
            get { return _vector[newIndex - StartIndex]; }

            set { _vector[newIndex - StartIndex] = value; }
        }
    }
}