using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolaPatentes
{
    class Program
    {
        static void Main(string[] args)
        {
            string Patente = "is0512";

            string numeros = "123456789";
            string letra3 = Patente.Substring(2, 1);

            int contador = 0;
            for (int i = 0; i < letra3.Length; i++)
            {
                if (numeros.IndexOf(letra3[i]) == -1)
                {
                    contador = numeros.IndexOf(letra3[i]);
                    break;
                };
            }

            int num = contador;

            Console.WriteLine("letra3: {0}", num);
            Console.WriteLine("let:  {0}", letra3);

            if (num != -1)
            {
                Console.WriteLine("Correcto");
            }
            else
            {
                Console.WriteLine("Patente Incorrecta");
            }

            Console.ReadKey();
        }
    }
}
