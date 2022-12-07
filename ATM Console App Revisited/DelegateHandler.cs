using System;
namespace ATM_Console_App_Revisited
{
    public delegate void MyDelegateHandler(string User, string Fund, string NoFund, string StartingQuestion, string balance, string respone, string QuestionWithdraw, string QuestionTransfer, string ErrorMessage);

    public class DelegateOperation
    {
        public void OperationOptions(string User, string Fund, string NoFund, string StartingQuestion, string balance, string respone, string QuestionWithdraw, string QuestionTransfer, string ErrorMessage, string SenderQuestion)

        {
            AtmOpearation Atm = new();
        Starting: Console.WriteLine($"{StartingQuestion}");
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
                    Console.Write($"{QuestionWithdraw} \n" +
                                                "₦ ");
                    string? withdraw = Console.ReadLine();

                    bool isFeeValid = decimal.TryParse(withdraw, out decimal WithdrawFee);
                    if (!isFeeValid || WithdrawFee < 0)
                    {

                        WithdrawFee = 0;
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
                    Console.WriteLine($"{QuestionTransfer}");
                    Console.Write("₦ ");
                    string? transfer = Console.ReadLine();
                    Console.WriteLine($"{SenderQuestion}");
                    string? reciever = Console.ReadLine();

                    //decimal TransferFee = Convert.ToDecimal(transfer);
                    bool isTransferFeeValid = decimal.TryParse(transfer, out decimal TransferFee);
                    if (!isTransferFeeValid || TransferFee < 0)
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
                    Console.WriteLine($"{Operation}? => {ErrorMessage}");
                    goto Starting;

            }




        }

        class Delegate
        {
            private void Operation(Dictionary<string, string> Login, string Username)
            {
                int tries = 0;
                int PossibleTries = 5;
                UserInterface User1 = new IUser1();
                UserInterface User2 = new IUser2();
                UserInterface User3 = new IUser3();


                while (tries < PossibleTries)
                {
                    Console.Write("Enter Your Pin:  ");

                    string? Password = Console.ReadLine();
                    Console.WriteLine(Login[Username.ToLower()]);

                    if (Password == Login[Username.ToLower()])
                    {
                        Console.Clear();
                        Console.WriteLine("Logged in");
                        Console.WriteLine($"Welcome {Username.ToUpper()} What Operation do you want to perform");

                        if (Username.ToLower() == "user1")
                        {
                            User1.English();
                        }
                        else if (Username.ToLower() == "user2")
                        {
                            User2.English();
                        }
                        else if (Username.ToLower() == "user3")
                        {
                            User3.English();

                        }



                        break;
                    }
                    else
                    {
                        Console.Clear();
                    }
                }



            }
        }
    }
}

