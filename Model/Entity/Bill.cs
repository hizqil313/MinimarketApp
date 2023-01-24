using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MinimarketApp.Model.Entity;

namespace MinimarketApp.Model.Entity
{
    public class Bill
    {
        public int KdBill { get; set; }
        public string NamaBrg { get; set; }
        public int JumlahBrg { get; set; }
        public int HargaBrg { get; set; }
        public int Total { get; set; }
    }
}
