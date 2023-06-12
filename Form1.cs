using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridViewdoiss
{
    public partial class Form1 : Form
    {
        DataTable dt = new DataTable();
        public Form1()
        {
            InitializeComponent();
            CarregarDados();
        }

        private void CarregarDados()
        {
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("Nome", typeof(string));
            dt.Columns.Add("idade", typeof(int));
            dt.Columns.Add("Email", typeof (string));

            dt.Rows.Add(new object[] {01 , "Amanda Cores", 16, "juu@gmail.com"});
            dt.Rows.Add(new object[] {02, "Andre Coelho", 16, "Andre@gmail.com"  });
            dt.Rows.Add(new object[] {03, "Cassia Jesus", 17, "Cassinha@gmail.com" });
            dt.Rows.Add(new object[] {04, "Carla Silva", 16, "Carla@gmail.com" });
            dt.Rows.Add(new object[] {05, "Davi Roma", 16, "Davi@gmail.com" });
            dt.Rows.Add(new object[] {06, "Daniela Tamires", 17, "Dani@gmail.com" });




            DataTable.DataSource = dt;
        }
    }
}
