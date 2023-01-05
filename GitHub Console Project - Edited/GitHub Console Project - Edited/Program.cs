// See https://aka.ms/new-console-template for more information

Random rand = new Random();

for (int i = 0; i < 9999; i++)
{
    Console.ForegroundColor = (ConsoleColor)rand.Next(0, 16);
    Console.BackgroundColor = (ConsoleColor)rand.Next(0, 16);
    Console.WriteLine("Hello, World!");
    Thread.Sleep(100);
}

