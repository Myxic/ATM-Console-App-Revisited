using System;
using static ATM_Console_App_Revisited.DelegateOperation;

namespace ATM_Console_App_Revisited
{
    public delegate void LanguageMenu(Dictionary<string, string> Login, string UsernameQuestion, string ErrorUsername, string Lanaguage);

     class LanguageMenuOption
    {

        public static void LanguageMenu(Dictionary<string, string> Login, string UsernameQuestion, string ErrorUsername, string Lanaguage)
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

