using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_programs
{
    public class BankAccount
    {
        private string account_id;

        public string AccountId
        {
            get
            {
                return "DDDDFFFJHBS"+ account_id+"DDDDDD";
            }
            set
            {
                if(value.Length == 10)
                {
                    account_id = value;
                }
                else
                {
                    Console.WriteLine("Invalid Account Id enter above 10 characters");
                }
            }
        }
    }
}
