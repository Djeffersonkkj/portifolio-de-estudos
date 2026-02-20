Produto Banana = new Produto();
Banana.Nome = "Banana";
Banana.Preco = 20.56m;
Banana.Quantidade = 0;

Console.WriteLine(Banana.ToString());
Banana.AdicionarEstoque(6);
Console.WriteLine(Banana.ToString());
Banana.RemoverEstoque(2);
Console.WriteLine(Banana.ToString());
Banana.RemoverEstoque(100);