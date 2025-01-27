using System;
using System.Collections;

namespace Assignment
{
    internal class Program
    {
        //public static ArrayList RemoveOdd(ArrayList arrayList)
        //{
        //    ArrayList evenList = new ArrayList();

        //    foreach (int item in arrayList)
        //    {
        //        if (item % 2 == 0 ) 
        //        {
        //            evenList.Add(item); 
        //        }
        //    }

        //    return evenList; 
        //}

        //public static void SearchInStack(Stack<int> stack, int target)
        //{
        //    int count = 0;
        //    foreach (int item in stack)
        //    {
        //        count++;
        //        if (item == target)
        //        {
        //            Console.WriteLine($"Target was found successfully and the count = {count}");
        //            return;
        //        }
        //    }
        //    Console.WriteLine("Target was not found");
        //}

        //public static int[] FindIntersection(int[] arr1,int[] arr2)
        //{
        //    List<int> intersectList = new List<int>();
        //    for (int i = 0; i < arr1.Length; i++) 
        //    {
        //        for (int j = 0; j < arr2.Length; j++)
        //        {
        //            if (arr1[i] == arr2[j])
        //            {
        //                intersectList.Add(arr1[i]);
        //            }

        //        }
        //    }
        //    return intersectList.ToArray();
        //}

        //public static ArrayList SumAndSublist(ArrayList arrayList, int targetSum)
        //{
        //    int sum = 0;
        //    int left = 0;
        //    ArrayList sublist = new ArrayList();

        //    for (int right = 0; right < arrayList.Count; right++)
        //    {
        //        if (arrayList[right] is int)
        //        {
        //            sum += (int)arrayList[right]; 
        //            while (sum > targetSum && left <= right)
        //            {
        //                sum -= (int)arrayList[left]; 
        //                left++;
        //            }

        //            if (sum == targetSum)
        //            {
        //                sublist.Clear(); 
        //                for (int i = left; i <= right; i++)
        //                {
        //                    sublist.Add(arrayList[i]);
        //                }

        //                Console.WriteLine($"Sublist that sums to {targetSum}:");
        //                foreach (int item in sublist)
        //                {
        //                    Console.Write(item + " ");
        //                }
        //                Console.WriteLine();
        //                return sublist; 
        //            }
        //        }
        //    }

        //    Console.WriteLine("No sublist found that sums to the target.");
        //    return new ArrayList();
        //}
        
        //public static void ReverseQueue(int elements ,Queue queue) 
        //{
        //    Stack<int> stack = new Stack<int>();
        //    for (int i = 0; i < elements && queue.Count > 0; i++)
        //    {
        //        stack.Push((int)queue.Dequeue());
        //    }

        //    while (stack.Count > 0)
        //    {
        //        queue.Enqueue(stack.Pop());
        //    }

        //    int remainingCount = queue.Count - elements;
        //    for (int i = 0; i < remainingCount; i++)
        //    {
        //        queue.Enqueue(queue.Dequeue());
        //    }
        //}
        static void Main(string[] args)
        {
            #region Question01
            //int Size, NumOfQueries;

            //Console.WriteLine("Enter number of queries:");
            //if (int.TryParse(Console.ReadLine(), out NumOfQueries))
            //{
            //    Console.WriteLine("Enter size of array:");
            //    if (int.TryParse(Console.ReadLine(), out Size))
            //    {
            //        int[] Arr = new int[Size];
            //        Console.WriteLine("Enter the elements of the array:");
            //        for (int i = 0; i < Size; i++)
            //        {
            //            if (int.TryParse(Console.ReadLine(), out Arr[i]) == false)
            //            {
            //                Console.WriteLine("Invalid input. Please enter a valid integer.");
            //                return;
            //            }
            //        }

            //        int[] Queries = new int[NumOfQueries];
            //        for (int i = 0; i < NumOfQueries; i++)
            //        {
            //            Console.WriteLine($"Enter query {i + 1}:");
            //            if (int.TryParse(Console.ReadLine(), out Queries[i]) == false)
            //            {
            //                Console.WriteLine("Invalid input. Please enter a valid integer.");
            //                return;
            //            }
            //        }

            //        int[] Results = new int[NumOfQueries];
            //        for (int i = 0; i < NumOfQueries; i++)
            //        {
            //            int count = 0;
            //            foreach (int num in Arr)
            //            {
            //                if (num > Queries[i])
            //                {
            //                    count++;
            //                }
            //            }
            //            Results[i] = count;
            //        }

            //        Console.WriteLine("Results:");
            //        for (int i = 0; i < NumOfQueries; i++)
            //        {
            //            Console.WriteLine(Results[i]);
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("Invalid input for size of array.");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input for number of queries.");
            //} 
            #endregion

            #region Question02

            //int size;

            //Console.WriteLine("Enter the size of the array:");
            //if (int.TryParse(Console.ReadLine(), out size) && size > 0)
            //{
            //    int[] arr = new int[size];

            //    Console.WriteLine("Enter the elements of the array:");
            //    for (int i = 0; i < size; i++)
            //    {
            //        if (!int.TryParse(Console.ReadLine(), out arr[i]))
            //        {
            //            Console.WriteLine("Invalid input! Enter a valid integer.");
            //            return;
            //        }
            //    }

            //    bool isPalindrome = true;
            //    int left = 0; 
            //    int right = size - 1; 

            //    while (left < right)
            //    {
            //        if (arr[left] != arr[right])
            //        {
            //            isPalindrome = false;
            //            break; 
            //        }
            //        left++; 
            //        right--; 
            //    }


            //    Console.WriteLine(isPalindrome ? "YES" : "NO");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input for array size.");
            //}

            #endregion

            #region Question03

            //Queue<int>queue = new Queue<int>();

            //queue.Enqueue(1);
            //queue.Enqueue(2);
            //queue.Enqueue(3);
            //queue.Enqueue(4);
            //queue.Enqueue(5);

            //Console.WriteLine("Before reversing : ");

            //foreach (int item in queue)
            //{
            //    Console.WriteLine($"{item}  ");
            //}

            //Stack<int> stack = new Stack<int>();    

            //while(queue.Count>0)
            //{
            //    stack.Push(queue.Dequeue());
            //}

            //while (stack.Count > 0)
            //{
            //    queue.Enqueue(stack.Pop());
            //}

            //Console.WriteLine("After reversing : ");
            //foreach (int item in queue)
            //{
            //    Console.WriteLine($"{item}  ");
            //}

            #endregion

            #region Question04

            //Console.WriteLine("Enter a string with parentheses:");
            //string input = Console.ReadLine();

            //Stack<char> stack = new Stack<char>();
            //bool isBalanced = true;

            //foreach (char c in input)
            //{
            //    if (c == '(' || c == '[' || c == '{')
            //    {
            //        stack.Push(c); 
            //    }
            //    else if (c == ')' && stack.Count > 0 && stack.Peek() == '(')
            //    {
            //        stack.Pop(); 
            //    }
            //    else if (c == ']' && stack.Count > 0 && stack.Peek() == '[')
            //    {
            //        stack.Pop(); 
            //    }
            //    else if (c == '}' && stack.Count > 0 && stack.Peek() == '{')
            //    {
            //        stack.Pop(); 
            //    }
            //    else if (c == ')' || c == ']' || c == '}')
            //    {
            //        isBalanced = false;
            //        break;
            //    }
            //}

            //if (stack.Count != 0)
            //{
            //    isBalanced = false;
            //}

            //Console.WriteLine(isBalanced ? "Balanced" : "Not Balanced");

            #endregion

            #region Question05

            //Stack<int> stack = new Stack<int>();
            //stack.Push(1);
            //stack.Push(0);
            //stack.Push(2);
            //stack.Push(0);
            //stack.Push(3);
            //stack.Push(0);
            //stack.Push(4);
            //stack.Push(0);

            //Console.WriteLine("Stack before removing duplicates:");
            //foreach (int item in stack)
            //{
            //    Console.WriteLine(item);
            //}

            //Stack<int> tempStack = new Stack<int>();

            //while (stack.Count > 0)
            //{
            //    int item = stack.Pop();

            //    bool isDuplicate = false;
            //    foreach (int tempItem in tempStack)
            //    {
            //        if (tempItem == item)
            //        {
            //            isDuplicate = true;
            //            break;
            //        }
            //    }

            //    if (!isDuplicate)
            //    {
            //        tempStack.Push(item);
            //    }
            //}

            //Console.WriteLine("Stack after removing duplicates:");
            //while (tempStack.Count > 0)
            //{
            //    Console.WriteLine(tempStack.Pop());
            //}
            #endregion

            #region Question06

            //ArrayList arrayList = new ArrayList() { 1,2,3,4,5,6,7,8,9,10};

            //Console.WriteLine("Array before removing odd numbers : ");
            //foreach (int item in arrayList) 
            //{
            //    Console.WriteLine($"{item} ");

            //}

            //ArrayList evenList = RemoveOdd(arrayList);

            //Console.WriteLine("Array after removing odd numbers:");
            //foreach (int item in evenList)
            //{
            //    Console.WriteLine($"{item}");
            //}

            #endregion

            #region Question07

            //Queue queue = new Queue();

            //queue.Enqueue(1);
            //queue.Enqueue("Apple");
            //queue.Enqueue(5.28);

            //foreach (var item in queue) 
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Question08

            //Stack<int> stack = new Stack<int>(new[] { 1,2,4,5,6,7});
            //Console.WriteLine("Enter a value to search in stack");
            //if (int.TryParse(Console.ReadLine(), out int target))
            //{
            //    SearchInStack(stack, target);
            //}
            //else
            //    Console.WriteLine("Invalid input");

            #endregion

            #region Question09

            //int[] arr1 = { 1, 2, 3, 4, 5 };
            //Console.WriteLine("First Array");
            //foreach (int num in arr1)
            //{
            //    Console.WriteLine($"{num}");

            //}


            //int[] arr2 = { 3, 4, 5, 6, 7 };
            //Console.WriteLine("Second Array");

            //foreach (int num in arr2)
            //{
            //    Console.WriteLine($"{num}");
            //}

            //int[] intersection = FindIntersection(arr1, arr2);

            //Console.WriteLine("Intersection:");
            //foreach (int num in intersection)
            //{
            //    Console.WriteLine($"{ num}");
            //}

            #endregion

            #region Question10

            //ArrayList arrayList = new ArrayList() { 1, 2, 3, 7, 5 };
            //int targetSum = 12;
            //foreach (int item in arrayList)
            //{
            //    Console.WriteLine($"{item}");
            //}

            //SumAndSublist(arrayList, targetSum);

            #endregion

            #region Question11

            //Queue queue = new Queue();
            //queue.Enqueue(1);
            //queue.Enqueue(2);
            //queue.Enqueue(3);
            //queue.Enqueue(4);
            //queue.Enqueue(5);
            
            //Console.WriteLine("Before reversing :");
            //Console.Write("[");
            //foreach (var item in queue)
            //{
            //    Console.Write($" {item} ");
            //}
            //Console.Write("]");

            //ReverseQueue(3, queue);
            //Console.WriteLine();

            //Console.WriteLine("After reversing : ");
            //Console.Write("[");
            //foreach (var item in queue)
            //{
            //    Console.Write($" {item} ");
            //}
            //Console.Write("]");

            #endregion

        }
    }

}
