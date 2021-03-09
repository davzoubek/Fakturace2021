using System;
using System.Collections.Generic;
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
        public List<Zakaznik> NactiZakazniky()
        {
            List<Zakaznik> zakaznici = new List<Zakaznik>();

        }

    }
}
