using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using webWhyPark.Context;
using webWhyPark;
using webWhyPark.Models;
using System;
using System.Security.Claims;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;

namespace webWhyPark.Controllers
{
    public class LoginClienteController : Controller
    {
        private readonly ApplicationDbContext _context = null!;


        //Construtor do Login do Cliente no Contexto
        public LoginClienteController(ApplicationDbContext context)
        {
            if (context != null)
                _context = context;
        }

        //Criar rota do Login do Cliente

        //GET LoginCliente/Login
        public IActionResult Login(bool errLogin)
        {
            if (errLogin)
            {
                ViewBag.Erro = "Nickname e/ou senha estão incorretos";
            }
            return View();
        }


        [HttpPost, AllowAnonymous]
        public async Task<IActionResult> Login([Bind("Email,Senha")] Cliente cliente)
        {


            var client = await _context.Clientes
                .FirstOrDefaultAsync(m => m.Email == cliente.Email);
            if (client?.Email == "")
            {
                return RedirectToAction("Index", new { erroLogin = true });
            }

            bool senhaValida = BCrypt.Net.BCrypt.Verify(cliente.Senha, client?.Senha);

            if (client?.Email == cliente.Email && senhaValida)
            {
                TempData["Nome"] = client.Nome;
                await new Services().Login(HttpContext, client!);
                return RedirectToAction("Profile", client);
            }
            else
            {
                return RedirectToAction("Index", new { erroLogin = true });

            }

        }


        [Authorize]
        public async Task<IActionResult> Logout()
        {
            await new Services().Logout(HttpContext);
            return Redirect("~/Home/Index");

        }

        [Authorize(Roles = "cliente")]
        public IActionResult Profile()
        {
            ViewBag.Permissoes = HttpContext.User.Claims.Where(x => x.Type == ClaimTypes.Role).Select(x => x.Value);
            return View();
        }

        public IActionResult AcessDenied()
        {
            return View();
        }

        //Get: LoginCliente
        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
            return View(await _context.Clientes.ToListAsync());
        }

        //Get: LoginCliente/Details
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var loginCli = await _context.Clientes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (loginCli == null)
            {
                return NotFound();
            }
            return View(loginCli);
        }


    }
}