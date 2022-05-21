int dividendo, divisor, resto;

Console.WriteLine("Máximo Divisor Comum (método iterativo)\n");

Console.Write("Digite o 1º número (a): ");
dividendo = Convert.ToInt32(Console.ReadLine());

Console.Write("Digite o 2º número (b): ");
divisor = Convert.ToInt32(Console.ReadLine());

do
{
    resto = dividendo % divisor;
    dividendo = divisor;
    divisor = resto;
}
while(resto != 0);

Console.WriteLine($"MDC(a, b) = {dividendo}");