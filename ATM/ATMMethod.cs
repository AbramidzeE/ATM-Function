using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    internal class ATMMethod
    {

        public int Money { get; set; }
        public static List<Bank> bank = new List<Bank>()
        {
            new Bank()
            {
               OwnerName = "Walter",
               OwnerLastName = "White",
               Balance = 290100,
               AccNumber = "GE9635467833356",
               Pin = 4588,
            },
            new Bank()
            {
               OwnerName = "Jessy",
               OwnerLastName = "Pinkman",
               Balance = 50145,
               AccNumber = "GE7788928655",
               Pin = 7765,

            },
            new Bank()
            {
               OwnerName = "Henk",
               OwnerLastName = "Schrader",
               Balance = 96645,
               AccNumber = "GE564755464545",
               Pin = 8524,

            },
            new Bank()
            {
               OwnerName = "Scyler",
               OwnerLastName = "White",
               Balance = 75220,
               AccNumber = "GE75645785623",
               Pin = 2587,

            },
        };
       



        public void Transfer()
        {
            Console.WriteLine("Enter AccNumber: ");
            string accNum = Console.ReadLine();

            var find = bank.Find(s=> s.AccNumber == accNum);

            if(find != null)
            {
                Console.WriteLine("Enter Money: ");
                Money = int.Parse(Console.ReadLine());
                find.Balance += Money;
            }
            else
            {
                Console.WriteLine("404 Not Found");
            }
        }



        public  void WithDraw()
        {
            Console.WriteLine("Min Amount - 500 \n Max Amount - 5000");

            Console.WriteLine("Enter Money: ");
            int money1  = int.Parse(Console.ReadLine());

            var find1 = bank.Find(s => money1 <= s.Balance);
             
            if (find1 == null && money1 >= 5000 && money1 < 500)
            {
                Console.WriteLine("Something Went Wrong");

            }
            else
            {
               Console.WriteLine("Withdraw Succsessfull");
               find1.Balance -= money1;

            }
            
        }


    }
}
