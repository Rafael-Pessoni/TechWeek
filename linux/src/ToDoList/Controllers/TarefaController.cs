using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ToDoList.Model;

namespace ToDoList.Controllers
{
    public class TarefaController : Controller
    {
        private readonly ToDoListContext _context;

        public TarefaController(ToDoListContext toDoListContext)
        {
            _context = toDoListContext;
        }

        public IActionResult Index()
        {
            // retornando a view incial com a listagem
            return View(_context.Tarefas.ToList());
        }

        public IActionResult Details(int? id)
        {
            if (id == null)
                return NotFound();

            // buscando os detalhes no banco
            var tarefa = _context.Tarefas.SingleOrDefault(x => x.Id == id);

            if (tarefa == null)
                return NotFound();

            return View(tarefa);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Tarefa tarefa)
        {
            // verificando se o model está válido
            if (!ModelState.IsValid)
                return View(tarefa);

            // inserindo o registro
            _context.Add(tarefa);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult Edit(int? id)
        {
            if (id == null)
                return NotFound();

            // buscando os detalhes no banco
            var tarefa = _context.Tarefas.SingleOrDefault(x => x.Id == id);

            if (tarefa == null)
                return NotFound();

            return View(tarefa);
        }

        [HttpPost]
        public IActionResult Edit(Tarefa tarefa)
        {
            // verificando se o model está válido
            if (!ModelState.IsValid)
                return View(tarefa);

            //atualizando o registro
            _context.Update(tarefa);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult Delete(int? id)
        {
            if (id == null)
                return NotFound();

            // buscando os detalhes no banco
            var tarefa = _context.Tarefas.SingleOrDefault(x => x.Id == id);

            if (tarefa == null)
                return NotFound();

            return View(tarefa);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int? id)
        {
            if (id == null)
                return NotFound();

            // buscando a tarefa no banco
            var tarefa = _context.Tarefas.SingleOrDefault(x => x.Id == id);

            //removendo o registro
            _context.Tarefas.Remove(tarefa);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult Finish(int? id)
        {
            if (id == null)
                return NotFound();

            // buscando a tafefa no banco
            var tarefa = _context.Tarefas.SingleOrDefault(x => x.Id == id);
            if (tarefa == null)
                return NotFound();

            // atualizando o registro
            tarefa.DataTerminoEfetivo = DateTime.Now;
            _context.Update(tarefa);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
