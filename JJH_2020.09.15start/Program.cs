using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JJH_2020_09_15start
{

    class BankAccount
    {
        private static double interest = 0.2;   //이자율
        private string accNum;           //계좌번호
        private string name;             //예금주명
        private int balance;             //잔액        

        #region property
        public string AccNum
        {
            get { return accNum; }
            set { accNum = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Balance //읽기전용속성
        {
            get { return balance; }
        }
        #endregion

        #region ctor
        public BankAccount()
        {
            balance = 10;
            interest = 0.2;
        }

        public BankAccount(string accNum, string accName)
        {
            this.accNum = accNum;
            Name = accName;
            balance = 10;
        }
        #endregion

        #region method
        //출금
        public string OutputMoney(int amount)
        {
            if (balance < amount)
            {
                string msg = "잔액이 부족합니다";
                return msg;
            }

            balance = balance - amount;
            return "";
        }
        /*
        public void OutputMoney(int amount)
        {
            if (balance < amount)
            {
                Console.WriteLine("잔액이 부족합니다");
                return;
            }

            balance = balance - amount;
        }
        */

        //예금
        public void InputMoney(int amount)
        {
            balance = balance + amount + (int)(amount * interest);
        }

        //계좌정보 출력
        public void PrintAccInfo()
        {
            Console.WriteLine($"계좌번호:{this.accNum} / 예금주명:{this.Name} / 잔액:{this.balance} / 이자율:{BankAccount.interest}%");
        }

        //이자율 변경
        public void SetInterest(double interest)
        {
            BankAccount.interest = interest;
            balance += 10;
        }
        #endregion
    }

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        BankAccount acc0 = new BankAccount();
    //        acc0.AccNum = "111-11111";
    //        acc0.Name = "홍길동";
    //        acc0.PrintAccInfo();
    //        acc0.SetInterest(10);



    //        BankAccount acc1 = new BankAccount("222-22222", "류현진");
    //        acc1.Name = "손흥민";
    //        acc1.PrintAccInfo();

    //        acc0.InputMoney(500);

    //        string errMsg = acc0.OutputMoney(100);
    //        if (errMsg.Length > 0)
    //            Console.WriteLine(errMsg);
    //        else
    //            Console.WriteLine(acc0.Balance);

    //    }
    //}
}
