Console.Write("Digite a temperatura em graus Fahrenheit: ");
double tempF = Convert.ToDouble(Console.ReadLine()!);

double tempC = (tempF - 32) / 1.8;

Console.WriteLine($"{tempF}°F equivalem a {tempC:N2}°C");