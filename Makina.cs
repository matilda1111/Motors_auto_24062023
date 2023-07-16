using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Motors_auto_24062023
{
    public class Makina
    {
        public string Marka;
        public string Modeli;
        public int Viti;
        public string Struktura;
        public string Konsumi;
        public double Motorri;
        public double Kapaciteti;
        public double KapacitetiTotal;
        public double Harxhimi;             // Konsumi ne litra i makines per 1 kilometer

        public Makina(string marka, string modeli, int viti, string struktura, string konsumi, double motorri, double kapaciteti, double kapacitetiTotal, double harxhimi)
        {
            Marka = marka;
            Modeli = modeli;
            Viti = viti;
            Struktura = struktura;
            Konsumi = konsumi;
            Motorri = motorri;
            Kapaciteti = kapaciteti;
            KapacitetiTotal = kapacitetiTotal;
            Harxhimi = harxhimi;
        }

        public void Specifikimet(Makina makina)
        {
            Console.WriteLine($"Ju keni zgjedhur {makina.Marka} {makina.Modeli}. Parametrat e makines jane:");
            Console.WriteLine($"Viti i Prodhimit: {makina.Viti}");
            Console.WriteLine($"Karburanti: {makina.Konsumi}");
            Console.WriteLine($"Motorri: {makina.Motorri}");
        }

        public void Menu()
        {
            Console.WriteLine("1. Bej Xhiro       2. Laj Makinen        3. Parko         4. Furnizo      0. Dil");
        }

        public void Xhiro(Makina makina)
        {
            Console.WriteLine("Ti bere nje xhiro!");

            Random random = new Random();
            int km = random.Next(1, 200);

            double l = km * makina.Harxhimi;

            if (l <= makina.Kapaciteti)
            {
                makina.Kapaciteti -= l;

                double cmimi = l * Cmimi(makina.Konsumi);

                Console.WriteLine($"Ti ke bere {km} kilometra dhe jane konsumuar {Math.Round(l, 2)} litra!");
                Console.WriteLine($"Ky udhetim kushtoi {Math.Round(cmimi)} LEK!");
                Console.WriteLine($"Kane mbetur: {Math.Round(makina.Kapaciteti, 2)} litra");
            }
            else
            {
                Console.WriteLine("Mbushe!");
            }
        }
        public int Laje(Makina makina)
        {
            int cmimi = 0;

            if ( makina.Struktura == "Sedan")
            {
                cmimi = 600;
            }
            else if ( makina.Struktura == "Hatch")
            {
                cmimi = 500;
            }
            else
            {
                cmimi = 700;
            }
            Console.WriteLine($"Ti sapo lave makinen!");
            Console.WriteLine($"Larja kushtoi: {cmimi}LEK");

            return cmimi;
        }
        public void Parko()
        {
            Console.WriteLine($"Ti parkove!");
        }
        public void Furnizo(Makina makina)
        {
            Console.WriteLine("Sa LEK do hudhni?");
            double lek = Convert.ToDouble(Console.ReadLine());
            double cmimi = 0;
            double l = lek / Cmimi(makina.Konsumi);

            if (makina.Kapaciteti < makina.KapacitetiTotal)
            {
                makina.Kapaciteti += l;

                if (makina.Kapaciteti > makina.KapacitetiTotal)
                {
                    double teprica = makina.Kapaciteti - makina.KapacitetiTotal;
                    double kusuri = teprica * Cmimi(makina.Konsumi);

                    makina.Kapaciteti = makina.KapacitetiTotal;

                    double km = makina.Kapaciteti / makina.Harxhimi;

                    double furnizimi = (lek - kusuri) / Cmimi(makina.Konsumi);

                    //cmimi = makina.B;

                    Console.WriteLine("Ti furnizove makinen!");
                    Console.WriteLine($"Kusuri: {kusuri}");
                    Console.WriteLine($"U furnizuan {Math.Round(furnizimi, 2)} litra!");
                    Console.WriteLine($"Litra te mbetura: {Math.Round(makina.Kapaciteti, 2)}");
                    Console.WriteLine($"Kilometra te mbetura: {Math.Round(km)}");

                }

                else
                {
                    double km = makina.Kapaciteti / makina.Harxhimi;

                    Console.WriteLine("Ti furnizove makinen!");
                    Console.WriteLine($"U furnizuan {Math.Round(l, 2)} litra!");
                    Console.WriteLine($"Litra te mbetura: {makina.Kapaciteti}");
                    Console.WriteLine($"Kilometra te mbetura: {Math.Round(km)}");
                }

            }
            
        


            else
            {
                Console.WriteLine("Veprimi nuk mund te kryhet! Keni arritur kapacitetin maksimal!!!");
             
            }

        }
    private int Cmimi(string lloji)
    {
        int cmimi = lloji == "Nafte" ? 176 : 179;
        return cmimi;
    }
}

        
    }

