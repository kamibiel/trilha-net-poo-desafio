using DesafioPOO.Models;

// Implementado
Console.WriteLine("-------------------");
Console.WriteLine("Smartphone Nokia");
Console.WriteLine("-------------------");
Smartphone nokia = new Nokia(numero:"21964291278", modelo:"Modelo 1", imei:"111111111", memoria:128);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n");

Console.WriteLine("-------------------");
Console.WriteLine("Smartphone Iphone");
Console.WriteLine("-------------------");
Smartphone iphone = new Iphone(numero:"21964291278", modelo:"Modelo 2", imei:"2222222222222", memoria:256);
iphone.Ligar();
iphone.InstalarAplicativo("Telegram");
