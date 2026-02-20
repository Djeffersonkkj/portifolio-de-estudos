Veiculo veiculo = new Veiculo();
veiculo.Marca = "Toyota";
veiculo.Modelo = "Corolla";
veiculo.Ano = 2023;

veiculo.Acelerar(80);
Console.WriteLine(veiculo.EstaEmMovimento()); // True
Console.WriteLine(veiculo.ObterFichaTecnica());

veiculo.Frear(80);
Console.WriteLine(veiculo.EstaEmMovimento()); // False

// Saída:
// True
// Marca: TOYOTA | Modelo: Corolla | Ano: 2023 | Velocidade: 80 km/h
// False