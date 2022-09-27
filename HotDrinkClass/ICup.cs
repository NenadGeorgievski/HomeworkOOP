using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotDrinkClass
{
    public interface ICup
    {
        public string Color { get; set; }

        public int Volume { get; set; }

        public void Refil();

        public void Wash();
    }
}
