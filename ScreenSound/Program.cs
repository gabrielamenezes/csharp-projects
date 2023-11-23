//List<string> listaDeBandas = new List<string> { "Queen", "Imagine Dragons"};
Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();
void ExibirLogo()
{
    Console.WriteLine(@"
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░");
}
void ExibirOpcoesDoMenu()
{
    ExibirLogo();
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda");
    Console.WriteLine("Digite -1 para sair");
    Console.Write("\nDigite a sua opção: ");
    int opcaoEscolhida = int.Parse(Console.ReadLine()!);

    switch (opcaoEscolhida)
    {
        case 1:
            RegistrarBandas();
            break;
        case 2:
            ExibirBandas();
            break;
        case 3:
            AvaliarBanda();
            break;
        case 4:
            Console.WriteLine("Você escolheu a opção " + opcaoEscolhida);
            break;
        case -1:
            Console.WriteLine("Tchau");
            break;
        default:
            Console.WriteLine("Opção Inválida");
            break;

    }
}
void RegistrarBandas()
{
    Console.Clear();
    ExibirTituloDaOpcaoSelecionada("Registro das bandas");
    Console.Write("Digite o nome da banda que você deseja registrar: ");
    string nomeDaBanda = Console.ReadLine()!;
    bandasRegistradas.Add(nomeDaBanda, new List<int>());
    Console.WriteLine($"A banda {nomeDaBanda} foi registrada");
    Thread.Sleep(2000);
    Console.Clear();
    ExibirOpcoesDoMenu();
}
void ExibirBandas()
{
    ExibirTituloDaOpcaoSelecionada("Exibindo bandas registradas");
    int count = 1;
    foreach (var banda in bandasRegistradas.Keys)
    {
        Console.WriteLine($"{count} - {banda}");
        count++;
    }
    Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesDoMenu();
}

void ExibirTituloDaOpcaoSelecionada(string titulo)
{
    string asteriscos = string.Empty.PadLeft(titulo.Length, '*');
    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteriscos + '\n');
}

void AvaliarBanda()
{
    //digite a banda que deseja avaliar
    //se banda existe no dicionário >> atribuir nota
    //senão, volta ao menu principal

    Console.Clear();
    ExibirTituloDaOpcaoSelecionada("Avaliar banda");
    Console.Write("Digite o nome da banda que deseja avaliar: ");
    string nomeDaBanda = Console.ReadLine()!;
    if(bandasRegistradas.Keys.Contains(nomeDaBanda))
    {
        Console.Write($"Qual nota você da para a banda {nomeDaBanda}: ");
        int nota = int.Parse(Console.ReadLine()!);
        bandasRegistradas[nomeDaBanda].Add(nota);
        Console.WriteLine($"\nA nota {nota} foi registrada com sucesso para a banda {nomeDaBanda}");
        Thread.Sleep(2000);
        Console.Clear();
        ExibirOpcoesDoMenu();
    } else
    {
        Console.WriteLine($"\nA banda {nomeDaBanda} não está registrada em nosso sistema");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
    
}
ExibirLogo();
ExibirOpcoesDoMenu();