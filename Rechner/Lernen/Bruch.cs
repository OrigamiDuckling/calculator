using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rechner
{
    public class Bruch
    {
        public int _zähler;
        public int _nenner;


        public Bruch(int zähler, int nenner)
        {
            _nenner = nenner;
            _zähler = zähler;

        }


        public string ToString()
        {
            int newGanzes;
            int newZähler;
            int newNenner;
            newNenner = _nenner;
            newZähler = _zähler % _nenner;
            newGanzes = _zähler / _nenner;
            if (newZähler == 0)
            {
                return "" + newGanzes;
            }
            else
            {
                return newGanzes + " " + newZähler + "/" + newNenner;
            }
            
        }

        public Bruch Add(Bruch x)
        {
            int newNenner = _nenner * x._nenner;
            int newZähler = _zähler * x._nenner + x._zähler * _nenner;

            return Runden(new Bruch(newZähler, newNenner));
        }
        public Bruch Sub(Bruch x)
        {
            int newNenner = _nenner * x._nenner;
            int newZähler = _zähler * x._nenner - x._zähler * _nenner;

            return Runden(new Bruch(newZähler, newNenner));

        }
        public Bruch Mul(Bruch x)
        {
            int newNenner = _nenner * x._nenner;
            int newZähler = _zähler * x._zähler;

            return Runden(new Bruch(newZähler, newNenner));

        }

        public Bruch Div(Bruch x)
        {
            int newNenner = _nenner * x._zähler;
            int newZähler = _zähler * x._nenner;

            return Runden(new Bruch(newZähler, newNenner));

        }


        public Bruch Runden(Bruch bruch)
        {

            int newNenner = bruch._nenner;
            int newZähler = bruch._zähler;

            while (true)
            {
                int ggt = GGT(newZähler, newNenner);

                newZähler = newZähler / ggt;
                newNenner = newNenner / ggt;

                if (ggt == 1)
                {
                    break;
                }
  
            }

            return new Bruch(newZähler, newNenner); 

        }

        private int GGT(int zahl1, int zahl2)
        {
            while (zahl2 > 0)
            {
                if (zahl1 > zahl2)
                {
                    zahl1 = zahl1 - zahl2;
                }
                else
                {
                    zahl2 = zahl2 - zahl1;
                }
            }

            return zahl1;
        }
    }
}
