using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc02
{
    class Program
    {
        static void Main(string[] args)
        {
            Double[] lista = { 100, 150, 230, 470 };
            Double[] nova = aumentarLista(lista, 10);
            imprimir(lista);
            imprimir(nova);
            Console.WriteLine(somaLista(nova));
            Console.ReadLine();
        }

        static Double somaLista(double[] lista)
        {
            Double result = 0;
            for (int i = 0; i < lista.Length; i++)
            {
                result = result + lista[i];
            }

            return result;
        }
        static void imprimir(Double[] lista)
        {
            for (int i = 0; i < lista.Length; i++)
            {
                Console.Write(lista[i] + " ");
            }
            Console.WriteLine();
        }
        static Double[] aumentarLista(Double[] lista, Double aumento)
        {
            Double[] novaLista = new double[lista.Length];

            for (int i = 0; i < lista.Length; i++)
            {
                novaLista[i] = lista[i] + lista[i]*aumento/100;
            }
           return novaLista;

        }
    }
}
