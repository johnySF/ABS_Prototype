using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABS_Prototype.Models
{
    internal class JuiceOrder
    {
        private DrinkJuice _drink;

        public bool CreateOrder(DrinkJuice drinkJuice)
        {
            if (drinkJuice == null)
            {
                Console.Clear();
                Console.WriteLine("Erro!");
                return false;
            }
            _drink = drinkJuice;
            Console.WriteLine("Sucesso");
            return true;
        }
    }
}
