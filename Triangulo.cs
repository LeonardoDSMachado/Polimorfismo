using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio10;

public class Triangulo : Figura
{
    public int Base {get; set;}
    public int Altura {get; set;}

    public override void Calcular()
    {
        int A;
        A = (Base * Altura)/2;
        Console.WriteLine("O valor do Triângulo é " + A);
    }
}
