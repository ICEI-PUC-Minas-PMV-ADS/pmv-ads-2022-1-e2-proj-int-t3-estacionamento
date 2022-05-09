using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using webWhyPark.Context;
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
        public IActionResult Login()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login([Bind("Email,Senha")] CadastroCliente cadastroCliente)
        {
            var loginCli = await _context.CadastroClientes
                .FirstOrDefaultAsync(m => m.Email == cadastroCliente.Email);
            Console.WriteLine(loginCli);
            Console.WriteLine(cadastroCliente.Senha);
            if (loginCli == null)
            {
                ViewBag.message = "Usuário e/ou senha inválidos.";
                return View();
            }

            bool senhaCorreta = BCrypt.Net.BCrypt.Verify(cadastroCliente.Senha, loginCli.Senha);

            if (senhaCorreta)
            {
                var claims = new List<Claim>

                {
                    new Claim(ClaimTypes.Name, loginCli.Email),
                    new Claim(ClaimTypes.NameIdentifier, loginCli.Email)
                };

                var loginIdentity = new ClaimsIdentity(claims, "login");

                ClaimsPrincipal principal = new ClaimsPrincipal(loginIdentity);

                var props = new AuthenticationProperties
                {
                    AllowRefresh = true,
                    ExpiresUtc = DateTime.Now.ToLocalTime().AddDays(7),
                    IsPersistent = true,
                };

                await HttpContext.SignInAsync(principal, props);

                return Redirect("/"); //Redireciona para o home da aplicação
            }

            ViewBag.Message = "Email e/ou senha inválidos!";
            return View();
        }

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction("Login, LoginCliente"); //Redireciona para a página de Login
        }

        public IActionResult AcessDenied()
        {
            return View();
        }

        //Get: LoginCliente
        public async Task<IActionResult> Index()
        {
            return View(await _context.CadastroClientes.ToListAsync());
        }

        //Get: LoginCliente/Details
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var loginCli = await _context.CadastroClientes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (loginCli == null)
            {
                return NotFound();
            }
            return View(loginCli);
        }


    }
}