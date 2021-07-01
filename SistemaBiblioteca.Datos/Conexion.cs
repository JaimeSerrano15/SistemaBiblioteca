using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SistemaBiblioteca.Datos
{
    public class Conexion
    {
        private string bd;
        private string server;
        private string user;
        private string pass;
        private bool security;
        private static Conexion Con = null;

        private Conexion()
        {
            this.bd = "dbBiblioteca";
            this.server = "ALEJANDROSERVER";
            this.user = "sa";
            this.pass = "jaiserpnc";
            this.security = true;
        }

        public SqlConnection createConnection()
        {
            SqlConnection connectionStr = new SqlConnection();

            try
            {
                connectionStr.ConnectionString = "Server=" + this.server + "; Database=" + this.bd + ";";
                if (this.security)
                {
                    connectionStr.ConnectionString = connectionStr.ConnectionString + "Integrated Security = SSPI";
                }
                else
                {
                    connectionStr.ConnectionString = connectionStr.ConnectionString + "User Id=" + this.user + "; Password=" + this.pass;
                }
            }
            catch(Exception ex)
            {
                connectionStr = null;
                throw ex;
            }
            return connectionStr;
        }

        public static Conexion getInstance()
        {
            if(Con == null)
            {
                Con = new Conexion();
            }
            return Con;
        }

    }
}
