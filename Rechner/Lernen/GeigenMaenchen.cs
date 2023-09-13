using System;
using System.Collections.Generic;
using Console = Colorful.Console;
using System.Text;
using System.Drawing;

namespace GeigenMaenchenSpiel
{

    public class GeigenMaenchen
    {
        string[] wortArray;
        string[] spielArray;
        int leben;

        public void Spiel()
        {
            Worteingabe();
            spielArrayErstellen();
            aktuellesSpielArray();
        }

        private void Worteingabe()
        {
            leben = 5;

            Console.WriteAscii("Geigenmaennchen", Color.Aqua);
            Console.WriteLine("Bitte geben sie das gesuchte Wort ein", Color.AntiqueWhite);
            string wort = Console.ReadLine();
            wortArray = new string[wort.Length];
            
            for (int i = 0; i <= wortArray.Length - 1; i++)
            {
                wortArray[i] = wort[i].ToString();
            }
        }
        private void spielArrayErstellen()
        {
            spielArray = new string[wortArray.Length];
            for (int a = 0; a <= wortArray.Length - 1; a++)
            {
                spielArray[a] = " _ ";
            }  
        }
        private void aktuellesSpielArray()
        {
            Console.WriteLine("Zu rantendes Wort: ", Color.AntiqueWhite);
            for (int i = 0; i <= spielArray.Length - 1; i++)
            {
                Console.Write(spielArray[i]);
            }

            Console.WriteLine("");

            bool istfertig = true;

            for (int i = 0; i <= spielArray.Length - 1; i++)
            {
                if (spielArray[i].Equals(" _ "))
                {
                    istfertig = false;
                }
            }

            if  (istfertig)
            {
                ende();
            }
            else
            {
                buchstabenEingabe();
            }
        }
        private void buchstabenEingabe()
        {
            Console.WriteLine(leben + " " + "<3", Color.Red);
            Console.WriteLine("Bitte Buchstabe eingeben: ", Color.AntiqueWhite);
            string a = Console.ReadLine();

            bool buchstabe_korrekt = false;

            for (int b = 0; b <= wortArray.Length - 1; b++)
            {
                if (wortArray[b].Equals(a))
                {
                    spielArray[b] = a;
                    buchstabe_korrekt = true;
                }
            }
            if (buchstabe_korrekt == false)
            {
                leben--;
            }

            if (leben == 0)
            {
                verloren();
            }
            else
            {
                aktuellesSpielArray();
            }

        }

        private void ende()
        {
            string wort = "";
            
            for (int i = 0;  i <= spielArray.Length - 1; i++)
            {
                wort = wort + spielArray[i];
            }
            Console.WriteLine("Herzlichen Glückwunsch. Du hast das Wort " + wort +" erraten", Color.AntiqueWhite);
        }
        private void verloren()
        {
            Console.WriteLine("Du hast verloren!", Color.Red); 
        }
    }
}