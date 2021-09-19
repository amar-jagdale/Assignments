using System;
using System.Data;
using System.Data.SqlClient;

namespace ADO.NET_Console_SQL
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------------- Implementaion of ADO.NET SQl server to Console Application Data Retriving -----------");
            string cs = "data source=DESKTOP-TL0FRLL\\SQLEXPRESS;Initial Catalog=College;integrated security=True";
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Student;", con);
            //SqlCommand cmd = new SqlCommand("select * from Student where branch='CSE';", con);

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string id = dr["id"].ToString();
                string Name = dr["Name"].ToString();
                string Branch = dr["Branch"].ToString();

                Console.WriteLine(id+"  "+Name+"  "+Branch);
            }
            dr.Close();
            con.Close();
            Console.ReadLine();
        }
    }
}
