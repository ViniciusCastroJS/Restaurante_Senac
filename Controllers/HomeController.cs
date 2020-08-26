using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using restaurante_senac_asp.mvc.Models;

namespace restaurante_senac_asp.mvc.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(ItemPedido pedido)
        {

            Dados.PedidoAtual.Incluir(pedido);
            return View("PedidoAdded");
        }



        public IActionResult Pedidos()
        {
            Dados.PedidoAtual.total = 0;
            return View();
        }
    }
}
