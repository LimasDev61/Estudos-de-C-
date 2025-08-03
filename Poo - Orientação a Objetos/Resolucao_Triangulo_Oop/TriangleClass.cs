using System;

namespace Resolucao_Triangulo_Oop;

public class TriangleClass
{
    public double A;
    public double B;
    public double C;
    
    // Função Delegativa para calcular a area do triângulo.
    public double CalcularArea()
    {
        double heronFormula = (A + B + C) / 2.0;
        return Math.Sqrt(heronFormula * (heronFormula - A) * (heronFormula - B) * (heronFormula - C));
    }
    
}