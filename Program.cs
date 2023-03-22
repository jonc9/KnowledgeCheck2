using System.Collections.Generic;
using System.Linq;
using KnowledgeCheck2;

namespace KnowledgeCheck2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many pairs of shoes do you own/want to add?");
            var numberOfRecords = int.Parse(Console.ReadLine());

            /*var ifZero = Console.ReadLine();
            if (ifZero == "zero")
            {
                Console.WriteLine("You entered " + ifZero + ".");
            }

            else if (ifZero == "Zero")
            {
                Console.WriteLine("You entered " + ifZero + ".");
                return;
            }
            else if (ifZero == "0")
            {
                Console.WriteLine("You entered " + ifZero + ".");
                return;
            }
            else
            {
                Console.WriteLine("You didn't enter a valid command. Please try again: How many pairs of shoes do you own/want to add?");
            }*/


            var recordList = new List<MyShoes>();
            for (int i = 0; i < numberOfRecords; i++)
            {
                // In this loop, populate the object's properties using Console.ReadLine()
                var myShoes = new MyShoes();

                Console.WriteLine("Enter brand of the shoe(s) you are adding:");
                myShoes.BrandName = Console.ReadLine();
                //recordList.Add(myShoes);
                Console.WriteLine("You entered " + myShoes.BrandName + " Thank you.");

                Console.WriteLine("Enter the shoe size:");
                myShoes.Size = int.Parse(Console.ReadLine());
                recordList.Add(myShoes);

                Console.WriteLine("You entered " + myShoes.Size + " Thank you.");

                Console.WriteLine("Here is a list of shoes you entered:");
                Console.WriteLine(recordList);

                // Print out the list of records using Console.WriteLine()
                
            }
            for (int i = 0; 1 < numberOfRecords; i++)
            {
                Console.WriteLine(recordList);

            }
        }
    }
}