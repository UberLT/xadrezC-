using tabuleiro;

namespace Console_xadrez
{
    class Program
    {
        public static void Main(string[] args)
        {
            Posicao p;

            p = new Posicao(3, 4);

            Console.WriteLine("Posição: " + p);
            Console.ReadLine();

        }
    }
}
