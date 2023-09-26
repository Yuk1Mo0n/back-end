using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
//using CRUD.Models;

//Crindo a classe ' TarefaCotroller ' e herdando seus métodos de Controller
public class TarefaController : Controller
{
    //Criando um objeto ' _tarefa ' que armazenará uma lista de tarefas
    private static List<Tarefa> _tarefas = new List<Tarefa>();

    public IActionResult Index()
    {
        return View(_tarefas);
    }
    public IActionResult Adicionar()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Adicionar(Tarefa novaTarefa)
    {
        //Verificando o total de tarefas da lista e somente mais 1 para criar o ID
        novaTarefa.Id = _tarefas.Count + 1;
        //Adicionar minha nova tarefa á minha lista
        _tarefas.Add(novaTarefa);
        //Redirecionarndo para a página principal com a lista de tarefas
        return RedirectToAction("Index");
    }
    
    public IActionResult Editar(int Id)
    {
        //Estou buscando na minha lista a tarefa que desejo alterar  
        Tarefa novaTarefa = _tarefas.FirstOrDefault(t => t.Id == Id);
        if (novaTarefa == null)
            return NotFound();

        return View(novaTarefa);

    }

    [HttpPost]
    public IActionResult Editar(Tarefa tarefaEditar)
    {
        Tarefa tarefaEncontrada = _tarefas.FirstOrDefault(t => t.Id == tarefaEditar.Id);
        if (tarefaEncontrada == null)
            return NotFound();

        tarefaEncontrada.Descricao = tarefaEditar.Descricao;
        tarefaEncontrada.Concluida = tarefaEditar.Concluida;
        return RedirectToAction("Index");
    }

    public IActionResult Deletar(int Id)
    {
        //Estou buscando na minha lista a tarefa que desejo alterar  
        Tarefa novaTarefa = _tarefas.FirstOrDefault(t => t.Id == Id);
        if (novaTarefa == null)
            return NotFound();

        return View(novaTarefa);

    }

    [HttpPost]
    public IActionResult deletarConfirmado(int Id)
    {
        Tarefa tarefaEncontrada = _tarefas.FirstOrDefault(t => t.Id == Id);
        if (tarefaEncontrada == null)
            return NotFound();

        _tarefas.Remove(tarefaEncontrada);
        return RedirectToAction("Index");
    }
}