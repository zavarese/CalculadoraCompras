using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;
using SQLite;

namespace CalculadoraCompras
{
    class ItemCompra
    {
        [PrimaryKey, AutoIncrement]
        public uint ID { get; set; }
        public String Descricao { get; set; }
        public Decimal Valor { get; set; }
        public String Comprado { get; set; }

    }
}
