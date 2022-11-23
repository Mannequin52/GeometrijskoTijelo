using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometrijskoTijelo
{
    class Program
    {
        class Geomtijelo
        {
            private double oplosje;
            private double volumen;

            public double Volumen { get => volumen; set => volumen = value; }
            public double Oplosje { get => oplosje; set => oplosje = value; }


        }
            static class Brojac
            {
                public static int br;
            public override int Brojac() => br++;
        }
            class Kugla : Geomtijelo
            {

            }
            class Kvadar : Geomtijelo
            {

            }
            class Kocka : Kvadar
            {

            }
       

        
        static public void Main(string[] args)
        {
            Kugla x = new Kugla();
            Kvadar y = new Kvadar();
            Kocka z = new Kocka();

            x.Volumen = 54.5;
            x.Oplosje = 38.6;
            y.Volumen = 20;
            y.Oplosje = 19.6;
            z.Volumen = 70;
            z.Oplosje = 35;

            Console.WriteLine("Kugla volumen = " + x.Volumen + "oplosje = " + x.Oplosje +
                "\n Kvadar volumen = " + y.Volumen + "oplosje = " + y.Oplosje +
                "\n Kocka volumen = " + z.Volumen + "oplosje = " + z.Oplosje);
            Console.WriteLine("Brojac = " + Brojac.br);


        }
    }
}
