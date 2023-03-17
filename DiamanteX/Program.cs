namespace DiamanteX
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x;
            Console.Write("Digite um número ímpar: ");
            x = Convert.ToInt32(Console.ReadLine());
            while(x % 2 == 0)
            {
                Console.Write($"{x} não é impar! Digite outro número: ");
                x = Convert.ToInt32(Console.ReadLine());
            }

            for(int i = 0; i < x; i+=2) 
            {
                for (int j = x; j > i; j-=2)
                    Console.Write(" ");

                for (int j = 0; j <= i; j++)
                    Console.Write("x");

                Console.WriteLine();
            }

            for (int i = x-2; i >= 0; i-=2)
            {
                for (int j = i; j < x+2; j+=2)
                    Console.Write(" ");

                for (int j = i; j > 0; j--)
                    Console.Write("x");

                Console.WriteLine();
            }

        }
    }
}