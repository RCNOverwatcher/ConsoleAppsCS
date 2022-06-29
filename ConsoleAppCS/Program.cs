using System.Threading;


Random rand = new Random();
Console.WriteLine("Hello, World!");
Thread.Sleep(5000);
Console.WriteLine("Tell me your name!");
String name = Console.ReadLine();
Console.WriteLine("Nice to meet you " + name + " lmao");

Console.ReadLine();