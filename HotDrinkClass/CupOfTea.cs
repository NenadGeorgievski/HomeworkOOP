using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotDrinkClass
{
    public class CupOfTea : HotDrink, ICup
    {
        public string Color { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Volume { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public string LeafType;

        public override void addMilk()
        {
            Console.WriteLine("Adding milk to the tea.");
        }

        public override void addSugar()
        {
            Console.WriteLine("Adding sugar to the tea.");
        }

        public override void Drink()
        {
            Console.WriteLine("Drinking the tea. Delicious.");
        }

        public void Refil()
        {
            Console.WriteLine("Time to refill the cup with tea.");
        }

        public void Wash()
        {
            Console.WriteLine("Washing the tea cup.");
        }
    }
}
