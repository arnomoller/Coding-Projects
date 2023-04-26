using System.Collections.Generic;
using System;
class Question2
{
    static void Main()
    {
        List<int> numberlist = new List<int>();
        
        numberlist.Add(56);
        numberlist.Add(85);
        numberlist.Add(42);
        numberlist.Add(73);
        numberlist.Add(65);
        numberlist.Add(30);
        numberlist.Add(90);
        numberlist.Add(75);
        
        // Displaying the initial content
        Console.Write("numlist Array: \n");
        Console.Write("Initial Content: ");
        foreach (int n in numberlist)
        {
            Console.Write(n + " ");
        }
        Console.WriteLine();
        //write number of elements in array
        Console.Write("Total Number of Elements: " + numberlist.Capacity);
        Console.WriteLine();

        //find the 30 .
        int find30 = numberlist.BinarySearch(30);
        if (find30 > 0)
        {
            Console.WriteLine("False");
        }
        else
        {
            Console.WriteLine("True");
        }
        //find the 70.
        int find70 = numberlist.BinarySearch(70);
        if (find70 < 0)
        {
            Console.WriteLine("False");
        }
        else
        {
            Console.WriteLine("True");
        }
        numberlist.Remove(90);
        // Displaying the final content after removing 90
        Console.Write("Final Content: ");
        foreach (int n in numberlist)
        {
            Console.Write(n + " ");
        }
    }
}