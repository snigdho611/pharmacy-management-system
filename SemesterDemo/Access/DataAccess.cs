using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemesterDemo.Access
{
    class DataAccess
    {
        private String ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\Snigdho\\Github\\Pharmacy_Management_System\\SemesterDemo\\DB_SAF.mdf;Integrated Security=True;Connect Timeout=30";

        private SqlConnection sqlCon;
        private SqlCommand sqlCom;
        private SqlDataAdapter sqlDataAdapter;

        public SqlConnection SqlCon
        {
            set { this.sqlCon = value; }
            get { return this.sqlCon; }
        }

        public SqlCommand SqlCom
        {
            set { this.sqlCom = value; }
            get { return this.sqlCom; }
        }

        public SqlDataAdapter SqlDataAdapter
        {
            set { this.sqlDataAdapter = value; }
            get { return this.sqlDataAdapter; }
        }
    }
}
