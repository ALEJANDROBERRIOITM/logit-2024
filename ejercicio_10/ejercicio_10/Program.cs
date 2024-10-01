public  class Program
{
    private static void Main(string[] args)
        int main()
    {
        float num1, num2, num3;
        float menor, medio, mayor;

        // Solicitar los tres números al usuario
        printf("Introduce el primer número: ");
        scanf("%f", &num1);
        printf("Introduce el segundo número: ");
        scanf("%f", &num2);
        printf("Introduce el tercer número: ");
        scanf("%f", &num3);

        // Comparar los números y asignar menor, medio y mayor
        if (num1 > num2 && num1 > num3)
        {
            mayor = num1;
            if (num2 > num3)
            {
                medio = num2;
                menor = num3;
            }
            else
            {
                medio = num3;
                menor = num2;
            }
        }
        else if (num2 > num1 && num2 > num3)
        {
            mayor = num2;
            if (num1 > num3)
            {
                medio = num1;
                menor = num3;
            }
            else
            {
                medio = num3;
                menor = num1;
            }
        }
        else
        {
            mayor = num3;
            if (num1 > num2)
            {
                medio = num1;
                menor = num2;
            }
            else
            {
                medio = num2;
                menor = num1;
            }
        }

        // Mostrar los resultados
        printf("El número menor es: %.2f\n", menor);
        printf("El número del medio es: %.2f\n", medio);
        printf("El número mayor es: %.2f\n", mayor);

        return 0;
    
    
        Console.WriteLine("Hello, World!");
    
}