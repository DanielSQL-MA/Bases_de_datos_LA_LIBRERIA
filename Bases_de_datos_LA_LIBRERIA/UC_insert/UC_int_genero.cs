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

namespace Bases_de_datos_LA_LIBRERIA.UC_insert
{
    public partial class UC_int_genero : UserControl
    {
        public UC_int_genero()
        {
            InitializeComponent();
        }
        Conexion cn = new Conexion();
        private void button1_Click(object sender, EventArgs e)
        {
            String generoTotal = "SELECT COUNT(idgenero) AS total_generos FROM dbo.genero";
            SqlCommand generos = new SqlCommand(generoTotal, cn.LeerCadena());
            int totalGeneros = (int)generos.ExecuteScalar();
            totalGeneros++;


            string cadena = "insert into dbo.genero([idgenero],[nombre_genero])"
                + "values('" + totalGeneros.ToString() + "','" + txtgenero.Text + "')";
            SqlCommand insert = new SqlCommand(cadena, cn.LeerCadena());
            insert.ExecuteNonQuery();

            MessageBox.Show("El genero a sido insertado Exitosamente");

            txtgenero.Text = "";
        }
    }
}
