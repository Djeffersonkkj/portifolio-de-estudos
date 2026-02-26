// Código Original
class Questao01
{
    public decimal CalcularValorTotal(decimal preco, int quantidade)
    {
        var desconto = 0m;
        int quantidadeMinimaDesconto = 10;

        if (quantidade > quantidadeMinimaDesconto)
        {
            decimal porcentagemDesconto = 0.1m;
            desconto = preco * porcentagemDesconto;
        }
        decimal valorFinal = (preco * quantidade) - desconto;

        return valorFinal;
    }
    
}