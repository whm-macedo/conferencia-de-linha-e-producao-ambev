using Microsoft.AspNetCore.Mvc;
using ConferenciaLinhaProducao.Models;

namespace ConferenciaLinhaProducao.Controllers
{
    public class HomeController : Controller
    {
        public HomeController()
        {
            // Inicializa dados em memória na primeira vez
            if (RepositorioMemoria.Usuarios.Count == 0 && RepositorioMemoria.Produtos.Count == 0)
            {
                RepositorioMemoria.Inicializar();
            }
        }

        // Página inicial — lista de produtos
        public IActionResult Index()
        {
            var produtos = RepositorioMemoria.Produtos;
            return View(produtos);
        }

        // Página para listar usuários
        public IActionResult Usuarios()
        {
            var usuarios = RepositorioMemoria.Usuarios;
            return View(usuarios);
        }
                // GET: Home/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Home/Create
        [HttpPost]
        public IActionResult Create(Produto produto)
        {
            produto.Id = RepositorioMemoria.Produtos.Count + 1;
            RepositorioMemoria.Produtos.Add(produto);
            return RedirectToAction("Index");
        }

        
    }
}
