using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Queue Example:");
        QueueExample();
        Console.WriteLine("\nPriorityQueue Example:");
        PriorityQueueExample();
        Console.WriteLine("\nStack Example:");
        StackExample();
        Console.WriteLine("\nLinkedList Example:");
        LinkedListExample();
        Console.WriteLine("\nDictionary Example:");
        DictionaryExample();
        Console.WriteLine("\nSortedList Example:");
        SortedListExample();
        Console.WriteLine("\nHashSet Example:");
        HashSetExample();
        Console.WriteLine("\nList Example:");
        ListExample();

        Console.ReadKey();
    }

    static void QueueExample()
    {
        Queue<string> myQueue = new Queue<string>();

        myQueue.Enqueue("apple");
        myQueue.Enqueue("banana");
        myQueue.Enqueue("grape");
        myQueue.Enqueue("orange");
        myQueue.Enqueue("watermelon");

        string specificItem = "grape";
        if (myQueue.Contains(specificItem))
        {
            Console.WriteLine($"{specificItem} is in the queue.");
        }

        myQueue.Dequeue();

        int queueCount = myQueue.Count;
        Console.WriteLine($"The queue contains {queueCount} items.");

        Console.WriteLine("Items in the queue:");
        foreach (string item in myQueue)
        {
            Console.WriteLine(item);
        }
    }

    static void PriorityQueueExample()
    {
        // PriorityQueue is only available in .NET 6 and later
        PriorityQueue<int, string> myPriorityQueue = new PriorityQueue<int, string>();

        myPriorityQueue.Enqueue(3, "apple");
        myPriorityQueue.Enqueue(1, "banana");
        myPriorityQueue.Enqueue(5, "grape");
        myPriorityQueue.Enqueue(2, "orange");
        myPriorityQueue.Enqueue(4, "watermelon");

        while (myPriorityQueue.Count > 0)
        {
            myPriorityQueue.TryDequeue(out int priority, out string value);
            Console.WriteLine($"Dequeued item with priority {priority}: {value}");
        }
    }

    static void StackExample()
    {
        Stack<string> myStack = new Stack<string>();

        myStack.Push("apple");
        myStack.Push("banana");
        myStack.Push("grape");
        myStack.Push("orange");
        myStack.Push("watermelon");

        string specificItem = "grape";
        if (myStack.Contains(specificItem))
        {
            Console.WriteLine($"{specificItem} is in the stack.");
        }

        myStack.Pop();

        int stackCount = myStack.Count;
        Console.WriteLine($"The stack contains {stackCount} items.");

        Console.WriteLine("Items in the stack:");
        foreach (string item in myStack)
        {
            Console.WriteLine(item);
        }
    }

    static void LinkedListExample()
    {
        LinkedList<string> myList = new LinkedList<string>();

        myList.AddLast("apple");
        myList.AddLast("banana");
        myList.AddLast("grape");
        myList.AddLast("orange");
        myList.AddLast("watermelon");

        Console.WriteLine($"First node: {myList.First.Value}");
        Console.WriteLine($"Last node: {myList.Last.Value}");

        LinkedListNode<string> middleNode = myList.Find("grape");
        myList.AddAfter(middleNode, "pineapple");

        myList.Remove("orange");

        int listCount = myList.Count;
        Console.WriteLine($"The linked list contains {listCount} items.");

        Console.WriteLine("Items in the linked list:");
        foreach (string item in myList)
        {
            Console.WriteLine(item);
        }
    }

    static void DictionaryExample()
    {
        Dictionary<int, string> myDictionary = new Dictionary<int, string>
{
            { 1, "apple"},
{ 2, "banana"},
{ 3, "grape"},
{ 4, "orange"},
{ 5, "watermelon"}
};
        Console.WriteLine("Keys:");
        foreach (int key in myDictionary.Keys)
        {
            Console.WriteLine(key);
        }

        Console.WriteLine("\nValues:");
        foreach (string value in myDictionary.Values)
        {
            Console.WriteLine(value);
        }

        Console.WriteLine("\nKey-Value pairs:");
        foreach (KeyValuePair<int, string> entry in myDictionary)
        {
            Console.WriteLine($"{entry.Key}: {entry.Value}");
        }

        myDictionary.Remove(3);

        int dictionaryCount = myDictionary.Count;
        Console.WriteLine($"The dictionary contains {dictionaryCount} items.");
    }

    static void SortedListExample()
    {
        SortedList<int, string> mySortedList = new SortedList<int, string>
        {
            { 3, "apple" },
            { 1, "banana" },
            { 5, "grape" },
            { 2, "orange" },
            { 4, "watermelon" }
        };

        Console.WriteLine("Enter a key:");
        int newKey = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter a value:");
        string newValue = Console.ReadLine();

        if (!mySortedList.ContainsKey(newKey))
        {
            mySortedList.Add(newKey, newValue);
        }
        else
        {
            Console.WriteLine("Key already exists.");
        }

        mySortedList.RemoveAt(0);

        Console.WriteLine("Key-Value pairs:");
        foreach (KeyValuePair<int, string> entry in mySortedList)
        {
            Console.WriteLine($"{entry.Key}: {entry.Value}");
        }
    }

    static void HashSetExample()
    {
        HashSet<string> firstSet = new HashSet<string>
    {
        "apple", "banana", "grape", "orange", "watermelon"
    };

        HashSet<string> secondSet = new HashSet<string>
    {
        "pineapple", "banana", "mango", "orange", "kiwi"
    };

        HashSet<string> thirdSet = new HashSet<string>
    {
        "avocado", "coconut", "grape", "lemon", "watermelon"
    };

        firstSet.UnionWith(secondSet);

        Console.WriteLine("Combined items of first and second set:");
        foreach (string item in firstSet)
        {
            Console.WriteLine(item);
        }

        HashSet<string> duplicates = new HashSet<string>(firstSet);
        duplicates.IntersectWith(thirdSet);

        Console.WriteLine("\nItems that appear in both first and third set:");
        foreach (string item in duplicates)
        {
            Console.WriteLine(item);
        }
    }

    static void ListExample()
    {
        List<string> myList = new List<string>
    {
        "apple", "banana", "grape", "orange", "watermelon"
    };

        myList.AddRange(new[] { "pineapple", "mango", "kiwi" });

        myList.Sort();
        Console.WriteLine("Sorted list:");
        foreach (string item in myList)
        {
            Console.WriteLine(item);
        }

        myList.RemoveAt(0);

        myList.Sort((a, b) => b.CompareTo(a));
        Console.WriteLine("\nReverse sorted list:");
        foreach (string item in myList)
        {
            Console.WriteLine(item);
        }
    }
}
