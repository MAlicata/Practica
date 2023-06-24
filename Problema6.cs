/*
* Crear un método público "MayorImparNegativoNoPrimo" que reciba un array de enteros y 
* retorne un entero.
* 
* El valor a retornar representa la posición (base 0) en el array del mayor número 
* impar menor a 0 que no sea un número primo, en caso de empate deberá retornar la posición del 
* primero en aparecer. 
* En cualquier otro caso deberá retornar null;
* 
* Aclaración: Un número primo es un numero natural mayor que 1, por lo que deberá considerarse
* el valor absoluto para determinarlo.
*/

public class Program
{
    public static void Main()
    {
        int[] array = { 2, 4, -3, 6, -5, -7, -9, 10, -8, -11 };
        int? resultado = MayorImparNegativoNoPrimo(array);
        Console.WriteLine(resultado.HasValue ? resultado.Value.ToString() : "null");
    }

    public static bool EsPrimo(int numero)
    {
        if (numero < 2)
            return false;

        for (int i = 2; i <= Math.Sqrt(numero); i++)
        {
            if (numero % i == 0)
                return false;
        }

        return true;
    }

    public static int? MayorImparNegativoNoPrimo(int[] array)
    {
        int mayorImparNegativoNoPrimo = int.MinValue;
        int posicion = -1;

        for (int i = 0; i < array.Length; i++)
        {
            int numero = array[i];

            if (numero < 0 && numero % 2 != 0 && !EsPrimo(Math.Abs(numero)))
            {
                if (numero > mayorImparNegativoNoPrimo)
                {
                    mayorImparNegativoNoPrimo = numero;
                    posicion = i;
                }
            }
        }

        return posicion >= 0 ? (int?)posicion : null;
    }
}

/*
En el ejemplo se utiliza el método EsPrimo para determinar si un número (absoluto) es primo. 
Luego, en el método MayorImparNegativoNoPrimo, se recorre el array y se realiza la verificación 
requerida para encontrar el mayor número impar negativo que no sea primo. El resultado se devuelve 
como un entero que representa la posición en el array (base 0) o 
null si no se encuentra ningún número que cumpla con las condiciones.
*/
