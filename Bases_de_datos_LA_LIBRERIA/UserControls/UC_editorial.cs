using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Bases_de_datos_LA_LIBRERIA.UserControls
{
    public partial class UC_editorial : UserControl
    {
        public UC_editorial()
        {
            InitializeComponent();
        }

        private void UC_editorial_Load(object sender, EventArgs e)
        {

            SqlConnection sqlcon = new SqlConnection("Data Source=DMLAP\\SQLEXPRESS; Initial Catalog=libreria;User ID=pru;Password=redes_01");
            sqlcon.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.editorial;", sqlcon);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
