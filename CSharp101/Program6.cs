using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace CSharp101
//{
//    internal class Program6
//    {
//    }
//}

ArrayList a = new ArrayList();
a.Add("hello");
a.Add("bye");
a.Add("Rommer");
a.Add("Apple");

//Console.WriteLine(a[1]);

foreach (string item in a) 
{
    Console.WriteLine(item);
}

//This will return TRUE if found
Console.WriteLine(a.Contains("Rommer"));




Console.WriteLine("After sorting");

foreach (String item in a)
{
    Console.WriteLine(item);
    a.Sort();
}



//foreach (string item in a)
//{
//    Console.WriteLine(item);
//    a.Sort();
//};