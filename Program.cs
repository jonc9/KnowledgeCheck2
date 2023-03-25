using System.Collections.Generic;
using System.Linq;
using KnowledgeCheck2;

namespace KnowledgeCheck2
{
    public class Program
    {
        static void Main(string[] args)
        { //Due to me owning a few pairs of shoes I thought a simple application for the shoes I own would be good to practice.
            Console.WriteLine("How many pairs of shoes do you own/want to add?");
            var numberOfRecords = int.Parse(Console.ReadLine());

            //int ifZero;

            /*if (Convert.ToString(numberOfRecords) is "zero")
            {
                switch (numberOfRecords.ToString().ToLower())
                {
                    case "zero":
                        Console.WriteLine("You entered " + numberOfRecords + ", please enter a non-zero number.");
                        break;
                }
            }*/



            /*return Console.WriteLine("You entered " + ifZero + ".");



            else if (ifZero = Zero)
            {
                return Console.WriteLine("You entered " + ifZero + ".");

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

                //Asking for the brand if there is one.
                Console.WriteLine("Enter brand of the shoe(s) you'd like to add:");
                myShoes.BrandName = Console.ReadLine();

                //I like the idea of the application telling you what you just did:
                Console.WriteLine("You entered " + myShoes.BrandName + "." + " Thank you." + "\n" + "\n");

                //The shoe size prompt part of the application
                Console.WriteLine("Enter the shoe size:");
                myShoes.Size = int.Parse(Console.ReadLine());

                //the user inputs being added to recordList:
                recordList.Add(myShoes);

                //Again the application telling you what you entered.
                Console.WriteLine("You entered " + myShoes.Size + "." + " Thank you." + "\n" + "\n");
                // Print out the list of records using Console.WriteLine()
                // Below displays to the user their entries:

                /*Console.WriteLine($"Here are the shoes you entered, brand first, followed by size: {myShoes.BrandName} | {myShoes.Size}");*/
            }
            Console.WriteLine("\n" + "\n" + "Here are the shoes you entered:" + "\n" + "\n");

            foreach (var i in recordList)
            {
                Console.WriteLine(i.BrandName + " " + i.Size);
            }
            Console.WriteLine("Have any more to enter?" + "\n");
            var AddMore = Console.ReadLine();
            if (AddMore is "No" or "no" or "n" or "N" or "NO" or "n0" or "N0" or "nah" or "NAH")
            {
                Console.WriteLine("Okay. Goodbye, I will exit now." + "\n" + "\n");
                return;
            }


        }
    }
}