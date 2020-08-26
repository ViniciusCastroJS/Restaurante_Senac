using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace restaurante_senac_asp.mvc.Models
{
    public static class Dados
    {
        public static Pedidos PedidoAtual { get; set; }
        static Dados()
        {
            PedidoAtual = new Pedidos();
        }
    }
}
