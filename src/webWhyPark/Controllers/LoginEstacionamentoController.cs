using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using webWhyPark.Context;
using webWhyPark;
using webWhyPark.Models;
using System;
using System.Security.Claims;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
namespace webWhyPark.Controllers
{
    public class LoginEstacionamento : Controller
    {
        private readonly ApplicationDbContext _context = null!;


        //Construtor do Login do Cliente no Contexto
        public LoginEstacionamento(ApplicationDbContext context)
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
        public async Task<IActionResult> LoginPark([Bind("Email,Senha")] Estacionamento estacionamento)
        {


            var park = await _context.Estacionamentos.FirstOrDefaultAsync(m => m.Email == estacionamento.Email);
            if (park?.Email == "")
            {
                return RedirectToAction("Index", new { erroLogin = true });
            }

            bool senhaValida = BCrypt.Net.BCrypt.Verify(estacionamento.Senha, park?.Senha);

            if (park?.Email == estacionamento.Email && senhaValida)
            {
                TempData["Nome"] = park?.RazaoSocial;
                await new ServicesEstacioanamento().Login(HttpContext, park!);
                return RedirectToAction("Profile");
            }
            else
            {
                return RedirectToAction("Index", new { erroLogin = true });

            }

        }


        [Authorize]
        public async Task<IActionResult> Logout()
        {
            await new ServicesEstacioanamento().Logout(HttpContext);
            return Redirect("~/Home/Index");

        }

        [Authorize(Roles = "gestor")]
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
            return View(await _context.Estacionamentos.ToListAsync());
        }

        //Get: LoginCliente/Details
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var loginCli = await _context.Estacionamentos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (loginCli == null)
            {
                return NotFound();
            }
            return View(loginCli);
        }

    }
}