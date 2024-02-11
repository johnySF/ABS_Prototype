using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABS_Prototype.Models
{
    internal class SodaOrder
    {
        private DrinkSoda _drink;
        
        public bool CreateOrderSoda(DrinkSoda drinkSoda)
        {
            if (drinkSoda == null)
            {
                Console.Clear();
                Console.WriteLine("Erro!");
                return false;
            }
            _drink = drinkSoda;
            Console.WriteLine("Sucesso");
            return true;
        }
    }
}