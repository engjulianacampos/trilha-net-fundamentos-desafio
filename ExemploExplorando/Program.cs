// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using ExemploExplorando.Models;
using System.Globalization;

string dataString="2022-04-17 18:00";

bool sucesso=DateTime.TryParseExact(dataString,"yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime data);

if (sucesso)
{
    Console.WriteLine($"Conversão com sucesso! Data: {data}");
}
else
{
    Console.WriteLine($"{dataString} não é uma data válida.");
}
Console.WriteLine(data.ToString("dd/MM/yyyy"));
Console.WriteLine(data.ToShortDateString());
Console.WriteLine(data.ToShortTimeString());
Console.WriteLine(data);


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