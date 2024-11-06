// Melody Flow
string mensagemDeBoasVindas = "Boas vindas ao Melody Flow";
List<string> listaDeBandas = new List<string> {"Stray Kids", "Black Pink", "Linkin Park"};

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
        case 3: Console.WriteLine($"Você escolheu a Opção {opcaoEscolhidaNumerica}");
            break;
        case 4: Console.WriteLine($"Você escolheu a Opção {opcaoEscolhidaNumerica}");
            break;
        case 0: Console.WriteLine("Fim do Programa");
            break;
        default: Console.WriteLine("Opção Inválida!");
            break;
    }
}

void RegistrarUmaBanda()
{
    Console.Clear();
    Console.WriteLine(@"
██████╗░███████╗░██████╗░██╗░██████╗████████╗██████╗░░█████╗░██████╗░  ██╗░░░██╗███╗░░░███╗░█████╗░
██╔══██╗██╔════╝██╔════╝░██║██╔════╝╚══██╔══╝██╔══██╗██╔══██╗██╔══██╗  ██║░░░██║████╗░████║██╔══██╗
██████╔╝█████╗░░██║░░██╗░██║╚█████╗░░░░██║░░░██████╔╝███████║██████╔╝  ██║░░░██║██╔████╔██║███████║
██╔══██╗██╔══╝░░██║░░╚██╗██║░╚═══██╗░░░██║░░░██╔══██╗██╔══██║██╔══██╗  ██║░░░██║██║╚██╔╝██║██╔══██║
██║░░██║███████╗╚██████╔╝██║██████╔╝░░░██║░░░██║░░██║██║░░██║██║░░██║  ╚██████╔╝██║░╚═╝░██║██║░░██║
╚═╝░░╚═╝╚══════╝░╚═════╝░╚═╝╚═════╝░░░░╚═╝░░░╚═╝░░╚═╝╚═╝░░╚═╝╚═╝░░╚═╝  ░╚═════╝░╚═╝░░░░░╚═╝╚═╝░░╚═╝

██████╗░░█████╗░███╗░░██╗██████╗░░█████╗░
██╔══██╗██╔══██╗████╗░██║██╔══██╗██╔══██╗
██████╦╝███████║██╔██╗██║██║░░██║███████║
██╔══██╗██╔══██║██║╚████║██║░░██║██╔══██║
██████╦╝██║░░██║██║░╚███║██████╔╝██║░░██║
╚═════╝░╚═╝░░╚═╝╚═╝░░╚══╝╚═════╝░╚═╝░░╚═╝");
    Console.Write("\nDigite o Nome da Banda que deseja registrar: ");
    string nomeDaBanda = Console.ReadLine()!;
    listaDeBandas.Add(nomeDaBanda);
    Console.WriteLine($"A Banda {nomeDaBanda} foi adicionada com sucesso!");
    Thread.Sleep(2000);
    Console.Clear();
    ExibirOpcoesDoMenu();
}

void MostrarTodasAsBandas()

{
    Console.Clear();
    Console.WriteLine(@"
███╗░░░███╗░█████╗░░██████╗████████╗██████╗░░█████╗░██████╗░  ████████╗░█████╗░██████╗░░█████╗░░██████╗
████╗░████║██╔══██╗██╔════╝╚══██╔══╝██╔══██╗██╔══██╗██╔══██╗  ╚══██╔══╝██╔══██╗██╔══██╗██╔══██╗██╔════╝
██╔████╔██║██║░░██║╚█████╗░░░░██║░░░██████╔╝███████║██████╔╝  ░░░██║░░░██║░░██║██║░░██║███████║╚█████╗░
██║╚██╔╝██║██║░░██║░╚═══██╗░░░██║░░░██╔══██╗██╔══██║██╔══██╗  ░░░██║░░░██║░░██║██║░░██║██╔══██║░╚═══██╗
██║░╚═╝░██║╚█████╔╝██████╔╝░░░██║░░░██║░░██║██║░░██║██║░░██║  ░░░██║░░░╚█████╔╝██████╔╝██║░░██║██████╔╝
╚═╝░░░░░╚═╝░╚════╝░╚═════╝░░░░╚═╝░░░╚═╝░░╚═╝╚═╝░░╚═╝╚═╝░░╚═╝  ░░░╚═╝░░░░╚════╝░╚═════╝░╚═╝░░╚═╝╚═════╝░

░█████╗░░██████╗  ██████╗░░█████╗░███╗░░██╗██████╗░░█████╗░░██████╗
██╔══██╗██╔════╝  ██╔══██╗██╔══██╗████╗░██║██╔══██╗██╔══██╗██╔════╝
███████║╚█████╗░  ██████╦╝███████║██╔██╗██║██║░░██║███████║╚█████╗░
██╔══██║░╚═══██╗  ██╔══██╗██╔══██║██║╚████║██║░░██║██╔══██║░╚═══██╗
██║░░██║██████╔╝  ██████╦╝██║░░██║██║░╚███║██████╔╝██║░░██║██████╔╝
╚═╝░░╚═╝╚═════╝░  ╚═════╝░╚═╝░░╚═╝╚═╝░░╚══╝╚═════╝░╚═╝░░╚═╝╚═════╝░");
    Console.WriteLine("\n");
    
    for (int i = 0; i < listaDeBandas.Count; i++)
    {
        Console.WriteLine($"{i + 1}ª Banda: {listaDeBandas[i]}");
    }

    //foreach (string banda in listaDeBandas)
    //{
        //Console.WriteLine($"Banda: {banda}");
    //}

    Console.WriteLine("\nDigite uma Tecla para Retornar ao Menu Principal");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesDoMenu();

}

ExibirOpcoesDoMenu();
