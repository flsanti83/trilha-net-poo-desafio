using DesafioPOO.Models;

Console.Clear();

Console.WriteLine("Testando o Nokia");
Nokia nokia = new Nokia(numero: "123456", modelo: "N95", imei: "56SD4F6SA1S6A5S1FD", memoria: 16);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Cobrinhas");

Console.WriteLine("");

Console.WriteLine("Testando o Iphone");
Iphone iphone = new Iphone(numero: "6546", modelo: "Iphone 14", imei: "465S4DGF5F6DSG4DS6G1DS2G1D3", memoria: 32);
iphone.InstalarAplicativo("Instagram");
iphone.ReceberLigacao();
iphone.Ligar();

Console.WriteLine("");