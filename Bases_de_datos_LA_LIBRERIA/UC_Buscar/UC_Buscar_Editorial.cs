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
    public partial class UC_Buscar_Editorial : UserControl
    {

        CARGACB cacb = new CARGACB();
        Conexion cn = new Conexion();
        public UC_Buscar_Editorial()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            int indice = cbieditorial.SelectedIndex;
            indice++;
            using (SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.editorial WHERE ideditorial =" + indice.ToString(), cn.LeerCadena()))
            {

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataEditorial.DataSource = dt;
            }


        }

        private void UC_Buscar_Editorial_Load(object sender, EventArgs e)
        {
            cbieditorial.DataSource = cacb.CargarComboEditorial();
            cbieditorial.DisplayMember = "ideditorial";
        }
    }
}
