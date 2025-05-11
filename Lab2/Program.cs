namespace Lab2;

class Program
{
    static void Main(string[] args)
    {
        int myfav = 30;
        double mydub = 3.14;
        char myletter = 'B';
        bool mybool = true;
        string mystr = "Hello!";

        Console.WriteLine("My favorite number is " + myfav + ".");
        Console.WriteLine("My favorite decimal is " + mydub + ".");
        Console.WriteLine("My favorite letter is " + myletter + ".");
        Console.WriteLine("Yes it is " + mybool + " that I am from Arkansas!");
        Console.WriteLine( mystr );

        double newdub = 9.78;
        int myInt = (int) newdub;  // Manual casting: double to int

      Console.WriteLine(newdub);
      Console.WriteLine(myInt);
      Console.WriteLine(Convert.ToString(myInt));
      Console.WriteLine(Convert.ToString(mybool));

      Console.WriteLine("Enter your Name:");
      string userName = Console.ReadLine();
     

       Console.WriteLine("Enter your age:");
       int age = Convert.ToInt32(Console.ReadLine());
     
       Console.WriteLine("Your name is  " + userName);
       Console.WriteLine("Your age is " + age);


       int num1 = 10;
       int num2 = 5;
       int a = num1 + 10;
       int b = num1 - 2;
       int c = num1 * 3;
       int d = num1 / 2;
       int e = num1 % 2;
       int f = num2 + 10;
       int g = num2 - 2;
       int h = num2 * 3;
       int i = num2 / 2;
       int j =num2 % 2;

       Console.WriteLine("10 + 10 ="+ a);
       Console.WriteLine("10 - 2 =" + b);
       Console.WriteLine("10 * 3 =" + c);
       Console.WriteLine("10 / 2 =" + d);
       Console.WriteLine("10 % 2 =" + e);
       Console.WriteLine("5 + 10 =" + f);
       Console.WriteLine("5 - 2 =" + g);
       Console.WriteLine("5 * 3 =" + h);
       Console.WriteLine("5 / 2 =" + i);
       Console.WriteLine("5 % 2 =" + j);





    }
    }

