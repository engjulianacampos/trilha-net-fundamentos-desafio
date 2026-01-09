// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using ExemploExplorando.Models;
using System.Globalization;



Dictionary<string, string> estados = new Dictionary<string, string>();
estados.Add("SP", "São Paulo");
estados.Add("RJ", "Rio de Janeiro");
estados.Add("MG", "Minas Gerais");

foreach (var item in estados)
{
    Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
}

estados.Remove("MG");
estados["RJ"] = "Rio de Janeiro - RJ alterado";

Console.WriteLine("----------------------");

foreach (var item in estados)
{
    Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
}

string chave="SP";
Console.WriteLine($"Verificando a existência da chave {chave} no dicionário:");
if (estados.ContainsKey(chave))
{
    Console.WriteLine($"O dicionário contém a chave {chave}.");
}
else
{
    Console.WriteLine($"O dicionário não contém a chave {chave}.");
}

Console.WriteLine(estados["RJ"]);


// Stack<int> pilha = new Stack<int>();
// pilha.Push(2);
// pilha.Push(4);
// pilha.Push(6);
// pilha.Push(8);

// foreach (int item in pilha)
// {
//     Console.WriteLine(item);
// }

// pilha.Pop();
// pilha.Push(10);
// Console.WriteLine("Removido o elemento do topo da pilha e inserindo novo elemento:");

// foreach (int item in pilha)
// {
//     Console.WriteLine(item);
// }



// Queue<int> fila = new Queue<int>();
// fila.Enqueue(2);
// fila.Enqueue(4);
// fila.Enqueue(6);        
// fila.Enqueue(8);

// foreach (int item in fila)
// {
//     Console.WriteLine(item);
// }
// fila.Dequeue();
// fila.Enqueue(10);
// Console.WriteLine("Removido o primeiro elemento da fila:");

// foreach (int item in fila)
// {
//     Console.WriteLine(item);
// }



//new ExemploExcecao().Metodo1();


// try{
// string[] linhas = File.ReadAllLines("Arquivos/arquivoLeitura.txt");

// foreach (string linha in linhas)
// {
//     Console.WriteLine(linha);
// }
// }
// catch (FileNotFoundException ex)
// {
//     Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Arquivo não encontrado. {ex.Message}");
// }
// catch (DirectoryNotFoundException ex)
// {
//     Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Caminho da pasta não encontrado. {ex.Message}");
// }
// catch (Exception ex)
// {
//     Console.WriteLine($"Ocorreu uma exceção genérica. {ex.Message}");
// }
// finally
// {
//     Console.WriteLine("Chegou no bloco finally.");
// }

// string dataString="2022-04-17 18:00";

// bool sucesso=DateTime.TryParseExact(dataString,"yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime data);

// if (sucesso)
// {
//     Console.WriteLine($"Conversão com sucesso! Data: {data}");
// }
// else
// {
//     Console.WriteLine($"{dataString} não é uma data válida.");
// }
// Console.WriteLine(data.ToString("dd/MM/yyyy"));
// Console.WriteLine(data.ToShortDateString());
// Console.WriteLine(data.ToShortTimeString());
// Console.WriteLine(data);


// CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");

// decimal valorMonetario=1582.40m;

// Console.WriteLine(valorMonetario.ToString("C",CultureInfo.CreateSpecificCulture("en-US")));
// Console.WriteLine(valorMonetario.ToString("C1"));
// Console.WriteLine(valorMonetario.ToString("C2"));
// Console.WriteLine(valorMonetario.ToString("N1"));

// double porcentagem = .3421;

// Console.WriteLine(porcentagem.ToString("P")); 

// int numero = 123456;

// Console.WriteLine(numero.ToString("##-##-##"));


// string numero1="10";
// string numero2="20";

// string resultado=numero1+numero2;

// Console.WriteLine(resultado);


// // Pessoa p1 = new Pessoa();
// // p1.Nome = "João";
// // p1.Sobrenome = "Silva";
// // p1.Idade = 20;

// // p1.Apresentar();

// Pessoa p1 = new Pessoa(nome: "Joao", sobrenome: "Silva");

// Pessoa p2 = new Pessoa(nome: "Juliana", sobrenome: "Campos");

// Curso cursoDeIngles = new Curso();
// cursoDeIngles.Nome = "Curso de Inglês";
// cursoDeIngles.Alunos = new List<Pessoa>();

// cursoDeIngles.AdicionarAluno(p1);
// cursoDeIngles.AdicionarAluno(p2);
// cursoDeIngles.ListarAlunos();