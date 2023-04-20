using Bases_de_datos_LA_LIBRERIA.UC_Buscar;
using Bases_de_datos_LA_LIBRERIA.UC_insert;
using Bases_de_datos_LA_LIBRERIA.UC_Update;
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

        private void AddUserControl2(UserControl userControl2)
        {
            userControl2.Dock = DockStyle.Fill;
            panelcontainer2.Controls.Clear();
            panelcontainer2.Controls.Add(userControl2);
            userControl2.Dock = DockStyle.Fill;
        }

        private void AddUserControl3(UserControl userControl3)
        {
            userControl3.Dock = DockStyle.Fill;
            panelcontainer3.Controls.Clear();
            panelcontainer3.Controls.Add(userControl3);
            userControl3.Dock = DockStyle.Fill;
        }
        private void AddUserControl4(UserControl userControl4)
        {
            userControl4.Dock = DockStyle.Fill;
            panelcontainer4.Controls.Clear();
            panelcontainer4.Controls.Add(userControl4);
            userControl4.Dock = DockStyle.Fill;
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
            AddUserControl2(UC);
        }

        private void insert_editorial_Click(object sender, EventArgs e)
        {
            UC_int_editorial UC = new UC_int_editorial();
            AddUserControl2(UC);
        }

        private void insert_genero_Click(object sender, EventArgs e)
        {
            UC_int_genero UC = new UC_int_genero();
            AddUserControl2(UC);
        }

        private void insert_libreria_Click(object sender, EventArgs e)
        {
            UC_int_libros UC = new UC_int_libros();
            AddUserControl2(UC);
        }

        private void Buscar_Autor_Click(object sender, EventArgs e)
        {
            UC_Buscar_Autor UCB = new UC_Buscar_Autor();
            AddUserControl3(UCB);
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            UC_Buscar_Editorial UCB = new UC_Buscar_Editorial();
            AddUserControl3(UCB);
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            UC_Buscar_Genero UCB = new UC_Buscar_Genero();
            AddUserControl3(UCB);
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            UC_Buscar_Libro UCB = new UC_Buscar_Libro();
            AddUserControl3(UCB);
        }

        private void guna2Button9_Click(object sender, EventArgs e)
        {
            UC_Update_Autor UCU = new UC_Update_Autor();
            AddUserControl4(UCU);
        }

        private void guna2Button11_Click(object sender, EventArgs e)
        {
            UC_Update_Editorial UCU = new UC_Update_Editorial();
            AddUserControl4(UCU);
        }

        private void guna2Button12_Click(object sender, EventArgs e)
        {
            UC_Update_Genero UCU = new UC_Update_Genero();
            AddUserControl4(UCU);
        }

        private void guna2Button10_Click(object sender, EventArgs e)
        {
            UC_Update_Libros UCU = new UC_Update_Libros();
            AddUserControl4(UCU);
        }
    }
}