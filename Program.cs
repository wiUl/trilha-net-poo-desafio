using System.ComponentModel;
using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
// Feito

Console.WriteLine("Instanciando Nokia");
Smartphone nokia = new Nokia(numero: "+55 (21) 998743214", modelo: "Nokia Tijolão", imei: "785945223", memoria: 32);

nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Telegram");

Console.WriteLine("\n");


Console.WriteLine("Instanciando Iphone");
Smartphone iphone = new Iphone(numero: "+55 (21) 993652177", modelo: "Iphone XR", imei: "444321876", memoria: 128);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");