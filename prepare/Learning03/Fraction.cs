using System;

public class Fraction
{
    // Atributos privados
    private int _top;
    private int _bottom;

    // Construtor sem parâmetros, inicializa como 1/1
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    // Construtor que recebe apenas o numerador
    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }

    // Construtor que recebe numerador e denominador
    public Fraction(int top, int bottom)
    {
        _top = top;
        // Evita divisão por zero
        _bottom = (bottom != 0) ? bottom : 1;
    }

    // Getters e setters
    public int GetTop()
    {
        return _top;
    }

    public void SetTop(int top)
    {
        _top = top;
    }

    public int GetBottom()
    {
        return _bottom;
    }

    public void SetBottom(int bottom)
    {
        if (bottom != 0)
        {
            _bottom = bottom;
        }
        else
        {
            Console.WriteLine("Denominador não pode ser zero. Valor mantido.");
        }
    }

    // Método que retorna a fração em formato string (ex: "3/4")
    public string GetFractionString()
    {
        return $"{_top}/{_bottom}";
    }

    // Método que retorna o valor decimal da fração
    public double GetDecimalValue()
    {
        return (double)_top / _bottom;
    }
}
