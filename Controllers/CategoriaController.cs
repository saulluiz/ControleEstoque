using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using ControleEstoque.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ControleEstoque.Controllers
{
    public class CategoriaController : Controller
    {
        private readonly EstoqueWebContext _context;
        public CategoriaController(EstoqueWebContext context)
        {
            this._context = context;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _context.Categorias.OrderBy(x => x.Nome).AsNoTracking().ToListAsync());
            //Retorna a view de mesmo nome(INDEX) que esta na pasta categoria. Alem disso, passa a lista como parametro (No arquivo a lista
            //sera acessada a partir do Model)

        }
        [HttpGet]
        public async Task<IActionResult> Cadastrar(int? id)
        {
            if (id.HasValue)
            {
                var categoria = await _context.Categorias.FindAsync(id);
                if (categoria == null)
                {
                    return NotFound();
                }
                return View(categoria);
            };
            return View(new CategoriaModel());

        }
        private bool CategoriaExiste(int id)
        {
            return _context.Categorias.Any(e => e.IdCategoria == id);
        }
        [HttpPost]
        public async Task<IActionResult> Cadastrar(int? id, [FromForm] CategoriaModel categoria)
        {
            if (ModelState.IsValid)
            {
                if (id.HasValue)
                {
                    if (CategoriaExiste(id.Value))
                    {
                        _context.Update(categoria);
                        if (await _context.SaveChangesAsync() > 0)
                        {
                            TempData["mensagem"] = MensagemModel.Serializar("Categoria Alteradácom sucesso");
                        }
                        else
                        {
                            TempData["mensagem"] = MensagemModel.Serializar("Erro ao alterar categoria", TipoMensagem.Erro);
                        }

                    }
                    else
                    {
                        TempData["mensagem"] = MensagemModel.Serializar("Categoria nao encontrada", TipoMensagem.Erro);//min 56



                    }
                }
                else
                {
                    _context.Add(categoria);
                    if (await _context.SaveChangesAsync() > 0)
                    {
                        TempData["mensagem"] = MensagemModel.Serializar("Categoria cadastrada com sucesso.");
                    }
                    else
                    {
                        TempData["mensagem"] = MensagemModel.Serializar("Erro ao cadastrar categoria", TipoMensagem.Erro);
                    }

                }
                return RedirectToAction("Index");
            }
            else
            {
                return View(categoria);
            }

        }
        [HttpGet]
        public async Task<IActionResult> Excluir(int? id)
        {
            if (!id.HasValue)
            {
                TempData["mensagem"] = MensagemModel.Serializar("Categoria não informada.", TipoMensagem.Erro);
                return RedirectToAction(nameof(Index));
            }
            var categoria = await _context.Categorias.FindAsync(id);
            if (categoria == null)
            {
                TempData["mensagem"] = MensagemModel.Serializar("Categoria não encontrada.", TipoMensagem.Erro);
                return RedirectToAction(nameof(Index));

            }
            return View(categoria);

        }
        [HttpPost]
        public async Task<IActionResult> Excluir(int id)
        {
            var categoria = await _context.Categorias.FindAsync(id);
            if (categoria != null)
            {
                _context.Categorias.Remove(categoria);
                if (await _context.SaveChangesAsync() > 0)
                {
                    TempData["mensagem"] = MensagemModel.Serializar("Categoria excluida com sucesso");
                }
                else
                {
                    TempData["mensagem"] = MensagemModel.Serializar("Não foi possivel excluir categoria", TipoMensagem.Erro);
                }
                    return RedirectToAction(nameof(Index));

            }
            else{
                TempData["mensagem"] = MensagemModel.Serializar("Categoria Não encontrada", TipoMensagem.Erro);
                    return RedirectToAction(nameof(Index));
            }

        }
    }
}

