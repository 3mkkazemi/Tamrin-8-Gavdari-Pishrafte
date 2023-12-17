using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public abstract class Animal
    {

        public int ID { get; init; }

        public string Name { get; init; }

        public DateTime BirthDate { get; init; }

        public static readonly int MaxLife = 9125 ;

        public List<Environment> Environments { get; set; }

        public List<Product> Products { get; set; }

        public List<Cost> Costs { get; set; }

        public double Weight { get; set; }

        public bool Gender { get; set; }

        public abstract double AverageStressFactor(Environment Environment);

        public abstract int Life();

        public abstract int TimeToDie();

        public abstract double KillPriority();

        public abstract decimal CostPerDay();

        public abstract decimal IncomePerDay();

        public abstract decimal MeatIncome(decimal MeatPrice);

    }
}
