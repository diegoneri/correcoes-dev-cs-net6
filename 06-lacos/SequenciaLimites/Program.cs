Console.Clear();

Console.Write($"Início: ");
int i = Convert.ToInt32(Console.ReadLine()!);

Console.Write($"Fim: ");
int j = Convert.ToInt32(Console.ReadLine()!);

string mensagem = "";

try
{
    if (j < i)
        throw new Exception("O segundo número não pode ser menor que o primeiro");

    while (j >= i)
    {
        mensagem += $"{i++} ";
    }
    exibirMensagemSucesso(mensagem);
}
catch (Exception e)
{
    exibirMensagemErro(e.Message);
}
finally
{
    Console.ResetColor();
    Console.WriteLine();
}

void exibirMensagemErro(string mensagem)
{
    Console.BackgroundColor = ConsoleColor.Red;
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine(mensagem);
}

void exibirMensagemSucesso(string mensagem)
{
    Console.BackgroundColor = ConsoleColor.Green;
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine(mensagem);
}