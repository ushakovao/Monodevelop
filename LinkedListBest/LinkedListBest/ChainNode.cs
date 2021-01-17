using System;
namespace LinkedListBest
{
    public class ChainNode<T>
    {
        public ChainNode<T> Next { get; set; }
        public ChainNode<T> Prev { get; set; }
        public T Value { get; set; }


    }
}
