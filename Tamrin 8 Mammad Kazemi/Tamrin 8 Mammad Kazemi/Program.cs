﻿using System.Collections;
using System.Runtime.InteropServices;
using ConsoleApp4;

List<Cow> Cows = new List<Cow>()
{
    new Cow() { ID = 1 ,Gender = true, Weight = 250, BirthDate = new DateTime(2022, 10, 05) },
    new Cow() { ID = 2 ,Gender = true, Weight =360, BirthDate = new DateTime(2021, 09, 25) },
    new Cow() { ID = 3 ,Gender = false, Weight = 290, BirthDate = new DateTime(2022, 11, 29) },
    new Cow() { ID = 4 ,Gender = true, Weight = 300, BirthDate = new DateTime(2021, 08, 14) },

};
List<Sheep> Sheeps = new List<Sheep>()
{
    new Sheep() { ID = 1, Gender = false, Weight = 80, BirthDate=new DateTime(2022,04,07)},
    new Sheep() {ID = 2,  Gender = true, Weight = 86, BirthDate=new DateTime(2021,06,16)},
    new Sheep() { ID = 3, Gender = true, Weight = 403, BirthDate=new DateTime(2021,08,08)},
    new Sheep() { ID = 4, Gender = false, Weight = 99, BirthDate=new DateTime(2022,12,25)},

};

bool Resualt = true;
do
{
    Console.WriteLine("1.daily income of animals");
    Console.WriteLine("2.daily cost of animals");
    Console.WriteLine("3:kill priority of animals");
    Console.WriteLine("4:daily profit of animals");
    Console.WriteLine("5:meat profit of animals");
    byte option = Convert.ToByte(Console.ReadLine());
    switch (option)
    {
        case 1:
            Income();
            ; break;
        case 2:
            Cost();
            break;
        case 3:
            KillPriority();
            break;
        case 4:
            Profit();
            break;
        case 5:
            MeatIncome();
            break;
        case 6:
            System.Environment.Exit(0);

            break;
        case 7:

            break;
    }
    Console.WriteLine("\nEDAME MIDI?(y/n)");
    Char Answer = Convert.ToChar(Console.ReadLine());
    if (Answer == 'y')
    { Resualt = true; }
    else { Resualt = false; }

} while (true);


void KillPriority()
{
    Console.WriteLine("Kill Priority Of Cows: ");

    foreach (Cow cow in Cows.OrderByDescending(c => c.KillPriority()))
    {
        Console.ForegroundColor = Tools.Color(cow.KillPriority());
        Console.WriteLine("Name:{0,12} KillPriority:{1,3} Gender:{2,6}", cow.Name, cow.KillPriority(), Tools.GenderConverter(cow.Gender));
    }

    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("Kill Priority Of Sheeps: ");

    foreach (Sheep sheep in Sheeps.OrderByDescending(s => s.KillPriority()))
    {
        Console.ForegroundColor = Tools.Color(sheep.KillPriority());
        Console.WriteLine("Name:{0,12} KillPriority:{1,3} Gender:{2,6}", sheep.Name, sheep.KillPriority(), Tools.GenderConverter(sheep.Gender));
    }

    Console.ForegroundColor = ConsoleColor.White;
}

void Income()
{
    Console.WriteLine("Daily Income Of Cows :");

    foreach (Cow cow in Cows.OrderByDescending(c => c.IncomePerDay()))
    {
        Console.WriteLine("Name:{0:,12} Income:{1,3:N} Gender:{2,6}", cow.Name, cow.IncomePerDay(), Tools.GenderConverter(cow.Gender));
    }

    Console.WriteLine("Daily Income Of Sheeps :");

    foreach (Sheep sheep in Sheeps.OrderByDescending(s => s.IncomePerDay()))
    {
        Console.WriteLine("Name:{0,12} Income:{1,3:N} Gender:{2,6}", sheep.Name, sheep.IncomePerDay(), Tools.GenderConverter(sheep.Gender));
    }
}

void Cost()
{
    Console.WriteLine("Daily Cost Of Cows :");

    foreach (Cow cow in Cows.OrderByDescending(c => c.CostPerDay()))
    {
        Console.WriteLine("Name:{0,12} Cost:{1,3:N} Gender:{2,6}", cow.Name, cow.CostPerDay(), Tools.GenderConverter(cow.Gender));
    }

    Console.WriteLine("Daily Cost Of Sheeps :");

    foreach (Sheep sheep in Sheeps.OrderByDescending(s => s.CostPerDay()))
    {
        Console.WriteLine("Name:{0,12} Cost:{1,3:N} Gender:{2,6}", sheep.Name, sheep.CostPerDay(), Tools.GenderConverter(sheep.Gender));
    }
}

void Profit()
{
    Console.WriteLine("Daily Profit Of Cows :");

    foreach (Cow cow in Cows.OrderByDescending(c => c.IncomePerDay() - c.CostPerDay()))
    {
        Console.WriteLine("Name:{0,12} Profit:{1,3:N} Gender:{2,6}", cow.Name, cow.IncomePerDay() - cow.CostPerDay(), Tools.GenderConverter(cow.Gender));
    }

    Console.WriteLine("Daily Profit Of Sheeps :");

    foreach (Sheep sheep in Sheeps.OrderByDescending(s => s.IncomePerDay() - s.CostPerDay()))
    {
        Console.WriteLine("Name:{0,12} Profit:{1,3:N} Gender:{2,6}", sheep.Name, sheep.IncomePerDay() - sheep.CostPerDay(), Tools.GenderConverter(sheep.Gender));
    }
}

void MeatIncome()
{
    Console.WriteLine("Meat Income Of Cows :");

    foreach (Cow cow in Cows.OrderByDescending(c => c.MeatIncome(350000m)))
    {
        Console.WriteLine("Name:{0,12} MeatIncome:{1,3:N} Gender:{2,6}", cow.Name, cow.MeatIncome(350000m), Tools.GenderConverter(cow.Gender));
    }

    Console.WriteLine("Meat Income Of Sheeps :");

    foreach (Sheep sheep in Sheeps.OrderByDescending(s => s.MeatIncome(500000m)))
    {
        Console.WriteLine("Name:{0,12} MeatIncome:{1,3:N} Gender:{2,6}", sheep.Name, sheep.MeatIncome(500000m), Tools.GenderConverter(sheep.Gender));
    }
}

