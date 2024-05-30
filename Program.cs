using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia: ");
Nokia celular = new Nokia(numero : "997994826", modelo :  "modelo1", imei : "1", memoria : 128);
celular.Ligar();
celular.ReceberLigacao();
celular.InstalarAplicativo("GitHub");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone: ");
Iphone celular2 = new Iphone(numero: "999990101", modelo: "modelo2", imei: "2", memoria : 256);
celular2.Ligar();
celular2.ReceberLigacao();
celular2.InstalarAplicativo("Linkedin");
