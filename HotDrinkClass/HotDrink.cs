using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotDrinkClass 
{
    public abstract class HotDrink : ICup
    {
        private string Milk { get; set; }

        private string Sugar { get; set; }
        public string Color { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Volume { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public abstract void Drink();

        public abstract void addMilk();

        public abstract void addSugar();

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
