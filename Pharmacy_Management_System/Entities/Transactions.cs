using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy_Management_System.Entities
{
    class Transactions
    {
        private int id { set; get; }
        private int cusID { set; get; }
        private string item { set; get; }
        private int total { set; get; }
        private DateTime datetime { set; get; }
    }
}
