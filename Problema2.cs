/*
Una brecha binaria dentro de un entero positivo N es cualquier secuencia máxima de ceros 
 consecutivos que está rodeada por unos en ambos extremos en la representación binaria de N.
 Por ejemplo, el número 9 tiene representación binaria 1001 y contiene un espacio binario de 
 longitud 2. El número 529 tiene representación binaria 1000010001 y contiene dos espacios 
 binarios: uno de longitud 4 y uno de longitud 3. El número 20 tiene representación binaria 
 10100 y contiene un espacio binario de longitud 1. El número 15 tiene una representación 
 binaria 1111 y no tiene espacios binarios. El número 32 tiene una representación binaria 
 de 100000 y no tiene huecos binarios. 
 
 Crear un método público "EncontrarBrechaMaxima" en c# que reciba un entero (N) y devuelva la longitud 
 de su brecha binaria más larga. El método debe devolver 0 si N no contiene un espacio binario. 
 Por ejemplo, dado N = 1041, el método debería devolver 5, porque N tiene representación 
 binaria 10000010001 y, por lo tanto, su espacio binario más largo es de longitud 5. 
 Dado N = 32, el método debería devolver 0, porque N tiene representación binaria '100000' y, 
 por lo tanto, sin huecos binarios.
*/

public int EncontrarBrechaMaxima(int N)
{
    string binaryString = Convert.ToString(N, 2); // Convertir N a su representación binaria
    
    int maxLength = 0; // Longitud máxima de la brecha binaria
    int currentLength = 0; // Longitud actual de la brecha binaria
    
    bool counting = false; // Variable para indicar si se está contando la longitud de la brecha
    
    // Recorrer la representación binaria
    foreach (char digit in binaryString)
    {
        if (digit == '1')
        {
            if (counting)
            {
                maxLength = Math.Max(maxLength, currentLength);
                currentLength = 0;
            }
            counting = true;
        }
        else if (digit == '0' && counting)
        {
            currentLength++;
        }
    }
    
    return maxLength;
}

int N = 1041;
int brechaMaxima = EncontrarBrechaMaxima(N);
Console.WriteLine("La brecha binaria más larga de {0} es: {1}", N, brechaMaxima);
/*Puedes llamar a este método con el valor de N que desees, por ejemplo: 
Esto imprimirá:
La brecha binaria más larga de 1041 es: 5*/
