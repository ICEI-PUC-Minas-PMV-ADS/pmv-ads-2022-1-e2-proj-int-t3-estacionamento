using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using webWhyPark.Context;
using webWhyPark.Models;
using System;
using System.Security.Claims;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webWhyPark.Controllers
{
    public class VeiculoController : Controller
    {
        private readonly ApplicationDbContext _context = null!;


        //Construtor do Cadastro do Veiculo no Contexto
        public VeiculoController(ApplicationDbContext context)
        {
            if (context != null)
                _context = context;
        }

        //Index 
        //GET: Veiculo
        public async Task<IActionResult> Index()
        {
            return View(await _context.Veiculos.ToListAsync());
        }

        //GET: Veiculos/Details/2
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            //Recupera o Veiculo

            var veiculoCadastrado = await _context.Veiculos
                                .FirstOrDefaultAsync(e => e.Id == id);

            if (veiculoCadastrado == null)
            {
                return NotFound();
            }

            return View(veiculoCadastrado);

        }

        //Criar rota do Cadastro do Veiculo
        //GET Veiculo/Create

        public IActionResult Create()
        {
            return View();
        }


        [HttpPost, ActionName("Create")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nome,Placa,Cor,Modelo,Veiculo")] Veiculo veiculoCadastrado)
        {
            if (ModelState.IsValid)
            {

                _context.Add(veiculoCadastrado);
                await _context.SaveChangesAsync();
                return Redirect("/");
            }
            return View();
        }

        //Recupera o Veiculo para editar
        //GET: Veiculo/Edit/9

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var veiculoCadastrado = await _context.Veiculos.FindAsync(id);

            if (veiculoCadastrado == null)
            {
                return NotFound();
            }

            return View(veiculoCadastrado);
        }

        //POST Veiculo/Edit/5
        [HttpPost, ActionName("Edit")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nome,Placa,Cor,Modelo,Veiculo")] Veiculo veiculoCadastrado)
        {
            if (id != veiculoCadastrado.Id)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {

                try
                {
                    _context.Veiculos.Update(veiculoCadastrado);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VeiculoExists(id))
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

            return View(veiculoCadastrado);
        }

        //Recupera o Veiculo para deletar
        //GET: Veiculo/Delete/9
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var veiculoCadastrado = await _context.Veiculos
                                .FirstOrDefaultAsync(d => d.Id == id);

            if (veiculoCadastrado == null)
            {
                return NotFound();
            }

            return View(veiculoCadastrado);
        }

        //POST Veiculo/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            var veiculoCadastrado = await _context.Veiculos.FindAsync(id);
            _context.Veiculos.Remove(veiculoCadastrado!);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public bool VeiculoExists(int id)
        {
            return _context.Veiculos.Any(e => e.Id == id);
        }



    }
}