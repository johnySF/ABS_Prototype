using ABS_Prototype.Models;
using ABS_Prototype.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ABS_Prototype
{
    internal class Program
    {
        static void Main(string[] args)
        {
            short drinkType;
            short flavorInput;
            short cupSizeInput;
            string iceInput;
            string takeOut;
            string shutdownCheck;
            bool OrderSuccessful;
            bool machineShutdown = false;
            SodaOrder sodaOrder = new SodaOrder();
            JuiceOrder juiceOrder = new JuiceOrder();

            do
            {
                Console.WriteLine("Escolha a categoria: \n1 - Refrigerante\n2 - Suco");
                drinkType = Convert.ToInt16(Console.ReadLine());
                switch (drinkType)
                {
                    case 0:
                        Console.WriteLine("Certeza que deseja encerrar a aplicação?");
                        shutdownCheck = Convert.ToString(Console.ReadLine());
                        Console.Clear();
                        shutdownCheck = shutdownCheck.ToLower();
                        if (shutdownCheck == "y")
                            machineShutdown = true;
                        break;
                    case 1:
                        DrinkSoda DrinkOrderSoda = new DrinkSoda();
                        do
                        {
                            Console.WriteLine("1 - Coca Cola\n2 - Guaraná");
                            flavorInput = Convert.ToInt16(Console.ReadLine());
                            if (flavorInput == 1 || flavorInput == 2)
                                DrinkOrderSoda.flavor = (SodaFlavorEnum)flavorInput;
                            else
                            {
                                Console.WriteLine("Opção Inválida!");
                                Console.ReadKey();
                            }
                        } while (flavorInput != 1 && flavorInput != 2);
                        do
                        {
                            Console.WriteLine("Escolha o tamanho:\n1 - 300ml\n2 - 500ml\n3 - 700ml");
                            cupSizeInput = Convert.ToInt16(Console.ReadLine());
                            if (cupSizeInput == 1 || cupSizeInput == 2 || cupSizeInput == 3)
                                DrinkOrderSoda.cupSize = (CupSizeSodaEnum)cupSizeInput;
                            else
                            {
                                Console.WriteLine("Opção Inválida!");
                                Console.ReadKey();
                            }
                        } while (cupSizeInput != 1 && cupSizeInput != 2 && cupSizeInput != 3);
                        Console.WriteLine("Gostária de gelo? Y/N");
                        iceInput = Convert.ToString(Console.ReadLine());
                        iceInput = iceInput.ToLower();
                        if (iceInput == "y")
                        {
                            DrinkOrderSoda.iceCount = 6;
                        }
                        Console.WriteLine("Ira beber no local? Y/N");
                        takeOut = Convert.ToString(Console.ReadLine());
                        takeOut = takeOut.ToLower();
                        if (takeOut == "y")
                        {
                            DrinkOrderSoda.orderType = OrderTypeEnum.EatIn;
                        }
                        else
                        {
                            DrinkOrderSoda.orderType = OrderTypeEnum.TakeOut;
                        }
                        OrderSuccessful = sodaOrder.CreateOrderSoda(DrinkOrderSoda);
                        if (!OrderSuccessful)
                            Console.WriteLine("erro");
                        break;
                    case 2:
                        DrinkJuice DrinkOrderJuice = new DrinkJuice();
                        do
                        {
                            Console.WriteLine("1 - Laranja\n2 - Uva");
                        flavorInput = Convert.ToInt16(Console.ReadLine());
                            if (flavorInput == 1 || flavorInput == 2)
                                DrinkOrderJuice.flavor = (JuiceFlavorEnum)flavorInput;
                            else
                            {
                                Console.WriteLine("Opção Inválida!");
                                Console.ReadKey();
                            }
                        } while (flavorInput != 1 && flavorInput != 2);
                        do
                        {
                            Console.WriteLine("Escolha o tamanho:\n1 - 300ml\n2 - 500ml");
                            cupSizeInput = Convert.ToInt16(Console.ReadLine());
                            if (cupSizeInput == 1 || cupSizeInput == 2)
                                DrinkOrderJuice.cupSize = (CupSizeJuiceEnum)cupSizeInput;
                            else
                            {
                                Console.WriteLine("Opção Inválida!");
                                Console.ReadKey();
                            }
                        } while (cupSizeInput != 1 && cupSizeInput != 2);
                        Console.WriteLine("Gostária de gelo? Y/N");
                        iceInput = Convert.ToString(Console.ReadLine());
                        iceInput = iceInput.ToLower();
                        if (iceInput == "y")
                        {
                            DrinkOrderJuice.iceCount = 12;
                        }
                        Console.WriteLine("Ira beber no local? Y/N");
                        takeOut = Convert.ToString(Console.ReadLine());
                        takeOut = takeOut.ToLower();
                        if (takeOut == "y")
                        {
                            DrinkOrderJuice.orderType = OrderTypeEnum.EatIn;
                        }
                        else
                        {
                            DrinkOrderJuice.orderType = OrderTypeEnum.TakeOut;
                        }
                        OrderSuccessful = juiceOrder.CreateOrderJuice(DrinkOrderJuice);
                        if (!OrderSuccessful)
                            Console.WriteLine("Erro");
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }
                Console.ReadKey();
                Console.Clear();
            } while(!machineShutdown);
        }
    }
}
