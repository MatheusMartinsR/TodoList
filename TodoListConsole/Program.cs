// See https://aka.ms/new-console-template for more information
using TodoList.Models;

Console.WriteLine("Hello, World!");

var global = new Global();
var casa = new Casa();
var escola = new Escola();
var viagens = new Viagens();
var projetos = new Projetos();



Console.WriteLine("Bem vindo ao nosso projeto");
Console.WriteLine("Digite 1 para adicionar tarefas para lista Casa");
Console.WriteLine("Digite 2 para adicionar tarefas para lista Escola");
Console.WriteLine("Digite 3 para adicionar tarefas para lista Projeto");
Console.WriteLine("Digite 4 para adicionar tarefas para lista Trabalho");
Console.WriteLine("Digite 5 para adicionar tarefas para lista Viagens");


var escolha = Console.ReadLine();

var listaPropsDaTarefa = new List<string>();

switch (escolha)
{
    case "1":
        Console.WriteLine("Insira o nome da tarefa");
        var nomeTarefaCasa = Console.ReadLine();

        casa.nome = nomeTarefaCasa;

        Console.WriteLine("Insira a descrição da tarefa");
        var descricaoTarefaCasa = Console.ReadLine();

        casa.descricao = descricaoTarefaCasa;

        Console.WriteLine("Insira o responsável da tarefa");
        var responsavelTarefaCasa = Console.ReadLine();

        casa.responsavel = responsavelTarefaCasa;

        Console.WriteLine("Insira o comodo da tarefa");
        var comodoTarefaCasa = Console.ReadLine();

        casa.responsavel = comodoTarefaCasa;

        listaPropsDaTarefa.Add($"nome:{nomeTarefaCasa}, descrição:{descricaoTarefaCasa}, responsável:{responsavelTarefaCasa}, comodo:{comodoTarefaCasa}");

        Console.WriteLine("Deseja ver a lista de tarefas ?(S/N)");
        var decisao = Console.ReadLine();

        if(decisao == "S")
        {
            Console.WriteLine(listaPropsDaTarefa);
        }

        break;
}


