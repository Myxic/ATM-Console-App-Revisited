using System;
using System.Globalization;

namespace ATM_Console_App_Revisited
{
    public delegate void MyOperationDelegateHandler(string User, string Fund, string NoFund, string StartingQuestion, string balance, string respone, string QuestionWithdraw, string QuestionTransfer, string ErrorMessage, string SenderQuestion);

    public delegate void LanguageDelegate(Dictionary<string, string> Login, string Username, string Greeting, string GreetingQuestion, string PinQuestion, string Logged, string Language);

    public delegate void LanguageMenu(Dictionary<string, string> Login, string UsernameQuestion, string ErrorUsername, string Lanaguage);

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
                    Console.Write($"{balance} {Atm.Balance()}");

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
                        //WithdrawFee = 0;
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

        class OperartionDelegate
        {
            public static void Operation(Dictionary<string, string> Login, string Username, string Greeting, string GreetingQuestion, string PinQuestion, string Logged, string Language)
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
                        Console.Write($"{Logged}\n" +
                        $"{Greeting} {Username.ToUpper()} {GreetingQuestion}\n");
                        switch (Language)
                        {
                            case "English":
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
                            case "Russian":
                                if (Username.ToLower() == "user1")
                                {
                                    User1.Russian();
                                }
                                else if (Username.ToLower() == "user2")
                                {
                                    User2.Russian();
                                }
                                else if (Username.ToLower() == "user3")
                                {
                                    User3.Russian();

                                }
                                break;
                            case "Chinese":
                                if (Username.ToLower() == "user1")
                                {
                                    User1.Chinese();
                                }
                                else if (Username.ToLower() == "user2")
                                {
                                    User2.Chinese();
                                }
                                else if (Username.ToLower() == "user3")
                                {
                                    User3.Chinese();

                                }
                                break;
                            default:
                                break;
                        }
                       
        
                    }
                    else
                    {
                        Console.Clear();
                    }
                }



            }
        }
        public class LanguageMenuOption
        {
           



            public static  void LanguageMenu(Dictionary<string, string> Login, string UsernameQuestion, string ErrorUsername, string Lanaguage)
            {
                LanguageDelegate LangDele = OperartionDelegate.Operation;
            start: Console.Write($"{UsernameQuestion} \n==>");

                string? Username = Console.ReadLine();


                if (Login.ContainsKey(Username.ToLower()))
                {
                    switch (Lanaguage)
                    {
                        case "English":
                            LangDele(Login: Login,
                             Username: Username.ToLower(),
                             Greeting: "Welcome",
                             GreetingQuestion: "What Operation do you want to perform",
                             PinQuestion: "Enter Your Pin:  ",
                             Logged: "Logged in",
                              Language: "English");
                            break;
                        case "Russian":
                            LangDele(Login: Login,
                             Username: Username.ToLower(),
                             Greeting: "Добро пожаловать",
                             GreetingQuestion: "Какую задачу вы хотите выполнить",
                             PinQuestion: "Введите ВАШ СУЩЕСТВУЮЩИЙ PIN-код:  ",
                             Logged: "Вы вошли",
                             Language: "Russian");
                            break;
                        case "Chinese":
                            LangDele(Login: Login,
                             Username: Username.ToLower(),
                             Greeting: "欢迎",
                             GreetingQuestion: "你想执行什么任务",
                             PinQuestion: "输入您现有的密码:  ",
                             Logged: "登录",
                             Language: "Chinese"
                                );
                            break;
                        default:
                            break;
                    }
                    
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine($"{ErrorUsername}");
                    goto start;
                }




            }

        }
    }
}

