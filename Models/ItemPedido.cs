using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace restaurante_senac_asp.mvc.Models
{
    public class ItemPedido
    {
        public string descricao { get; set; }

        public int valor_unitario { get; set; }

        public int quantidade { get; set; }

    }
}
