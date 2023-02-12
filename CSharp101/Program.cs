// See https://aka.ms/new-console-template for more information

using CSharp101;
using System.Diagnostics;


namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program : Program4
    {
        String name;
        String lastName;
        //String firstName;


        //Constructor
        public Program(String name) 
        {
            this.name = name;
        }

        //Constructor2
        public Program(String firstName, String lastName)
        {
            //this.firstName = firstName;
            this.name = firstName;
            this.lastName = lastName;
        }

        public void GetName() 
        {
            Console.WriteLine("GetName-------------------------------");
            Console.WriteLine("My name is" + " " + this.name + " " + this.lastName);
            Console.WriteLine($"My name is {this.name} {this.lastName}");
        }

        public void GetData() 
        {
            Console.WriteLine("GetData-------------------------------");
            Console.WriteLine("I am inside the method");
        }

        static void Main(string[] args)
        {

            Program p = new Program("Rommer"); // create new object;
            Program p1 = new Program("Rommer","Chu"); // create new object;
            p.GetData(); // to import a method outside the Main block;
            p.SetData();
            p.GetName();
            p1.GetName();

            //Program 2
            Program2 p2 = new Program2();
            p2.Test(); 


            Debug.WriteLine("Hello, World!");

            int _ = 4;
            Console.WriteLine("Integer-------------------------------");
            Console.WriteLine("The number is " + _);

            String name = "RommerChu";
            Console.WriteLine("String Name-------------------------------");
            Console.WriteLine("My name is " + name);
            Console.WriteLine($"My name is {name}");

            var age = 10;
            Console.WriteLine(age);
            //age = "hello";

            dynamic height = 10;
            //height = 50;
            Console.WriteLine("Using Dynamic-------------------------------");
            Console.WriteLine(height);
            Console.WriteLine($"Height is {height}");

            Console.WriteLine("Hello World!");


        }
    }
}



