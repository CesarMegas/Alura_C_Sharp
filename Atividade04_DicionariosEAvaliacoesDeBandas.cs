// Atividade 04 - Dicionários e Avaliando Bandas
// Exercício 01: Criar um dicionário que represente um aluno, com uma lista de notas, e mostre a média de suas notas na tela.
using System;

Dictionary<string, List<double>> notasAlunos = new Dictionary<string, List<double>>();
notasAlunos.Add("Carlos", new List<double> {9.0, 8.5, 7.5, 6.0});
notasAlunos.Add("Giovanna", new List<double> { 10.0, 9.5, 8.0, 8.5});

foreach (var aluno in notasAlunos) 
{
    double soma = 0;
    for (int i = 0; i < aluno.Value.Count; i++) 
    {
        soma += aluno.Value[i];
    }
    double media = soma / aluno.Value.Count;
    Console.WriteLine($"A Média de {aluno.Key} é" +
        $": {media}");
}


// Exercício 02: Criar um programa que gerencie o estoque de uma loja. Utilize um dicionário para armazenar produtos e suas
// quantidades em estoque e mostre, a partir do nome de um produto, sua quantidade em estoque.

Dictionary<string, int> listaDeProdutos = new Dictionary<string, int>();
listaDeProdutos.Add("Café", 20);
listaDeProdutos.Add("Leite", 15);

Console.Write("\nDigite o nome do produto que deseja saber a quantidade em estoque: ");
string produtoDigitado = Console.ReadLine()!;

if (listaDeProdutos.ContainsKey(produtoDigitado)) 
{
    Console.WriteLine($"A quantidade de {produtoDigitado} em estoque é: {listaDeProdutos[produtoDigitado]}");
}
else
{
    Console.WriteLine($"O produto {produtoDigitado} não foi encontrado no estoque...");
}

// Exercício 03: Crie um programa que implemente um quiz simples de perguntas e respostas. Utilize um dicionário para armazenar
// as perguntas e as respostas corretas.

Dictionary<string, string> perguntasERespostas = new Dictionary<string, string>();
perguntasERespostas.Add("Qunatos dias tem o mês de Março?", "31");
perguntasERespostas.Add("Quannto é 7 vezes 8?", "56");
perguntasERespostas.Add("Quem disse a frase: Penso, logo existo?", "Descartes");
perguntasERespostas.Add("O que significa a palavra TALE em português?", "Conto");
perguntasERespostas.Add("Quantas casas existem ao todo em Hogwarts?", "4");

int pontos = 0;

foreach (var pergunta in perguntasERespostas) 
{
    Console.WriteLine($"\n{pergunta.Key}");
    Console.Write("Digite sua resposta: ");
    string respostaDigitada = Console.ReadLine()!;

    if (respostaDigitada.ToLower() == pergunta.Value.ToLower()) 
    {
        Console.WriteLine("Resposta Correta!");
        pontos++;
    }
    else 
    {
        Console.WriteLine($"Resposta Incorreta... A resposta correta era: {pergunta.Value}");
    }
}

Console.WriteLine($"Você acertou {pontos} perguntas de {perguntasERespostas.Count}.");

// Exercício 04: Criar um programa que simule um sistema de login utilizando um dicionário para armazenar nomes de usuário e
// senhas.

Dictionary<string, string> usuarioESenha = new Dictionary<string, string>();
usuarioESenha.Add("user01", "user01password");
usuarioESenha.Add("user02", "user02password");

Console.Write("\nDigite o Nome de Usuário: ");
string nomeDeUsuarioDigitado  = Console.ReadLine()!;
Console.Write("\nDigite a Senha: ");
string senhaDigitada = Console.ReadLine()!;


if (usuarioESenha.ContainsKey(nomeDeUsuarioDigitado) && usuarioESenha.ContainsValue(senhaDigitada))
{
    Console.WriteLine($"Bem Vindo {nomeDeUsuarioDigitado}!");
}
else 
{
    Console.WriteLine("Usuário ou Senha incorretos...");
