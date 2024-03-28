using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using ControleEstoque.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace ControleEstoque.Controllers
{
    public class ProdutoController : Controller
    {
        private readonly EstoqueWebContext _context;
        public ProdutoController(EstoqueWebContext context)
        {
            this._context = context;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _context.Produtos.OrderBy(x => x.Nome).Include(x=>x.Categoria).AsNoTracking().ToListAsync());
            //Retorna a view de mesmo nome(INDEX) que esta na pasta produto. Alem disso, passa a lista como parametro (No arquivo a lista
            //sera acessada a partir do Model)

        }
        [HttpGet]
        public async Task<IActionResult> Cadastrar(int? id)
        {
            var categorias = _context.Categorias.OrderBy(x=>x.Nome).AsNoTracking().ToList();
            var categoriasSelectList = new SelectList(categorias,nameof(CategoriaModel.IdCategoria),nameof(CategoriaModel.Nome));
            ViewBag.Categorias = categoriasSelectList;
            
            if (id.HasValue)
            {
                var produto = await _context.Produtos.FindAsync(id);
                if (produto == null)
                {
                    return NotFound();
                }
                return View(produto);
            };
            return View(new ProdutoModel());

        }
        private bool ProdutoExiste(int id)
        {
            return _context.Produtos.Any(e => e.IdProduto == id);
        }
        [HttpPost]
        public async Task<IActionResult> Cadastrar(int? id, [FromForm] ProdutoModel produto)
        {
            if (ModelState.IsValid)
            {
                if (id.HasValue)
                {
                    if (ProdutoExiste(id.Value))
                    {
                        _context.Update(produto);
                        if (await _context.SaveChangesAsync() > 0)
                        {
                            TempData["mensagem"] = MensagemModel.Serializar("Produto Alterado com sucesso");
                        }
                        else
                        {
                            TempData["mensagem"] = MensagemModel.Serializar("Erro ao alterar produto", TipoMensagem.Erro);
                        }

                    }
                    else
                    {
                        TempData["mensagem"] = MensagemModel.Serializar("Produto nao encontrado", TipoMensagem.Erro);//min 56



                    }
                }
                else
                {
                    _context.Add(produto);
                    if (await _context.SaveChangesAsync() > 0)
                    {
                        TempData["mensagem"] = MensagemModel.Serializar("Produto cadastrado com sucesso.");
                    }
                    else
                    {
                        TempData["mensagem"] = MensagemModel.Serializar("Erro ao cadastrar produto", TipoMensagem.Erro);
                    }

                }
                return RedirectToAction("Index");
            }
            else
            {
                return View(produto);
            }

        }
        [HttpGet]
        public async Task<IActionResult> Excluir(int? id)
        {
            if (!id.HasValue)
            {
                TempData["mensagem"] = MensagemModel.Serializar("Produto não informad.", TipoMensagem.Erro);
                return RedirectToAction(nameof(Index));
            }
            var produto = await _context.Produtos.FindAsync(id);
            if (produto == null)
            {
                TempData["mensagem"] = MensagemModel.Serializar("Produto não encontrada.", TipoMensagem.Erro);
                return RedirectToAction(nameof(Index));

            }
            return View(produto);

        }
        [HttpPost]
        public async Task<IActionResult> Excluir(int id)
        {
            var produto = await _context.Produtos.FindAsync(id);
            if (produto != null)
            {
                _context.Produtos.Remove(produto);
                if (await _context.SaveChangesAsync() > 0)
                {
                    TempData["mensagem"] = MensagemModel.Serializar("Produto excluida com sucesso");
                }
                else
                {
                    TempData["mensagem"] = MensagemModel.Serializar("Não foi possivel excluir produto", TipoMensagem.Erro);
                }
                    return RedirectToAction(nameof(Index));

            }
            else{
                TempData["mensagem"] = MensagemModel.Serializar("Produto Não encontrada", TipoMensagem.Erro);
                    return RedirectToAction(nameof(Index));
            }

        }
    }
}

