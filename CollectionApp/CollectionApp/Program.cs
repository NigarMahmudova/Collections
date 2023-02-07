using System;
using System.Collections.Generic;
using System.Linq;

namespace CollectionApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            numbers.Add(10);
            numbers.Add(25);
            numbers.Add(3);
            numbers.Add(46);
            numbers.Add(58);
            numbers.Add(6);
            int[] nums = { 12, 18, 32, 45 };
            numbers.AddRange(nums);
            numbers.Sort();
            numbers.Insert(2, 15);
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(numbers.Contains(10));
            Console.WriteLine(numbers.Contains(35));

            Dictionary<string, string> cities = new Dictionary<string, string>();
            cities.Add("1", "Baki");
            cities.Add("2", "New York");
            cities.Add("3", "Istanbul");
            cities.Remove("1");
            foreach (var item in cities)
            {
                Console.WriteLine($"Key: {item.Key} - Value: {item.Value}");
            }

            SortedList<int, string> numNames = new SortedList<int, string>();
            numNames.Add(8, null);
            numNames.Add(11, "One");
            numNames.Add(2, "Two");
            numNames.Add(4, "Eleven");
            numNames.Add(10, "Five");
            numNames.Add(5, "Four");
            foreach (var item in numNames)
            {
                Console.WriteLine(item.Value);
            }

            Queue<int> no = new Queue<int>();
            no.Enqueue(1);
            no.Enqueue(2);
            no.Enqueue(3);
            no.Enqueue(4);

            no.Dequeue();
            Console.WriteLine(no.Peek()); 

            foreach (var item in no)
                Console.WriteLine(item);

            Console.WriteLine(no.Contains(2));
            Console.WriteLine(no.Contains(10));

            Stack<int> Stack = new Stack<int>();
            Stack.Push(1);
            Stack.Push(2);
            Stack.Push(3);
            Stack.Push(4);
            Console.WriteLine(Stack.Peek());
            Stack.Pop();
            Console.WriteLine(Stack.Peek());
            foreach (var item in Stack)
                Console.WriteLine(item);


        }
    }
}
