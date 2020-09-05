//My first ever C# program
//As per tradition, this will simply print hello world to the console window
//Once I get that done I think I will figure out how to put this into a Git repository, then practice branching (forking?)
//making changes, submitting a pull request, and merging my changes.

//seems kind of like a #include
using System;

//Everything in C# is made of classes, I think. Namespace can have multiple classes. For now, I will have one.
 namespace helloWorldApplication
 {
    class helloWorld
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world");
            Console.ReadKey();
            //add Japanese to explore branching and pull requests further
            Console.WriteLine("minasan konnichiwa");
        }

    }

 }