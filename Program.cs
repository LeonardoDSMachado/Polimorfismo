using Exercicio10;

Quadrado quadrado = new Quadrado();
Triangulo triangulo = new Triangulo();
Circulo circulo = new Circulo();

quadrado.Lado = 5;
quadrado.Calcular();

Console.WriteLine();

triangulo.Base = 8;
triangulo.Altura = 2;
triangulo.Calcular();

Console.WriteLine();

circulo.raio = 7;
circulo.Calcular();


Console.ReadKey();