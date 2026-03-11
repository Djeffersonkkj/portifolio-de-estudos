using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlocoDeNotas.Repository.Csvhelper;
public static class CsvHelper
{
    public static string[] Varrer(string email, string senha)
    {
        var usuario = File.ReadAllLines(@"C:\djota\portifolio-de-estudos\POO\LinqBlocoNotas\BlocoDeNotas\Data\Usuario.csv")
            .Skip(1)
            .Select( linha => linha.Split(','))
            .FirstOrDefault( colunas => colunas[2] == email && colunas[3] == senha);
            
        return usuario;
    }
}