using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication.Accounts
{
    public class CheckingAccount:Account
    {
        public CheckingAccount()
        {
            
        }

        public override int WithDraw()
        {
            return Balance;
        }

        public override void Deposit(int money)
        {
            Balance += money;
        }
    }

    public class Account
    {
        public int Balance { get; set; }

        protected Account()
        {
            Balance = 0;
        }


        public virtual int WithDraw()
        {
            return Balance;
        }

        public virtual void Deposit(int money)
        {
            Balance += money;
        }
    }
}
