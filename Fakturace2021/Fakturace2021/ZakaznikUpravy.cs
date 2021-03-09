using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fakturace2021
{
    public partial class ZakaznikUpravy : Form
    {
        private List<Zakaznik> zakaznici;
        private SqlRepository sqlRepository;
        public ZakaznikUpravy()
        {
            InitializeComponent();
            sqlRepository = new SqlRepository("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Fakturace2021;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }
        private void ZobrazData()
        {
            zakaznici = sqlRepository.NactiZakazniky();
            listView1.Items.Clear();
            foreach (var zakaznik in zakaznici)
            {
                listView1.Items.Add(zakaznik.GetListViewItem());
            }
        }

    }
}
