namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n******");
            Console.WriteLine("Ejercicio de numeros amigos");
            Console.WriteLine("******\n");

            Console.Write("Ingrese un numero: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese un numero: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            if (Amigos(num1, num2))
            {
                Console.WriteLine($"{num1} y {num2} son numeros amigos");
            }
            else
            {
                Console.WriteLine($"{num1} y {num2} no son numeros amigos");
            }
        }

        static bool Amigos(int num1, int num2)
        {
            int sumaDivNum1 = SumaDivPropios(num1);
            int sumaDivNum2 = SumaDivPropios(num2);

            return (sumaDivNum1 == num2) && (sumaDivNum2 == num1);
        }

        static int SumaDivPropios(int num)
        {
            int suma = 0;

            for (int i = 1; i < num; i++)
            {
                if (num % i == 0)
                {
                    suma += i;
                }
            }

            return suma;
        }
    }
}
