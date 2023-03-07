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
            List<double> listNum = new List<double>();
            foreach (var item in list)
            {
                var n = char.GetNumericValue(item);
                listNum.Add(n);
            }



            var listN = from n in listNum
                        group n by n into g
                        let count = g.Count()
                        orderby count descending
                        select new { Value = g.Key, Count = count };

            foreach (var item in listN)
            {
                Console.WriteLine($"Number {item.Value} appears {item.Count} time/s");
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
