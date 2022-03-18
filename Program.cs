Start();

static void Menu()
{
    Console.WriteLine("Bem Vindo ao Stopwatch Dv");
    Console.ReadKey();
    Console.WriteLine("------------------------");
    Console.WriteLine("S - Segundos");
    Console.WriteLine("M - Minutos");
    Console.WriteLine("0 - Sair");
    Console.WriteLine("Quanto tempo desejar contar?");

    string data = Console.ReadLine().ToLower(); //ToLower serve pra diminuir as letras

    // data.Length vai contar quantos caracteres foi digitado
    char type = char.Parse(data.Substring(data.Length - 1, 1));
}

static void Start(int time)
{
    int currentTime = 0;
    while (currentTime != time)
    {
        Console.Clear();
        currentTime++;
        Console.WriteLine(currentTime);
        Thread.Sleep(1000); // Faz com que durma um segundo
    }

    Console.Clear();
    Console.WriteLine("Stopwatch finalizado");
    Thread.Sleep(2500);
}
