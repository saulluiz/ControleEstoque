using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ControleEstoque.Controllers
{
    public class CategoriaController : Controller{
        private readonly EstoqueWebContext _context;
        public CategoriaController(EstoqueWebContext context){
            this._context=context;
        }
        public async Task<IActionResult> Index(){
            return View( await _context.Categorias.OrderBy(x=>x.Nome).AsNoTracking().ToListAsync());
            //Retorna a view de mesmo nome(INDEX) que esta na pasta categoria. Alem disso, passa a lista como parametro (No arquivo a lista
            //sera acessada a partir do Model)
        }
}
}