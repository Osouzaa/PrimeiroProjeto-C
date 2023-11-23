// See https://aka.ms/new-console-template for more information
ExibirMensagem();


Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();
bandasRegistradas.Add("Link Park", new List<int> { 10, 8, 8 });

void ExibirMensagem() { 
    string mensagemBoasVindas = "Boas vindas ao Screen Sound";
    Console.WriteLine(mensagemBoasVindas);
}


void ExibirOpções()
{
    Console.WriteLine("\nDigite 1 para registrar uma banda.");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir uma média da banda");
    Console.WriteLine("Digite -1 para sair ");

    Console.Write("\nDigite a sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumber = int.Parse(opcaoEscolhida);

   switch (opcaoEscolhidaNumber)
    {
        case 1: RegistrarBanda();
            break;
        case 2:
            MostrarTodasBandas();
            break;
        case 3:
            AvaliarUmaBanda();
            break;
        case 4:
            ExibirMedia();
            break;
        case -1:
            Console.WriteLine("Tchau tchau :) ");
            break;
        default: Console.WriteLine("Opção Invalida");
            break;
    }
}


void RegistrarBanda()
{
    Console.Clear();
    ExibirTituloDaOpção("Registro das bandas");
    Console.Write("Digite o nome da banda que deseja registrar: ");
    string nomeDaBanda = Console.ReadLine()!;
    bandasRegistradas.Add(nomeDaBanda, new List<int>());
    Console.WriteLine($"A banda {nomeDaBanda} foi registrado com sucesso!");
    Thread.Sleep(2000);
    Console.Clear();
    ExibirOpções();
}


void MostrarTodasBandas()
{
    Console.Clear();
    ExibirTituloDaOpção("Exibindo todas bandas cadastradas");

    /*for( int i = 0; i < listaDasBandas.Count; i++ )
    {
        Console.WriteLine($"Banda: {listaDasBandas[i]}");
    }*/

    foreach (string banda in bandasRegistradas.Keys)
    {
        Console.WriteLine($"Banda: {banda}");
    }

    Console.WriteLine("\nDigite uma telca para voltar ao menu principal");
    Console.ReadKey();
    Console.Clear();
    ExibirOpções();

}

void ExibirTituloDaOpção(string titulo)
{
    int quantidadeDeLetras = titulo.Length;
    string astericos = string.Empty.PadLeft(quantidadeDeLetras, '*');
    Console.WriteLine(astericos);
    Console.WriteLine(titulo);
    Console.WriteLine(astericos + "\n");
}


void AvaliarUmaBanda()
{
    Console.Clear();
    ExibirTituloDaOpção("Avaliar Banda");

    Console.Write("Digite o nome da banda que deseja avaliar: ");
    string nomeDaBanda = Console.ReadLine()!;
    if(bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        Console.Write($"Qual a nota a banda {nomeDaBanda} merece: ");
        int nota = int.Parse(Console.ReadLine()!);
        bandasRegistradas[nomeDaBanda].Add(nota);
        Console.WriteLine($"\nA nota {nota} foi registrado com sucesso para a banda {nomeDaBanda}");
        Thread.Sleep(2000);
        Console.Clear();
        ExibirOpções();
    } else
    {
        Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!!!");
        Console.WriteLine("Digite uma tecla para voltar ao menu");
        Console.ReadKey();
        Console.Clear();
        ExibirOpções();
    }
}

void ExibirMedia()
{
    Console.Clear();
    ExibirTituloDaOpção("Exibir média da banda");

    Console.Write("Digite o nome da banda que deseja média: ");
    string nomeDaBanda = Console.ReadLine()!;

    if( bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        List<int> notasDaBanda = bandasRegistradas[nomeDaBanda];
        Console.WriteLine($"A média da banda {nomeDaBanda} é {notasDaBanda.Average()}");
        Console.WriteLine("Digite uma tecla para voltar ao menu");
        Console.ReadKey();
        Console.Clear();
        ExibirOpções();
    }
    else
    {
        Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!!!");
        Console.WriteLine("Digite uma tecla para voltar ao menu");
        Console.ReadKey();
        Console.Clear();
        ExibirOpções();
    }


}
ExibirOpções();


