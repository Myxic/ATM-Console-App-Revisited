using System;
using System.Globalization;

namespace ATM_Console_App_Revisited
{
    public delegate void MyOperationDelegateHandler(string User, string Fund, string NoFund, string StartingQuestion, string balance, string respone, string QuestionWithdraw, string QuestionTransfer, string ErrorMessage, string SenderQuestion);
    public delegate void LanguageDelegate(Dictionary<string, string> Login, string Username,  string Greeting, string GreetingQuestion, string PinQuestion, string Logged);
    public class DelegateOperation
    {
         public static void OperationOptions(string User, string Fund, string NoFund, string StartingQuestion, string balance, string respone, string QuestionWithdraw, string QuestionTransfer, string ErrorMessage, string SenderQuestion)

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

        class OperartionDelegate
        {
            public static void Operation(Dictionary<string, string> Login, string Username, string Greeting, string GreetingQuestion, string PinQuestion, string Logged )
            {
                int tries = 0;
                int PossibleTries = 5;
                Users User1 = new IUser1();
                Users User2 = new IUser2();
                Users User3 = new IUser3();


                while (tries < PossibleTries)
                {
                    Console.Write($"{PinQuestion}");

                    string? Password = Console.ReadLine();
                    Console.WriteLine(Login[Username.ToLower()]);

                    if (Password == Login[Username.ToLower()])
                    {
                        Console.Clear();
                        Console.Write($"{Logged}\n"+
                        $"{Greeting} {Username.ToUpper()} {GreetingQuestion}\n"+
			                "==>  ");

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
        class Language 
	    {
            LanguageDelegate LangDele = OperartionDelegate.Operation;

            

            public void English(Dictionary<string, string> Login, string Language)
            {
                switch (Language)
                {
                    case "English":
                    start:    Console.Write("Enter Your username:  ");

                        string? Username = Console.ReadLine();


                        if (Login.ContainsKey(Username.ToLower()))
                        {

                            LangDele(Login: Login,
                                     Username: Username.ToLower(),
                                     //Language: "English",
                                     Greeting: "Welcome",
                                     GreetingQuestion: "What Operation do you want to perform",
                                     PinQuestion: "Enter Your Pin:  ",
                                     Logged: "Logged in" );
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Invalid Username");
                            goto start;
                        }
                        break;
                    case "Russian":
                        break;
                    case "Chinese":
                        break;
                    default:
                        break;
                }

               
            }

        }
    }
}

