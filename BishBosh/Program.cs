using System;

namespace BishBosh
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Bish-Bosh";
            GameMenu();
        }

        public static void GameMenu()
        {
            int userMenuPick = 0;
            bool isNumber = false;

            while (userMenuPick != 2)
            {
                Console.WriteLine("Welcome to a simple game of Bish-Bosh!\nChoose one of the two options:\n1. Play Bish-Bosh\n2. Quit the game");
                isNumber = int.TryParse(Console.ReadLine(), out userMenuPick);

                //Catch if user tries anything funny instead of numbers.
                if (!isNumber)
                {
                    Console.WriteLine("Has to be a number! Try again.\n\nPress KEY to continue. . . .");
                    Console.ReadKey();
                    Console.Clear();
                }
                else
                {
                    switch (userMenuPick)
                    {
                        case 1:
                            PlayGame();
                            break;
                        case 2:
                            Console.WriteLine("See you later!");
                            break;
                        default:
                            Console.WriteLine("Invalid input!\nPress KEY to try again.....");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                    }

                    Console.Clear();
                }

            }

        }

        public static void PlayGame() 
        {
            Console.Clear();

            //Gets the numbers from user. Assign to corresponding variable.
            int userNumberMaximum = GetNumber("max number");
            int bishNumber = GetNumber("bish number");
            int boshNumber = GetNumber("bosh number");

            //Console clear for aesthetic. 
            Console.Clear();
            Console.WriteLine($"Max number is: {userNumberMaximum}\tBish number is : {bishNumber}\tBosh number is: {boshNumber}\n-------------------------");

            for (int i = 1; i <= userNumberMaximum; i++)
            {
                //Checks if i is able to divide to zero with the different numbers.
                if (i % bishNumber == 0 && i % boshNumber == 0)
                {
                    Console.Write("Bish-Bosh ");
                    continue;
                }
                else if (i % bishNumber == 0)
                {
                    Console.Write("Bish ");
                }
                else if (i % boshNumber == 0)
                {
                    Console.Write("Bosh ");
                }
                else
                {
                    Console.Write(i + " ");
                }


            }

            //Waits for user input.
            Console.WriteLine("Press KEY to for menu . . . .");
            Console.ReadKey();

        }


        //Methods for getting different numbers to use in main.
        public static int GetNumber(string whatNumber)
        {
            int userNumber = 0;
            bool isNumber = false;

            do
            {
                Console.Write($"Write in your {whatNumber}: ");
                isNumber = int.TryParse(Console.ReadLine(), out userNumber);

                if (!isNumber)
                {
                    Console.Clear();
                    Console.WriteLine("Hey! It has to be a number.\nTry Again.");
                }

            } while (!isNumber);


            return userNumber;
        }


    }
}
