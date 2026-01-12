using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

using MySql.Data;
using MySql.Data.MySqlClient;


namespace Dasha_Almancen.Presentacion
{
    public class Cnx
    {
        private string Base;
        private string Server;
        private string Port;
        private string Usuario;
        private string Clave;

        //inicializamos la conexion con null
        private static Cnx Cnxn = null;

        private Cnx() {
            this.Base = "bd_almacen";
            this.Server="localhost";
            this.Port = "3306";
            this.Usuario = "root";
            this.Clave = "oportunidades";
        }

        //definicion de realizar la conexion
        public MySqlConnection CrearConexionMySQL()
        {
            MySqlConnection cdna = new MySqlConnection();
            try
            {
                cdna.ConnectionString = "datasource=" + this.Server + ";port=" + this.Port + ";username=" + this.Usuario + ";password=" + this.Clave + ";Database=" + this.Base;
            }
            catch (Exception ex)
            {
                cdna = null;
                throw ex;
            }
            return cdna;
        }
        public static Cnx getInstancia()
        {
            if (Cnxn == null) { Cnxn=new Cnx (); }
            return Cnxn;
        }
    }
}
