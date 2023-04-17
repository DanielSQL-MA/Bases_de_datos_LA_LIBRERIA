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

        private void UC_genero_Load(object sender, EventArgs e)
        {

            SqlConnection sqlcon = new SqlConnection("Data Source=DMLAP\\SQLEXPRESS; Initial Catalog=libreria;User ID=pru;Password=redes_01");
            sqlcon.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.genero;", sqlcon);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
