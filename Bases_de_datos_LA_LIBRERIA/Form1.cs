using Bases_de_datos_LA_LIBRERIA.UserControls;
using System.Windows.Forms;

namespace Bases_de_datos_LA_LIBRERIA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelcontainer.Controls.Clear();
            panelcontainer.Controls.Add(userControl);
            userControl.Dock = DockStyle.Fill;
        }

        private void addUserControl2(UserControl userControl2)
        {
            userControl2.Dock = DockStyle.Fill;
            panelcontainer2.Controls.Add(userControl2);
            panelcontainer2.Controls.Add(userControl2);
            userControl2.Dock = DockStyle.Fill;
        }



        private void autorbtn_Click(object sender, EventArgs e)
        {
            UC_autor UC = new UC_autor();
            addUserControl(UC);
        }

        private void editorialbtn_Click_1(object sender, EventArgs e)
        {
            UC_editorial UC = new UC_editorial();
            addUserControl(UC);
        }

        private void generobtn_Click_1(object sender, EventArgs e)
        {
            UC_genero UC = new UC_genero();
            addUserControl(UC);
        }

        private void lbreriabtn_Click(object sender, EventArgs e)
        {
            UC_libros UC = new UC_libros();
            addUserControl(UC);
        }

        private void inster_autor_Click(object sender, EventArgs e)
        {
            UC_int_Autor UC = new UC_int_Autor();
            addUserControl2(UC);
        }

        private void insert_editorial_Click(object sender, EventArgs e)
        {
            UC_int_editorial UC = new UC_int_editorial();
            addUserControl2(UC);
        }

        private void insert_genero_Click(object sender, EventArgs e)
        {
            UC_int_genero UC = new UC_int_genero();
            addUserControl2(UC);
        }

        private void insert_libreria_Click(object sender, EventArgs e)
        {
            UC_int_libros UC = new UC_int_libros();
            addUserControl2(UC);
        }
    }
}