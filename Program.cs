Console.WriteLine("<<<<<Exemplo List>>>>>");

//Declaração das listas com tipos de dados simples
List<String> nomes = new List<string>();
List<int> cpfs = new List<int>();

//Adicionando valores string
nomes.Add("Heitor");
nomes.Add("Dorival");
nomes.Add("Lucas");

//Adicionando valores int
cpfs.Add(1234);
cpfs.Add(4567);
cpfs.Add(8901);

//Foreach para imprimir nome
foreach(var nome in nomes)
{
    Console.WriteLine($"Nome:{nome}");
}

//Foreach para imprimir cpf
foreach (var cpf in cpfs)
{
    Console.WriteLine($"CPF:{cpf}");
}