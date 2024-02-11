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
        private char _orderConfirmation;
        
        public bool CreateOrderSoda(DrinkSoda drinkSoda)
        {
            if (drinkSoda == null)
            {
                Console.Clear();
                Console.WriteLine("Erro!");
                return false;
            }
            _drink = drinkSoda;
            Console.Clear();
            Console.WriteLine("Pedido correto? y/n");
            Console.WriteLine("Sabor: {0}\nTamanho: {1}\nGelo: {2}\nTipo de pedido: {3}", drinkSoda.flavor, drinkSoda.cupSize, drinkSoda.iceCount, drinkSoda.orderType);
            _orderConfirmation = Convert.ToChar(Console.ReadLine());
            if (_orderConfirmation == 'y')
            {
                Console.WriteLine("Sucesso");
                return true;
            }
            else
            {
                Console.WriteLine("Pedido cancelado");
                return false;
            }
        }
    }
}