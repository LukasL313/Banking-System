using System;




namespace Program
{
    class Program
    {
        public static void Main(string[] args)
        {
           while (true)
           {
              Console.WriteLine("/n Hello, Welcome.");
              Console.WriteLine("1. Create account.");
              Console.WriteLine("2. Show account info.");
              Console.WriteLine("3. Withdraw account.");
              Console.WriteLine("4. Deposit into account.");
              Console.WriteLine("5. Exit program");

              int choice = int.Parse(Console.ReadLine());
              
              switch (choice)
              {
                
                case '1':
                 
                break; 

                 case '2':
                
                break; 

                 case '3':
                
                break; 

                 case '4':
                
                break; 

                 case '5':
                
                return; 
              }
           }
        }
    }
}