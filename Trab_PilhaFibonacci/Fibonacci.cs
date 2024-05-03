using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trab_PilhaFibonacci
{
    internal class Fibonacci
    {
        int valor;
        Fibonacci anterior;
        public Fibonacci(int numero)
        {
            this.valor = numero;
        }
        public void setAnterior(Fibonacci num)
        {
            this.anterior = num;
        }
        public Fibonacci getAnterior()
        {
            return this.anterior;
        }
        public int getNumero()
        {
            return this.valor;
        }
        public override string? ToString()
        {
            return "\n" + valor;
        }
    }
}
