using System;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography.X509Certificates;
using ATM_Console_App_Revisited;
using static ATM_Console_App_Revisited.AtmOpearation;
using static ATM_Console_App_Revisited.Program;

namespace ATM_Console_App_Revisited
{

    class AtmOpearation
    {

        public static decimal _money;




        public AtmOpearation(decimal money)
        {

            _money = money;
        }
        public AtmOpearation()
        {

        }

        public decimal Balance()
        {

            return _money;

        }

        public decimal Withdrawal(decimal withdraw, string Fund, string NoFund)
        {
            if (withdraw < Balance())
            {
                _money = Balance() - withdraw;

            }
            else
            {
                Console.Clear();
                Console.WriteLine($"{NoFund.ToUpper()}");
                Console.WriteLine($"{Balance()} < {withdraw} ?????");
            }
            Console.Write($"{Fund}");
            return Balance();
        }

        public decimal Transfer(string User, decimal transfer, string reciever, string Fund, string NoFund)
        {



            if (transfer < Balance())
            {
                _money = Balance() - transfer;

                if (User.ToLower() == "user1")
                {

                    StartingMoney.dept = transfer;
                }
                else if (User.ToLower() == "user2")
                {
                    StartingMoney.dept2 = transfer;
                }
                else if (User.ToLower() == "user3")
                {
                    StartingMoney.dept3 = transfer;
                }

                if (reciever.ToLower() == "user1")
                {
                    StartingMoney.num = transfer;

                }
                else if (reciever.ToLower() == "user2")
                {
                    StartingMoney.num2 = transfer;
                }
                else if (reciever.ToLower() == "user3")
                {

                    StartingMoney.num3 = transfer;
                }

            }
            else
            {
                Console.Clear();
                Console.WriteLine($"{NoFund.ToUpper()}");
                Console.WriteLine($"{Balance()} < {transfer} ?????");
            }

            Console.Write($"{Fund}");
            return Balance();
        }



    }

}
