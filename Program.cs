﻿using Motors_auto_24062023;

double Buxheti = 10000;
Makina audi = new Makina("Audi", "A7", 2014, "Sedan", "Nafte", 3.0, 75, 75, 0.047);
Makina bmw = new Makina("BMW", "M4", 2008, "Hatch", "Benzine", 3.6, 57, 57, 0.096);
Makina mercedes = new Makina("Mercedes", "w204", 2008, "SUV", "Benzine", 6.3, 66, 66, 0.134);

Console.WriteLine("Mire se erdhet ne AUTO Motors");
Console.WriteLine("Ju lutem zgjidhi nje model:");
Console.WriteLine($"1. {audi.Marka} {audi.Modeli}       2. {bmw.Marka} {bmw.Modeli}     3. {mercedes.Marka} {mercedes.Modeli}");

int opsioni = Convert.ToInt32(Console.ReadLine());

//Ky eshte nj

if (opsioni == 1)
{
    audi.Specifikimet(audi);

    while (true)
    {
        audi.Menu();
        int op = Convert.ToInt32(Console.ReadLine());

        if (op == 1)
        {
            audi.Xhiro(audi);
        }
        else if (op == 2 && Buxheti >= 500)
        {
            int cmimiILarjes = audi.Laje(audi);

            Buxheti = Buxheti - cmimiILarjes;
        }
        else if (op == 3)
        {
            audi.Parko();
        }
        else if (op == 4)
        {
            audi.Furnizo(audi);

        }
        else if (op == 0)
        {
            break;
        }
        else
        {
            Console.WriteLine("Opsioni eshte i gabuar!");
            continue;
        }
    }
}
else if (opsioni == 2)
{
    bmw.Specifikimet(bmw);

    while (true)
    {
        bmw.Menu();
        int op = Convert.ToInt32(Console.ReadLine());

        if (op == 1)
        {
            bmw.Xhiro(bmw);
        }
        else if (op == 2)
        {
            bmw.Laje(bmw);
        }
        else if (op == 3)
        {
            bmw.Parko();
        }
        else if (op == 4)
        {
            bmw.Furnizo(bmw);
        }
        else if (op == 0)
        {
            break;
        }
        else
        {
            Console.WriteLine("Opsioni eshte i gabuar!");
            continue;
        }
    }
}
else if (opsioni == 3)
{
    mercedes.Specifikimet(mercedes);

    while (true)
    {
        mercedes.Menu();
        int op = Convert.ToInt32(Console.ReadLine());

        if (op == 1)
        {
            mercedes.Xhiro(mercedes);
        }
        else if (op == 2)
        {
            mercedes.Laje(mercedes);
        }
        else if (op == 3)
        {
            mercedes.Parko();
        }
        else if (op == 4)
        {
            mercedes.Furnizo(mercedes);
        }
        else if (op == 0)
        {
            break;
        }
        else
        {
            Console.WriteLine("Opsioni eshte i gabuar!");
            continue;
        }
    }
}
else
{
    Console.WriteLine("Zgjedhje e gabuar!");
}