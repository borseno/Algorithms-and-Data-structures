using System;

namespace ConsoleApp21
{
    class Node<T>
    {
        internal T value;

        public override string ToString()
        {
            return value.ToString();
        }

        public bool IsBalanced()
        {
            return Math.Abs(Balance) == 0 || Math.Abs(Balance) == 1;
        }

        public int Balance
        {
            get
            {
                if (Left == null && Right == null)
                    return 0;
                else if (Left == null && Right != null)
                    return -1 - Right.Height;
                else if (Left != null && Right == null)
                    return Left.Height + 1;
                return (Left.Height - Right.Height);
            }
        }
        public int Height
        {
            get
            {
                if (Left == null && Right != null)
                    return 1 + Right.Height;
                else if (Left != null && Right == null)
                    return 1 + Left.Height;
                else if (Left != null && Right != null)
                {
                    if (Left.Height >= Right.Height)
                        return Left.Height + 1;
                    else
                        return Right.Height + 1;
                }
                else
                    return 0;
            }
        }

        public Node<T> Right;
        public Node<T> Left;
        public Node(T value)
        {
            this.value = value;
            Right = null;
            Left = null;
        }
        
        public Node(Node<T> other) // deep copy
        {
            value = other.value;
            
            if (other.Left == null)
                Left = null;
            else
                Left = new Node<T>(other.Left);
            if (other.Right == null)
                Right = null;
            else
                Right = new Node<T>(other.Right);
        }

    }
    class BinarySearchTree<T> where T : IComparable
    {
        public Node<T> root;

        public Node<T> Root { get { return root; } set { } }

        public bool IsTreeBalanced()
        {
            return Math.Abs(root.Balance) == 0 || Math.Abs(root.Balance) == 1;
        }

        public bool IsEmpty()
        {
            return root == null;
        }

        public void InOrder()
        {
            Console.WriteLine("\n");
            TraversalRec(root);
        }

        public void RotateLeftRight(ref Node<T> root)
        {
            // Double right rotating - Left Right   
            // 1. perform a left rotation on the left subtree
            // 2. rotate the root to the right

            RotateLeft(ref root.Left);
            RotateRight(ref root);
        }

        public void RotateRightLeft(ref Node<T> root)
        {
            // Double left rotation - Right Left
            // 1. perform a right rotation on the right subtree
            // 2. rotate the root to the left

            RotateRight(ref root.Right);
            RotateLeft(ref root);
        }
        
        public void RotateRight(ref Node<T> root)
        {
            // 1. new root = old root.Left
            // 2. old root.Left = null; old root.Left = old root.Left.Right
            // 3. new root.Right = old root;

            Node<T> newRoot = new Node<T>(root.Left);
            root.Left = root.Left.Right;
            newRoot.Right = new Node<T>(root);
            root = newRoot;
            
        }

        public void RotateLeft(ref Node<T> root)
        {
            // 1. new root = old root.Right
            // 2. old root.Right = null; old root.Right = old root.Right.Left
            // 3. new root.Left = old root;

            Node<T> newRoot = new Node<T>(root.Right);
            root.Right = root.Right.Left;
            newRoot.Left = new Node<T>(root);
            root = newRoot;
        }

        private void TraversalRec(Node<T> root) // not done yet
        {
            if (root.Left != null)
            {
                TraversalRec(root.Left);
            }
            Console.Write(root.value + " ");
            if (root.Right != null)
            {
                TraversalRec(root.Right);
            }
        }

        public Node<T> Search(T value)
        {
            return SearchRec(value, root);
        }        

        private Node<T> SearchRec(T value, Node<T> root)
        {
            if (root == null)
                return null;
            if (root.value.Equals(value))
                return root;
            else if (root.value.CompareTo(value) > 0)
                return SearchRec(value, root.Left);
            else
                return SearchRec(value, root.Right);
        }

        public bool PreOrder()
        {
            Console.WriteLine(PreOrderRec(root));
            return true;
        }

        private bool PreOrderRec(Node<T> root)
        {
            Console.Write(root + " ");
            if (root.Left != null)
                PreOrderRec(root.Left);
            if (root.Right != null)
                PreOrderRec(root.Right);

            return true;
        }

        public bool Add(T value)
        {
            return AddRec(value, ref root);
        }

        private bool AddRec(T value, ref Node<T> root)
        {
            if (root == null)
            {
                root = new Node<T>(value);
                return true;
            }
            else if (value.CompareTo(root.value) > 0)
            {
                AddRec(value, ref root.Right);
                if (!root.IsBalanced())
                    Rebalance(ref root);
            }
            else if (value.CompareTo(root.value) <= 0)
            {
                AddRec(value, ref root.Left);
                if (!root.IsBalanced())
                    Rebalance(ref root);
            }

            return false;
        }

        private void Rebalance(ref Node<T> root)
        {
            int LeftHeight;
            int RightHeight;

            if (root.Left == null)
                LeftHeight = -1;
            else
                LeftHeight = root.Left.Height;

            if (root.Right == null)
                RightHeight = -1;
            else
                RightHeight = root.Right.Height;


            if (LeftHeight > RightHeight) // left case
            {
                int LeftLeftHeight;
                int LeftRightHeight;

                if (root.Left.Left == null)
                    LeftLeftHeight = -1;
                else
                    LeftLeftHeight = root.Left.Left.Height;

                if (root.Left.Right == null)
                    LeftRightHeight = -1;
                else
                    LeftRightHeight = root.Left.Right.Height;


                if (LeftLeftHeight > LeftRightHeight) // left left case
                {
                    RotateRight(ref root);
                }
                else // left right case
                {   
                    RotateLeftRight(ref root);
                }
            }
            else // right case
            {
                int RightRightHeight;
                int RightLeftHeight;

                if (root.Right.Right == null)
                    RightRightHeight = -1;
                else
                    RightRightHeight = root.Right.Right.Height;

                if (root.Right.Left == null)
                    RightLeftHeight = -1;
                else
                    RightLeftHeight = root.Right.Left.Height;


                if (RightRightHeight >= RightLeftHeight) // right right case
                {
                    RotateLeft(ref root);
                }
                else // right left case
                {
                    RotateRightLeft(ref root);
                }
            }
        }

        private void ReplaceWithSmallest(ref Node<T> rootReplace, ref Node<T> rootSmallest) // rootReplace - what to replace, rootSmallest - its right child.
        {
            if (rootSmallest.Left != null)
            {
                ReplaceWithSmallest(ref rootReplace, ref rootSmallest.Left);
                //if (!rootSmallest.IsBalanced())
                    //Rebalance(ref rootSmallest);
            }
            else
            {
                Node<T> newroot = new Node<T>(rootSmallest);
                rootSmallest = rootSmallest.Right;
                newroot.Right = rootReplace.Right;
                newroot.Left = rootReplace.Left;
                rootReplace = newroot;
            } 
        }

        public void Remove(T value)
        {
            RemoveRec(ref root, ref root, value);
        }

        private void RemoveRec(ref Node<T> root, ref Node<T> ParentElem, T value)
        {
            if (root.value.CompareTo(value) == 0) // the element has been found
            {
                if (root.Left != null && root.Right != null)
                {
                    ReplaceWithSmallest(ref root, ref root.Right); // replace current root element with the element that this function is going to find (second parameter)
                    if (!root.Right.IsBalanced())
						Rebalance(ref root.Right);
                }
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
                RemoveRec(ref root.Right, ref root, value);     // then go to its right child
                if (!root.IsBalanced())
                    Rebalance(ref root);
            }
            else if (value.CompareTo(root.value) < 0)
            {
                RemoveRec(ref root.Left, ref root, value); // otherwise go to its left child
                if (!root.IsBalanced())
                    Rebalance(ref root);
            }
        }

    }

    class IntBinarySearchTree : BinarySearchTree<int>
    {

        public int SumAllKeys()
        {
            return SumAllKeysRec(root, 0);
        }

        private int SumAllKeysRec(Node<int> root, int sum)
        {
            if (root.Left != null)
            {
                sum = SumAllKeysRec(root.Left, sum);
            }
            if (root.Right != null)
            {   
                sum = SumAllKeysRec(root.Right, sum + root.Right.value);
            }
            return sum;
        }

        public int SumKeys()
        {
            int sum = 0;
            for (Node<int> i = root.Right; i != null; i = i.Right)
            {
                sum += i.value;
            }
            return sum;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            IntBinarySearchTree A = new IntBinarySearchTree();
            int[] A_array = { 40, 50, 30, 35, 27, 37 };
            for (int i = 0; i < A_array.Length; i++)
                A.Add(A_array[i]);

            //A.InOrder();
            A.PreOrder();

            //Console.WriteLine(A.SumKeys());
            //Console.WriteLine(A.SumAllKeys());
            
            //Console.WriteLine(A.root.Balance);

            //Console.WriteLine(A.root.Left.Height);
            //Console.WriteLine(A.Root.Right.Height);
















            /*
            // TEST



            // LEFT LEFT = {10, 15, 5, -10, -20} A
            // root.left = -10, root.right = 15, root.left.left = -20, root.left.right = 5

            // LEFT RIGHT = {10, 15, 5, -10, -5} B
            // root.left = -5, root.left.right = 5, root.left.left = -10


            // RIGHT RIGHT = {10, 20, 30, 40, -5} C
            // root.left = -5, root.right = 30, root.right.right = 40, root.right.left = 20

            // RIGHT LEFT = {10, -5, 20, 40, 30} D
            // root.left = -5, root.right = 30, root.right.right = 40, root.right.left = 20

            
            IntBinarySearchTree A = new IntBinarySearchTree();
            IntBinarySearchTree B = new IntBinarySearchTree();
            IntBinarySearchTree C = new IntBinarySearchTree();
            IntBinarySearchTree D = new IntBinarySearchTree();

            int[] A_values = { 10, 15, 5, -10, -20 };
            int[] B_values = { 10, 15, 5, -10, -5 };
            int[] C_values = {10, 20, 30, 40, -5};
            int[] D_values = { 10, -5, 20, 40, 30 };

            for (int i = 0; i < 5; i++)
            {
                A.Add(A_values[i]);
                B.Add(B_values[i]);
                C.Add(C_values[i]);
                D.Add(D_values[i]);
            }

            //Console.WriteLine($"AVL TREE 'A':\n root left = {A.root.Left.value} root right = {A.root.Right.value} root.left.left = {A.root.Left.Left.value} root.Left.Right = {A.root.Left.Right.value}");
            //Console.WriteLine($"AVL TREE 'B':\n root.left = {B.root.Left.value}, root.left.right = {B.root.Left.Right.value}, root.left.left = {B.root.Left.Left.value}");
            //Console.WriteLine($"AVL TREE 'C':\n root.left = {C.root.Left.value}, root.right = {C.root.Right.value}, root.left.left = {C.root.Left.Left.value}, root.right.right = {C.root.Right.Right}");
            C.InOrder();
            //Console.WriteLine($"AVL TREE 'D':\n root.left = {D.root.Left.value}, root.right = {D.root.Right.value}, root.right.right = {D.root.Right.Right.value}, root.right.left = {D.Root.Right.Left.value}");
            */




            Console.ReadKey();
        }
    }
}
