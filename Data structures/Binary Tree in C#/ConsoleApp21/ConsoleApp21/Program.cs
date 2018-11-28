using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21
{
    class Node<T>
    {
        public T value;
        public int Height;
        public Node<T> Right;
        public Node<T> Left;
        public Node(T value)
        {
            this.value = value;
            Right = null;
            Left = null;
        }
    }
    class BinarySearchTree<T> where T : IComparable
    {
        public Node<T> root;

        public BinarySearchTree()
        {
            root = null;
        }

        public bool Search(T value)
        {
            return SearchRec(value, root);
        }        

        private bool SearchRec(T value, Node<T> root)
        {
            if (root == null)
                return false;
            if (root.value.Equals(value))
                return true;
            else if (root.value.CompareTo(value) > 0)
                return SearchRec(value, root.Left);
            else
                return SearchRec(value, root.Right);
        }

        public Node<T> Add(T value)
        {
            return AddRec(value, root);
        }

        private Node<T> AddRec(T value, Node<T> root)
        {
            if (root == null)
            {
                root = new Node<T>(value);
                return root;
            }
            else if (value.CompareTo(root.value) > 0)
                return AddRec(value, root.Right);
            else if (value.CompareTo(root.value) <= 0)
                return AddRec(value, root.Left);

            return root;
        }
        
        private Node<T> ReplaceWithSmallest(Node<T> rootReplace, Node<T> rootSmallest) // rootReplace - what to replace, rootSmallest - its right child.
        {
            if (rootSmallest.Left != null)
            {
                return ReplaceWithSmallest(rootReplace, rootSmallest.Left);
            }
            else
            {
                rootSmallest.Left = rootReplace.Left;
                rootSmallest.Right = rootReplace.Right;
                rootReplace = rootSmallest;
                rootSmallest = null;
                return rootReplace;
            }
        }

        public Node<T> Remove(Node<T> root, Node<T> ParentElem, T value)
        {
            if (root.value.CompareTo(value) == 0) // the element has been found
            {
                if (root.Left != null && root.Right != null)
                    return ReplaceWithSmallest(root, root.Right); // replace current root element with the element that this function is going to find (second parameter)
                else if (root.Left != null && root.Right == null) // if there's 1 child there
                {
                    if (ParentElem.Left.Equals(root)) // if our element is its parent's left son
                        ParentElem.Left = root.Left; 
                    else
                        ParentElem.Right = root.Left;
                }
                else if (root.Left == null && root.Right != null)
                {
                    if (ParentElem.Left.Equals(root))
                        ParentElem.Left = root.Right;
                    else
                        ParentElem.Right = root.Right;
                }
                else if (root.Left == null && root.Right == null)
                    root = null;
            }
            else if (value.CompareTo(root.value) > 0) // if the value we're looking for is bigger than current element
            {
                return Remove(root.Right, root, value);     // then go to its right child
            }
            else if (value.CompareTo(root.value) < 0)
            {
                return Remove(root.Left, root, value); // otherwise go to its left child
            }
            return root;
        }
    }

    class IntBinarySearchTree : BinarySearchTree<int>
    {

    }
    class Program
    {
        static void Main(string[] args)
        {
            IntBinarySearchTree A = new IntBinarySearchTree();
            A.Add(12);
            Console.WriteLine(A.root.value);
            A.Add(11);
            Console.WriteLine(A.root.value);
            A.Add(45);
            A.Add(13);
            A.Add(55);

            
            //Console.WriteLine(A.root.value);
            Console.WriteLine(A.root.Left.value);
            Console.WriteLine(A.root.Right.value);



            Console.ReadKey();
            A.Search(50);
        }
    }
}
