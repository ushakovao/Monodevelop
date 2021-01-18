using System;
namespace LinkedListFinal
{
    public class ListNode<T>
    {
        public ListNode<T> Next { get; set; }
        public ListNode<T> Prev { get; set; }
        public T Value { get; set; }

    }
}
