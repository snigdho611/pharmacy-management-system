using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy_Management_System.Access
{
    class DataAccess
    {
        private String ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\Snigdho\\Github\\Pharmacy_Management_System\\Pharmacy_Management_System\\DB_SAF.mdf;Integrated Security=True;Connect Timeout=30";

        private SqlConnection sqlCon;
        private SqlCommand sqlCmd;
        private SqlDataAdapter sqlDataAdapter;

        public SqlConnection SqlCon
        {
            set { this.sqlCon = value; }
            get { return this.sqlCon; }
        }

        public SqlCommand SqlCmd
        {
            set { this.sqlCmd = value; }
            get { return this.sqlCmd; }
        }

        public SqlDataAdapter SqlDA
        {
            set { this.sqlDataAdapter = value; }
            get { return this.sqlDataAdapter; }
        }

        public DataAccess()
        {
            SqlCon = new SqlConnection(ConnectionString);
        }
    }
}
