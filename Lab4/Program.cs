using System.IO.Compression;
using System.Security.Cryptography.X509Certificates;

namespace Lab4;

class Program
{
    static void Main(string[] args)
    {
      for (int l = 1; l <= 10; l++) 
{
  Console.WriteLine(l);
}

    for (int l = 1; l <= 20; l++)
     
    {
        if (l % 2 == 0)
        Console.WriteLine(l);
    }

    for (int l = 5; l >= 0; l--)
    
    {
        Console.WriteLine(l);
    }

    
     double number, total = 100;
     Console.WriteLine("Enter a number greater than 100: ");
   
   
    do 
    {
       Console.Write("Number: ");
       number = Convert.ToDouble(Console.ReadLine());
       total += number;

    }
    while (number < 100);

    

   
            for (int b = 10; b <= 1000; b++)
     
    {
        if (b % 10 == 0)
        Console.WriteLine(b);
    }


     int i = '*';
     while (i >= 1)
     {
       int k = i;
       while (k >= 1)
       {
        Console.Write(k + " ");
        k++;
       }
       Console.WriteLine();
       i++;

     }



            
        }

 
    


    
    
        
    
   

}