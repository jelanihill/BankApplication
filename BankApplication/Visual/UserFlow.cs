using System;
using System.Net.Mime;
using BankApplication.Accounts;

namespace BankApplication.Visual
{
    public class UserFlow
    {
        public void Begin()
        {
              Flow();         
        }

        private void Flow()
        {
            while (true)
            {
                DisplayLoginOptions();
                var loginChoice = Console.ReadLine();

                switch (loginChoice)
                {
                    case "1":
                        break;
                    case "2":
                        break;
                    case "3":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Your choice is invalid");
                        break;

                        

                }
            }
        }

        private void DisplayLoginOptions()
        {
            Console.WriteLine("1) Join Bank");
            Console.WriteLine("2) Enter Pin");
            Console.WriteLine("3) Exit");
        }


    }
}