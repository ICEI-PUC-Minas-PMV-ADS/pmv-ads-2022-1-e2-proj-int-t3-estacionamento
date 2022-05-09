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
    public class CadastroClienteController : Controller
    {
        private readonly ApplicationDbContext _context = null!;


        //Construtor do Cadastro do Cliente no Contexto
        public CadastroClienteController(ApplicationDbContext context)
        {
            if (context != null)
                _context = context;
        }

        //Index 
        //GET: CadastroCliente
        public async Task<IActionResult> Index()
        {
            return View(await _context.CadastroClientes.ToListAsync());
        }

        //GET: CadastroClientes/Details/2
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            //Recupera o Cliente

            var cadastroCli = await _context.CadastroClientes
                                .FirstOrDefaultAsync(e => e.Id == id);

            if (cadastroCli == null)
            {
                return NotFound();
            }

            return View(cadastroCli);

        }

        //Criar rota do Cadastro do Cliente
        //GET CadastroCliente/Create

        public IActionResult Create()
        {
            return View();
        }


        [HttpPost, ActionName("Create")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nome,Email,Senha")] CadastroCliente cadastroCli)
        {
            if (ModelState.IsValid)
            {
                cadastroCli.Senha = BCrypt.Net.BCrypt.HashPassword(cadastroCli.Senha, BCrypt.Net.SaltRevision.Revision2B);
                _context.Add(cadastroCli);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View();
        }

        //Recupera o CadastroCliente para editar
        //GET: CadastroCliente/Edit/9

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cadastroCli = await _context.CadastroClientes.FindAsync(id);

            if (cadastroCli == null)
            {
                return NotFound();
            }

            return View(cadastroCli);
        }

        //POST CadastroCliente/Delete/5
        [HttpPost, ActionName("Edit")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nome,Email,Senha")] CadastroCliente cadastroCli)
        {
            if (id != cadastroCli.Id)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {

                try
                {
                    _context.CadastroClientes.Update(cadastroCli);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CadastroClienteExists(id))
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

            return View(cadastroCli);
        }

        //Recupera o CadastroCliente para deletar
        //GET: CadastroCliente/Edit/9
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cadastroCli = await _context.CadastroClientes
                                .FirstOrDefaultAsync(d => d.Id == id);

            if (cadastroCli == null)
            {
                return NotFound();
            }

            return View(cadastroCli);
        }

        //POST CadastroCliente/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            var cadastroCli = await _context.CadastroClientes.FindAsync(id);
            _context.CadastroClientes.Remove(cadastroCli!);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public bool CadastroClienteExists(int id)
        {
            return _context.CadastroClientes.Any(e => e.Id == id);
        }



    }
}