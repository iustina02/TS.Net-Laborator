using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scenariul2
{
    public partial class Form1 : Form
    {
        string connectionString = @"data source=JARVICE;initial catalog=Products;integrated security=True";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("Select * from Product", sqlCon);

                DataTable dataTable = new DataTable();
                sqlDa.Fill(dataTable);

                dataGridView1.DataSource = dataTable;
            }
        }

    }
}
