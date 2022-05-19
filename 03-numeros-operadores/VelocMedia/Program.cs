double distancia, tempo, velocidade;

Console.Write("Distância percorrida (m): ");
distancia = Convert.ToDouble(Console.ReadLine()!);

Console.Write("Tempo gasto (s): ");
tempo = Convert.ToDouble(Console.ReadLine()!);

velocidade = distancia / tempo;

Console.WriteLine($"\nVelocidade média: {velocidade:N2} m/s");