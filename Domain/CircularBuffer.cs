using System;
using System.Collections;
using System.Collections.Generic;

namespace Domain
{
    public class CircularBuffer<T>
    {

        T _value;
        //private Array<T> dafsd;

        public List<T> buffer { get; }

        public CircularBuffer(T t)
        {
            this.size = 7;
            throw new NotImplementedException();
        }

        public CircularBuffer(T t, int size)
        {
            this._value = t;
            this.size = size;
            throw new NotImplementedException();
        }

        public int size { get; }

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
