using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.SQLite;

namespace HalloDatenbank
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** Hallo Datenbank ***");


            string conString = "Data Source=c:\\DB\\Northwind.sqlite";
            var con = new SQLiteConnection(conString);
            con.Open();
            Console.WriteLine("DB Verbindung wurde hergestellt");
            var cmd = new SQLiteCommand("SELECT * FROM Employees", con);
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string vorname = reader["FirstName"].ToString();
                string nachname = reader["LastName"].ToString();
                var bDate = reader.GetDateTime(reader.GetOrdinal("BirthDate"));
                Console.WriteLine($"{vorname} {nachname} [{bDate:d}]");
            }

            //SqlServer();

            Console.WriteLine("Ende");
            Console.ReadLine();
        }

        private static void SqlServer()
        {
            string conString = "Server=.;Database=Northwind;Trusted_Connection=true;";
            var con = new SqlConnection(conString);
            con.Open();
            Console.WriteLine("DB Verbindung wurde hergestellt");
            var cmd = new SqlCommand("SELECT * FROM Employees", con);
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string vorname = reader["FirstName"].ToString();
                string nachname = reader["LastName"].ToString();
                var bDate = reader.GetDateTime(reader.GetOrdinal("BirthDate"));
                Console.WriteLine($"{vorname} {nachname} [{bDate:d}]");
            }
        }
    }
}
