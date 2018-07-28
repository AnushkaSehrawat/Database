using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace Account_bank
{
    public class Class1
    {
       static  SqlConnection con = new SqlConnection();
       
        
        public void initial_connection()
        {
            //SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString);
            con.ConnectionString = @"Data Source=TAVDESK136;Initial Catalog=Acc;Integrated Security=true";
            con.Open();


        }

        public static void search(int id)
        {
            int x = 0;
            int acc_id=0;
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Account where account_id=@id";
            cmd.Parameters.Add(new SqlParameter("@id",id));
            Console.WriteLine(cmd.ExecuteNonQuery());
           // Console.WriteLine(acc_id);
            if (acc_id==-1)
            {
                Console.WriteLine("The given account_id does not exists. Please enter valid account_id");
            }
            else
            {
                int balance;
                cmd.CommandText = "select balance from ACCOUNT where account_id=@id";
                cmd.Parameters.Add(new SqlParameter("@id", id));
                balance = cmd.ExecuteNonQuery();
                Console.WriteLine(balance);


            }


        }

        public static void insert(int acc_id,string name,string acc_type,int balance)
        {
            try
            {
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into ACCOUNT values(@acc_id,@name,@acc_type,@balance)";
                cmd.Parameters.Add(new SqlParameter("@acc_id", acc_id));
                cmd.Parameters.Add(new SqlParameter("@name", name));
                cmd.Parameters.Add(new SqlParameter("@acc_type", acc_type));
                cmd.Parameters.Add(new SqlParameter("@balance", balance));

                cmd.ExecuteNonQuery();
            }
            catch(SqlException sq)
            {
                Console.WriteLine(sq.Message);
            }
         

        }

    }
}
