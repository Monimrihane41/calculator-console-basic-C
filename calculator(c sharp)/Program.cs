using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator_c_sharp_
{
    internal class Program
    {
        static void Main(string[] args)

        {

            int num1;
            int num2;
            string answer;
            
            Console.WriteLine("HELLO USER :)  Welcome to The C# Calculator");
            Console.WriteLine("Enter The First Number : ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter The Second Number");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Now chose which Operation you want to do \n For + Press (a) for - press (b) for / press(c) for * press (D)");
            answer = Console.ReadLine();

            if (answer == "a")
            {
               Console.WriteLine(num1  + " + " + num2 + " = " + (num1 + num2));
            }else if( answer == "b")
            {
                Console.WriteLine(num1 + " - " + num2 + " = " + (num1 - num2));
            }else if (answer == "c")
            {
                Console.WriteLine(num1 + " / " + num2 + " = " + (num1 / num2));
            }
            else
            {
                Console.WriteLine(num1 + " * " + num2 + " = " + (num1 * num2));
            }

            Console.WriteLine("Thank you for Using The Calculator Programme !");
        }
        
    }
}
