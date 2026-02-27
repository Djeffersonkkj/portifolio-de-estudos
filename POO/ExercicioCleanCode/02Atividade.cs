class Atividade02
{
    public void Processar(List<Usuario> usuarios)
    {
        foreach(var usuario in usuarios)
        {
            if(usuario.A) //Que djabo é "A"?
                Enviar(usuario);
        }
    }
}