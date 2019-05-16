using System.Linq;

namespace HelloAspCore.Data
{
    public class DbSeeder
    {
        public DbSeeder(ApplicationDbContext db)
        {
            Db = db;
        }

        public ApplicationDbContext Db { get; }

        public void Seed()
        {
            if (Db.Todos.Any())
            {
                return;
            }

            var todos = new[]
            {
                new Todo { id = 1, Description = "Tarefa 1"},
                new Todo { id = 12, Description = "Tarefa 2"}
            };

            foreach (var todo in todos)
            {
                Db.Todos.Add(todo);
            }
            Db.SaveChanges();
        }
    }
}