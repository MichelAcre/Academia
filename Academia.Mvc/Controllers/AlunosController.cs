namespace Academia;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Academia.Mvc.Data;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using global::Academia.Mvc.Data;

[Authorize(Roles = "Admin,Colaborador")] // Regra de autorização para acessar o controller, apenas usuários com as regras "Admin" ou "Colaborador" podem acessar
    public class AlunosController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AlunosController(ApplicationDbContext context) => _context = context;

        public async Task<IActionResult> Index() =>
            View(await _context.Alunos.ToListAsync());

        // Create, Edit, Delete seguem o mesmo padrão de CRUD que já vimos na aula anterior (Produto/Categoria)
    }

