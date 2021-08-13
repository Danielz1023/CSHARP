using System;

namespace CSHARP.Constructor
{
    public class Parameterless
    {
        /*
        VALID
            class Sample<T> where T : class, IDisposable, new()
            class Sample<T> where T : struct, IDisposable
            class Sample<T,U> where T: class where U : struct, T
            class Sample<T,U> where T: Stream where U : IDisposable
        INVALID
            class Sample<T> where T : class, struct
            class Sample<T> where T : Stream, class
            class Sample<T> where T: new(), Stream
            class Sample<T,U> where T : struct where U: class, T
        */
        public T CreateInstance<T>() where T :new()
        {
            return new T();
        }
        static int CompareToDefault<T>(T value) where T : IComparable<T>
        {
            return value.CompareTo(default(T));
        }
    }
}