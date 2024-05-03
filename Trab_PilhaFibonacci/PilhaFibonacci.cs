using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using Trab_PilhaFibonacci;

namespace Trab1_DuasPilhas
{
    internal class PilhaFibonacci
    {
        Fibonacci topo;

        public PilhaFibonacci()
        {
            topo = null;
        }
        public void push(Fibonacci aux)
        {
            if (topo == null)
            {
                topo = aux;
            }
            else
            {
                aux.setAnterior(topo);
                topo = aux;
            }
        }
        public int pop()
        {
            int valor = 0;
            if (topo != null)
            {
                valor = topo.getNumero();
                topo = topo.getAnterior();
            }
            return valor;
        }
        public int getContador()
        {
            int contador = 0;
            Fibonacci aux = topo;
            do
            {
                contador++;
                aux = aux.getAnterior();
            } while (aux != null);
            return contador;
        }
        public string print()
        {
            Fibonacci aux = topo;
            string texto = "";
            if (topo != null)
            {
                texto = "Topo:";
                do
                {
                    texto += $"{aux.ToString()} ";
                    aux = aux.getAnterior();
                } while (aux != null);
            }
            return texto;
        }
    }
}
