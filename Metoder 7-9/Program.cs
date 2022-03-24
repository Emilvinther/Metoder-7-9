using System;

namespace Metoder_7_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int arrayresult = arrayfind();
            Console.WriteLine(arrayresult);

            Console.ReadKey();
            Console.Clear();

            int[] winner = new int[7];
            int[] player = new int[7];
            Random random = new Random();
            int winnernumbers = 0;

            for (int i = 0; i < player.Length; i++)
            {
                Console.WriteLine("Vælg et nummer");
                player[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Clear();
            WinnerNumbers(winner, random);
            winnernumbers = LottoCupon(player, winner, winnernumbers);
            Console.WriteLine($"Du har {winnernumbers} rigtige");

            Console.ReadKey();


        }

        public static int arrayfind()
        {
            int[] number = new int[9];

            for (int i = 0; i < number.Length; i++)
            {
                number[i] = i + 1;
                if (i == 5)
                {
                    number[i] = number[i] * 2;  
                }
            }
            return number[5];
        }

        public static int [] WinnerNumbers(int [] winner,Random random)
        {
            for (int i = 0; i < winner.Length; i++)
            {
                winner[i] = random.Next(1, 20);
            }
            return winner;
        }

        public static int LottoCupon(int [] player, int [] winner, int winnernumbers)
        {
          

            for (int i = 0; i < player.Length; i++)
            {
                for (int j = 0; j < winner.Length; j++)
                {
                    if (player[i] == winner[j])
                    {
                       winnernumbers++;
                    }
                }

            }


            return winnernumbers;

        }


    }
}
