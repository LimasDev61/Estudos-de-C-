using System;
using System.Globalization;

namespace Exercise_3_OOP_Rectangle;

class Rectangle
{
    /*
     *
     * Fazer um programa para ler os valores da largura e altura de um retângulo. Em
     * seguida, mostrar na tela o valor de sua área, perímetro e diagonal.
     *
     */
    static void Main(string[] args)
    {
        RectangleClass rectangle = new RectangleClass();
        Console.WriteLine("Entre com a largura e altura do triangulo: ");
        bool value1 = double.TryParse(Console.ReadLine(), NumberStyles.Any, CultureInfo.InvariantCulture,
            out rectangle.A);
        bool value2 = double.TryParse(Console.ReadLine(), NumberStyles.Any, CultureInfo.InvariantCulture,
            out rectangle.B);

        Console.WriteLine(rectangle);
    }
}