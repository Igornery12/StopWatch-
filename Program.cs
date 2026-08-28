using System.Collections;
using System.Data;
using System.Threading;
Menu();
static void Menu()
{
    Console.Clear();
    Console.WriteLine("M = Minutos (ex: 2m)");
    Console.WriteLine("S = Segundos (ex: 10s)");
    Console.WriteLine("0 = Sair");
    Console.Write("Quanto tempo deseja contar? ");

    string data = Console.ReadLine().ToLower();
    char type = char.Parse(data.Substring(data.Length - 1 ,1));

    switch (type)
    {
        case 'm':
            data = data.Replace("m","");
            Start(double.Parse(data)* 60);
            break;
        case 's':
            data = data.Replace("s","");
            Start(double.Parse(data));
            break;
        case '0' : 
            System.Console.WriteLine("StopWatch finalizado");
            System.Environment.Exit(0);
            break;
    }

}

static void Start(double time)
{
    double currentTime = 0;

    while (currentTime.ToString("f2") != time.ToString("f2"))
    {
        Console.Clear();
        currentTime += 0.01; 
        Console.WriteLine(currentTime.ToString("f2"));
        Thread.Sleep(10);

    }
}
Menu();
