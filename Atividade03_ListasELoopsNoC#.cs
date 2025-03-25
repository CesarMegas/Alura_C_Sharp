// Atividade 03 - Listas e Loops no C#
// Exercício 01: Escrever uma função que a partir de dois números de ponto flutuante a e b exiba no console o resultado de suas
// quatro operações básicas (adição, subtração, divisão e multiplicação), utilizando interpolação de strings.

Console.Write("Digite o Primeiro Valor: ");
string primeiroValor = Console.ReadLine()!;
int primeiroValorNumerico = int.Parse(primeiroValor);

Console.Write("Digite o Segundo Valor: ");
string segundoValor = Console.ReadLine()!;
int segundoValorNumerico = int.Parse(segundoValor);

int soma = primeiroValorNumerico + segundoValorNumerico;

int subtracao = primeiroValorNumerico - segundoValorNumerico;

int divisao = primeiroValorNumerico / segundoValorNumerico;

int multiplicacao = primeiroValorNumerico * segundoValorNumerico;

Console.WriteLine($"\nOs valores digitados foram: {primeiroValor} e {segundoValor}.");
Console.WriteLine($"\nA soma dos valores é igual a: {soma}.");
Console.WriteLine($"\nA subtração dos valores é igual a: {subtracao}.");
Console.WriteLine($"\nA divisão dos valores é igual a: {divisao}.");
Console.WriteLine($"\nA multiplicação dos valores é igual a: {multiplicacao}.");
Console.WriteLine();

//Exercício 02: Criar uma lista de bandas vazia e adicionar suas bandas prediletas em seguida.

List<string> listaDeBandas = new List<string>();
listaDeBandas.Add("Stray Kids");
listaDeBandas.Add("Linkin Park");
listaDeBandas.Add("Black Pink");

//Exercício 03: Utilizar a estrutura 'for' para mostrar todas as suas bandas preferidas, listadas na lista do exercício anterior,
//no console.

for (int i = 0; i < listaDeBandas.Count; i++)
{
    Console.WriteLine($"{i + 1}ª Banda: {listaDeBandas[i]}");
}
Console.WriteLine();

//Exercício 04: Criar um programa que calcula a soma de todos os elementos inteiros em uma lista.

List<int> listaDeNumeros = new List<int> {10, 30, 50};
int numerosSomados = 0;

foreach (int numero in listaDeNumeros)
{
    numerosSomados += numero;
}

Console.WriteLine($"A soma dos números presentes na Lista de Números é: {numerosSomados}");
