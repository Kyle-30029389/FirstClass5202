using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            int end = 1;
            int attempts = 0;
            Console.WriteLine("Hello what is your name");
            string name = Console.ReadLine();
            if(name == "kyle")
            {
                Console.Clear();
                Console.WriteLine("Welcome Creator");
                Console.ReadLine();
            }
            if(name == "oliver")
            {
                Console.Clear();
                Console.WriteLine("Bad");
                Console.ReadLine();
            }
           
 
            Console.Clear();


            Random rnd = new Random();
            int RandomNumber = rnd.Next(0, 1000);
            while (end == 1)
            {
                attempts++;
                Console.WriteLine("Guess a number between 0 , 1000");
                int guess = int.Parse(Console.ReadLine());
                if(guess == RandomNumber)
                {
                    end = 0;
                    Console.WriteLine("Congrats " + name + " you are correct");
                    Console.WriteLine("You had " + attempts + " Attempts " + name);
                    Console.ReadLine();
                }
                if(guess > RandomNumber)
                {
                    Console.WriteLine("Too High");
                }
                if(guess < RandomNumber)
                {
                    Console.WriteLine("Too low");
                }

            }
            
        }
    }
}
