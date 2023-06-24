public static double Calcular(double operando1, double operado2, string operador = "+"){
	return operador switch
	{
	"-" => operando1 - operando2;
	"*" => operando1 - operando2;
	"/" => operando1 - operando2;
	_ => operando1 + operando2;   // default
	};
}

//Ejercicio 02:

class Problema2
{
            public static double? Reversar(string numero)
            {

                if (!double.TryParse(numero, out double valor))
                {
                    return null;
                }
               
                // Separar parte entera y decimal 
                string[] subs = numero.Split(' ',',');
                string parteEntera = subs[0];
                string parteDecimal = subs.Length > 1 ? subs[1] : "";


                // Reversar parte entera
                char[] enteraReversada = parteEntera.ToCharArray();
                Array.Reverse(enteraReversada);
                string enteraReversadaStr = new string(enteraReversada);

                //Reversar parte decimal
                char[] decimalReversada = parteDecimal.ToCharArray();
                Array.Reverse(decimalReversada);
                string decimalReversadaStr = new string(decimalReversada);
                
                //Concatenar parte entera y decimal 
                string resultado = enteraReversadaStr + (decimalReversadaStr.Length > 0 ? "," + decimalReversadaStr : "");

               
                if (double.TryParse(resultado, out double numeroReversado))
                {
                    return numeroReversado;
                }
                else
                {
                    return null;
                }
}
