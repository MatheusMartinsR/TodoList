// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

const global = new Global();
const casa = new Casa();
const escola = new Escola();
const viagens = new Viagens();
const projetos = new Projetos();

Console.WriteLine('Testando o metodo RetornarTarefa da classe escola');

escola.setDever('fazer lição de casa');

if(escola.RetornarTarefa() == 'O nome do dever de casa é: fazer lição de casa'){
    Console.WriteLine('Teste passou');
}else{
    Console.WriteLine('Teste falhou');
}
