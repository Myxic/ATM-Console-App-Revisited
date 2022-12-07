using System;
using System.Globalization;

namespace ATM_Console_App_Revisited
{
    public delegate void MyOperationDelegateHandler(string User, string Fund, string NoFund, string StartingQuestion, string balance, string respone, string QuestionWithdraw, string QuestionTransfer, string ErrorMessage, string SenderQuestion);

    public class DelegateOperation
    {
        public static void OperationOptions(string User, string Fund, string NoFund, string StartingQuestion, string balance, string respone, string QuestionWithdraw, string QuestionTransfer, string ErrorMessage, string SenderQuestion)

        {
            AtmOpearation Atm = new();
        Starting: Console.Write($"{StartingQuestion}");
            string? Operation = Console.ReadLine();

            switch (Operation)
            {

                case "1":
                    Console.Clear();
                    Console.Write($"{balance} {Atm.Balance()}  ");

                    Console.Write($"{respone}\n ==> ");
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
                withdrawQuestion: Console.Write($"{QuestionWithdraw} \n" +
                                            "₦ ");
                    string? withdraw = Console.ReadLine();

                    bool isFeeValid = decimal.TryParse(withdraw, out decimal WithdrawFee);
                    if (!isFeeValid || WithdrawFee < 0)
                    {
                        Console.Clear();
                        Console.WriteLine($"{withdraw}: {ErrorMessage}");

                        goto withdrawQuestion;
                    }



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
                TransferQuestion: Console.WriteLine($"{QuestionTransfer}");
                    Console.Write("₦ ");
                    string? transfer = Console.ReadLine();
                    Console.WriteLine($"{SenderQuestion}");
                    string? reciever = Console.ReadLine();


                    bool isTransferFeeValid = decimal.TryParse(transfer, out decimal TransferFee);
                    if (!isTransferFeeValid || TransferFee < 0)
                    {

                        Console.Clear();
                        Console.WriteLine($"{transfer}: {ErrorMessage}");
                        goto TransferQuestion;
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
                    Console.WriteLine($"{Operation}? => {ErrorMessage}");
                    goto Starting;

            }




        }


    }
}

