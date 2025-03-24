using System.Reflection.Metadata;

namespace lab1;

class Program
{
    static void Main(string[] args)
    {
        // Step 2/3/5 strings, constants, int
        const string mySchool = "Tri C";
        int myNum = 15;
        string name = "Blake"; 
        string date = "March 23, 2025";
        
       // Step 1
        Console.WriteLine("Hello, " + name + "!");
        Console.WriteLine("I attend " + mySchool + ".");
        Console.WriteLine("Welcome to IT 1050!");
        Console.WriteLine("The current date is " + date + "." );
        Console.WriteLine("My favorite number is " + myNum + ".");
       
        

    }
}