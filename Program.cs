using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

var fone = new Nokia("3323131");
fone.Ligar();
fone.ReceberLigacao();
fone.InstalarAplicativo("google");

var foneMaca = new Iphone("4241241");
fone.Ligar();
fone.ReceberLigacao();
fone.InstalarAplicativo("fire");