using tabuleiro;

namespace Console_xadrez
{
    class Program
    {
        public static void Main(string[] args)
        {
           Tabuleiro tab = new Tabuleiro(8, 8);

            Tela.imprimirTabuleiro(tab);

            Console.ReadLine();

        }
    }
}
