using System.Collections;
using System.Collections.Generic;

namespace CSHARP.Iterator
{
    public class GenericIterator : IEnumerable<int>
    {
        public IEnumerator<int> GetEnumerator()
        {
            return new CountingEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
    class CountingEnumerator : IEnumerator<int>
    {
        int current = -1;
        public bool MoveNext(){
            current++;
            return current<10;
        }
        public int Current { get { return current; }}
        object IEnumerator.Current { get { return Current; }}
        
        public void Reset(){
            current = -1;
        }
        public void Dispose(){}
    }
}