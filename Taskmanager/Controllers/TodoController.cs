using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Taskmanager.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Taskmanager.Controllers
{

    public class TodoController : Controller
    {
        public List<Todo> todos { get; set; }

        public TodoController()
        {
          this.todos = new List<Todo>
            {
                new Todo {id=1, name="ASP.NET", description="ASP.NET api development", status="Not started", createDate=DateTime.Now, dueDate=DateTime.Now.AddDays(30)},
                new Todo {id=2, name="Python Selenium", description="Selenium framework", status="In progress", createDate=DateTime.Now, dueDate=DateTime.Now.AddDays(60)},
                new Todo {id=3, name="Django", description="Backend development", status="Completed", createDate=DateTime.Now, dueDate=DateTime.Now.AddDays(14)},
                new Todo {id=4, name="PLSQL", description="SQL development", status="Not started", createDate=DateTime.Now, dueDate=DateTime.Now.AddDays(366)}
            };
        }

        // GET: /<controller>/
        [HttpGet]
        public IActionResult Index()
        {

            return View(todos);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Todo todo)
        {
            todos.Add(todo);
            return RedirectToAction("Index","Todo");
        }

    }
}

