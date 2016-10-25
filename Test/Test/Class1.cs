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

            //Generate Password
            string password = passwordGenerator();
            Console.WriteLine(password);

            ////Crack password
            //bruteforce(password);

            //Console.ReadLine();

            
        }

        //Generates simple password
        static string passwordGenerator()
        {
            //Random random = new Random();
            //string password = random.Next(0, 10).ToString();
            //password = password + random.Next(0, 10).ToString();
            //password = password + random.Next(0, 10).ToString();
            //password = password + random.Next(0, 10).ToString();
            //return password;

            Random random = new Random();



            int pn1 = random.Next(0, 37);
            int pn2 = random.Next(0, 37);
            int pn3 = random.Next(0, 37);
            int pn4 = random.Next(0, 37);
            string finalpassword = itc(pn1, pn2, pn3, pn4);
            return finalpassword;
        }

        //this is an exparamental method to convert the string value of the password generator to letters and numbers.

        static string itc(int pn1, int pn2, int pn3, int pn4)
        {
            string[] possChrs = new string[26] { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };

            string finalpassword;
            string pn1ts = pn1.ToString();
            string pn2ts = pn1.ToString();
            string pn3ts = pn1.ToString();
            string pn4ts = pn1.ToString();

            if (pn1 > 9)
            {
                pn1ts = possChrs[pn1 - 1];
            }

            if (pn2 > 9)
            {
                pn2ts = possChrs[pn2 - 1];
            }

            if (pn3 > 9)
            {
                pn3ts = possChrs[pn3 - 1];
            }

            if (pn4 > 9)
            {
                pn4ts = possChrs[pn4 - 1];
            }

            finalpassword = pn1ts + pn2ts + pn3ts + pn4ts;

            //temp to satisy return
            return finalpassword;
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
