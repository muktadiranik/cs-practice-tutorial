using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            list.Add(6);

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(list.Count);
            Console.WriteLine(list.Capacity);

            ArrayList list2 = new ArrayList();
            list2.AddRange(list);
            foreach (var item in list2)
            {
                Console.WriteLine(item);
            }

            list2.AddRange(list);
            foreach (var item in list2)
            {
                Console.WriteLine(item);
            }

            list2.Sort();
            foreach (var item in list2)
            {
                Console.WriteLine(item);
            }

            list2.Reverse();
            foreach (var item in list2)
            {
                Console.WriteLine(item);
            }

            ArrayList range = list2.GetRange(0, 10);
            foreach (var item in range)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(list2.IndexOf(1));

            list2.Insert(0, 0);
            foreach (var item in list2)
            {
                Console.WriteLine(item);
            }

            string[] strings = list2.OfType<string>().ToArray();
            foreach (var item in strings)
            {
                Console.WriteLine(item);
            }

            string[] customers = { "Jhon", "Jane", "Jack" };
            ArrayList customers2 = new ArrayList();
            customers2.AddRange(customers);
            foreach (var item in customers2)
            {
                Console.WriteLine(item);
            }

            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("name", "Jhon");
            dictionary.Add("age", "25");
            dictionary.Add("city", "New York");
            dictionary.Add("state", "NY");
            foreach (var item in dictionary)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(dictionary["name"]);
            Console.WriteLine(dictionary["age"]);
            Console.WriteLine(dictionary["city"]);
            Console.WriteLine(dictionary["state"]);

            dictionary.Remove("age");
            foreach (var item in dictionary)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(dictionary.Count);
            Console.WriteLine(dictionary.ContainsKey("name"));

            dictionary.TryGetValue("name", out string? value);
            Console.WriteLine(value);

            foreach (KeyValuePair<string, string> item in dictionary)
            {
                Console.WriteLine($"{item.Key} : {item.Value}");
            }

            dictionary.Clear();
            foreach (var item in dictionary)
            {
                Console.WriteLine(item);
            }

            Queue queue = new Queue();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(queue.Count);
            Console.WriteLine(queue.Peek());
            Console.WriteLine(queue.Contains(1));
            Console.WriteLine(queue.Dequeue());
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }

            object[] objects = queue.Cast<object>().ToArray();
            foreach (var item in objects)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(string.Join(", ", objects));
            foreach (var item in objects)
            {
                Console.WriteLine(item);
            }

            queue.Clear();
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }

            Stack stack = new Stack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(stack.Count);
            Console.WriteLine(stack.Peek());
            Console.WriteLine(stack.Contains(1));
            Console.WriteLine(stack.Pop());
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }

            object[] objects1 = stack.Cast<object>().ToArray();
            foreach (var item in objects1)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(string.Join(", ", objects1));
            foreach (var item in objects1)
            {
                Console.WriteLine(item);
            }

            stack.Clear();
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
        }
    }
}
