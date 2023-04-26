using System;
using System.Linq;

class Question2
{

    static public void Main()
    {

        // Creating a count variable
        var total = 0;

        // creating array of numbers
        int[] numberlist = {56, 85, 42, 73, 65, 30, 90, 75 };

        // Counting the number of elements
        total = numberlist.Count();

        // Displaying the count
        
        Console.Write("numlist Array:\n");
            Console.WriteLine("Total Number of Elements: " + total);
        Console.Write(Array.Exists(numberlist, element => element == 30 ));
        Console.Write("\n");
        Console.Write(Array.Exists(numberlist, element => element == 70 ));

    }
}