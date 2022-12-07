using System;
namespace ATM_Console_App_Revisited
{
    public interface Users
    {
        void English();
        void Russian();
        void Chinese();
    }




    public class IUser1 : Users
    {

        MyOperationDelegateHandler MODH = DelegateOperation.OperationOptions;

        public void English()
        {
            StartingMoney IntialAmount = new StartingMoney();
            AtmOpearation ATM = new AtmOpearation(IntialAmount.First_Amount());
             MODH(User: "user1" ,
             Fund: "Cash Balance  ₦",
             NoFund: "Insufficient  Funds",
             StartingQuestion: "Enter 1 for Balance, \n2 for Withdraw, \n3 for Transfer, \n4 to Return to main menu , \n==> ",
             balance: "Balance is: ₦",
             respone: "Do you want to perform another operation? Enter Y to continue",
             QuestionWithdraw: "Enter Amount To Withdraw",
             QuestionTransfer: "Enter Amount To Transfer",
             ErrorMessage: "Enter a valid Option",
             SenderQuestion: "Who do you want to send to");
        }

        public void Russian()
        {
            StartingMoney IntialAmount = new StartingMoney();
            AtmOpearation ATM = new AtmOpearation(IntialAmount.First_Amount());
            MODH(User: "user1",
               Fund: "Денежных баланс  ₦",
               NoFund: "Недостаточно средств",
               StartingQuestion: "Введите 1 для баланса, \n2 для снятия, \n3 для перевода, \n4, чтобы вернуться в главное меню , \n==> ",
               balance: "Баланс: ₦",
               respone: "Вы хотите выполнить другую операцию? Введите Y, чтобы продолжить",
               QuestionWithdraw: "Введите сумму для вывода",
               QuestionTransfer: "Введите сумму для перевода",
               ErrorMessage: "Введите правильный вариант",
               SenderQuestion: "Кому вы хотите отправить");
        }

        public void Chinese()
        {
            StartingMoney IntialAmount = new StartingMoney();
            AtmOpearation ATM = new AtmOpearation(IntialAmount.First_Amount());
            MODH(User: "user1",
               Fund: "现金余额  ₦",
               NoFund: "不充足的资金",
               StartingQuestion: "余额输入1，\n提款输入2，\n转账输入3, \n4 返回主菜单 , \n==> ",
               balance: "余额是: ₦",
               respone: "是否要执行其他操作？ 输入 Y 继续",
               QuestionWithdraw: "输入取款金额",
               QuestionTransfer: "输入转账金额",
               ErrorMessage: "输入有效选项",
               SenderQuestion: "你想送给谁");
        }
    }


   


   
}

