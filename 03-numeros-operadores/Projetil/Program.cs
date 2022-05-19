const double gravidade = 9.80665;
double velocidade, anguloGraus, anguloRadianos, altura, alcance;

Console.WriteLine("-- Projétil --\n");

Console.Write("Entre com a velocidade, em m/s..: ");
velocidade = Convert.ToDouble(Console.ReadLine()!);

Console.Write("Entre com o ângulo, em graus....: ");
anguloGraus = Convert.ToDouble(Console.ReadLine()!);

anguloRadianos = anguloGraus * Math.PI / 180;

altura = Math.Pow(velocidade * Math.Sin(anguloRadianos), 2) / (2 * gravidade);
alcance = (Math.Pow(velocidade, 2) * Math.Sin(anguloRadianos * 2)) / gravidade;

Console.WriteLine($"\nAlcance........: {alcance:N2} m");
Console.WriteLine($"Altura máxima..: {altura:N2} m");