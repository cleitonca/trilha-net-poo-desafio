using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Smartphone Nókia:");
Smartphone nokia = new Nokia(numero: "123456", modelo: "modelo 1", iMEI: "111111111", memoria: 64);

nokia.Ligar();
nokia.InstalarAplicativo("whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone:");

Smartphone iphone = new Iphone(numero: "487", modelo: "modelo 2", iMEI: "22222222", memoria: 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");