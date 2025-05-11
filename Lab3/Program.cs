namespace Lab3;

class Program
{
    static void Main(string[] args)
    {
       int a = 10;
       int b = 5;
       int c = 15;

       Console.WriteLine(a > b);
       Console.WriteLine(a < c);
       Console.WriteLine(a > b && a > c);


        
       bool isRaining = true;
       bool haveUmbrella = false;

       if (isRaining || haveUmbrella)
       {
        Console.WriteLine("It is raining, take an umbrella.");
       }
        else if (!isRaining)
      {
       Console.WriteLine("It is not raining, you're good to go!");

      }

       
       else
       {
        Console.WriteLine("It is not raining, you're good to go!");
       }


       Console.WriteLine("Please enter your age:");
       int age = Convert.ToInt32(Console.ReadLine());

       if (age < 5)
       {
        Console.WriteLine("Your ticket is free!");
       }
       else if (age > 5 && age < 12)
       {
         Console.WriteLine("Child ticket: $5");

       }
       else if (age > 13 && age < 64)
       {
        Console.WriteLine("Standard ticket price: $12");
       }

       else if (age > 65)
       {
        Console.WriteLine("Senior ticket price: $6");
       }

       Console.WriteLine("What day is it?");
       string day = Console.ReadLine();

       switch(day)
       { 
        case "Monday":
        Console.WriteLine("It's Monday.");
        break;
        
        case "Tuesday":
        Console.WriteLine("It's Tuesday.");
        break;
        
        case "Wednesday":
        Console.WriteLine("It's Wednesday.");
        break;

        case "Thursday":
        Console.WriteLine("It's Thursday.");
        break;

        case "Friday":
        Console.WriteLine("It's Friday.");
        break;

        case "Saturday":
        Console.WriteLine("It's Saturday.");
        break;

        case "Sunday":
        Console.WriteLine("It's Sunday.");
        break;

        default:
        Console.WriteLine(day + " is not a day!");
        break;

       }


    }


       

}
