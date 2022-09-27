using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

var fone = new Nokia(numero: "319903323131", imei: "42412", memoria: "1024");
fone.Ligar();
fone.ReceberLigacao();
fone.InstalarAplicativo("google");

var foneMaca = new Iphone(numero: "31990888831", imei: "333312", memoria: "500");
fone.Ligar();
fone.ReceberLigacao();
fone.InstalarAplicativo("fire");