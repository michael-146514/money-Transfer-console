using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyTransfer
{
    internal class Simulation
    {
        public Simulation()
        {
            
        }

        public void RunSimulation()
        {
            Console.WriteLine("Starting simulation");

            //Console.WriteLine("Enter the Name of the Peson you want to transfer to! Jake, Rose, Devon, Aiden");

            

          //  string userInput = "Jake";
           //  userInput = Console.ReadLine();

            

            //TODO 5: Instantiate two Person objects, with unique names and money amounts. Two lines.
            Person Michael = new Person("Michael", 1000);
            Person Jakie = new Person("Jake", 500);
            Person Rose = new Person("Rose", 1500);
            Person Devon = new Person("Devon", 250);
            Person Aiden = new Person("Aiden", 750);



            //TODO 6: Call the .DisplayInfo() method on each person object, one at a time. This will show their initial money amount. Two lines.
            Michael.DisplayInfo();
            Jakie.DisplayInfo();


            //TEST THE APPLICATION AFTER TODOS 5 AND 6!!

            //TODO 9: Call the .TransferMoney() method on one person object (giver), making sure to pass in the second person object (receiver), and the amount being transfered. One line.
            Michael.TransferMoney(Jakie, 500);

            //TODO 10: Call the .DisplayInfo() method on each person object again, showing that each person's balance has changed. Two lines.
            Michael.DisplayInfo();
            Jakie.DisplayInfo();

            Console.WriteLine("Simulation complete.");
        }
    }
}
