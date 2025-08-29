using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone - Implementado

Console.WriteLine("=== Testando Nokia ===");
Nokia nokia = new Nokia("11 99999-8888", "Nokia 3310", "123456789012345", 16);
Console.WriteLine($"Número: {nokia.Numero}");
Console.WriteLine($"Modelo: {nokia.Modelo}");
Console.WriteLine($"IMEI: {nokia.IMEI}");
Console.WriteLine($"Memória: {nokia.Memoria}GB");
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Snake Game");

Console.WriteLine();

Console.WriteLine("=== Testando iPhone ===");
Iphone iphone = new Iphone("11 88888-9999", "iPhone 15", "987654321098765", 128);
Console.WriteLine($"Número: {iphone.Numero}");
Console.WriteLine($"Modelo: {iphone.Modelo}");
Console.WriteLine($"IMEI: {iphone.IMEI}");
Console.WriteLine($"Memória: {iphone.Memoria}GB");
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");