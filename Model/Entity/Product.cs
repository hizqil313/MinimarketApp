using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinimarketApp.Model.Entity
{
    public class Product
    {
        public int KdProduct { get; set; }
        public string Nama { get; set; }
        public string Jumlah { get; set; }
        public int  Harga { get;set; }
        public int KdCategory { get; set; }
    }
}
