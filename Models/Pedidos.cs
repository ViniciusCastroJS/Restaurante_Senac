using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace restaurante_senac_asp.mvc.Models
{
    public class Pedidos
    {
        private List<ItemPedido> Itens = new List<ItemPedido>();

        public double total;


        public void Incluir(ItemPedido pedido)
        {
            Itens.Add(pedido);
        }

        public List<ItemPedido> ListarPedidos()
        {
            return Itens;
        }


        public double FecharPedido()
        {

            foreach (ItemPedido item in Itens)
            {

                total = total + (item.valor_unitario * item.quantidade);
                
            }

            return total;
        }

    }
}
