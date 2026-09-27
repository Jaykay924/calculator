using System;

namespace MyCalculator
{
    class Numbers
    {
        static void Main(string[] args)
        {
    
        int num1 = Convert.ToInt32(Console.ReadLine());
        char operation = Convert.ToChar(Console.ReadLine());
        int num2 = Convert.ToInt32(Console.ReadLine());

        switch(operation)
            {
                case '+':
                    Console.WriteLine(num1 + num2);
                    break;

                    case '-':
                    Console.WriteLine(num1 - num2);
                    break;

                case '*':
                    Console.WriteLine(num1 * num2);
                    break;

                case '/':
                    if(num2 != 0)
                    {
                        Console.WriteLine(num1 / num2);
                    }
                    else
                    {
                        Console.WriteLine("Error: Division by zero is not allowed.");
                    }
                    break;
                    
                
            }
        
        

       }
    }
}