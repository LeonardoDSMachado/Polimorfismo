using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio10;

public class Quadrado : Figura
{
    public int Lado { get; set; }

    public override void Calcular()
    {
        int A = Lado * Lado;
        Console.WriteLine($"O valor do quadrado é {A}");
    }
}
