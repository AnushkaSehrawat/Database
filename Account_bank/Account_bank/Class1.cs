﻿using System;
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

        public static int search(int id)
        {
            int balance = -100000000;
            int acc_id=0;
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Account where account_id=@id";
            cmd.Parameters.Add(new SqlParameter("@id",id));
            SqlDataReader sq = cmd.ExecuteReader();
           // Console.WriteLine(acc_id);
            if (!sq.HasRows)
            {
                Console.WriteLine("No Entry in the database");
            }
            else
            {
                while (sq.Read())
                {
                    acc_id = sq.GetInt32(sq.GetOrdinal("account_id")) ;
                    if (acc_id==id)
                    {
                        balance = sq.GetInt32(sq.GetOrdinal("balance"));
                        break;
                    }
                }


            }
            return balance;


        }
        public static string search_acc_type(int id)
        {
            
            int acc_id;
            string Acc_type = null; 
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Account where account_id=@id";
            cmd.Parameters.Add(new SqlParameter("@id", id));
            SqlDataReader sq = cmd.ExecuteReader();
            // Console.WriteLine(acc_id);
            if (!sq.HasRows)
            {
                Console.WriteLine("No Entry in the database");
            }
            else
            {
                while (sq.Read())
                {
                    acc_id = sq.GetInt32(sq.GetOrdinal("account_id"));
                    if (acc_id == id)
                    {
                        Acc_type = sq.GetString(sq.GetOrdinal("account_type"));
                        break;
                    }
                }


            }
            return Acc_type;


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

        public static void Update(int bal,int id)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Update ACCOUNT set balance=@bal where account_id=@id ";
            cmd.Parameters.Add(new SqlParameter("@bal",bal));
            cmd.Parameters.Add(new SqlParameter("@id", id));
            cmd.ExecuteNonQuery();

        }

        public static void Display(int id)
        {
            Console.WriteLine("Enter the account Id whose details you want to display:");
            id = int.Parse(Console.ReadLine());
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select *from ACCOUNT";
            SqlDataReader sqr = cmd.ExecuteReader();
            if (sqr.HasRows)
            {
                while (sqr.Read())
                {
                    int acc_id = sqr.GetInt32(sqr.GetOrdinal("account_id"));
                    string name = sqr.GetString(sqr.GetOrdinal("name"));
                    string acc_type = sqr.GetString(sqr.GetOrdinal("acc_type"));
                    int balance = sqr.GetInt32(sqr.GetOrdinal("balance"));
                    if (acc_id==id)
                    {
                        Console.WriteLine(id+" "+name+" "+acc_type+" "+balance);
                        break;

                    }

                }

            }
            else
            {
                Console.WriteLine("The table is empty");
            }


        }

    }
}
