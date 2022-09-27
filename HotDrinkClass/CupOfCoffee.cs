using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotDrinkClass
{
    public class CupOfCoffee : HotDrink, ICup
    {
        public string Color;
        public int Volume;

        public string BeanType;

        string ICup.Color { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        int ICup.Volume { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override void addMilk()
        {
            Console.WriteLine("Just added some milk to the coffee.");
        }

        public override void addSugar()
        {
            Console.WriteLine("Just added some sugar to the coffee.");
        }

        public override void Drink()
        {
            Console.WriteLine("Drinking the beverage.");
        }

        public void Refil()
        {
            Console.WriteLine("Refilling the cup.");
        }

        public void Wash()
        {
            Console.WriteLine("Washing the cup.");
        }
    }
}
