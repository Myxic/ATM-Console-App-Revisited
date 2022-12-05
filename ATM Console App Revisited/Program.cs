using System.Web;
using static ATM_Console_App_Revisited.AtmOpearation;

namespace ATM_Console_App_Revisited;


/*So the idea in this code is to simulate a real time ATM where we already have an existing User(User1,User2,User3)
 * Here they enter a password (ALREADY EXISTING) the ATM does 4 operation(Language(3 different types), Checking Balance, Withdrawal and Tranfer,
 * The opeartion when user1 tranfer money to user2 or user3 , they should be able to get the money and the money will be removed from user1.
 * and also endless loop lol
 *          {"user1", "1234"},
            {"user2", "5678"},
            {"user3", "6969"}

 */
public class Program
{
    static void Main(string[] args)
    {


        Program.Run();



    }

    public static void Run()
    {
        Console.Clear();
        Console.Write("TYPE 1 for English \n"+
                        "Тип 2 для русского \n"+
                        "类型 3 中文 \n"+
                        "Type 4 to Cancel\n"+
	                    "====>  "
                       );

        string? language = Console.ReadLine();

        Console.Clear();

        LanguageOptions(language);


    }




    public static void LanguageOptions(string? num)
    {


        AtmOpearation ATM = new AtmOpearation();
        Dictionary<string, string> Login = new Dictionary<string, string>
            {   {"user1", "1234"},
                {"user2", "5678"},
                {"user3", "6969"}
            };





        switch (num)
        {
            case "1":
                ATM.English(Login);

                break;
            case "2":
                ATM.Russian(Login);
                break;
            case "3":
                ATM.Chinese(Login);
                break;
            case "4":
                Console.Clear();
                Console.WriteLine("Thanks for choosing us");
                Environment.Exit(0);
                break;
            default:
                Console.WriteLine("Enter Valid Option");
                Run();
                break;
        }




    }




}
