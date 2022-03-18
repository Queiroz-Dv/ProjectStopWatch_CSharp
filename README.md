# 🐱‍💻 Project Stopwatch CSharp

Projeto de estudos da linguagem C# onde foi realizado um cronômetro básico.

Implementações:

## Método do Menu

Menu de interação:

```c#
  Console.WriteLine("Bem Vindo ao Stopwatch Dv");
  Console.ReadKey();
  Console.WriteLine("------------------------");
  Console.WriteLine("S - Segundos");
  Console.WriteLine("M - Minutos");
  Console.WriteLine("0 - Sair");
  Console.WriteLine("Quanto tempo desejar contar?");

```

Coleta de dados:

```c#
//ToLower serve pra diminuir as letras
  string data = Console.ReadLine().ToLower();
  // data.Length vai contar quantos caracteres foi digitado
  char type = char.Parse(data.Substring(data.Length - 1, 1));
  int time = int.Parse(data.Substring(0, data.Length - 1));
  int multiplier = 1;
  ```

Tratando condições e invocando função de inicialização:

```c#
if (type == 'm')
  {
    multiplier = 60;
  }

  if (time == 0)
  {
    Environment.Exit(0);
  }

  PreStart(time * multiplier);
```

## Método de Pré Inicialização

Tela de interatividade com thread:

```c#
static void PreStart(int time)
{
  Console.Clear();
  Console.WriteLine("Ready...");
  Thread.Sleep(1000);
  Console.WriteLine("Set...");
  Thread.Sleep(1000);
  Console.WriteLine("Go...");
  Thread.Sleep(2500);

  Start(time);
}
```

## Método Start

Método que faz a contagem:

```c#
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
  Menu();
}
```

## Tecnologias Usadas 
- CSharp 
- Visual Studio Code