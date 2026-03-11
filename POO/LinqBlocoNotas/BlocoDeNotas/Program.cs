using BlocoDeNotas.Repository;

UsuarioRepository teste = new UsuarioRepository();

var Usuario = teste.ChamarUsuario("thayscarla@gmail.com", "123456789");
System.Console.WriteLine(Usuario.ToString());
