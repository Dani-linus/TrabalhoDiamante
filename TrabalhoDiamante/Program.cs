namespace TrabalhoDiamante
{
    internal class Program
    {
        //O programa deve solicitar ao usuário um número inteiro.
        //O número deve ser ímpar. Caso contrário, o programa deve informar que a entrada é inválida e solicitar um novo número.
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("----------------------------");
                Console.WriteLine("        Diamante de X      ");
                Console.WriteLine("----------------------------");

                Console.Write("Digite um número inteiro para gerar o diamante: ");
                int numero = Convert.ToInt32(Console.ReadLine());

                if (numero % 2 == 1)
                {
                    Console.WriteLine($"{numero} é um número impar.");
                    break;
                }
                else
                {
                    Console.WriteLine($" O {numero} não é um número impar.");
                    continue;
                }
            }
        }
    }
}
