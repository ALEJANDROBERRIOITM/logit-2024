using System.ComponentModel.Design;

internal class Program
{
    private static void Main(string[] args)

        //declaracion de constantes:

        const decimal preciokilomanzana = 5000
        double descuento;

    //Una frutería ofrece las manzanas con descuento según la siguiente tabla:
    //Usted determina el precio del kilo de manzanas
    //como desarrollador.Determinar y mostrar cuánto
    //pagará una persona que compre manzanas es esa frutería
    //y cuál descuento fue el que se le aplicó,
    //si fue que se le aplicó alguno.

    //datos de entrada cantidad de kilos d emanzanas
    //proceso clcular el valor neto d emanzanas y luego aplicarle descuento si es que le aplica
    //datos de salidad valor total y descuento aplicado

    console.Write("ingrese la cantidad de kilos de manzana a comprar; ");
        decimal  kilosmanzanas = Convert.ToDouble - readLine() );

    //calculos


     if (KilosManzana >= && Kilomanzanas< = 2)

       descuento =0;
        }
   else if (kilosmanzanas > 2 && kilosmanzanas <= 5)

    descuento = 10;

   }
   else if (kilosmanzanas > 2 && kilosmanzanas <= 10)

    descuento = 15;
   }
    else if 

    descuento = 20;

// Calculo del precio bruto
preciobruto = preciokilomanzana * Kilomanzana;

// calculo de precio neto
precioneto = preciobruto * (descuento / 100);

//calculo del precio neto
precioneto = preciobruto - preciodescuento;
Console.WriteLine($" el total a pagar por¨{ preciokilomanzana}.");
Console.WriteLine($" se aolicado un descuento del{ descuento}% que equivale a { preciodescuento}.");





{
        
    }
}