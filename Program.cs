using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AcuCafe
{
    class Program
    {
        static void Main(string[] args)
        {
            var deposit = new Deposit(1000, 1000, 1000, 1000);

            var order = new Order
            {
                Coffees = new List<Coffee> { new Coffee(1, 2, 1, 1, 2) },
                Teas = null
            };

            var coffees = order.Coffees;
            var teas = order.Teas;

            if (coffees != null && coffees.Count > 0)
            {
                foreach (var coffee in coffees)
                {
                    deposit.IceTank = deposit.IceTank - coffee.Ice;
                    deposit.MilkTank = deposit.MilkTank - coffee.Milk;
                    deposit.WaterTank = deposit.WaterTank - coffee.Water;
                    deposit.ToppingTank = deposit.ToppingTank - coffee.Topping;

                    Task.Delay(coffee.Time);

                    Console.WriteLine("Coffee is ready");
                }

            }

            if (teas != null && teas.Count > 0)
            {
                foreach (var tea in teas)
                {
                    deposit.IceTank = deposit.IceTank - tea.Ice;
                    deposit.MilkTank = deposit.MilkTank - tea.Milk;
                    deposit.WaterTank = deposit.WaterTank - tea.Water;
                    deposit.ToppingTank = deposit.ToppingTank - tea.Topping;

                    Task.Delay(tea.Time);

                    Console.WriteLine("Tea is ready");

                }
            }


            Console.WriteLine("Deposit details");
            Console.WriteLine("Ice Tank: " + deposit.IceTank);
            Console.WriteLine("Water Tank: " + deposit.WaterTank);
            Console.WriteLine("Topping Tank: " + deposit.ToppingTank);
            Console.WriteLine("Milk Tank: " + deposit.MilkTank);


            Console.ReadKey();

        }
    }
}
