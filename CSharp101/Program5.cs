using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace CSharp101
//{
    //internal class Program5
    //{

    //}
//}


//Array style 1
String[] arr = { "Hello", "One", "Two", "Three" };

//Array style 2
String[] arr2 = new string[4];
arr2[0] = "Hello";
arr2[1] = "One";
arr2[2] = "Two";
arr2[3] = "Three";

Console.WriteLine(arr2[3]);

for (int i = 0; i < arr.Length; i++) 
{
    //Console.WriteLine(arr[i]);

    if (arr[i] == "Hello")
    {
        //Console.WriteLine(arr[i]);

        Console.WriteLine("Match found");
        break;
    }
    //else
    //{
        //Console.WriteLine(arr[i]);

        //Console.WriteLine("No match found");
    //}

};

