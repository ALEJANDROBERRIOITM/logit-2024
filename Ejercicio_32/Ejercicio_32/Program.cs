using System.Security.Cryptography;
using System;

internal class Program
{
    
        /*32.Se desea obtener el valor de la matrícula de un estudiante cuyo valor se calcula de la siguiente manera:
        Si toma 20 o menos créditos, paga el crédito al valor normal.
        Si toma por encima de 20 créditos, se pagarán los créditos extras al doble de valor normal.	Si el estudiante es de estrato 1, 2 o 3 recibe los siguientes descuentos:
            -Si  estrato es 1, el descuento es del 80 %.
            - Si el estrato es 2, el descuento es del 50 %.
            - Si el estrato es 3, el descuento es del 30 %.

        Además, los estratos 1 y 2 reciben subsidio de alimentación y transporte de la siguiente manera:

        Para el estrato 1, el subsidio de alimentación y transporte es igual a $200.000.
        Para el estrato 2, el subsidio de alimentación y transporte es igual a $100.000.
        Se debe informar al usuario sobre el costo de la matrícula y el valor del subsidio.

        La aplicación debe preguntar al usuario si quiere volver al inicio o no para calcular la matrícula de un nuevo estudiante.
        */




class Estudiante
    {
        public int Creditos { get; set; }
        public double ValorCredito { get; set; }
        public int Estrato { get; set; }

        public Estudiante(int creditos, double valorCredito, int estrato)
        {
            Creditos = creditos;
            ValorCredito = valorCredito;
            Estrato = estrato;
        }

        public double CalcularMatricula()
        {
            double costoBase;
            if (Creditos <= 20)
            {
                costoBase = Creditos * ValorCredito;
            }
            else
            {
                costoBase = 20 * ValorCredito + (Creditos - 20) * (ValorCredito * 2);
            }

            double descuento = 0;
            switch (Estrato)
            {
                case 1:
                    descuento = 0.80;
                    break;
                case 2:
                    descuento = 0.50;
                    break;
                case 3:
                    descuento = 0.30;
                    break;
            }

            double costoFinal = costoBase * (1 - descuento);
            return costoFinal;
        }

        public double CalcularSubsidio()
        {
            switch (Estrato)
            {
                case 1:
                    return 200000;
                case 2:
                    return 100000;
                default:
                    return 0;
            }
        }
    }

class DatosEstudiante
    {
        static void Main()
        {
            while (true)
            {
                try
                {
                    Console.Write("Ingrese el número de créditos: ");
                    int creditos = int.Parse(Console.ReadLine());

                    Console.Write("Ingrese el valor por crédito: ");
                    double valorCredito = double.Parse(Console.ReadLine());

                    Console.Write("Ingrese el estrato (1, 2 o 3): ");
                    int estrato = int.Parse(Console.ReadLine());

                    Estudiante estudiante = new Estudiante(creditos, valorCredito, estrato);
                    double costoMatricula = estudiante.CalcularMatricula();
                    double subsidio = estudiante.CalcularSubsidio();

                    Console.WriteLine($"El costo de la matrícula es: ${costoMatricula:F2}");
                    Console.WriteLine($"El valor del subsidio es: ${subsidio:F2}");

                    Console.Write("¿Desea calcular la matrícula de un nuevo estudiante? (s/n): ");
                    string reiniciar = Console.ReadLine().ToLower();
                    if (reiniciar != "s")
                    {
                        break;
                    }
                }
                
            }
        }
    }


}