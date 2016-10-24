using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Class1

    {
        static void Main()
        {
            //This is a pointless comment for testing gitHub purposes only.

            //Generate Password
            string password = passwordGenerator();
            Console.WriteLine(password);

            //Crack password
            bruteforce(password);
            
            //keeps program running
            Console.ReadLine();

            
        }

        //Generates simple password
        static string passwordGenerator()
        {
            //Creates a new instance of the Random class
            Random random = new Random();
            string password = random.Next(0, 10).ToString();
            password = password + random.Next(0, 10).ToString();
            password = password + random.Next(0, 10).ToString();
            password = password + random.Next(0, 10).ToString();
            return password;
        }

        //Password Y/N checker
        static string guess(string guess, string password)
        {
            
            if (guess == password)
            {
                return "yes";
            }
            else
            {
                Double Doubbleguess;
                Double.TryParse(guess, out Doubbleguess);
                Doubbleguess = Doubbleguess / 100;
                Doubbleguess = Math.Round(Doubbleguess);
                //Console.Clear();
                //Console.WriteLine("[-------" + Doubbleguess + "%-------]");
                return "no";
            }
        }

        //Bruteforce password
        static void bruteforce(string password)
        {
            //Counters
            int counter1 = 0;
            int counter2 = 0;
            int counter3 = 0;
            int counter4 = 0;

            //possible comboss
            string[] firstNum = new string[10] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            string[] secondNum = new string[10] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            string[] thirdNum = new string[10] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            string[] fourthNum = new string[10] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };

            string newGuess = firstNum[counter1] + secondNum[counter2] + thirdNum[counter3] + fourthNum[counter4];

            while (counter1 < 10)
            {
                while (counter2 < 10)
                {
                    while (counter3 < 10)
                    {
                        while (counter4 < 10)
                        {
                            newGuess = firstNum[counter1] + secondNum[counter2] + thirdNum[counter3] + fourthNum[counter4];
                            if (guess(newGuess, password) == "yes")
                            {
                                break;
                            }
                            counter4 += 1;
                        }
                        if (guess(newGuess, password) == "yes")
                        {
                            break;
                        }
                        counter3 += 1;
                        counter4 = 0;
                    }
                    if (guess(newGuess, password) == "yes")
                    {
                        break;
                    }
                    counter2 += 1;
                    counter3 = 0;
                    counter4 = 0;
                }
                if (guess(newGuess, password) == "yes")
                {
                    Console.WriteLine("Password: " + newGuess);
                    break;
                }
                counter1 += 1;
                counter2 = 0;
                counter3 = 0;
                counter4 = 0;
            }
        }
    }
}
