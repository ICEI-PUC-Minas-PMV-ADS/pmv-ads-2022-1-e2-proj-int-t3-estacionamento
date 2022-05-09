using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using webWhyPark.Context;
using webWhyPark.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webWhyPark.Controllers
{
    public class EstacionamentoController : Controller
    {

        private readonly ApplicationDbContext _context = null!;

        //Constructor
        public EstacionamentoController(ApplicationDbContext context)
        {
            if (context != null)
                _context = context;
        }


        //Index
        //GET: Estacioanamentos
        public async Task<IActionResult> Index()
        {
            return View(await _context.Estacionamentos.ToListAsync());
        }

        //GET: Estacioanamentos/Details/2
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            //Recupera o estacionamento

            var estacionamento = await _context.Estacionamentos
                                .FirstOrDefaultAsync(e => e.Id == id);

            if (estacionamento == null)
            {
                return NotFound();
            }

            return View(estacionamento);

        }


        //Criar estacionameto rota
        //GET Estacionamento/Create

        public IActionResult Create()
        {
            return View();
        }



        [HttpPost, ActionName("Create")]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Create([Bind("Id,RazaoSocial,CNPJ,Telefone,Email")] Estacionamento estacionameto)
        {
            if (ModelState.IsValid)
            {
                _context.Add(estacionameto);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View();
        }


        //Recupera o estacionamento para editar
        //GET: Estacionamento/Edit/9

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var estacionamento = await _context.Estacionamentos.FindAsync(id);

            if (estacionamento == null)
            {
                return NotFound();
            }

            return View(estacionamento);
        }

        //POST Alunos/Delete/5
        [HttpPost, ActionName("Edit")]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Edit(int id, [Bind("Id,RazaoSocial,CNPJ,Telefone,Email")] Estacionamento estacionamento)
        {
            if (ModelState.IsValid)
            {

                try
                {
                    _context.Estacionamentos.Update(estacionamento);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EstacionamentoExists(id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }

            return View(estacionamento);
        }


        //Recupera o estacionamento para deletar
        //GET: Estacionamento/Edit/9

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var estacionamento = await _context.Estacionamentos
                                .FirstOrDefaultAsync(d => d.Id == id);

            if (estacionamento == null)
            {
                return NotFound();
            }

            return View(estacionamento);
        }

        //POST Estacionamento/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]


        public async Task<IActionResult> Delete(int id)
        {
            var estacionamento = await _context.Estacionamentos.FindAsync(id);
            _context.Estacionamentos.Remove(estacionamento!);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public bool EstacionamentoExists(int id)
        {
            return _context.Estacionamentos.Any(e => e.Id == id);
        }
    }
}