using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fakturace2021
{
    public class SqlRepository
    {
        public string ConnectionString { get; set; }

        public SqlRepository(string connectionString)
        {
            ConnectionString = connectionString;
        }
        public List<Zakaznik> NactiZakazniky(string sloupecTrideni, bool sestupne, string hledani)
        {
            List<Zakaznik> zakaznici = new List<Zakaznik>();
            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
            {
                using (SqlCommand sqlCommand = new SqlCommand("", sqlConnection))
                {
                    sqlCommand.CommandText = $"select * from Zakaznici where Prijmeni like @Hledani order by {sloupecTrideni}{(sestupne ? " desc" : "")}";
                    sqlCommand.Parameters.AddWithValue("Hledani", "%" + hledani + "%");
                    sqlConnection.Open();
                    using (SqlDataReader dataReader = sqlCommand.ExecuteReader())
                    {
                        while (dataReader.Read())
                        {
                            zakaznici.Add(new Zakaznik(Convert.ToInt32(dataReader["IdZakaznika"]),
                                                   dataReader["Jmeno"].ToString(),
                                                   dataReader["Prijmeni"].ToString(),
                                                   dataReader["Typ"].ToString(),
                                                   dataReader["Adresa"].ToString(),
                                                   Convert.ToInt32(dataReader["Ico"]),
                                                   dataReader["Email"].ToString(),
                                                   Convert.ToInt32(dataReader["Telefon"])));
                        }
                    }
                    sqlConnection.Close();
                }
            }
            return zakaznici;
        }

    }
}
