using System;

namespace DevBuildGrandCircusDay2Number_AnalyzerLab2
{
    class Program
    {
        static void Main(string[] args)

        {
            /*How can if statements be used to cover multiple situations? Can you show an example?
             If statments do this by evaluating condtions to determin wheter they are true or false.
             From there we can set different actions for either the same oor a different situation 
             depending on if that situation is true or false. For example :
             Console.WriteLine("Enter the number 1 if you want to go home and the number 2 if you want to stay: ");
             int x = int.Parse(Console.ReadLine());
             if(x == 1)
             {
                Console.WriteLine(" You get to go home!");
             }
             else if(x == 2)
             {
                Console.WriteLine("You get to stay with me! :)");
             } */

            
            string answer, name;
            Console.Write("Hey, what is your name?");
            name = Console.ReadLine();

            do
            {

               
                Console.Write($"{name}, enter a number between 1 and 100: ");
                double num = double.Parse(Console.ReadLine());
                if (num % 2 == 1 && num > 60)
                {
                    Console.WriteLine($"Hey {name}, {num} is odd!");
                }
                if (num % 2 == 1 && num < 60)
                {
                    Console.WriteLine($"Hey {name}, {num} is odd!");
                }
                if (num % 2 == 0 && num >= 2 && num <= 25)
                    {
                        Console.WriteLine($"Hey {name}, this number is even and less than 25");
                         if (num % 2 == 0 && num >= 26 && num <= 60)
                        {
                            Console.WriteLine($"Hey {name}, this number is even");
                             if (num % 2 == 0 && num > 60)
                            {
                                Console.WriteLine($"Hey {name}, {num} is even!");
                            }
                        }
                    }

                    Console.Write($"Would you like to continue {name}? y/n ");
                    answer = Console.ReadLine().ToLower();
                    if (answer != "y")
                    {
                        Console.WriteLine($"Bye {name}!");
                    }




            }
            while (answer == "y");
                
        }
    }
}
