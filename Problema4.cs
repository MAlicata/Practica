/*
* El array de retorno deberá contener los índices de los dos números que sumados dan 
* el parámetro.
*
* Si los números en el array recibido no son distintos debe retornar un array vacío.
* En cualquier otro caso alternativo, también se debe retornar un array vacío.
* 
* Aclaraciones:
*   - Solo hay una combinación correcta
*   - No importa el orden del array de retorno
*   - El mismo numero no se usará dos veces e.g no habrá una respuesta [1, 1]
*/
public int[] EncontrarIndices(int[] numeros, int objetivo)
{
    // Verificar si el arreglo contiene al menos dos números distintos
    if (numeros.Length < 2 || numeros.Distinct().Count() < 2)
    {
        return new int[0]; // Retornar un arreglo vacío
    }

    Dictionary<int, int> mapa = new Dictionary<int, int>();

    for (int i = 0; i < numeros.Length; i++)
    {
        int complemento = objetivo - numeros[i];

        // Verificar si el complemento ya está en el mapa
        if (mapa.ContainsKey(complemento))
        {
            // Retornar los índices de los dos números
            return new int[] { mapa[complemento], i };
        }

        // Agregar el número actual al mapa con su índice correspondiente
        if (!mapa.ContainsKey(numeros[i]))
        {
            mapa.Add(numeros[i], i);
        }
    }

    return new int[0]; // Retornar un arreglo vacío si no se encuentra una combinación correcta
}
