/*
Problema N° 1
 Cantidad de Pruebas: 5 
 
 Crear un método público "EncontrarPrimo" que reciba un número variable de 
 parámetros enteros y retorne un entero.
 El método deberá retornar la posición (base 0) del primer número primo encontrado. 
 En cualquier otro caso deberá retornar -1
*/

class Problema1
    {

        public static int EncontrarPrimo(params int[] primos)
        {
            if (primos.Length > 0)
            {
                for (int i = 0; i < primos.Length; i++)
                {
                    if (EsPrimo(primos[i]))
                    {
                        return i;
                    }

                }
            }
            return -1;

        }

        public static bool EsPrimo(int values)
        {
            int divisores = 0;
            for (int i = 0; i <= values; i++)
            {
                if (i % 2 == 0)
                {
                    divisores++;
                }
            }
            if (divisores == 2) return true;
            return false;
        }
    }
