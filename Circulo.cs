using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio10;

internal class Circulo : Figura
{
    public int raio { get; set; }

    public override void Calcular()
    {
        double pi = Math.PI;
        double A = pi * raio * raio;
        Console.WriteLine("O valor do Circulo é " + A);

    }
}
