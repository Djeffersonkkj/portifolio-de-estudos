Macaco macaco1 = new Macaco("Geremias");
Macaco macaco2 = new Macaco("Xeroline");

Banana banana1 = new Banana("Nanica", 1);
Banana banana2 = new Banana("Nanica", 1);
Banana banana3 = new Banana("Nanica", 1);
Banana banana4 = new Banana("Maçã", 1);
Banana banana5 = new Banana("Maçã", 1);
Banana banana6 = new Banana("Terra", 3);
Banana banana7 = new Banana("Terra", 3);
Banana banana8 = new Banana("Prata", 2);
Banana banana9 = new Banana("Prata", 2);

macaco1.PegarBanana(banana1);
macaco1.PegarBanana(banana2);
macaco1.PegarBanana(banana6);
Console.WriteLine(macaco1.ToString());
macaco1.ComerBanana();
Console.WriteLine(macaco1.ToString());
macaco1.ToString();
macaco1.DarBanana(macaco2);
macaco2.ExibirBananas();
macaco1.ExibirBananas();
