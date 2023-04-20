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
    public partial class UC_int_libros : UserControl
    {

        public UC_int_libros()
        {


            InitializeComponent();
            cbo_Autor.DropDownStyle = ComboBoxStyle.DropDownList;
            cbo_Editorial.DropDownStyle = ComboBoxStyle.DropDownList;
            cbo_Genero.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        CARGACB cacb = new CARGACB();
        private void UC_int_libros_Load(object sender, EventArgs e)
        {
            //Carga los datos del CB de Autor
            cbo_Autor.DataSource = cacb.CargarComboAutor();
            cbo_Autor.DisplayMember = "nombre_autor";

            //Carga los datos del CB de Editorial
            cbo_Editorial.DataSource = cacb.CargarComboEditorial();
            cbo_Editorial.DisplayMember = "editorial";


            //Carga los datos del CB Genero

            cbo_Genero.DataSource = cacb.CargarComboGenero();
            cbo_Genero.DisplayMember = "genero";


        }
        Conexion cn = new Conexion();
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int existencias = int.Parse(txtexistencia.Text);

                int anio = int.Parse(txtanio.Text);


                String libroTotal = "SELECT COUNT(id) AS total_libros FROM dbo.libros";
                SqlCommand libros = new SqlCommand(libroTotal, cn.LeerCadena());
                int totalLibros = (int)libros.ExecuteScalar();
                totalLibros++;


                int indiceAutor = cbo_Autor.SelectedIndex;
                indiceAutor++;

                int indiceEditorial = cbo_Editorial.SelectedIndex;
                indiceEditorial++;

                int indiceGenero = cbo_Genero.SelectedIndex;
                indiceGenero++;

                string cadena = "insert into dbo.libros([id],[nombre],[id_autor],[id_editorial],[existencia],[anio_publicacion],[id_genero])"
                    + "values('" + totalLibros.ToString() + "','" + txtnombre.Text + "','" + indiceAutor.ToString() + "','"+indiceEditorial.ToString()+"','"+existencias.ToString()+"','"+anio.ToString()+"','"+indiceGenero.ToString()+"')";
                SqlCommand insert = new SqlCommand(cadena, cn.LeerCadena());
                insert.ExecuteNonQuery();

                MessageBox.Show("El genero a sido insertado Exitosamente");

                txtnombre.Text = "";
                txtexistencia.Text = "";
                txtanio.Text = "";

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR "+ex + " Existencias y año deben ser Numeros enteros");
            }
            
        }
    }
}
