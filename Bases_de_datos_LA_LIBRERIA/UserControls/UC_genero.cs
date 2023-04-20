using System.Data;
using System.Data.SqlClient;


namespace Bases_de_datos_LA_LIBRERIA.UserControls
{
    public partial class UC_genero : UserControl
    {
        public UC_genero()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        Conexion CN = new Conexion();   
        private void UC_genero_Load(object sender, EventArgs e)
        {

            SqlDataAdapter da = new SqlDataAdapter("SP_MOSTRARGENERO", CN.LeerCadena());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
