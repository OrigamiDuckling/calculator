using System;
using System.Collections.Generic;
using System.Text;

namespace Rechner
{
    public class Rechteck
    {
        public double _höhe;
        public double _breite;

        public Rechteck(double höhe, double breite)
        {
            _höhe = höhe;
            _breite = breite;
        }
        public string Formel()
        {
            return "Höhe: " + _höhe + " Breite: " + _breite;
        }
        public double Umfang()
        {
            return (_höhe * 2) + (_breite * 2);
        }
        public double Flächeninhalt()
        {
            return _höhe * _breite;
        }


    }
}
