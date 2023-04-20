using System.Data.SqlClient;

namespace Bases_de_datos_LA_LIBRERIA.UC_insert
{
    public partial class UC_int_Autor : UserControl
    {
        Conexion cn = new Conexion();

        public UC_int_Autor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String autorestotal = "SELECT COUNT(idautor) AS total_autores FROM dbo.autor";
            SqlCommand autores = new SqlCommand(autorestotal, cn.LeerCadena());
            int totalAutores = (int)autores.ExecuteScalar();
            totalAutores++;


            string cadena = "insert into dbo.autor([idautor],[nombre_autor])"
                + "values('" + totalAutores.ToString() + "','" + txtautor.Text + "')";
            SqlCommand insert = new SqlCommand(cadena, cn.LeerCadena());
            insert.ExecuteNonQuery();

            MessageBox.Show("El Autor a sido insertado Exitosamente");

            txtautor.Text = "";

        }

        private void UC_int_Autor_Load(object sender, EventArgs e)
        {

        }
    }
}
