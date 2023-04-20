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

namespace Bases_de_datos_LA_LIBRERIA.UserControls
{
    public partial class UC_autor : UserControl
    {
        public UC_autor()
        {
            InitializeComponent();
        }
        Conexion cn = new Conexion();

        private void UC_autor_Load(object sender, EventArgs e)
        {
           
            SqlDataAdapter da = new SqlDataAdapter("SP_MOSTRARAUTORES", cn.LeerCadena());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }
    }
}
