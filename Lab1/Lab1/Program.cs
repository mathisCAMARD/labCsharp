using System;

namespace Lab1
{
    class Program
    {
        const int change100 = 100, change50 = 50, change20 = 20, change10 = 10, change5 = 5, change2 = 2, change1 = 1;
        public static int resultChange100 = 0, resultChange50 = 0, resultChange20 = 0, resultChange10 = 0, resultChange5 = 0, resultChange2 = 0, resultChange1 = 0;
        static int price = 0, paid = 0, change = 0;
        static bool a = true;
        static string str = "Your change is : ";

        static void Main(string[] args)
        {
            Console.WriteLine("What is the price ?");
            price = int.Parse(Console.ReadLine());

            do
            {
                Console.WriteLine("What did you pay ?");
                paid = int.Parse(Console.ReadLine());
            } while (paid < price);


            if (paid - price != 0)
            {

                change = paid - price;
                while (a == true)
                {
                    change = calculChangeRest(change, change100);
                }
                a = true;
                while (a == true)
                {
                    change = calculChangeRest(change, change50);
                }
                a = true;
                while (a == true)
                {
                    change = calculChangeRest(change, change20);
                }
                a = true;
                while (a == true)
                {
                    change = calculChangeRest(change, change10);
                }
                a = true;
                while (a == true)
                {
                    change = calculChangeRest(change, change5);
                }
                a = true;
                while (a == true)
                {
                    change = calculChangeRest(change, change2);
                }
                a = true;
                while (a == true)
                {
                    change = calculChangeRest(change, change1);
                }
                
            }

            
            str = resultStr(str);
            Console.WriteLine(str);
        }

        public static int calculChangeRest(int change, int changeCoins)
        {


            int changeTemp = change;

            if (changeTemp - changeCoins >= 0)
            {

                if (changeCoins == 100)
                {
                    Program.resultChange100++;
                }
                if (changeCoins == 50)
                {
                    Program.resultChange50++;
                }

                if (changeCoins == 20)
                {
                    Program.resultChange20++;
                }

                if (changeCoins == 10)
                {
                    Program.resultChange10++;
                }

                if (changeCoins == 5)
                {
                    Program.resultChange5++;
                }

                if (changeCoins == 2)
                {
                    Program.resultChange2++;
                }

                if (changeCoins == 1)
                {
                    Program.resultChange1++;
                }

                changeTemp = change - changeCoins;
            }
            else
            {
                a = false;
            }

            return changeTemp;

        }

        public static string resultStr(string str)
        {
            for (int i = 0; i < resultChange100; i++)
            {
                str += change100 + " ";
            }
            for (int i = 0; i < resultChange50; i++)
            {
                str += change50 + " ";
            }
            for (int i = 0; i < resultChange20; i++)
            {
                str += change20 + " ";
            }
            for (int i = 0; i < resultChange10; i++)
            {
                str += change10 + " ";
            }
            for (int i = 0; i < resultChange5; i++)
            {
                str += change5 + " ";
            }
            for (int i = 0; i < resultChange2; i++)
            {
                str += change2 + " ";
            }
            for (int i = 0; i < resultChange1; i++)
            {
                str += change1 + " ";
            }

            return str;
        }
    }
}
