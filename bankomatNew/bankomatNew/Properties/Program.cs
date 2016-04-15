using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankomatNew
{
    class Program
    {
        static void Main(string[] args)
        {
            bankomat b1 = new bankomat();
            bool flag = false;
            Console.WriteLine("Enter your password");
            for (int i = 0; i < 3; i++)
            {
                string password = Console.ReadLine();
                b1.ChekPassword(password,ref flag);
                if (flag == true)
                    break;
                b1.CounterCount();
            }

            bool exit = false;
            if (flag == true)
            {
                while (exit == false)
                {
                    Console.WriteLine("If you want to add some money press 1");
                    Console.WriteLine("To check current balance press 2");
                    Console.WriteLine("To take your cash press 3");
                    Console.WriteLine("To exit press 4");
                    int key = Convert.ToInt16(Console.ReadLine());

                    switch (key)
                    {
                        case 1:
                            {
                                Console.WriteLine("Enter a bill you want to add");
                                long money = Convert.ToInt64(Console.ReadLine());
                                if (money < 0)
                                {
                                    Console.WriteLine("Wrong value");
                                    break;
                                }
                                b1.SetMoney(money);
                                //Console.WriteLine(b1.GetMoney());
                                Console.WriteLine("You have sacssesfully added: {0} hrn", Convert.ToString(money));
                            }
                            break;
                            case 2:
                            {
                                Console.WriteLine("Your current balance:{0} hrn", b1.GetMoney());
                            }
                            break;
                        case 3:
                            {
                                Console.WriteLine("How much money would you like to take?");
                                long money = Convert.ToInt64(Console.ReadLine());
                                if (money < 0)
                                {
                                    Console.WriteLine("Wrong value");
                                    break;
                                }
                                    Console.WriteLine("You have saccesfully took {0}: hrn", money);
                                    b1.GetCash(money);
                            }
                            break;
                        case 4:
                            {
                                Console.WriteLine("End of transaction");
                                exit = true;
                            }
                            break;
                        default:
                            Console.WriteLine("Wrong value");
                            break;


                    }
                }
            }
            
            Console.ReadLine();
        }
    }
}
