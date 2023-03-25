using System.Collections.Generic;
using System.Linq;
using KnowledgeCheck2;

namespace KnowledgeCheck2
{
    public class Program
    {
        static void Main(string[] args)
        { 
            StartPoint: // this is for the goto down on line 72

            //Due to me owning a few pairs of shoes I thought a simple application for the shoes I own would be good to practice.
            Console.WriteLine("\n" + "\n" + "How many pairs of shoes do you own/want to add?");
            var numberOfRecords = int.Parse(Console.ReadLine());
     
            var recordList = new List<MyShoes>();
            for (int i = 0; i < numberOfRecords; i++)
            {
                // In this loop, populate the object's properties using Console.ReadLine()

                var myShoes = new MyShoes();

                //Asking for the brand if there is one.
                Console.WriteLine("Enter brand of the shoe(s) you'd like to add:" + "\n");
                myShoes.BrandName = Console.ReadLine();

                //I like the idea of the application telling you what you just did:
                Console.WriteLine("\n" + "You entered " + myShoes.BrandName + "." + " Thank you." + "\n");

                //The shoe size prompt part of the application
                Console.WriteLine("Enter the shoe size:");
                myShoes.Size = int.Parse(Console.ReadLine());

                //the user inputs being added to recordList:
                recordList.Add(myShoes);

                //Again the application telling you what you entered.
                Console.WriteLine("\n" + "You entered " + myShoes.Size + "." + " Thank you." + "\n");
                // Print out the list of records using Console.WriteLine()

            }
            // Below displays to the user their entries:
            Console.WriteLine("\n" + "\n" + "Here are the shoes you entered:" + "\n" + "\n");

            foreach (var i in recordList)
            {
                Console.WriteLine(i.BrandName + " " + i.Size + "\n");
            }
            Console.WriteLine("Have any more shoes to enter?" + "\n");

            //The code below checks to see if the user wants to enter any more shoes and what to do with yes, no and other responses.
            while (true)
            {
                var AddMore = Console.ReadLine();
                AddMore = AddMore.Trim().ToLower();
                if (AddMore is "no")
                {
                    Console.WriteLine("\n");
                    Console.WriteLine("Okay. Goodbye, I will exit now." + "\n" + "\n");
                    return;
                }
                else if (AddMore.Equals(AddMore))
                {
                    Console.WriteLine("Invalid response.");
                    goto StartPoint; /*from some reading "goto" seems to be a point of contention due to spaghetti code and it being an old-way
                to do things. So this does what I want it to do I would like to find a better solution at some point. probably changing the 
                main code to a method*/
                }
                else
                {
                    goto StartPoint; 
                }
            }

        }
    }
}