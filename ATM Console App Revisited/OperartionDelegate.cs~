using System;
namespace ATM_Console_App_Revisited
{
    public delegate void LanguageDelegate(Dictionary<string, string> Login, string Username, string Greeting, string GreetingQuestion, string PinQuestion, string Logged, string Language);

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

}

