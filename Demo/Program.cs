using System.Collections;

namespace Demo
{
    internal class Program
    {
        public static void PrintArrayList(ArrayList arrayList)
        {
            Console.WriteLine();
            foreach (int item in arrayList) 
            {
             Console.WriteLine(item);
            }
            Console.WriteLine();
        }

        public static int SumArrayList(ArrayList list)
        {
            int Sum = 0;
            if (list != null) 
            {
                for (int i=0; i<list.Count;i++ )
                {
                    if (list[i] is int)
                    {
                    Sum += (int) list[i]; // UnBoxing [ReferenceType] to [Valuetype] - Unsafe

                    }

                }

            }
            return Sum;
        }

        public static void PrintList<T>(List<T> values)
        {
            Console.WriteLine();
            foreach (T item in values)
            {
                Console.WriteLine($"{ item} ");
            }
            Console.WriteLine();
        }

        public static int SumList(List<int> list)
        {
            int Sum = 0;
            if (list != null)
            {
                for (int i = 0; i < list.Count; i++)
                {
                        Sum += list[i]; 
                }

            }
            return Sum;
        }

        public static void PrintLinkedList(LinkedList<int> list)
        {
            Console.Write("null");

            foreach (int item in list)
            {
                Console.Write($"<- {item} ->");
            }
            Console.WriteLine("null");
            Console.WriteLine();
        }

        public static void PrintStack(Stack<int> stack)
        {
            Console.WriteLine();
            foreach (int item in stack)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }

        public static void PrintQueue(Queue<int> queue)
        {
            Console.WriteLine();
            foreach (int item in queue)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            #region What are Collections
            // Collection : Built-in DS in C#
            // Array : Container {Array based}
            // Collections in C# :
            // Lists
            // Hashtables


            // Generic || Non-Generic 
            // Lists :
            // Non-generic lists : ArrayList - Stack - Queue
            // Generic lists : List - LinkedList - Stack - Queue

            // Hashtables :
            // Non-generic : HashTable
            // Generic  : Dictionary - SortedDictionary 
            #endregion

            #region Non-Generic Lists: ArrayList
            // Lists
            // Non-Generic : ArrayList

            // ArrayList like array 
            // Array based
            // index

            // Array indexed collection : Fixed
            // ArrayList indexed collection : Dynamic

            // Index : 0 1 2 3 4 5
            // Items : 4 5 6 7 8 1
            // Size : 6

            //Arr[1] ---> 5

            //int[] Numbers = { 9, 8, 7, 6, 1, 2, 3, 4, 5 };
            //Numbers[1] = 12;
            //Console.WriteLine(Numbers[1]);

            //ArrayList list= new ArrayList( new int[] { 1,2,3,4,5});
            //Console.WriteLine($"Count : {list.Count} , Capacity : {list.Capacity}");

            //list.Add( 6 );
            //list.Add( 6 );
            //list.Add( 6 );
            //list.Add( 6 );
            //list.Add( 6 );
            //list.Add( 6 );
            //list.Add( 6 );
            //list.Add( 6 );
            //list.Add( 6 );
            //Console.WriteLine($"Count : {list.Count} , Capacity : {list.Capacity}");


            // ArrayList list = new ArrayList();
            //list.Add(1);
            //Console.WriteLine($"Count : {list.Count} , Capacity : {list.Capacity}");

            //list.Add(2);
            //list.Add(3);
            //list.Add(4);
            //Console.WriteLine($"Count : {list.Count} , Capacity : {list.Capacity}");
            //list.Add(5);
            //Console.WriteLine($"Count : {list.Count} , Capacity : {list.Capacity}");
            //list.Add(6);
            //list.Add(7);
            //list.Add(8);
            //list.Add(9);
            //Console.WriteLine($"Count : {list.Count} , Capacity : {list.Capacity}");

            //Console.WriteLine(list.IsFixedSize);
            //Console.WriteLine(list.IsReadOnly);
            //Console.WriteLine(list[1]);

            //list[1] = 12;
            //Console.WriteLine(list[1]);

            //list.AddRange(new[] { 10, 11, 12 });

            //PrintArrayList(list);
            ////int index=list.BinarySearch(2);
            //int index=list.BinarySearch(2,);
            //Console.WriteLine(index);

            //Employee E01 = new Employee() {Id=1, Name="Malak" , Salary=12000,Age=29};
            //Employee E02 = new Employee() {Id=2, Name="Mariam" , Salary=13000,Age=30};
            //Employee E03 = new Employee() {Id=3, Name="Noura" , Salary=15000,Age=35};
            //Employee E04 = new Employee() {Id=4, Name="Nada" , Salary=1000,Age=32};

            //ArrayList list = new ArrayList();
            //list.AddRange(new Employee[] {E01,E02,E03,E04} );

            //int index = list.BinarySearch(new Employee() { Name ="Mariam"},new EmployeeComparerName());
            //Console.WriteLine($"Index : {index} ");

            //int index = list.BinarySearch(0,2, new Employee() { Name = "Mariam" }, new EmployeeComparerName());
            //Console.WriteLine($"Index : {index} ");


            //Console.WriteLine("--------------------------");

            //foreach (Employee item in list)
            //{
            //    Console.WriteLine(item);
            //}

            //ArrayList list = new ArrayList(); 
            //list.Add(1);
            //list.Add(2);
            //list.Add(3);
            //list.Add(4);
            //list.Add(5);
            //list.Add(6);
            //list.Add(7);
            //list.Add(8);

            //Console.WriteLine($"Count : {list.Count} , Capacity : {list.Capacity}");

            //list.Clear();
            //Console.WriteLine($"Count : {list.Count} , Capacity : {list.Capacity}");

            //bool flag = list.Contains(2);
            //Console.WriteLine(flag);

            //int[] Arr = new int[10];
            //list.CopyTo( 2,Arr, 3,1);

            //foreach (int item in Arr)
            //{
            //    Console.WriteLine(item);
            //}

            //ArrayList arrayList = list.GetRange(0, 2);

            //foreach (var item in arrayList)
            //{
            //    Console.WriteLine(arrayList);
            //}

            //int i= list.IndexOf(5,4,5);
            //Console.WriteLine(i);

            //list.Insert(0, 100);
            //PrintArrayList(list);

            //list.Remove(5);
            //list.RemoveAt(0);
            //list.RemoveRange(0,3);
            //list.SetRange(0, new int[] { 10, 20, 30});
            //list.Sort(list);

            //Console.WriteLine($"Count : {list.Count} , Capacity : {list.Capacity}");

            //list.TrimToSize(); // Delete || Release

            //Console.WriteLine($"Count : {list.Count} , Capacity : {list.Capacity}");

            //PrintArrayList(list); 
            #endregion

            #region Problems With Non-Generic Lists [ArrayList]

            //ArrayList list = new ArrayList();
            //list.Add(1);
            //list.Add(2);
            //list.Add(3);
            //list.Add(4);
            //list.Add(5);

            //list.Add("Hello World");
            //list.Add(new Employee());
            //list.Add(2.3);

            //int sum =SumArrayList(list);
            //Console.WriteLine($"Sum : {sum}"); 
            #endregion

            #region Generic Lists : List

            // Generic Lists : List
            // List : Version of Generic ArrayList

            //List<int> list = new List<int>(new int[] {1,2,3,4});
            //list.Add(1);
            //list.Add(2);
            //list.Add(3);
            //list.Add(4);
            //list.Add("Hello World"); // Compiler

            //PrintList(list);

            //int sum = SumList(list);
            //Console.WriteLine(sum);

            //list.AddRange(new int[] { 10, 20, 30, 40,50});

            //list.AsReadOnly();
            //int index= list.BinarySearch(20);

            //Console.WriteLine(index);

            //PrintList(list);

            //Employee E01 = new Employee() { Id = 1, Name = "Malak", Salary = 12000, Age = 29 };
            //Employee E02 = new Employee() { Id = 2, Name = "Mariam", Salary = 13000, Age = 30 };
            //Employee E03 = new Employee() { Id = 3, Name = "Noura", Salary = 15000, Age = 35 };
            //Employee E04 = new Employee() { Id = 4, Name = "Nada", Salary = 1000, Age = 32 };

            //List<Employee> employees = new List<Employee>(){ E01,E02,E03,E04} ;

            //int i = employees.BinarySearch(E01,new EmployeeComparerName());
            //Console.WriteLine(i);

            //Console.WriteLine($"Count : {list.Count} , Capacity : {list.Capacity}");

            //list.EnsureCapacity(10);

            //Console.WriteLine($"Count : {list.Count} , Capacity : {list.Capacity}");

            //List<int> result = list.GetRange(0, 2);

            //PrintList(result);

            //list.Sort();
            //Console.WriteLine($"Count : {list.Count} , Capacity : {list.Capacity}");

            //list.TrimExcess();
            //Console.WriteLine($"Count : {list.Count} , Capacity : {list.Capacity}");

            #endregion

            #region Generic Lists : Linked list

            //LinkedList<int> list = new LinkedList<int>();
            //list.AddFirst(1);
            //list.AddFirst(2);

            //list.AddLast(1);
            //list.AddLast(2);

            //LinkedListNode<int> node = new LinkedListNode<int>(3);
            //list.AddLast(node);

            //list.AddAfter(node, 4);

            //LinkedListNode<int> result =list.Find(1);
            //list.AddBefore(result, 4);

            //Console.WriteLine(list.First.Value);
            //Console.WriteLine(list.Last.Value);

            //list.Clear();

            //Console.WriteLine(list.First.Next.Value);

            //list.Remove(list.First);
            //list.Remove(2);
            //list.RemoveLast();
            //list.Remove(list.Last);

            //PrintLinkedList(list);

            #endregion

            #region  Generic Lists : Stack

            // Generic Lists : Linked list

            //Stack<int> stack = new Stack<int>();

            //stack.Push(1);
            //stack.Push(2);
            //stack.Push(3);
            //stack.Push(4);
            //stack.Push(5);

            //int top=stack.Pop();
            //Console.WriteLine(top);

            //int top = stack.Peek();
            //Console.WriteLine(top);

            //stack.Peek();
            //bool flag = stack.TryPeek(out int top);
            //stack.Pop();
            //bool flag = stack.TryPop(out int top);

            //PrintStack(stack);

            //Console.WriteLine(top);

            //Undo:Ctrl+Z

            #endregion

            #region Generic Lists : Queue

            // Generic Lists : Queue

            //Queue<int> queue = new Queue<int>();
            //queue.Enqueue(1);
            //queue.Enqueue(2);
            //queue.Enqueue(3);
            //queue.Enqueue(4);

            //queue.Dequeue();

            //queue.Peek();

            //PrintQueue(queue);

            #endregion

        }
    }
}
