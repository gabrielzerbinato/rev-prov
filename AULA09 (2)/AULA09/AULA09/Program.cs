using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AULA09
{
    class Program
    {
        static void Main(string[] args)
        {
            Double imposto = IRRF(2000);
            Console.WriteLine(imposto);
            Console.ReadLine();
        }

        static Double IRRF(Double salario)
        {
            Double result = 0;
            if (salario <= 1903.80)
            {
                result = 0;
            }
            else
            if (salario>=1903.99 && salario<=2826.65)
            {
                result = salario * (7.5 / 100) - 142.80;
            }
            else if (salario >= 2826.66 && salario <= 3751.05)
            {
                result = salario * (15.0 / 100) - 354.80;
            }
            else if (salario >= 3751.06  && salario <=   4664.68)
            {
                result = salario * (22.5 / 100) - 636.13;
            }
            else
            {
                result = salario * (27.5 / 100) - 869.36;
            }

            return result;
        }
    }
}
