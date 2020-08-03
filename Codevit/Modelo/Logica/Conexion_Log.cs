using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Codevit.Modelo.Logica
{
    public class Conexion_Log
    {
        
        private static string StringConnexion = "Server=localhost;Database=codevit; Uid=codevit;Pwd=C0d3v1tDb;";

        public MySqlConnection Conectar(string Servidor) 
        {

            StringConnexion = "Server='"+ Servidor + "';Database=codevit; Uid=codevit;Pwd=C0d3v1tDb;";

            MySqlConnection cn = new MySqlConnection();
            cn.ConnectionString = StringConnexion;

            try
            {
                cn.Open();
                return cn;
            }
            catch(MySqlException ex)
            {
                return null;
            }            

        }

        public MySqlConnection Conectar()
        {

            MySqlConnection cn = new MySqlConnection();
            cn.ConnectionString = StringConnexion;

            try
            {
                cn.Open();
                return cn;
            }
            catch (MySqlException ex)
            {
                return null;
            }

        }

    }

}
