using System.Linq;
using HelloAspCore.Data;
using Microsoft.AspNetCore.Mvc;

namespace HelloAspCore.Controllers
{
    public class TodosApiController : Controller
    {
        public ApplicationDbContext Db { get; set; }
        // A base de dados é inicializada pelo ASP.NET CORE e passada no construtor.
        public TodosApiController(ApplicationDbContext db)
        {
            Db = db;
        }

        public ActionResult Index()
        {
            var todos = Db.Todos.ToList();
            return Ok(todos);
        }
    }
}