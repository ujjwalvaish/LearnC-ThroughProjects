using System;
using System.Data.SqlClient;
using System.Data;
namespace SaveAqueryResultToDataTable
{
    class Program
    {
        static void Main()
        {
            DataTable dataTable = new DataTable() ;
            string connectionString = @"user id=US\uvaish;" +
                                       @"server=USBLRUVAISH1\SQLEXPRESS;" +
                                       "Trusted_Connection=yes;" +
                                       "database=master; " +
                                       "connection timeout=30";
                SqlConnection connection = new SqlConnection(connectionString);
                string stringSQLCommand = "Select * from student";
                SqlCommand command = new SqlCommand(stringSQLCommand, connection);
                connection.Open();
                SqlDataAdapter adaptor = new SqlDataAdapter(command);
                adaptor.Fill(dataTable);    
                connection.Close();
                adaptor.Dispose();
                foreach (DataColumn column in dataTable.Columns)
                {
                    Console.Write(column.ColumnName + "\t");
                }
                foreach (DataRow row in dataTable.Rows)
                {
                    Console.WriteLine();
                    for (int i = 0; i < dataTable.Columns.Count ; i++ )
                    {
                        Console.Write(row[i].ToString() + "\t");
                    }
                }                
                Console.ReadKey();
        }
    }
}