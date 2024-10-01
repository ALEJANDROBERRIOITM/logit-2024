internal class Program
{
    private static void Main(string[] args)
    {
        //Realice un programa que solicite dos números, luego debe pedirse un número que seleccionará alguna operación aritmética desde un menú. Si introduce 1 los números se deben sumar, si introduce 2 los números se deben restar, si es 3 los números se multiplican y si introduce 4 los números se dividen (validar división por cero). Independientemente de la selección, imprima el resultado. Además, el programa debe tener la posibilidad de volver al menú para pedir 2 nuevos
        //números y hacer la elección de la operación aritmética o digitar cero para finalizar el programa. DONE
        
        //variables
        double num1, num2;
        int opcion;
        double resultados = 0;
        bool continuar = true;

        do
        {
            Console.Write(" ingresar el primer numero");
            num1 = double.Parse(Console.ReadLine()); //double.parse ex exatamente lo mismo que el vonvert.todoublet

            Console.Write(" ingresar el segundo numero");
            num2 = double.Parse(Console.ReadLine());







            Console.WriteLine("Hello, World!");
    }
}