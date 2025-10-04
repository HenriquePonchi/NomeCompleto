// See https://aka.ms/new-console-template for more information
string nome;
string sobrenome;


Console.Write("Informe o seu nome: ");
nome = Console.ReadLine()!;


Console.Write("Informe o seu sobrenome: ");
sobrenome = Console.ReadLine()!;



string nomeCatalogo = $"Nome de catálogo: {sobrenome.ToUpper()}, {nome}";
Console.WriteLine(nomeCatalogo);
