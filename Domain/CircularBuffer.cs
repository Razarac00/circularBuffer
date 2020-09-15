using System;
using System.Collections;
using System.Collections.Generic;

namespace Domain
{
    public class CircularBuffer<T>
    {

        private int _defaultsize = 7;
        private int _defaultMinSize = 1;
        private int _defaultMaxSize = 1000000;

        private int current = 0;
        private int oldest = 0;

        public T[] buffer { get; private set; }
        public int size { get; private set; }

        public CircularBuffer()
        {
            this.size = _defaultsize;
            buffer = new T[this.size];
        }

        public CircularBuffer(int size)
        {
            if (size < _defaultMinSize || size > _defaultMaxSize) 
            {
                throw new IndexOutOfRangeException();
            }

            this.size = size;
            buffer = new T[this.size];
        }

        public void AddtoBuffer(T t)
        {
            buffer[current] = t;
        }

        public char ReadfromBuffer()
        {
            throw new NotImplementedException();
        }

        public IEnumerator GetEnumerator() 
        {
            throw new System.NotImplementedException();
        }
        // to implement foreach, we need a public definition of GetEnumerator
        // We need a class that implements the IEnumerator interface, which means implementing IEnumerator.Current, MoveNext(), Reset()
    }
}
