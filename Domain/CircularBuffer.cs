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

        public IEnumerable GetIterator()
        {
            throw new System.NotImplementedException();
        }
    }
}
