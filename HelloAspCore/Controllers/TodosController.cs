using System.Linq;
using HelloAspCore.Data;
using Microsoft.AspNetCore.Mvc;

namespace HelloAspCore.Controllers
{
    public class TodosController : Controller
    {
        public ApplicationDbContext Db { get; set; }
        // A base de dados é inicializada pelo ASP.NET CORE e passada no construtor.
        public TodosController(ApplicationDbContext db)
        {
            Db = db;
        }

        public ActionResult Index()
        {
            var todos = Db.Todos.ToList();
            return View(todos);
        }
    }
}