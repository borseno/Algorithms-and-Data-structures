e.WriteLine(A.root.Left.Height);
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
                                                                                                                                                                                                                      ʙ
"�������;�D\��D��߿��2�Cc��Zvqclנډ�lH�Mύ1�Y."�~�S�S�F�(`35��'���f�@`I������Ci�U�1IW�L�FZ���T� �u��d�)��l��3�[����%5���)`}�*�n�Y;�1S��܌f{�m�6�&(�0{�c����BQ
�nm�@�~�U�倵�ɕ/�����'ҐM;��P�4o`�!||P�*#�rU�lUf餡��謲���.D��W�v��U0@*H;e2Bv�}���Pҹ߫`b�3]�Y"��L���P��N@bӀd<Oi"���!ܐ�-�9:6�K(�*��iUl�A��ճ�z��PŉÏT����
�����_T���8W�L�nx{��j�
�
�68�~����V_�B+iH@̽
���Rx��ȇ�� ��鵋5֋�%4m׉�h^�y�~@����pw���9����#�>�f�@�>���w1���G�i�][-�x��5с;�q��8�����f���k�:�K�)J;̈r�>U�&6a�Ҏ�S�7�E-���Ed!1G��L!���M�ŹK�� ������ٔ�ɰo���pKiw��Vb��g�j�]C녺��9mhUСI)�S���C`�hIᄝP{�^K�k��2� �z�����J�W�p�g#ly�rxⰐV Y������ؖO텢�aD{OU���J����bRq��uδUSY7���:;0'y��'���vhً:K��V0>{[H�{z͔3����'�T5�|�y�2�k/+����O��+]���(l�Me|���/�*�<B氠eO-ڪƢ[�M��J؅�eJ�y������ђ���ؿ�$���������ΥP�Й-1\5wsttO����#@q)Km��2:���8Ͻ�eg����&1�-��C\1��BBynЍ�!��f����
s'����CF�M޻� ����Ɠ�s��(ޟ.YlRߌ��<���M��r ��b
u�<�]
��Z`'@SD��"Pʯ��Y��F�%�5:�H.SI�]��$@�o��"FĪf1��� ���<�i�b�,F�㥧�kLK��!�������N�p�ptIx�\hN~{htG�%�<�P�Z��yI�1ؠr�@|�x�,NgK!����j��9�f#箷��f�J\~�Y�o�l�����i�W�YF�s·e}�����M��ɝK%_�j#���;���V��T�_���Z��_u��`�Lc_/����VB�M-B���JYw ȓ�,�@�v�kC��r��#I�p�Cd��<�ܽl�-˝�x"�O���o#��{F���"����N
z��VS^R�Wgi��ـo8�׶.�����>'n��P���L����^�������
�ukD�{�S ��Et�� ��w;��*�V}e���O�|k��k�@�� Ա���1R��|׌m�[�	5�L����Oq�Or�!�5�2RIf��i*?plm�<'��Uj��q�5eKN*�eue is empty.");
            }
            else
            {
                string result = "";
                for (PQNode i = list.head; i != null; i = i.Next)
                    result += i.Data + " ";

                Console.WriteLine(result);
            }
        }

    }

    public class List
    {
        private Nullable<int>[] Array;
        int Count;
        public int Length;
        public bool IsSorted;

        public List(int Length)
        {
            if (Length < 1)
                throw new ArgumentException("Length can't be less than 1!");

            Array = new Nullable<int>[Length];
            Count = 0;
            this.Length = Length;
            IsSorted = true;
        }
        public bool IsEmpty()
        {
            return Count == 0;
        }
        public bool IsFull()
        {
            return Count == Length;
        }

        public int? this[int i] // int? in C# - integer value that can be null (value types can't normally be null)
        {
            get
            {
                return Array[i];
            }
            set
            {
                Array[i] = value;
            }
        }

        public void Print()
        {
            for (int i = 0; i < Length; i++)
            {
                if (Array[i] == null)
                {
                    Console.Write("null ");
                    continue;
                }
                Console.Write(Array[i] + " ");
            }
            Console.Write("\n");
        }

        public void Add(int? value)
        {
            if (IsEmpty())
            {
                Array[0] = value;
                IsSorted = true;
                Count++;
                return;
            }

            if (IsFull())
            {
                Extend();
                Array[Length - 1] = value;
            }
            else
            {
                for (int i = 0; i < Length; i++)
                    if (Array[i] == null)
                    {
                        Array[i] = value;
                        if (Array[i - 1] > Array[i] || (i + 1 < Length && Array[i + 1] < Array[i]))
                            IsSorted = false;
                        break;
                    }
            }
            Count++;
        }

        public void Insert(int? value, int i)
        {
            if (i >= Length || i < 0)
                throw new ArgumentOutOfRangeException();
            if (Array[i] == null)
                Count++;

            Array[i] = value;
            if (Array[i - 1] > Array[i] || (i + 1 < Length && Array?[i + 1] < Array[i]))
                IsSorted = false;
        }

        public void Extend(int Size = 1)
        {
            int?[] tempArr = new int?[Length + Size];
            for (int i = 0; i < Array.Length; i++)
                tempArr[i] = Array[i];

            Array = tempArr;
            Length += Size;
        }

        public void RemoveAt(int i)
        {
            if (i >= Length || i < 0)
                return;

            if (IsSorted)
            {
                for (int j = i + 1; j < Length; j++)
                {
                     Array[j - 1] = Array[j];
                }
                Array[Length - 1] = null;
            }
            else
                Array[i] = null;
            Count--;
        }

        public void Remove(int? item)
        {
            int i;
            if (IsSorted)
            {
                i = BinarySearch(item);
                RemoveAt(i);
            }
            else
            {
                i = Search(item);
                RemoveAt(i);
            }
            Count--;
        }   

        public int Search(int? value)
        {
            for (int i = 0; i < Length; i++)
                if (Array[i] == value)
                    return i;
            return -1;
        }

        public int BinarySearch(int? value)
        {
            if (!IsSorted)
                throw new Exception("Array is not sorted!");

            int Last = Length - 1;
            int First = 0;

            while (First <= Last) // [1, 3, 4, 5, 6] 
            {
                int Mid = First + (Last - First) / 2;

                if (Array[Mid] == value)
                    return Mid;
                else if (Array[Mid] < value)
                {
                    First = Mid + 1;
                    continue;
                }
                else if (Array[Mid] > value)
                {
                    Last = Mid - 1;
                }
            }
            return -1;
        }

        public void HeapSort() // ascending order
        {
            BinaryMaxHeap A = new BinaryMaxHeap();
            for (int i = 0; i < Length; i++)
                if (Array[i] != null)
                    A.Add(new Node((int)Array[i])); // Add to a MaxHeap

            for (int i = Length - 1; i >= 0; i--)
                Array[i] = A.Remove();
            IsSorted = true;
        }
        public void HeapSortDescending() // descending order
        {
            BinaryMinHeap A = new BinaryMinHeap();
            for (int i = 0; i < Length; i++)
                if (Array[i] != null)
                    A.Add(new Node((int)Array[i])); // Add to a MinHeap

            for (int i = Length - 1; i >= 0; i--)
                Array[i] = A.Remove();
            IsSorted = false;
        }
    }

    public class Node // Binary Heap node
    {
        public int Data;
        internal Node parent;
        internal Node Left;
        internal Node Right;
        public Node(int Data, Node parent)
        {
            this.Data = Data;
            this.parent = parent;
        }
        public Node(Node parent)
        {
            this.parent = parent;
        }
        public Node(int Data)
        {
            this.Data = Data;
        }
        public Node()
        {

        }

        public override string ToString()
        {
            return Data.ToString();
        }
    }

    class BinaryMaxHeap : BinaryMinHeap
    {
        public BinaryMaxHeap(int[] Items) : base(Items)
        { }
        public BinaryMaxHeap()
        {   Count = 0;  }

        public override void Add(Node node)
        {
            if (root == null)
            {
                root = node;
            }
            else
            {
                pointer = root;

                string bitcount = Convert.ToString(Count + 1, 2);
                for (short i = 1; i < bitcount.Length - 1; i++)
                {
                    if (bitcount[i] == '0')
                        pointer = pointer.Left;
                    else if (bitcount[i] == '1')
                        pointer = pointer.Right;
                }

                if (pointer.Left == null)
                {
                    pointer.Left = new Node(pointer);
                    pointer = pointer.Left;
                }
                else if (pointer.Right == null)
                {
                    pointer.Right = new Node(pointer);
                    pointer = pointer.Right;
                }

                pointer.Data = node.Data;

                while (pointer != root)
                {

                    if (pointer.Data > pointer.parent.Data)
                    {
                        // swap
                        int tempData = pointer.Data;
                        pointer.Data = pointer.parent.Data;
                        pointer.parent.Data = tempData;

                        pointer = pointer.parent; // go higher
                    }
                    else
                        break;
                }
            }
            Count++;
        }
        protected override void Heapify()
        {
            Node compare;
            pointer = root;

            while (true)
            {
                if (pointer.Left == null)
                    break;
                else if (pointer.Right == null)
                    compare = pointer.Left;
                else
                {
                    if (pointer.Left.Data >= pointer.Right.Data)
                        compare = pointer.Left;
                    else
                        compare = pointer.Right;
                }   
                if (compare.Data > pointer.Data)
                {
                    int tempData = compare.Data;
                    compare.Data = pointer.Data;
                    pointer.Data = tempData;

                    pointer = compare;
                }
                else
                    break;
                
            }

        }

    }

    class BinaryMinHeap
    {
        public Node root;
        public Node pointer;
        protected int Count;

        public BinaryMinHeap(int[] Items)
        {
            Count = 0;
            for (int i = 0; i < Items.Length; i++)
            {
                Add(new Node(Items[i]));
            }
        }

        public BinaryMinHeap()
        {
            Count = 0;
        }

        public virtual void Add(Node node)
        {
            if (root == null)
            {
                root = node;
            }
            else
            {
                pointer = root;

                string bitcount = Convert.ToString(Count + 1, 2);
                for (short i = 1; i < bitcount.Length - 1; i++)
                {
                    if (bitcount[i] == '0')
                        pointer = pointer.Left;
                    else if (bitcount[i] == '1')
                        pointer = pointer.Right;
                }

                if (pointer.Left == null)
                {
                    pointer.Left = new Node(pointer);
                    pointer = pointer.Left;
                }
                else if (pointer.Right == null)
                {
                    pointer.Right = new Node(pointer);
                    pointer = pointer.Right;
                }

                pointer.Data = node.Data;

                while (pointer != root)
                {

                    if (pointer.Data < pointer.parent.Data)
                    {
                        // swap
                        int tempData = pointer.Data;
                        pointer.Data = pointer.parent.Data;
                        pointer.parent.Data = tempData;

                        pointer = pointer.parent; // go higher
                    }
                    else
                        break;
                }
            }
            Count++;
        }

        public int Remove()
        {
            int output = root.Data;
            pointer = root;

            string bitcount = Convert.ToString(Count, 2);

            for (int i = 1; i < bitcount.Length; i++)
            {
                if (bitcount[i] == '0')
                    pointer = pointer.Left;
                else if (bitcount[i] == '1')
                    pointer = pointer.Right;
            }

            try
            {
                root.Data = pointer.Data;

                if (pointer.parent.Right == pointer)
                    pointer.parent.Right = null;
                else if (pointer.parent.Left == pointer)
                    pointer.parent.Left = null;

                Count--;
                //GC.Collect(); 

                Heapify(); // Move the first element to its correct position if needed (and it is always needed) 
            }
            catch (NullReferenceException) // root doesn't have a parent
            {
                return output;
            }
            return output;
        }

        protected virtual void Heapify()
        {
            Node compare;
            pointer = root;

            while (true)
            {
                if (pointer.Left == null)
                    break;
                else if (pointer.Right == null)
                    compare = pointer.Left;
                else
                {
                    if (pointer.Left.Data <= pointer.Right.Data)
                        compare = pointer.Left;
                    else
                        compare = pointer.Right;
                }
                if (compare.Data < pointer.Data)
                {
                    int tempData = compare.Data;
                    compare.Data = pointer.Data;
                    pointer.Data = tempData;

                    pointer = compare;
                }
                else
                    break;
            }

        }
 
    }



    class Program
    {
        static int DivideRec(int a, int b)
        {
            if (a - b == 0)
                return 1;
            else if (a - b < 0)
                return 0;
            return 1 + DivideRec(a - b, b);
        }

        static void Main(string[] args)
        {

            int[] integers = { 5, 1, 6, 7, 8, 9, 10, 11, 14, 16, 5 , 1, 2, 4, 5, 6, 7, 8, 7, 8, 8, 9, 30, 400, 500, 30, 20, 12, 40, 5, 75, 45, 47, 67, 73, 34, 12}; // 1 5 5 6 7 8 9 10 11 14 16



            PriorityQueue priorityQueue = new PriorityQueue();
            priorityQueue.Enqueue(5);
            priorityQueue.Enqueue(6);
            priorityQueue.Enqueue(5);
            priorityQueue.Enqueue(1);
            priorityQueue.Enqueue(10);
            priorityQueue.Enqueue(5);

            priorityQueue.PrintQueue();

            priorityQueue.Dequeue();
            priorityQueue.Dequeue();

            Console.WriteLine("2 elements dequeued");

            priorityQueue.Enqueue(12);

            Console.WriteLine("1 element enqueued");

            priorityQueue.PrintQueue();

            Console.WriteLine("Peek " + priorityQueue.Peek());

            for (int i = 0; i < integers.Length; i++)
                priorityQueue.Enqueue(integers[i]);

            priorityQueue.PrintQueue();

            for (int i = 0; i < 10; i++)
                Console.Write(priorityQueue.Dequeue() + " ");

            Console.WriteLine("\n ////// \n");
            priorityQueue.PrintQueue();
            Console.ReadKey();

        }
    }
}
