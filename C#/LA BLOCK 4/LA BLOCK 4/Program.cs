using System;
using System.Collections;

class Arno_Moller
{

    public static void Main()
    {

        // 1.
        Stack eduvos = new Stack();

        //2.
        eduvos.Push("Arno");
        eduvos.Push("Jan");
        eduvos.Push("Jacob"); 
        eduvos.Push("John");
        eduvos.Push("Jacob");

        // 3.
        Console.Write("Total number of elements in the Stack are : ");
        Console.WriteLine(eduvos.Count);

        // 4.
        Console.WriteLine("Element at the top is : "
                                  + eduvos.Peek());

        //5.
        Console.WriteLine("Total number of elements after removing the top element:"  + eduvos.Pop());

        

        Console.WriteLine(eduvos.Count);
    }
}