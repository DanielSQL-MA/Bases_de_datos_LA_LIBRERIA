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
    public partial class UC_libros : UserControl
    {
        public UC_libros()
        {
            InitializeComponent();
        }

        private void UC_libros_Load(object sender, EventArgs e)
        {

            SqlConnection sqlcon = new SqlConnection("Data Source=DMLAP\\SQLEXPRESS; Initial Catalog=libreria;User ID=pru;Password=redes_01");
            sqlcon.Open();
            SqlCommand cmd = new SqlCommand("SELECT dbo.libros.id, dbo.libros.nombre, dbo.autor.nombre_autor AS autor, dbo.editorial.nombre_editorial AS editorial, dbo.libros.existencia, dbo.libros.anio_publicacion, dbo.genero.nombre_genero AS genero\r\nFROM libros\r\nJOIN autor ON dbo.libros.id_autor = dbo.autor.idautor\r\nJOIN editorial ON dbo.libros.id_editorial = dbo.editorial.ideditorial\r\nJOIN genero ON dbo.libros.id_genero = dbo.genero.idgenero;", sqlcon);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
