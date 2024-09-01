using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{

    // Veritabanındaki Product tablosuna denk gelir
    // Bu nedenle join içeren operasyonlar yazılır

    public class Product:IEntity
    {
        public int ProductId { get; set; }

        public int CategoryId { get; set; }

        public string ProductName { get; set; }

        public short UnitsInStock { get; set; }

        public int UnitPrice { get; set; }

    }
}
