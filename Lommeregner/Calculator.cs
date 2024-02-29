using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lommeregner
{
    internal class Calculator

    {
        //Forklaring på hvad de forskellige ting betyder i første linje dvs. linje 18
        // Access modifier: public
        // Returtype: int (metoden returnerer et heltal)/svaret jeg får når jeg bruger metoden får jeg i form af den her datatype
        // Metodenavn: AddNumbers, beskriver metodens formål, hvad den skal gøre
        // Parametre: to heltal, som metoden modtagere som indput, a og b

        public int Add(int a, int b)
        {
            // Metoden skal lægger de to tal sammen
            int result = a + b;

            // Returnerer resultatet
            return result;
        }

        public int Substract(int a, int b)
        {
            // Metoden skal minuse de to tal
            int result = a - b;

            // Returnerer resultatet
            return result;
        }

        public double Divide(int a, int b)
        {
            // Metoden skal dividere de to tal
            double result = (double)a / b;

            // Returnerer resultatet
            return result;
        }

        public int Multiply(int a, int b)
        {
            // Metoden skal gange de to tal sammen
            int result = a * b;

            // Returnerer resultatet
            return result;
        }




    }
}
