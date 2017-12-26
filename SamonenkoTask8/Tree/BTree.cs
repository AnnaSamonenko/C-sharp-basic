using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Runtime.InteropServices;
using System.Runtime.Remoting;
using System.Security.AccessControl;

namespace Tree
{
    public class BTree<T> : ICollection<T>, IEnumerable<T> where T : IComparable<T>
    {
        private Node<T> root;
        private int numberOfNodes;

        public bool IsEmpty
        {
            get { return root == null; }
        }

        public BTree()
        {
            numberOfNodes = 0;
        }

        public BTree(T[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Add(array[i]);
            }
        }

        // for ICollection
        public void Add(T item)
        {
            if (item == null)
            {
                throw new Exception("Item musn't be null");
            }
            if (root == null)
            {
                root = new Node<T>(item);
                ++numberOfNodes;
            }
            else
            {
                Insert(item);
            }
        }

        public void Clear()
        {
            root = null;
        }

        public bool Contains(T item)
        {
            if (IsEmpty)
            {
                return false;
            }
            Node<T> temp = root;
            while (temp != null)
            {
                int comparedValue = temp.Value.CompareTo(item);
                if (comparedValue == 0)
                    return true;
                else if (comparedValue < 0)
                    temp = temp.Left;
                else
                    temp = temp.Right;
            }
            return false;
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public int Count
        {
            get { return numberOfNodes; }
        }

        public bool IsReadOnly
        {
            get { return false; }
        }

        public bool Remove(T item)
        {
            throw new NotImplementedException();
        }

        // for IEnumerable
        public IEnumerator<T> GetEnumerator()
        {
            foreach (Node<T> TempNode in Traversal(root))
            {
                yield return TempNode.Value;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            foreach (Node<T> TempNode in Traversal(root))
            {
                yield return TempNode.Value;
            }
        }

        // private functions
        private void Insert(T item)
        {
            Node<T> temp = root;
            while (true)
            {
                int comparedValue = temp.Value.CompareTo(item);
                if (comparedValue < 0)
                {
                    if (temp.Left == null)
                    {
                        temp.Left = new Node<T>(item, temp);
                        ++numberOfNodes;
                        return;
                    }
                    else
                    {
                        temp = temp.Left;
                    }
                }
                else if (comparedValue > 0)
                {
                    if (temp.Right == null)
                    {
                        temp.Right = new Node<T>(item, temp);
                        ++numberOfNodes;
                        return;
                    }
                    else
                    {
                        temp = temp.Right;
                    }
                }
                else
                {
                    return;
                }
            }
        }

        private IEnumerable<Node<T>> Traversal(Node<T> Node)
        {
            if (Node.Left != null)
            {
                foreach (Node<T> LeftNode in Traversal(Node.Left))
                    yield return LeftNode;
            }
            yield return Node;
            if (Node.Right != null)
            {
                foreach (Node<T> RightNode in Traversal(Node.Right))
                    yield return RightNode;
            }
        }
    }
}