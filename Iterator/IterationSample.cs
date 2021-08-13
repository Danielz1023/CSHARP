using System.Collections;

namespace CSHARP.Iterator
{
    public class IterationSample : IEnumerable
    {
        object[] values;
        int startingPoint;

        public IterationSample(object[] values, int startingPoint){
            this.values = values;
            this.startingPoint = startingPoint;
        }
        public IEnumerator GetEnumerator()
        {
            throw new System.NotImplementedException();
        }
    }
}