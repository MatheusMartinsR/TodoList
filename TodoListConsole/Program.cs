// See https://aka.ms/new-console-template for more information
using TodoList.Models;

Console.WriteLine("Hello, World!");

var casa = new Casa();
var escola = new Escola();
var viagens = new Viagens();
var projetos = new Projetos();
var trabalho = new Trabalho();



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
        var decisaoCasa = Console.ReadLine();

        if (decisaoCasa == "S")
        {
            foreach (var item in listaPropsDaTarefa)
            {
                Console.WriteLine(item);
            }
        }

        break;

    case "2":
        Console.WriteLine("Insira o nome da tarefa");
        var nomeTarefaEscola = Console.ReadLine();

        escola.nome = nomeTarefaEscola;

        Console.WriteLine("Insira a descrição da tarefa");
        var descricaoTarefaEscola = Console.ReadLine();
        escola.descricao = descricaoTarefaEscola;

        Console.WriteLine("Insira o responsável da tarefa");
        var responsavelTarefaEscola = Console.ReadLine();
        escola.responsavel = responsavelTarefaEscola;

        Console.WriteLine("Insira o dever da tarefa");
        var deverTarefaEscola = Console.ReadLine();
        escola.dever = deverTarefaEscola;

        Console.WriteLine("Insira a matéria da tarefa");
        var materiaTarefaEscola = Console.ReadLine();
        escola.materia = materiaTarefaEscola;

        Console.WriteLine("Insira o professor da tarefa");
        var professorTarefaEscola = Console.ReadLine();
        escola.professor = professorTarefaEscola;

        listaPropsDaTarefa.Add($"nome:{nomeTarefaEscola}, descrição:{descricaoTarefaEscola}, responsável:{responsavelTarefaEscola}, dever:{deverTarefaEscola}, matéria:{materiaTarefaEscola}, professor:{professorTarefaEscola}");

        Console.WriteLine("Caso deseja ver a lista de tarefas digite 1, para ver somente o dever digite 2");
        var decisaoEscola = Console.ReadLine();

        if (decisaoEscola == "1")
        {
            foreach (var item in listaPropsDaTarefa)
            {
                Console.WriteLine(item);
            }
        } else if(decisaoEscola == "2")
        {

             if(escola.dever == ""){
            Console.WriteLine("Não há dever para ser feito");
            }
            else{
                Console.WriteLine("Testando o metodo que retorna o dever, deve retornar o valor inserido no dever ");
                escola.RetornarTarefa();
            }
        }

       

        break;

    case "3":
        Console.WriteLine("Insira o nome da tarefa");
        var nomeTarefaProjeto = Console.ReadLine();


        projetos.nome = nomeTarefaProjeto;

        Console.WriteLine("Insira a descrição da tarefa");
        var descricaoTarefaProjeto = Console.ReadLine();
        projetos.descricao = descricaoTarefaProjeto;

        Console.WriteLine("Insira o responsável da tarefa");
        var responsavelTarefaProjeto = Console.ReadLine();
        projetos.responsavel = responsavelTarefaProjeto;

        Console.WriteLine("Insira a ideia do projeto");
        var ideiaTarefaProjeto = Console.ReadLine();
        projetos.ideia = ideiaTarefaProjeto;

        Console.WriteLine("Insira o desenvolvimento do projeto");
        var desenvolvimentoTarefaProjeto = Console.ReadLine();
        projetos.desenvolvimento = desenvolvimentoTarefaProjeto;

        Console.WriteLine("Insira a conclusão do projeto");
        var conclusaoTarefaProjeto = Console.ReadLine();
        projetos.conclusao = conclusaoTarefaProjeto;

        listaPropsDaTarefa.Add($"nome:{nomeTarefaProjeto}, descrição:{descricaoTarefaProjeto}, responsável:{responsavelTarefaProjeto}, ideia:{ideiaTarefaProjeto}, desenvolvimento:{desenvolvimentoTarefaProjeto}, conclusão:{conclusaoTarefaProjeto}");

        Console.WriteLine("Caso deseje ver a lista de tarefas digite 1, para ver somente a ideia do projeto digite 2");
        var decisaoProjeto = Console.ReadLine();

        if (decisaoProjeto == "1")
        {
            foreach (var item in listaPropsDaTarefa)
            {
                Console.WriteLine(item);
            }
        }
        else if (decisaoProjeto == "2")
        {
            Console.WriteLine("Testando o método que retorna a ideia do projeto, deve retornar o valor inserido no campo de ideia");
            projetos.RetornarTarefa();
        }
        break;

    case "4":
        Console.WriteLine("Insira o nome da tarefa");
        var nomeTarefaTrabalho = Console.ReadLine();

        trabalho.nome = nomeTarefaTrabalho;

        Console.WriteLine("Insira a descrição da tarefa");
        var descricaoTarefaTrabalho = Console.ReadLine();
        trabalho.descricao = descricaoTarefaTrabalho;

        Console.WriteLine("Insira o responsável da tarefa");
        var responsavelTarefaTrabalho = Console.ReadLine();
        trabalho.responsavel = responsavelTarefaTrabalho;

        Console.WriteLine("Insira a tarefa do trabalho");
        var tarefaTarefaTrabalho = Console.ReadLine();
        trabalho.tarefa = tarefaTarefaTrabalho;

        Console.WriteLine("Insira o setor do trabalho");
        var setorTarefaTrabalho = Console.ReadLine();
        trabalho.setor = setorTarefaTrabalho;

        Console.WriteLine("Insira o gestor do trabalho");
        var gestorTarefaTrabalho = Console.ReadLine();
        trabalho.gestor = gestorTarefaTrabalho;

        listaPropsDaTarefa.Add($"nome:{nomeTarefaTrabalho}, descrição:{descricaoTarefaTrabalho}, responsável:{responsavelTarefaTrabalho}, tarefa:{tarefaTarefaTrabalho}, setor:{setorTarefaTrabalho}, gestor:{gestorTarefaTrabalho}");

        Console.WriteLine("Caso deseje ver a lista de tarefas digite 1, para ver somente o setor e a tarefa do trabalho digite 2");
        var decisaoTrabalho = Console.ReadLine();

        if (decisaoTrabalho == "1")
        {
            foreach (var item in listaPropsDaTarefa)
            {
                Console.WriteLine(item);
            }
        }
        else if (decisaoTrabalho == "2")
        {
            Console.WriteLine("Testando o método que retorna a tarefa do trabalho, deve retornar o valor inserido no campo tarefa");
            trabalho.RetornarTarefa();

            Console.WriteLine("Testando o metódo que retorna o setor, deve retornar o valor inserido no campo setor");
            trabalho.RestornarSetor();
        }
        break;

    case "5":
        Console.WriteLine("Insira o nome da tarefa");
        var nomeTarefaViagens = Console.ReadLine();

        viagens.nome = nomeTarefaViagens;

        Console.WriteLine("Insira a descrição da tarefa");
        var descricaoTarefaViagens = Console.ReadLine();
        viagens.descricao = descricaoTarefaViagens;

        Console.WriteLine("Insira o responsável da tarefa");
        var responsavelTarefaViagens = Console.ReadLine();
        viagens.responsavel = responsavelTarefaViagens;

        Console.WriteLine("Insira o passeio da viagem");
        var passeiosTarefaViagens = Console.ReadLine();
        viagens.passeios = passeiosTarefaViagens;

        Console.WriteLine("Insira as compras da viagem");
        var comprasTarefaViagens = Console.ReadLine();
        viagens.compras = comprasTarefaViagens;

        listaPropsDaTarefa.Add($"nome:{nomeTarefaViagens}, descrição:{descricaoTarefaViagens}, responsável:{responsavelTarefaViagens}, passeio:{passeiosTarefaViagens}, compras:{comprasTarefaViagens}");

        Console.WriteLine("Caso deseje ver a lista de tarefas digite 1, para ver as compras e o passeio da viagem digite 2");
        var decisaoViagens = Console.ReadLine();

        if (decisaoViagens == "1")
        {
            foreach (var item in listaPropsDaTarefa)
            {
                Console.WriteLine(item);
            }
        }
        else if (decisaoViagens == "2")
        {
            Console.WriteLine("Testando o método que retorna o passeio da viagem, deve retornar o valor inserido no campo de passeio");
            viagens.RetornarPasseio();

            Console.WriteLine("Testando o método que retorna as compras da viagem, deve retornar o valor inserido no campo de compras");
            viagens.RetornarCompras();
        }
        break;

    default:
        Console.WriteLine("Escolha inválida. Tente novamente.");
        break;

}


