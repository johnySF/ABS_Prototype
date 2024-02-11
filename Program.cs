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
            char iceInput;
            char takeOut;
            char shutdownCheck;
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
                        shutdownCheck = Convert.ToChar(Console.ReadLine());
                        Console.Clear();
                        if (shutdownCheck == 'y')
                            machineShutdown = true;
                        break;
                    case 1:
                        DrinkSoda DrinkOrderS = new DrinkSoda();
                        do
                        {
                            Console.WriteLine("1 - Coca Cola\n2 - Guaraná");
                            flavorInput = Convert.ToInt16(Console.ReadLine());
                            if (flavorInput == 1 || flavorInput == 2)
                                DrinkOrderS.flavor = (SodaFlavorEnum)flavorInput;
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
                                DrinkOrderS.cupSize = (CupSizeSodaEnum)cupSizeInput;
                            else
                            {
                                Console.WriteLine("Opção Inválida!");
                                Console.ReadKey();
                            }
                        } while (cupSizeInput != 1 && cupSizeInput != 2 && cupSizeInput != 3);
                        Console.WriteLine("Gostária de gelo? Y/N");
                        iceInput = Convert.ToChar(Console.ReadLine());
                        if (iceInput == 'y')
                        {
                            DrinkOrderS.iceCount = 6;
                        }
                        Console.WriteLine("Ira beber no local? Y/N");
                        takeOut = Convert.ToChar(Console.ReadLine());
                        if (takeOut == 'y')
                        {
                            DrinkOrderS.orderType = OrderTypeEnum.EatIn;
                        }
                        else
                        {
                            DrinkOrderS.orderType = OrderTypeEnum.TakeOut;
                        }
                        OrderSuccessful = sodaOrder.CreateOrderSoda(DrinkOrderS);
                        if (!OrderSuccessful)
                            Console.WriteLine("erro");
                        break;
                    case 2:
                        DrinkJuice DrinkOrderJ = new DrinkJuice();
                        do
                        {
                            Console.WriteLine("1 - Laranja\n2 - Uva");
                        flavorInput = Convert.ToInt16(Console.ReadLine());
                            if (flavorInput == 1 || flavorInput == 2)
                                DrinkOrderJ.flavor = (JuiceFlavorEnum)flavorInput;
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
                                DrinkOrderJ.cupSize = (CupSizeJuiceEnum)cupSizeInput;
                            else
                            {
                                Console.WriteLine("Opção Inválida!");
                                Console.ReadKey();
                            }
                        } while (cupSizeInput != 1 && cupSizeInput != 2);
                        Console.WriteLine("Gostária de gelo? Y/N");
                        iceInput = Convert.ToChar(Console.ReadLine());
                        if (iceInput == 'y')
                        {
                            DrinkOrderJ.iceCount = 12;
                        }
                        Console.WriteLine("Ira beber no local? Y/N");
                        takeOut = Convert.ToChar(Console.ReadLine());
                        if (takeOut == 'y')
                        {
                            DrinkOrderJ.orderType = OrderTypeEnum.EatIn;
                        }
                        else
                        {
                            DrinkOrderJ.orderType = OrderTypeEnum.TakeOut;
                        }
                        OrderSuccessful = juiceOrder.CreateOrderJuice(DrinkOrderJ);
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
