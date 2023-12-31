using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Nokia");

Nokia smartphoneNokia = new Nokia("22355", "L43", "BR", 3000);
smartphoneNokia.InstalarAplicativo("Whatsapp");
smartphoneNokia.ReceberLigacao();
smartphoneNokia.Ligar();

Console.WriteLine("\n");

Console.WriteLine("Iphone");
Iphone smartphoneApple = new Iphone("2235e", "10", "BR", 3500);
smartphoneApple.InstalarAplicativo("Whatsapp");
smartphoneApple.ReceberLigacao();
smartphoneApple.Ligar();

