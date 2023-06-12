using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ado.NetDemo
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Decimal UnitPrice { get; set; }
        public int StockAmount { get; set; }
    }
}
