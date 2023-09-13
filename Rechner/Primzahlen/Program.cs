using System;

namespace Primzahlen
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int zahl = 1; zahl <= 2147483647; zahl++)
            {
                bool isPrime = true;

                for (int Überprüfungszahl = 2; Überprüfungszahl <= zahl - 1; Überprüfungszahl++)
                {
                    if (zahl % Überprüfungszahl == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime)
                {
                    Console.WriteLine("Zahl " + zahl + " ist eine Primzahl");
                }
            }
                
            
            // a % b == 0
        }
    }
}
