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

namespace Bases_de_datos_LA_LIBRERIA.UC_Buscar
{
    public partial class UC_Buscar_Autor : UserControl
    {
        public UC_Buscar_Autor()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        CARGACB cacb = new CARGACB();
        Conexion cn = new Conexion();
        private void btnbuscar_Click(object sender, EventArgs e)
        {
            int indice = cbidautor.SelectedIndex;
            indice++;
            using (SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.autor WHERE idautor ="+indice.ToString(), cn.LeerCadena()))
            {

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
             
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvautor.DataSource = dt;
            }


        }

        private void UC_Buscar_Autor_Load(object sender, EventArgs e)
        {
            cbidautor.DataSource = cacb.CargarComboAutor();
            cbidautor.DisplayMember = "idautor";
        }
    }
}
