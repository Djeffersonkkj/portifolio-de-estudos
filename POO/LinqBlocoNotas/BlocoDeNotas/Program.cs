using BlocoDeNotas.Models;
using BlocoDeNotas.Repository;

UsuarioRepository teste = new UsuarioRepository();
NotaRepository notaRepository
 = new NotaRepository();

var usuario = teste.ChamarUsuario("djefferson141005@gmail.com", "123456789");
System.Console.WriteLine(usuario.ToString());


var notas = notaRepository.ChamarNotas(usuario);
System.Console.WriteLine();
foreach ( var nota in notas)
{
    System.Console.WriteLine(nota.Titulo);
    System.Console.WriteLine();
    System.Console.WriteLine(nota.Texto);
    System.Console.WriteLine("===========================");
}
