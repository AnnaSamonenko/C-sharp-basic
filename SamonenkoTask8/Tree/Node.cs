using System;

namespace Tree
{
    public class Node<T>
    {
        public Node()
        {
        }

        public Node(T Value)
        {
            this.Value = Value;
        }

        public Node(T Value, Node<T> Parent)
        {
            this.Value = Value;
            this.Parent = Parent;
        }

        public T Value { get; }

        public Node<T> Parent { get; }

        public Node<T> Left { get; set; }

        public Node<T> Right { get; set; }
    }
}