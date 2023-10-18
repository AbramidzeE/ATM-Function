using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    internal class Bank
    {
        public string OwnerName { get; set; }
        public string OwnerLastName { get; set; }
        public string AccNumber { get; set; }
        public int Balance { get; set; }
        public int Pin { get; set; }


        public override string ToString()
        {
            return $"OwnerName {OwnerName},OwnerLastName {OwnerLastName}, " +
                $"AccNumber {AccNumber},Balance {Balance}";
        }
    }
}
