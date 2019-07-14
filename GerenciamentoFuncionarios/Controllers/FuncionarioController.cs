using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GerenciamentoFuncionarios.Models;

namespace GerenciamentoFuncionarios.Controllers
{
    public class FuncionarioController : Controller
    {
        private readonly FuncionarioContext _context;

        public FuncionarioController(FuncionarioContext context)
        {
            _context = context;
        }

        // GET: Funcionario
        public async Task<IActionResult> Index()
        {
            return View(await _context.Funcionarios.ToListAsync());
        }

        // GET: Funcionario/Create
        public IActionResult AdicionarOuEditar(int id = 0)
        {
            if (id == 0)
                return View(new Funcionario());

            return View(_context.Funcionarios.Find(id));
        }

        // POST: Funcionario/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken] // O atributo do tipo Bind é responsável por corresponder os valores do formulário para as propriedades definidas no model.
        public async Task<IActionResult> AdicionarOuEditar([Bind("Id,NomeCompleto,Codigo,Posicao,LocalizacaoEscritorio")] Funcionario funcionario)
        {
            // Para a validação do lado do servidor, usamos a seguinte propriedade: ModelState.IsValid.
            if (ModelState.IsValid)
            {
                if (funcionario.Id == 0)
                    _context.Add(funcionario);
                else
                    _context.Update(funcionario);

                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(funcionario);
        }

        // GET: Funcionario/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            var funcionario = await _context.Funcionarios.FindAsync(id);
            _context.Funcionarios.Remove(funcionario);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
