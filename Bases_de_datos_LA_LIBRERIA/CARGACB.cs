using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bases_de_datos_LA_LIBRERIA
{
    public class CARGACB
    {
        Conexion cn = new Conexion();


        public DataTable CargarComboAutor()
        {
            SqlDataAdapter da = new SqlDataAdapter("SP_CBAUTOR", cn.LeerCadena());
            da.SelectCommand.CommandType = CommandType.Text;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable CargarComboEditorial()
        {
            SqlDataAdapter da = new SqlDataAdapter("SP_CBEDITORIAL", cn.LeerCadena());
            da.SelectCommand.CommandType = CommandType.Text;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable CargarComboGenero()
        {
            SqlDataAdapter da = new SqlDataAdapter("SP_CBGENERO", cn.LeerCadena());
            da.SelectCommand.CommandType = CommandType.Text;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable CargarComboLibro()
        {
            SqlDataAdapter da = new SqlDataAdapter("SP_LIBROS", cn.LeerCadena());
            da.SelectCommand.CommandType = CommandType.Text;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }


    }

}
