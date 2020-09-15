using System;
using System.Collections;
using System.Collections.Generic;

namespace Domain
{
    public class CircularBuffer<T>
    {

        T _value;
        private int _defaultsize = 7;

        public T[] buffer { get; }
        public int size { get; }

        public CircularBuffer()
        {
            this.size = _defaultsize;
            throw new NotImplementedException();
        }

        public CircularBuffer(int size)
        {
            this.size = size;
            throw new NotImplementedException();
        }

        public void AddtoBuffer(char x)
        {
            throw new NotImplementedException();
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
