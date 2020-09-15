using JJH_2020_09_15start;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace JJH_2020_09_15start
{
    class AccountManager
    {
        BankAccount test1;
        
        
        
        int money;

        public void PrintMenu()     //계좌관리프로그램 메뉴
        {
            Console.WriteLine("\n---Menu--------");
            Console.WriteLine("1. 계좌 개설");
            Console.WriteLine("2. 입금");
            Console.WriteLine("3. 출금");
            Console.WriteLine("4. 잔액 조회");
            Console.WriteLine("5. 프로그램 종료");
            Console.WriteLine();
        }

        public void MakeAccount()   //계좌 개설
        {
            int test = 10001;

            Console.Write("예금주를 입력해주세요 : ");
            string name = Console.ReadLine();
            string AccNum = $"1111-111-{test}";
            Console.WriteLine($"{name}님의 계좌번호는 1111-111-{test} 입니다");

            test1 = new BankAccount(AccNum,name);
            Console.WriteLine("개설이 완료되었습니다");
            Console.WriteLine();
            test++;
        }

        public void Deposit()       //입금
        {
            Console.Write("입금하실 금액은? :");
            int money = int.Parse(Console.ReadLine());
            test1.InputMoney(money);
            Console.WriteLine($"{money}원 입금 되었습니다");
            Console.WriteLine();
        }

        public void Withdrawal()    //출금
        {
            Console.Write("출금하실 금액은? : ");
            int money = int.Parse(Console.ReadLine());
            test1.OutputMoney(money);
            Console.WriteLine($"{money}원 출금 되었습니다");
            Console.WriteLine();
        }

        public void BalanceCheck()  //잔액 조회
        {
            int balance = test1.Balance;
            Console.WriteLine($"{test1.Name}님의 잔액은 {balance}원 입니다");
            Console.WriteLine();
        }
    }

    class AccountProgram
    {

        static void Main()
        {

            AccountManager manager = new AccountManager();
            Console.WriteLine(manager.ToString());

            int choice;

            while (true)
            {
                manager.PrintMenu();
                Console.Write("선택 : ");
                choice = int.Parse(Console.ReadLine());
                switch(choice)
                {
                    case 1:
                        manager.MakeAccount(); break;
                    case 2:
                        manager.Deposit(); break;
                    case 3:
                        manager.Withdrawal(); break;
                    case 4:
                        manager.BalanceCheck(); break;
                    case 5: return;
                    default:
                        Console.WriteLine("다시 선택하세요"); break;

                }

            }


            
        }
    }
}
