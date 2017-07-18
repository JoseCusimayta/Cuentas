using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ConexionesBD
{
    public class BalanceBD
    {
        Conexion con = new Conexion();

        public SqlConnection connect;
        public SqlCommand command;
        public SqlDataAdapter da;
        public DataTable dt;
        public DataSet ds;

    }
}
