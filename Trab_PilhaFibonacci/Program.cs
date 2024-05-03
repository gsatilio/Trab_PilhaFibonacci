using Trab_PilhaFibonacci;
using Trab1_DuasPilhas;

internal class Program
{
    private static void Main(string[] args)
    {
        int opc, anterior, atual, valorfibonacci, posicao;
        PilhaFibonacci pilha = new PilhaFibonacci();
        do
        {
            anterior = -1; atual = 1; valorfibonacci = 0; posicao = 0;
            Console.WriteLine("Informe a quantidade de números Fibonacci que deseja inserir na pilha, ou digite 0 para sair.");
            opc = int.Parse(Console.ReadLine());
            for (int i = 0; i <= opc; i++)
            {
                valorfibonacci = anterior + atual;

                if (valorfibonacci > 0)
                {
                    pilha.push(new Fibonacci(valorfibonacci));
                }
                anterior = atual;
                atual = valorfibonacci;
            }
            Console.WriteLine(pilha.print());
            for (int i = 0; i <= opc; i++)
            {
                pilha.pop();
            }
            if (opc > 0)
            {
                opc = -1;
            }
        } while (opc != 0);
    }
}