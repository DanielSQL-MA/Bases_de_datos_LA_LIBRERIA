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
    public partial class UC_int_editorial : UserControl
    {
        public UC_int_editorial()
        {
            InitializeComponent();
        }
        Conexion cn = new Conexion();
        private void button1_Click(object sender, EventArgs e)
        {
            String editorialtotal = "SELECT COUNT(ideditorial) AS total_editorial FROM dbo.editorial";
            SqlCommand editoriales = new SqlCommand(editorialtotal, cn.LeerCadena());
            int totalEditoriales = (int)editoriales.ExecuteScalar();
            totalEditoriales++;


            string cadena = "insert into dbo.editorial([ideditorial],[nombre_editorial])"
                + "values('" + totalEditoriales.ToString() + "','" + txteditorial.Text + "')";
            SqlCommand insert = new SqlCommand(cadena, cn.LeerCadena());
            insert.ExecuteNonQuery();

            MessageBox.Show("La Editorial a sido insertado Exitosamente");

            txteditorial.Text = "";

        }
    }
}
