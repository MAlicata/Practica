/* 
Crear un método público "CalcularArea" que reciba 3 parámetros y retorne un resultado (el área).
 
 El primer parámetro es un número y obligatorio.
 El segúndo también es número pero opcional y nuleable.
 El tercero es del tipo Enum, opcional y nuleable.
 
 Los dos parámetros numéricos incluyen los valores necesarios para calcular el área.
 
 El método debe calcular el área según la figura recibida en la enumeración y retornar el valor.
 En cualquier otro caso debe retornar null.
 
 La enumeración con los valores posibles se encuentra en la librería y se llama Figura.
 
 El método no debe generar excepciones y  para los datos numéricos usar un tipo de dato 
 punto flotante de 128 bits.
 
 Ayuda: Enum es el tipo base que da origen a las enumeraciones. 
*/
public enum Figura
{
    Rectangulo,
    Triangulo,
    Circulo
}

public class CalculadoraAreas
{
    public decimal? CalcularArea(decimal lado1, decimal? lado2 = null, Figura figura = default)
    {
        if (lado1 <= 0)
        {
            return null;
        }

        switch (figura)
        {
            case Figura.Rectangulo:
                if (lado2.HasValue && lado2.Value > 0)
                {
                    return lado1 * lado2.Value;
                }
                break;

            case Figura.Triangulo:
                if (lado2.HasValue && lado2.Value > 0)
                {
                    return (lado1 * lado2.Value) / 2;
                }
                break;

            case Figura.Circulo:
                if (lado2 == null || lado2.Value > 0)
                {
                    decimal radio = lado2 ?? 0;
                    return (decimal)Math.PI * radio * radio;
                }
                break;

            default:
                break;
        }

        return null;
    }
}

public class Program
{
    public static void Main()
    {
        CalculadoraAreas calculadora = new CalculadoraAreas();

        // Ejemplo de uso
        decimal lado1 = 5;
        decimal? lado2 = 3;
        Figura figura = Figura.Rectangulo;

        decimal? area = calculadora.CalcularArea(lado1, lado2, figura);

        if (area != null)
        {
            Console.WriteLine("El área calculada es: " + area);
        }
        else
        {
            Console.WriteLine("No se pudo calcular el área.");
        }
    }
}


/*
En este ejemplo, se crea una clase llamada CalculadoraAreas que contiene el método CalcularArea. El método recibe tres parámetros: 
lado1 es obligatorio y de tipo decimal, lado2 es opcional y nuleable (decimal?) y figura es opcional y nuleable de tipo Figura (la enumeración).

Dentro del método, se realiza una verificación para asegurarse de que lado1 sea mayor que cero. Si no cumple esta condición, se retorna null.

Luego, se utiliza un switch para calcular el área dependiendo del valor de figura. Para cada figura (Rectangulo, Triangulo y Circulo), 
se realiza el cálculo correspondiente utilizando los valores de lado1 y lado2 si son válidos. Si no se especifica lado2 o su valor es nulo, se asume un valor predeterminado en cada caso (0 para el círculo).

Si la figura no coincide con ninguna de las opciones, se retorna null.

Finalmente, se muestra el resultado obtenido o un mensaje indicando que no se pudo calcular el área.
*/
