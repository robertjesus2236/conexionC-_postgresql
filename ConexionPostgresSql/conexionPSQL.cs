using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Windows.Forms;
using System.Data;

namespace ConexionPostgresSql
{
    internal class conexionPSQL
    {
        //Ejemplo de conexion a la base de datos
        NpgsqlConnection conn = new NpgsqlConnection("Server = localhost; User Id = postgres; Password =1234; Database=conexionC#;");


        public void Conectar()
        {
            conn.Open();
            MessageBox.Show("liSTO");
        }

        public void Desconectar()
        {
            conn.Close();
            MessageBox.Show("Cerrado");
        }

        public DataTable Consultar()
        {
            string query = "select * from \"participantes\"";
            NpgsqlCommand conector = new NpgsqlCommand(query, conn);
            NpgsqlDataAdapter datos = new NpgsqlDataAdapter(conector);
            DataTable tabla = new DataTable();
            datos.Fill(tabla);

            return tabla;

        }

        public DataTable Consultar(string nom)
            //Consulta personalizada
        {
            string query = "select * from \"participantes\" where \"ci\" = '"+nom+"'";
            NpgsqlCommand conector = new NpgsqlCommand(query, conn);
            NpgsqlDataAdapter datos = new NpgsqlDataAdapter(conector);
            DataTable tabla = new DataTable();
            datos.Fill(tabla);

            return tabla;
        }
    }

}
