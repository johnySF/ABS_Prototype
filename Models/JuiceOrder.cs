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
        private char _orderConfirmation;

        public bool CreateOrderJuice(DrinkJuice drinkJuice)
        {
            if (drinkJuice == null)
            {
                Console.Clear();
                Console.WriteLine("Erro!");
                return false;
            }
            _drink = drinkJuice;
            Console.Clear();
            Console.WriteLine("Pedido correto? y/n");
            Console.WriteLine("Sabor: {0}\nTamanho: {1}\nGelo: {2}\nTipo de pedido: {3}", drinkJuice.flavor, drinkJuice.cupSize, drinkJuice.iceCount, drinkJuice.orderType);
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
