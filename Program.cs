﻿using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Nokia smartphone1 = new(numero: "419860567", modelo: "G60 5G", imei: "12346578bc", memoria: 256);
Iphone smartphone2 = new(numero: "4199506412", modelo: "Iphone 15", imei: "12346574987fds", memoria: 1024);

Console.WriteLine("Smartphone Nokia:");
smartphone1.Ligar();
smartphone1.ReceberLigacao();
smartphone1.InstalarAplicativo(nomeApp: "Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphoe Iphone:");
smartphone1.Ligar();
smartphone2.ReceberLigacao();
smartphone2.InstalarAplicativo(nomeApp: "Signal");