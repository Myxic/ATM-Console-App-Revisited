using System;
namespace ATM_Console_App_Revisited
{
    public delegate void MyDelegateHandler(string balance, string User, string Fund, string NoFund);

    public class DelegateHandler
    {
        public DelegateHandler()
        {
        }

        public void OperationOptions(string User, string Fund, string NoFund, string balance, string respone, string QuestionWithdraw)

        {
            AtmOpearation Atm = new();
        Starting:    Console.WriteLine("Enter 1 for Balance, \n2 for Withdraw, \n3 for Transfer, \n4 to Return to main menu");
            string? Operation = Console.ReadLine();

            switch (Operation)
            {

                case "1":
                    Console.Clear();
                    Console.Write($"{balance}: ₦ {Atm.Balance()}");
                  
                    Console.WriteLine($"{respone}");
                    string? Continue = Console.ReadLine();
                    if (Continue.ToUpper() == "Y")
                    {
                        Console.Clear();
                        goto Starting;
                    }
                    Program.Run();
                    break;
                case "2":
                    Console.Clear();
                    Console.Write($"{QuestionWithdraw} \n"+
                                                "₦ ");
                    string? withdraw = Console.ReadLine();

                    bool isFeeValid = decimal.TryParse(withdraw, out decimal WithdrawFee);
                    if (!isFeeValid)
                    {

                        WithdrawFee = 0;
                    }


                    //decimal WithdrawFee = Convert.ToDecimal(withdraw);
                    Console.WriteLine(Atm.Withdrawal(WithdrawFee, Fund, NoFund));

                    Console.WriteLine($"{respone}");
                    string? Continue2 = Console.ReadLine();
                    if (Continue2.ToUpper() == "Y")
                    {
                        Console.Clear();
                        goto Starting;
                    }
                    Program.Run();
                    break;
                case "3":
                    Console.Clear();
                    Console.WriteLine("Enter Amount To Transfer");
                    Console.Write("₦ ");
                    string? transfer = Console.ReadLine();
                    Console.WriteLine("Who do you want to send to");
                    string? reciever = Console.ReadLine();

                    //decimal TransferFee = Convert.ToDecimal(transfer);
                    bool isTransferFeeValid = decimal.TryParse(transfer, out decimal TransferFee);
                    if (!isTransferFeeValid)
                    {

                        TransferFee = 0;
                    }
                    if (User == "user1")
                    {
                        Console.WriteLine(Atm.Transfer(User, TransferFee, reciever, Fund, NoFund));
                    }
                    else if (User == "user2")
                    {
                        Console.WriteLine(Atm.Transfer(User, TransferFee, reciever, Fund, NoFund));
                    }
                    else if (User == "user3")
                    {
                        Console.WriteLine(Atm.Transfer(User, TransferFee, reciever, Fund, NoFund));
                    }

                    Console.WriteLine($"{respone}");
                    string? Continue3 = Console.ReadLine();
                    if (Continue3.ToUpper() == "Y")
                    {
                        Console.Clear();
                        goto Starting;
                    }
                    Program.Run();


                    break;
                case "4":
                    Program.Run();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Enter a valid Option");
                    goto Starting;
                    break;
            }




        }

    }
}

