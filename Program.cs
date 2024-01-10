using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
// Implementado!

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero:"123456",modelo:"Modelo 1",imei:"1111",memoria:32);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone(numero:"654321",modelo:"Modelo 2",imei:"2222",memoria:64);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("WhatsApp");