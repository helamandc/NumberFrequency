using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberFrequency
{
    public class Program
    {
        //Write a program in C# Sharp to display the number and frequency of number from giving array.
        //https://www.w3resource.com/csharp-exercises/linq/index.php
        static void Main(string[] args)
        {
            NumberFrequency myNumberFrequency = new NumberFrequency();

            Console.WriteLine("Please enter at least 10 different integers: ");
            myNumberFrequency.NumberSet(Console.ReadLine());
            Console.ReadLine();
        }

        
    }

    public class NumberFrequency
    {

        public void NumberSet(string num)
        {
            var number = num.ToCharArray();
            List<char> list = new List<char>();
            foreach (var item in number)
            {
                list.Add(item);
            }

            var listNum = list.Where(x => x > 5);


            Console.WriteLine("The numbers greater that 5 are: ");

            foreach (var item in listNum)
            {
                Console.WriteLine($"{item} ");
            }
        }

    }
}
