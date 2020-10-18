﻿using System;

namespace CertifV2.Demos
{
    class Listing2_29
    {
        class BankAccount
        {
            private decimal _accountBalance = 0;

            public void PayInFunds(decimal amountToPayIn)
            {
                _accountBalance = _accountBalance + amountToPayIn;
            }

            public bool WithdrawFunds(decimal amountToWithdraw)
            {
                if (amountToWithdraw > _accountBalance)
                    return false;

                _accountBalance = _accountBalance - amountToWithdraw;
                return true;
            }

            public decimal GetBalance()
            {
                return _accountBalance;
            }
        }

        static void Main(string[] args)
        {
            BankAccount a = new BankAccount();
            a.PayInFunds(50);
            Console.WriteLine("Pay in 50");
            a.PayInFunds(50);
            if (a.WithdrawFunds(10))
                Console.WriteLine("Withdrawn 10");
            Console.WriteLine("Account balance is: {0}", a.GetBalance());
        }
    }
}
