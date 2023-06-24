/*
* Crear un método público "SopaDeLetras" que reciba dos parámetros y retorne un entero.
* 
* El primero parámetro es un string y representa una sopa de letras de N líneas donde 
* cada línea está separada por una coma.
* El segundo parámetro es un también un string y representa una palabra a buscar.
* 
* El método deberá retornar el número de línea (contando desde 0) en el que aparece la 
* palabra.
* 
* Si la palabra no se encuentra en la sopa de letras se deberá retornar -1.
* 
* A tener en cuenta: la sopa de letras no es case sensitive.
*/

public class SopaDeLetrasSolver
{
    public int SopaDeLetras(string sopa, string palabra)
    {
        // Convertir la sopa de letras a minúsculas para hacerla case insensitive
        sopa = sopa.ToLower();
        palabra = palabra.ToLower();

        // Dividir la sopa de letras en líneas
        string[] lineas = sopa.Split(',');

        // Buscar la palabra en cada línea de la sopa de letras
        for (int i = 0; i < lineas.Length; i++)
        {
            // Verificar si la línea contiene la palabra
            if (lineas[i].Contains(palabra))
            {
                // La palabra se encontró en la línea i
                return i;
            }
        }

        // La palabra no se encontró en la sopa de letras
        return -1;
    }
}
/*
Puedes utilizar esta clase SopaDeLetrasSolver para probar el método SopaDeLetras de la siguiente manera:
*/
public class Program
{
    public static void Main(string[] args)
    {
        SopaDeLetrasSolver solver = new SopaDeLetrasSolver();

        // Ejemplo de uso
        string sopa = "hola,mundo,openai";
        string palabra = "openai";
        int linea = solver.SopaDeLetras(sopa, palabra);
        Console.WriteLine("La palabra se encuentra en la línea: " + linea);

        Console.ReadLine();
    }
}
