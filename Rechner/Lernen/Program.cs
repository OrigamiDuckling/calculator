using System;
using System.Drawing;
using Console = Colorful.Console;
using GeigenMaenchenSpiel;
using Rechner;

namespace Lernen
{
    class Program
    {
        static void Main(string[] args)
        {
            Program lernen = new Program();
            GeigenMaenchen Spiel = new GeigenMaenchen();
            lernen.UltimativesMathematikTool();
            //Spiel.Spiel();
            //jlernen.rechner();
            //lernen.Schleife();
            //lernen.FibonacciFolge();
            //lernen.EinfacheMultiplikation();
            //lernen.Fakultät();
            //lernen.WhichIsTheBiggerNumber();
            //lernen.NumberSorter();
            //lernen.arraytest();
            //lernen.stringarray();
            //lernen.arrayMath();
            //lernen.averageNumber();
            //lernen.dezimalZuProzent();
            //lernen.ungerade();
            //lernen.ungerade2();
            //lernen.bruchrechner();
            //lernen.bruchrechnerAdd();
            //lernen.bruchrechnerSub();
            //lernen.bruchrechnerMul();
            //lernen.bruchrechnerDiv();;
            //lernen.quadrat();
        }

        private void rechner()
        {
            Console.WriteLine("Erste Zahl:", Color.AntiqueWhite);
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Zeichen", Color.AntiqueWhite);
            string c = Console.ReadLine();
            Console.WriteLine("Zweite Zahl:", Color.AntiqueWhite);
            double b = double.Parse(Console.ReadLine());


            if (c.Equals("-"))
            {
                minus(a, b);
            }
            if (c.Equals("+"))
            {
                add(a, b);
            }
            if (c.Equals("/"))
            {
                division(a, b);
            }
            if (c.Equals("*"))
            {
                multiplication(a, b);
            }

            Console.WriteLine("Nochmal oder zurück zum Menu? [y/n/m]", Color.AntiqueWhite);
            string y = Console.ReadLine();

            if (y.Equals("y"))
            {
                rechner();
            }
            if (y.Equals("m"))
            {
                UltimativesMathematikTool();
            }
            else
            {
                Console.WriteLine("Danke und Tschüss!", Color.AntiqueWhite);
            }
        }

        private void add(double a, double b)
        {
            Console.WriteLine("Ergebnis:" + (a + b), Color.AntiqueWhite);
        }

        private void minus(double a, double b)
        {
            Console.WriteLine("Ergebnis:" + (a - b), Color.AntiqueWhite);
        }
        private void division(double a, double b)
        {
            Console.WriteLine("Ergebnis:" + (a / b), Color.AntiqueWhite);
        }
        private void multiplication(double a, double b)
        {
            Console.WriteLine("Ergebnis:" + (a * b), Color.AntiqueWhite);
        }

        private void Schleife()
        {
            Console.WriteLine("Bis welche Zahl?:", Color.AntiqueWhite);
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Wie groß sollen die schritte sein?:", Color.AntiqueWhite);
            int z = int.Parse(Console.ReadLine());

            for (int i = 0; i <= x; i = i + z)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Nochmal oder zurück zum Menu? [y/n/m]", Color.AntiqueWhite);
            string y = Console.ReadLine();
            if (y.Equals("y"))
            {
                Schleife();
            }
            if (y.Equals("m"))
            {
                UltimativesMathematikTool();
            }
            else
            {
                Console.WriteLine("Danke und Tschüss!", Color.AntiqueWhite);
            }
        }
        private void FibonacciFolge()
        {
            int a = 0;
            int b = 1;
            Console.WriteLine("Wie oft?", Color.AntiqueWhite);
            int x = int.Parse(Console.ReadLine());

            for (int i = 0; i <= x; i++)
            {
                Console.WriteLine(a + b);
                Console.WriteLine();
                int c = a + b;
                a = b;
                b = c;

            }
            Console.WriteLine("Nochmal oder zurück zum Menu? [y/n/m]", Color.AntiqueWhite);
            string y = Console.ReadLine();

            if (y.Equals("y"))
            {
                FibonacciFolge();
            }
            if (y.Equals("m"))
            {
                UltimativesMathematikTool();
            }
            else
            {
                Console.WriteLine("Danke und Tschüss!", Color.AntiqueWhite);
            }
        }
        private void EinfacheMultiplikation()
        {
            Console.WriteLine("Nummer Eins: ", Color.AntiqueWhite);
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Nummer Zwei: ", Color.AntiqueWhite);
            int z = int.Parse(Console.ReadLine());

            for (int a = 0; a <= x; a++)
                for (int b = 0; b <= z; b++)
                    Console.WriteLine(a * b);
            {
                Console.WriteLine("Nochmal oder zurück zum Menu? [y/n/m]", Color.AntiqueWhite);
                string y = Console.ReadLine();

                if (y.Equals("y"))
                {
                    EinfacheMultiplikation();
                }
                if (y.Equals("m"))
                {
                    UltimativesMathematikTool();
                }
                else
                {
                    Console.WriteLine("Danke und Tschüss!", Color.AntiqueWhite);
                }
            }

        }
        private void Fakultät()
        {
            Console.WriteLine("Geben sie ihre Zahl ein", Color.AntiqueWhite);
            int a = int.Parse(Console.ReadLine());

            int b = 1;

            for (int x = 1; x <= a; x++)

            {
                b = b * x;
                //Console.WriteLine("b: " + b);
                //Console.WriteLine("x: " + x);
            }
            {
                Console.WriteLine(b);
            }

            Console.WriteLine("Nochmal oder zurück zum Menu? [y/n/m]", Color.AntiqueWhite);
            string y = Console.ReadLine();

            if (y.Equals("y"))
            {
                Fakultät();
            }
            if (y.Equals("m"))
            {
                UltimativesMathematikTool();
            }
            else
            {
                Console.WriteLine("Danke und Tschüss!", Color.AntiqueWhite);
            }
        }
        private void WhichIsTheBiggerNumber()
        {
            Console.WriteLine("Erste Zahl:", Color.AntiqueWhite);
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Zweite Zahl:", Color.AntiqueWhite);
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Dritte Zahl:", Color.AntiqueWhite);
            double c = double.Parse(Console.ReadLine());

            if (a > b && a > c)
            {
                Console.WriteLine("Erste Zahl is biggest", Color.AntiqueWhite);
            }
            if (b > a && b > c)
            {
                Console.WriteLine("Zweite Zahl is biggest", Color.AntiqueWhite);
            }
            if (c > a && c > b)
            {
                Console.WriteLine("Dritte Zahl is biggest", Color.AntiqueWhite);
            }
            if (a == b && c == b && c == a)
            {
                Console.WriteLine("Zahlen sind gleich", Color.AntiqueWhite);
            }
            Console.WriteLine("Nochmal oder zurück zum Menu? [y/n/m]", Color.AntiqueWhite);
            string y = Console.ReadLine();

            if (y.Equals("y"))
            {
                WhichIsTheBiggerNumber();
            }
            if (y.Equals("m"))
            {
                UltimativesMathematikTool();
            }
            else
            {
                Console.WriteLine("Danke und Tschüss!", Color.AntiqueWhite);
            }
        }
        private void NumberSorter()
        {
            Console.WriteLine("Erste Zahl:", Color.AntiqueWhite);
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Zweite Zahl:", Color.AntiqueWhite);
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Dritte Zahl:", Color.AntiqueWhite);
            double c = double.Parse(Console.ReadLine());
            //double a = 4;
            //double b = 2;
            //double c = 1;

            if (a > b && a > c)
            {
                if (b > c)
                {
                    Console.WriteLine(a + " " + b + " " + c, Color.AntiqueWhite);
                }
                else
                {
                    Console.WriteLine(a + " " + c + " " + b, Color.AntiqueWhite);
                }
            }
            if (b > a && b > c)
            {
                if (c > a)
                {
                    Console.WriteLine(b + " " + c + " " + a, Color.AntiqueWhite);
                }
                else
                {
                    Console.WriteLine(b + " " + a + " " + c, Color.AntiqueWhite);
                }
            }
            if (c > a && c > b)
            {
                if (b > a)
                {
                    Console.WriteLine(c + " " + b + " " + a, Color.AntiqueWhite);
                }
                else
                {
                    Console.WriteLine(c + " " + a + " " + b, Color.AntiqueWhite);
                }
            }
            if (a == b && c == b && c == a)
            {
                Console.WriteLine(a + " " + b + " " + c, Color.Red);
            }
            Console.WriteLine("Nochmal oder zurück zum Menu? [y/n/m]", Color.AntiqueWhite);
            string y = Console.ReadLine();

            if (y.Equals("y"))
            {
                NumberSorter();
            }
            if (y.Equals("m"))
            {
                UltimativesMathematikTool();
            }
            else
            {
                Console.WriteLine("Danke und Tschüss!", Color.AntiqueWhite);
            }
        }
        private void UltimativesMathematikTool()
        //Version 1.0.2
        //Plan: aus [y/n] ein [y/n/m], m = menu / DONE
        {
            {
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteAscii("MATH TOOL", Color.LightCoral);
                Console.WriteLine("Version 1.0.2", Color.LightGreen);
                Console.WriteLine("Changelog: ", Color.LightGreen);
                Console.WriteLine(" ");
                Console.WriteLine("17.11.2021, Ver 1.0.1 ", Color.LightGreen);
                Console.WriteLine("+ Added Colors, ASCII, Changelog and Version counter ", Color.LightGreen);
                Console.WriteLine("18.11.2021, Ver 1.0.2 (Newest) ", Color.LightGreen);
                Console.WriteLine("+ Added 2 new functions, avrg and dcm% ", Color.LightGreen);
                Console.WriteLine("+ Added function to go back to menu", Color.LightGreen);
                Console.WriteLine("+ Made menu fancy and a few fixes", Color.LightGreen);
                Console.WriteLine(" ");
                Console.WriteLine("Willkommen zum Ultimativem Mathe Tool", Color.LightCoral);
                Console.WriteLine("Was möchten sie machen?", Color.LightCoral);
                Console.WriteLine("calc = Taschenrechner", Color.LightCoral);
                Console.WriteLine("loop = Schleife", Color.LightCoral);
                Console.WriteLine("fibbo = Fibonacci Folge", Color.LightCoral);
                Console.WriteLine("m = Einfache Multiplikation", Color.LightCoral);
                Console.WriteLine("fa = Fakultät", Color.LightCoral);
                Console.WriteLine("> or < = Was ist die größere nummer?", Color.LightCoral);
                Console.WriteLine("sort = Nummer sortierung", Color.LightCoral);
                Console.WriteLine("avrg = Durschnitt von 4 Zahlen herausfinden", Color.LightCoral);
                Console.WriteLine("dcm% = dezimal Zahlen zu Prozent", Color.LightCoral);
            }

            string t = Console.ReadLine();


            if (t.Equals("calc"))
            {
                rechner();
            }
            if (t.Equals("loop"))
            {
                Schleife();
            }
            if (t.Equals("fibbo"))
            {
                FibonacciFolge();
            }
            if (t.Equals("m"))
            {
                EinfacheMultiplikation();
            }
            if (t.Equals("fa"))
            {
                Fakultät();
            }
            if (t.Equals(">"))
            {
                WhichIsTheBiggerNumber();
            }
            if (t.Equals("<"))
            {
                WhichIsTheBiggerNumber();
            }
            if (t.Equals("sort"))
            {
                NumberSorter();
            }
            if (t.Equals("avrg"))
            {
                averageNumber();
            }
            if (t.Equals("dcm%"))
            {
                dezimalZuProzent();
            }
                
        }

        private void arraytest()
        {
            int[] testarray = new int[5];
            int[] testarray2 = new int[] { 0, 542, 897, -45 };

            string[] stringarray = new[] { "mein", "Haus", "brennt" };

            testarray[3] = 18;
            testarray[1] = 2;

            for (int i = 0; i <= testarray.Length - 1; i++)
            {
                Console.WriteLine(testarray[i]);
            }

            Console.WriteLine("");

            for (int i = 0; i <= testarray2.Length - 1; i++)
            {
                Console.WriteLine(testarray2[i]);
            }

            Console.WriteLine("");

            for (int i = 0; i <= stringarray.Length - 1; i++)
            {
                Console.WriteLine(stringarray[i]);
            }

            Console.WriteLine("");

            for (int i = 0; i <= testarray.Length - 1; i++)
            {
                testarray[i] = i;
                Console.WriteLine(testarray[i]);
            }
        }
        private void stringarray()
        {
            Console.WriteLine("Zahlen und/oder Buchstaben deiner Wahl eingeben (Max:15)", Color.AntiqueWhite);
            string[] stringarray1 = new string[15];

            for (int i = 0; i <= stringarray1.Length - 1; i++)
            {
                stringarray1[i] = Console.ReadLine();
            }

            Console.WriteLine(" ");

            for (int i = 0; i <= stringarray1.Length - 1; i++)
            {
                Console.WriteLine(stringarray1[i]);
            }


        }
        private void arrayMath()
        {
            int x = 0;

            int[] TESTARRAY = new int[4];
            Console.WriteLine("Zahlen deiner Wahl eingeben (Max:4)", Color.AntiqueWhite);

            for (int i = 0; i <= TESTARRAY.Length - 1; i++)
            {
                TESTARRAY[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(" ");

            for (int i = 0; i <= TESTARRAY.Length - 1; i++)
            {
                x = x + TESTARRAY[i];
            }
            Console.WriteLine("Ergebnis:" + (x), Color.AntiqueWhite);

        }
        private void averageNumber()
        {
            double[] a = new double[4];
            Console.WriteLine("Zahlen deiner Wahl eingeben (Max:4)", Color.AntiqueWhite);

            for (int i = 0; i <= a.Length - 1; i++)
            {
                a[i] = double.Parse(Console.ReadLine());
            }

            double b = (a[0] + a[1] + a[2] + a[3]) / a.Length;
            Console.WriteLine("Der durchschnitt ist: " + b);

            Console.WriteLine("Nochmal oder zurück zum Menu? [y/n/m]", Color.AntiqueWhite);
            string y = Console.ReadLine();

            if (y.Equals("y"))
            {
                averageNumber();
            }
            if (y.Equals("m"))
            {
                UltimativesMathematikTool();
            }
            else
            {
                Console.WriteLine("Danke und Tschüss!", Color.AntiqueWhite);
            }

        }
        private void dezimalZuProzent()
        {
            Console.WriteLine("Zahl, die zur % Zahlen werden soll (Nur Komma Zahlen!):", Color.AntiqueWhite);
            decimal a = decimal.Parse(Console.ReadLine());
            Console.WriteLine(a * 100 + "%", Color.AntiqueWhite);

            Console.WriteLine("Nochmal oder zurück zum Menu? [y/n/m]", Color.AntiqueWhite);
            string y = Console.ReadLine();

            if (y.Equals("y"))
            {
                dezimalZuProzent();
            }
            if (y.Equals("m"))
            {
                UltimativesMathematikTool();
            }
            else
            {
                Console.WriteLine("Danke und Tschüss!", Color.AntiqueWhite);
            }
        }
        private void ungerade()
        {
            Console.WriteLine("Geben sie ein bis welche Nummer man zählen soll.");
            int a = int.Parse(Console.ReadLine());
            for (int i = 0; i <= a; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i + " ist gerade");
                }
            }
        }
        private void ungerade2()
        {
            Console.WriteLine("Geben sie 5 Nummern ein.");
            int[] a = new int[5];
            for (int i = 0; i <= a.Length - 1; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            for (int b = 0; b <= a.Length - 1; b++)
            {
                if (a[b] % 2 == 0)
                {
                    Console.WriteLine(a[b] + " ist eine gerade Zahl", Color.LightGreen);
                }
                else
                {
                    Console.WriteLine(a[b] + " ist eine ungerade Zahl", Color.Red);
                }
            }




        }
        private void bruchrechner()
        {
            Console.WriteLine("Zeichen", Color.AntiqueWhite);
            string z = Console.ReadLine();


            if (z.Equals("-"))
            {
                bruchrechnerSub();
            }
            if (z.Equals("+"))
            {
                bruchrechnerAdd();
            }
            if (z.Equals("/"))
            {
                bruchrechnerDiv();
            }
            if (z.Equals("*"))
            {
                bruchrechnerMul();
            }
        }
            private void bruchrechnerAdd()
        {
            Console.WriteLine("Erster Zähler Zahl:", Color.AntiqueWhite);
            int zähler1 = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Erster Nenner Zahl:", Color.AntiqueWhite);
            int nenner1 = int.Parse(Console.ReadLine());
            Bruch x = new Bruch(zähler1, nenner1);

            Console.WriteLine("Zweiter Zähler:", Color.AntiqueWhite);
            int zähler2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Zweiter Nenner:", Color.AntiqueWhite);
            int nenner2 = int.Parse(Console.ReadLine());
            Bruch y = new Bruch(zähler2, nenner2);

            Bruch z = x.Add(y);
            Console.WriteLine(z.ToString());
        }
        private void bruchrechnerSub()
        {
            Console.WriteLine("Erster Zähler Zahl:", Color.AntiqueWhite);
            int zähler1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Erster Nenner Zahl:", Color.AntiqueWhite);
            int nenner1 = int.Parse(Console.ReadLine());
            Bruch x = new Bruch(zähler1, nenner1);

            Console.WriteLine("Zweiter Zähler:", Color.AntiqueWhite);
            int zähler2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Zweiter Nenner:", Color.AntiqueWhite);
            int nenner2 = int.Parse(Console.ReadLine());
            Bruch y = new Bruch(zähler2, nenner2);

            Bruch z = x.Sub(y);
            Console.WriteLine(z.ToString());
        }
        private void bruchrechnerMul()
        {
            Console.WriteLine("Erster Zähler Zahl:", Color.AntiqueWhite);
            int zähler1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Erster Nenner Zahl:", Color.AntiqueWhite);
            int nenner1 = int.Parse(Console.ReadLine());
            Bruch x = new Bruch(zähler1, nenner1);

            Console.WriteLine("Zweiter Zähler:", Color.AntiqueWhite);
            int zähler2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Zweiter Nenner:", Color.AntiqueWhite);
            int nenner2 = int.Parse(Console.ReadLine());
            Bruch y = new Bruch(zähler2, nenner2);

            Bruch z = x.Mul(y);
            Console.WriteLine(z.ToString());
        }
        private void bruchrechnerDiv()
        {
            Console.WriteLine("Erster Zähler Zahl:", Color.AntiqueWhite);
            int zähler1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Erster Nenner Zahl:", Color.AntiqueWhite);
            int nenner1 = int.Parse(Console.ReadLine());
            Bruch x = new Bruch(zähler1, nenner1);

            Console.WriteLine("Zweiter Zähler:", Color.AntiqueWhite);
            int zähler2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Zweiter Nenner:", Color.AntiqueWhite);
            int nenner2 = int.Parse(Console.ReadLine());
            Bruch y = new Bruch(zähler2, nenner2);

            Bruch z = x.Div(y);
            Console.WriteLine(z.ToString());
        }
        private void quadrat()
        {
            Console.WriteLine("Höhe in CM: ", Color.AntiqueWhite);
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Breite in CM:", Color.AntiqueWhite);
            double c = double.Parse(Console.ReadLine());

            Rechteck a = new Rechteck(b, c);
            
            Console.WriteLine(a.Formel());
            double umfang = a.Umfang();
            Console.WriteLine("Umfang " + umfang, Color.AntiqueWhite );
            double flächeninhalt = a.Flächeninhalt();
            Console.WriteLine("Flächeninhalt " + flächeninhalt, Color.AntiqueWhite);


        }
    }
}  