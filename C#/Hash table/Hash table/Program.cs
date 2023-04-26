//C# code to create hash table 
using System;
using System.Collections;
namespace HashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable Ht = new Hashtable();
            Ht["Pet"] = "A domestic or tamed animal kept for companionship or pleasure.";
            Ht["Learn"] = "Gain or acquire knowledge of or skill in (something) by study, experience, or being taught.";
            Ht["Speak"] = "Say something in order to convey information or to express a feeling.";

            Console.WriteLine("Totoal Number of elements in the hash Table : " + Ht.Count);
            foreach (DictionaryEntry student in Ht)
            {
                Console.WriteLine(student.Key + ": " + student.Value);
                
            }
            
        }
    }
}
