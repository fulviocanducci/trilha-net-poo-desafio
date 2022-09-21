using DesafioPOO.Models;

Console.WriteLine("Nokia");
Smartphone nokia = new Nokia("1", "Nokia 100", "10112255360", 64);
nokia.Ligar();
nokia.InstalarAplicativo("Telegram");

Console.WriteLine("------------------------------------------------------------");

Console.WriteLine("IPhone");
Smartphone iphone = new Iphone("2", "Iphone 10", "580112255369", 512);
iphone.Ligar();
iphone.InstalarAplicativo("Photos");