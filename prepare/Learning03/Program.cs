using System;

class Program
{
    static void Main(string[] args)
    {
        // Teste dos construtores
        Fraction fraction1 = new Fraction(); // 1/1
        Fraction fraction2 = new Fraction(5); // 5/1
        Fraction fraction3 = new Fraction(3, 4); // 3/4

        // Exibição das frações e seus valores decimais
        Console.WriteLine(fraction1.GetFractionString()); // Saída: 1/1
        Console.WriteLine(fraction1.GetDecimalValue());   // Saída: 1.0

        Console.WriteLine(fraction2.GetFractionString()); // Saída: 5/1
        Console.WriteLine(fraction2.GetDecimalValue());   // Saída: 5.0

        Console.WriteLine(fraction3.GetFractionString()); // Saída: 3/4
        Console.WriteLine(fraction3.GetDecimalValue());   // Saída: 0.75

        // Usando setters para alterar os valores
        fraction3.SetTop(1);
        fraction3.SetBottom(3);

        // Exibindo a fração alterada
        Console.WriteLine(fraction3.GetFractionString()); // Saída: 1/3
        Console.WriteLine(fraction3.GetDecimalValue());   // Saída: 0.3333333333333333
    }
}
