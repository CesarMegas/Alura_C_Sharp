// Melody Flow
string mensagemDeBoasVindas = "Boas vindas ao Melody Flow";

//List<string> listaDeBandas = new List<string> {"Stray Kids", "Black Pink", "Linkin Park"};

Dictionary<string, List<int>> dicionarioDeBandas = new Dictionary<string, List<int>>();
dicionarioDeBandas.Add("Stray Kids", new List<int> {10, 8, 6});
dicionarioDeBandas.Add("Black Pink", new List<int> {10, 9});
dicionarioDeBandas.Add("Linkin Park", new List<int>());

void ExibirLogo()
{
    Console.WriteLine(@"

███╗░░░███╗███████╗██╗░░░░░░█████╗░██████╗░██╗░░░██╗  ███████╗██╗░░░░░░█████╗░░██╗░░░░░░░██╗
████╗░████║██╔════╝██║░░░░░██╔══██╗██╔══██╗╚██╗░██╔╝  ██╔════╝██║░░░░░██╔══██╗░██║░░██╗░░██║
██╔████╔██║█████╗░░██║░░░░░██║░░██║██║░░██║░╚████╔╝░  █████╗░░██║░░░░░██║░░██║░╚██╗████╗██╔╝
██║╚██╔╝██║██╔══╝░░██║░░░░░██║░░██║██║░░██║░░╚██╔╝░░  ██╔══╝░░██║░░░░░██║░░██║░░████╔═████║░
██║░╚═╝░██║███████╗███████╗╚█████╔╝██████╔╝░░░██║░░░  ██║░░░░░███████╗╚█████╔╝░░╚██╔╝░╚██╔╝░
╚═╝░░░░░╚═╝╚══════╝╚══════╝░╚════╝░╚═════╝░░░░╚═╝░░░  ╚═╝░░░░░╚══════╝░╚════╝░░░░╚═╝░░░╚═╝░░
");
    Console.WriteLine(mensagemDeBoasVindas);
}

void ExibirOpcoesDoMenu()
{
    ExibirLogo();
    Console.WriteLine("\n(Digite o número referente à opção desejada)");
    Console.WriteLine("1. Registrar uma Banda");
    Console.WriteLine("2. Mostrar Todas as Bandas");
    Console.WriteLine("3. Avaliar uma Banda");
    Console.WriteLine("4. Exibir a Média de uma Banda");
    Console.WriteLine("0. Sair do Programa");

    Console.Write("\nOpção Escolhida: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    switch (opcaoEscolhidaNumerica)
    {
        case 1: RegistrarUmaBanda();
            break;
        case 2: MostrarTodasAsBandas();
            break;
        case 3: AvaliarUmaBanda();
            break;
        case 4: Console.WriteLine($"Você escolheu a Opção {opcaoEscolhidaNumerica}");
            break;
        case 0: Console.WriteLine("Fim do Programa");
            break;
        default: Console.WriteLine("Opção Inválida!");
            break;
    }
}

void ExibirTituloDaOpcao(string titulo)
{
    int quantidadeDeCaracteres = titulo.Length;
    string asteriscos = string.Empty.PadLeft(quantidadeDeCaracteres, '*');
    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteriscos + '\n');
}

void RegistrarUmaBanda()
{
    Console.Clear();
    ExibirTituloDaOpcao("Registrar uma Banda");
    Console.Write("\nDigite o Nome da Banda que deseja registrar: ");
    string nomeDaBanda = Console.ReadLine()!;
    //listaDeBandas.Add(nomeDaBanda);
    dicionarioDeBandas.Add(nomeDaBanda, new List<int>());
    Console.WriteLine($"A Banda {nomeDaBanda} foi adicionada com sucesso!");
    Thread.Sleep(2000);
    Console.Clear();
    ExibirOpcoesDoMenu();
}

void MostrarTodasAsBandas()

{
    Console.Clear();
    ExibirTituloDaOpcao("Mostrar Todas as Bandas");
    Console.WriteLine("\n");
    
    //for (int i = 0; i < dicionarioDeBandas.Count; i++)
    //{
      //Console.WriteLine($"{i + 1}ª Banda: {dicionarioDeBandas.Keys}");
    //}

    foreach (string banda in dicionarioDeBandas.Keys)
    {
        Console.WriteLine($"Banda: {banda}");
    }

    Console.WriteLine("\nDigite uma Tecla para Retornar ao Menu Principal");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesDoMenu();

}

void AvaliarUmaBanda()
{
    Console.Clear();
    ExibirTituloDaOpcao("Avaliar uma Banda");
    Console.Write("Digite a Nome da Banda que deseja Avaliar: ");
    string nomeDaBanda = Console.ReadLine()!;

    if(dicionarioDeBandas.ContainsKey(nomeDaBanda))
    {
        Console.Write($"\nDigite uma Nota para a Banda {nomeDaBanda}: ");
        int nota = int.Parse(Console.ReadLine()!);
        dicionarioDeBandas[nomeDaBanda].Add(nota);
        Console.WriteLine($"\nA nota {nota} foi Registrada com Sucesso para a Banda {nomeDaBanda}!");
        Thread.Sleep(3000);
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
    else
    {
        Console.WriteLine($"\nA Banda {nomeDaBanda} não foi encontrada...");
        Console.WriteLine("\nDigite uma Tecla para Retornar ao Menu Principal");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
}

ExibirOpcoesDoMenu();
