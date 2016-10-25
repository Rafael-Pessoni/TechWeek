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
            return View(_context.Tarefas.ToList());
        }

        public IActionResult Details(int? id)
        {
            if (id == null)
                return NotFound();

            var tarefa = _context.Tarefas.Include(x => x.Interessados).SingleOrDefault(x => x.Id == id);

            if (tarefa == null)
                return NotFound();

            return View(tarefa);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Tarefa tarefa, Interessado interessado)
        {
            tarefa.DataCadastro = DateTime.Now;

            tarefa.AddInteressado(interessado);

            if (!ModelState.IsValid)
                return View(tarefa);

            _context.Add(tarefa);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult Edit(int? id)
        {
            if(id == null)
                return NotFound();

            var tarefa = _context.Tarefas.Include(x => x.Interessados).SingleOrDefault(x => x.Id == id);

            if(tarefa == null)
                return NotFound();

            return View(tarefa);
        }

        [HttpPost]
        public IActionResult Edit(Tarefa tarefa)
        {
            if (!ModelState.IsValid)
                return View(tarefa);

            try
            {
                _context.Update(tarefa);
                _context.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_context.Tarefas.Any(x => x.Id == tarefa.Id))
                    return NotFound();

                throw;
            }

            return RedirectToAction("Index");
        }

        public IActionResult Delete(int? id)
        {
            if (id == null)
                return NotFound();

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

            var tarefa = _context.Tarefas.SingleOrDefault(x => x.Id == id);
            _context.Tarefas.Remove(tarefa);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult Finish(int? id)
        {
            if (id == null)
                return NotFound();

            var tarefa = _context.Tarefas.SingleOrDefault(x => x.Id == id);
            if(tarefa == null)
                return NotFound();

            tarefa.DataTerminoEfetivo = DateTime.Now;
            _context.Update(tarefa);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
