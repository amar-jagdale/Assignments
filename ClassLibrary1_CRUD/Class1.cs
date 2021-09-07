using System;
using System.Data;
using System.Data.SqlClient;

namespace ClassLibrary1
{
    public class Class1
    {
        static string constr = "data source=DESKTOP-TL0FRLL\\SQLEXPRESS;Initial Catalog=Emp;integrated security=True";  //Connection String
        public void DisplayEmployee()
        {
            DataTable dt = ExecuteData("select * from emp");
            if (dt.Rows.Count > 0)
            {
                Console.WriteLine(Environment.NewLine);
                Console.WriteLine("============================================");
                Console.WriteLine("DataBase Records");
                Console.WriteLine("============================================");

                foreach (DataRow row in dt.Rows)
                {
                    Console.WriteLine(row["eno"].ToString() + " " + row["ename"].ToString() + " " + row["sal"].ToString());
                }

                Console.WriteLine("===============================================" + Environment.NewLine);
            }
            else
            {
                Console.WriteLine(Environment.NewLine);
                Console.WriteLine("No employee found in the database table ....");
                Console.WriteLine(Environment.NewLine);
            }
        }

        public DataTable ExecuteData(string query)
        {
            DataTable result = new DataTable();
            try
            {
                using (SqlConnection sqlcon = new SqlConnection(constr))  //This block will release the memory when object is not in use
                {
                    sqlcon.Open();

                    SqlCommand sqlcmd = new SqlCommand(query, sqlcon);
                    SqlDataAdapter da = new SqlDataAdapter(sqlcmd);   //Disconnected Architecture
                    da.Fill(result);
                    sqlcon.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return result;
        }

        public bool ExecuteCommand(string query)
        {
            DataTable result = new DataTable();
            try
            {
                using (SqlConnection sqlcon = new SqlConnection(constr))
                {
                    sqlcon.Open();
                    SqlCommand sqlcmd = new SqlCommand(query, sqlcon);
                    sqlcmd.ExecuteNonQuery();       //It Executes the DML Queries
                    sqlcon.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
                throw;
            }
            return true;
        }

        public void Addemployee()
        {
            string eno = string.Empty;
            string ename = string.Empty;
            string sal = string.Empty;

            Console.WriteLine("Insert New Employee: ");

            Console.WriteLine("Enter the Employee Number: ");
            eno = Console.ReadLine();

            Console.WriteLine("Enter the Employee Name: ");
            ename = Console.ReadLine();

            Console.WriteLine("Enter the Employee Salary: ");
            sal = Console.ReadLine();

            ExecuteCommand(string.Format("Insert into emp(eno,ename,sal)values('{0}','{1}','{2}')", eno, ename, sal));  // Insertion Query
            Console.WriteLine("=============== New Employee Details Inserted Succeffuly into the Emp Database ==============");
        }

        public void EditEmployee()
        {
            string eno = string.Empty;
            string ename = string.Empty;
            string sal = string.Empty;

            Console.WriteLine("EDIT EXISTING Employee: ");

            Console.WriteLine("Enter the Employee Number: ");
            eno = Console.ReadLine();

            Console.WriteLine("Enter the Employee Name: ");
            ename = Console.ReadLine();

            Console.WriteLine("Enter the Employee Salary: ");
            sal = Console.ReadLine();

            ExecuteCommand(string.Format("Update emp set ename='{0}',sal='{1}' where eno='{2}'", ename,sal,eno)); //updating Query
            Console.WriteLine("==================== Employee Details Updated Succeffuly into the Emp Database =====================");
        }

        public void DeleteEmployee()
        {
            string eno = string.Empty;
            Console.WriteLine("DELETE EXISTING EMPLOYEE: ");

            Console.WriteLine("Enter Employee No:");
            eno = Console.ReadLine();

            ExecuteCommand(string.Format("delete from emp where eno='{0}'", eno));
            Console.WriteLine("Employee details delted from the Database !" + Environment.NewLine);
        }
    }
}
