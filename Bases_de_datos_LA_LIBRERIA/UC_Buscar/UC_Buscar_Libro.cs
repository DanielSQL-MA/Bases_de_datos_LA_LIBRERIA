using Bases_de_datos_LA_LIBRERIA.UserControls;
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
    public partial class UC_Buscar_Libro : UserControl
    {
        CARGACB cacb = new CARGACB();
        Conexion cn = new Conexion();
        public UC_Buscar_Libro()
        {
            InitializeComponent();
        }

        private void UC_Buscar_Libro_Load(object sender, EventArgs e)
        {
            cblibro.DataSource = cacb.CargarComboLibro();
            cblibro.DisplayMember = "id";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int indice = cblibro.SelectedIndex;
            indice++;
            using (SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.libros WHERE id =" + indice.ToString(), cn.LeerCadena()))
            {

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView.DataSource = dt;
            }
        }
    }
}
