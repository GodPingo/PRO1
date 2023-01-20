using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            int rend = 0;
            int stava = 0;
            int bet = 0;
            int najv = 0;
            int najm = 9999;
            int betz = 0;
            int dobicek = 0;
            Console.WriteLine("Vnesi denar: ");
            stava = int.Parse(Console.ReadLine());
            Console.WriteLine("Koliko stavite: ");
            bet = int.Parse(Console.ReadLine());
            betz = bet;
            dobicek = stava;
            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                rend = rnd.Next(0, 36);
                if (rend % 2 == 0)
                {
                    Console.WriteLine("Zmagali ste!");
                    stava = stava + bet;
                    Console.WriteLine(stava);
                    bet = betz;
                }
                else
                {
                    Console.WriteLine("Izgubili ste!");
                    stava = stava - bet;
                    Console.WriteLine(stava);
                    bet = bet * 2;
                }
                if(stava > najv)
                {
                    najv = stava;
                }
                if (stava < najm)
                {
                    najm = stava;
                }
            }
            dobicek = stava - dobicek;
            Console.WriteLine("Dobicek/izguba = " + dobicek);
            Console.WriteLine("Največje stanje je bilo:" + najv);
            Console.WriteLine("Najmanjše stanje je bilo: " + najm);
        }
    }
}
