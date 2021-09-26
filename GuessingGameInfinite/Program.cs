using System;

namespace GuessingGameInfinite
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm genereerib juhuslikku numbrit 1 kuni 10;
            //kasutaja peab seda numbrit ära arvama;
            //kui kasutaja suutis seda numbrit ära arvata, siis ta on mängu võitnud;
            //katsete arv on piiramatu.
            //programm genereerib juhuslikku numbrit ühte korda.

            Random rnd = new Random();
            int cpuNumber = rnd.Next(1, 11);

            //Console.WriteLine($"Juhuslik number on: {cpuNumber}");

            while (true)
            {
                Console.WriteLine("Sisesta arvatav number 1 kuni 10:");
                int userNumber = Convert.ToInt32(Console.ReadLine());
                
                if (userNumber == cpuNumber)
                {
                    Console.WriteLine("Palju õnne! Olete mängu võitnud!");
                    break;
                }
                else
                {
                    Console.WriteLine("Proovi uuesti!");
                }
            }
        }
    }
}
