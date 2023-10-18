using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    internal class ATM
    {
        public void Authentication()
        {

            Console.WriteLine("Enter Pin: ");
            int pin = int.Parse(Console.ReadLine());
            string manager = "";
            foreach (var item in ATMMethod.bank)
            {
                if (item.Pin == pin)
                {

                    while (manager != "6")
                    {
                        Console.WriteLine("1: Show Info 2: Transfer 3: Withdraw " +
                            "4: Deposit 5: Exit 6: Cancel");
                        switch (manager = Console.ReadLine())
                        {
                            case "1":
                                Console.WriteLine($"{item.OwnerName}, {item.AccNumber}, {item.Balance}");
                                break;
                            case "2":
                                ATMMethod method = new ATMMethod();
                                method.Transfer();
                                item.Balance -= method.Money;
                                break;
                            case "3":
                                ATMMethod method1 = new ATMMethod();
                                method1.WithDraw();
                                break;

                            case "4":
                                Console.WriteLine("Min Amount - 500 ");

                                Console.WriteLine("Enter Money: ");
                                int money2 = int.Parse(Console.ReadLine());

                                if (money2 < 500)
                                {
                                    Console.WriteLine("Enter Enough Money");

                                }
                                else
                                {
                                    item.Balance += money2;
                                }

                                break;
                            case "5":
                                Authentication();
                                break;


                        }
                    }
                }
            }

        }
    }
}
