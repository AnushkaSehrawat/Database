using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Account_bank;
using BuissnessLogic;

namespace Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Class1 c1 = new Class1();
                c1.initial_connection();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            int option = 0;
            int decide = 1;




            while (decide == 1)
            {
                Console.WriteLine("Enter which operation You want to perform: 1: Add_account 2: Deposit 3.Withdrawal 4. Calculate interest remaining: ");
                option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:

                        Accounts.Add_account();
                        break;

                    case 2:
                        
                        
                       
                        Accounts.deposit();
                        break;

            //        case 3:
            //            Console.WriteLine("Enter the ammount you want to withdraw: ");
            //            int withdraw_amt = int.Parse(Console.ReadLine());
            //            Console.WriteLine("Enter the Account type: ");
            //            string type_account = Console.ReadLine();
            //            Console.WriteLine("Enter the account number: ");
            //            int acc_number = int.Parse(Console.ReadLine());
            //            Accounts.withdraw(withdraw_amt, type_account, acc_number);
            //            break;

            //        case 4:
            //            Console.WriteLine("Enter the account number whose interest you want to calculate: ");
            //            int no_acc = int.Parse(Console.ReadLine());
            //            Console.WriteLine("Enter the account type whose interest you want to calculate: ");
            //            //account_type = Console.ReadLine();


            //            //Accounts.interest(no_acc, account_type);

            //            break;

              }

               Console.WriteLine("Do you want to continue: 1: Yes 2: No");
               decide = int.Parse(Console.ReadLine());
            }





            Console.ReadKey();



        }
    }
}
