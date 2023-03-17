namespace DiamanteLetras
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            Console.Write("Digite uma letra: ");
            char x = Convert.ToChar(Console.ReadLine().ToUpper());
            int y = x - 64;
            x = 'A';

            for (int i = 0; i < y; i++)
            {
                for (int j = y; j > i; j--)
                    Console.Write(" ");

                for (double j = 0; j <= i; j+=0.5)
                    if (j == 0 || j == i)
                        Console.Write(x);
                    else
                        Console.Write(" ");

                Console.WriteLine();
                x++;
            }

            x = (char)(x - 2);

            for (int i = y-1; i >= 0; i --)
            {
                for (int j = i; j < y+1; j ++)
                    Console.Write(" ");

                for (double j = i; j > 0; j-=0.5)
                    if (j == i || j == 1)
                        Console.Write(x);
                    else
                        Console.Write(" ");
                Console.WriteLine();
                x = (char)(x - 1);
            }
        }
    }
}