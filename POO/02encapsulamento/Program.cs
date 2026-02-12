try // tratamento de exception
{
    Aluno aluno = new Aluno("Aluno teste", [10.0M, 9.0M, 8.0M, 0M]);
    Console.WriteLine(aluno.ToString());
}
catch (InvalidOperationException ex)
{
    Console.Write(ex.Message);
}
