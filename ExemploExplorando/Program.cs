// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using ExemploExplorando.Models;

// Pessoa p1 = new Pessoa();
// p1.Nome = "João";
// p1.Sobrenome = "Silva";
// p1.Idade = 20;

// p1.Apresentar();

Pessoa p1 = new Pessoa(nome: "Joao", sobrenome: "Silva");

Pessoa p2 = new Pessoa(nome: "Juliana", sobrenome: "Campos");

Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Curso de Inglês";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListarAlunos();