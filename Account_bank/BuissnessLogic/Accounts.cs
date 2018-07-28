using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Account_bank;


namespace BuissnessLogic
{
    public class Accounts
    {


        public static void deposit()
        {
            Console.WriteLine("Enter the amount you want to deposit:");
            int amt = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Account id: ");
            int account_id = int.Parse(Console.ReadLine());
            Class1.search(account_id);


            
        }

        public static void Add_account()
        {
            Console.WriteLine("Enter Account id: ");
            int acc_id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the account type:");
            string acc_type = Console.ReadLine();
            Class1.insert(acc_id,name,acc_type,0);
        }

        //public static void withdraw(int withdraw_amt, string type_account, int acc_number)
        //{
        //    for (int count = 0; count < name.Count; count++)
        //    {
        //        if (acc_number == acc_no[count] && type_account == acc_type[count])
        //        {
        //            if (balance[count] <= 1000 && (type_account == "saving" || type_account == "Saving"))
        //            {
        //                Console.WriteLine("Not enough Balance");
        //            }

        //            else if (balance[count] == 0 && (type_account == "current" || type_account == "Current"))
        //            {
        //                Console.WriteLine("Not enough balance");
        //            }

        //            else if (balance[count] <= (-10000) && (type_account == "DMAT" || type_account == "Dmat"))
        //            {
        //                Console.WriteLine("Not enough balance");
        //            }

        //            else
        //            {
        //                if (withdraw_amt > balance[count] && ((type_account == "current" || type_account == "Current") && (type_account == "saving" || type_account == "Saving")))

        //                {


        //                    Console.WriteLine("inside if");
        //                    Console.WriteLine("Cannot withdraw that much amount not enough balance");

        //                }
        //                else if (type_account == "DMAT" || type_account == "Dmat")
        //                {
        //                    int reference = balance[count] - withdraw_amt;
        //                    Console.WriteLine("Inside else if ");
        //                    if (reference < (-10000))
        //                    {
        //                        Console.WriteLine("Not anough balance to withdraw");
        //                    }
        //                    else
        //                    {
        //                        balance[count] = reference;
        //                        Console.WriteLine("Total balance now is: " + balance[count]);
        //                    }
        //                }
        //                else
        //                {
        //                    balance[count] = balance[count] - withdraw_amt;
        //                    Console.WriteLine("The amount : " + withdraw_amt + " has been withdrawed");
        //                    Console.WriteLine("Balance left in : " + acc_number + " is: " + balance[count]);
        //                }
        //            }
        //        }

        //        else
        //        {
        //            if (count == name.Count)
        //            {
        //                Console.WriteLine("Account number in that account type does not exists.");
        //            }
        //        }
        //    }
        //}

        //public static void interest(int no_acc, string account_type)
        //{
        //    for (int count = 0; count < name.Count; count++)
        //    {
        //        if (no_acc == acc_no[count] && account_type == acc_type[count])
        //        {

        //            if (acc_type[count] == "saving" || acc_type[count] == "Saving")
        //            {


        //                double interest = 0.04 * balance[count];
        //                Console.WriteLine("The interest is: " + interest);


        //            }
        //            else
        //            {

        //                Console.WriteLine(balance[count]);
        //                double interest = 0.01 * balance[count];
        //                Console.WriteLine("The interest is: " + interest);


        //            }

        //            break;

        //        }

        //        else

        //        {
        //            if (count == name.Count - 1)
        //            {
        //                Console.WriteLine("Account no in that account type does not exist.");
        //            }

        //        }
        //    }
        //}

    }
}
