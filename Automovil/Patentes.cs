using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automovil
{
    public class Patentes
    {
        public string Patente { get; set; }

        public int PatenteAntigua()
        {
            string letras = "ABCEFGHDKLNPRSTUVXYZWM";
            string fraseMayus = Patente.ToUpper();

            string letra1 = fraseMayus.Substring(0, 2);

            int contador = 0;
            for (int i = 0; i < letra1.Length; i++)
            {
                if (letras.IndexOf(letra1[i]) == -1)
                {
                    contador = letras.IndexOf(letra1[i]);
                    break;
                };
            }

            int num = contador;
            return num;
        }

        public int PatenteNueva()
        {
            string letras = "BCDFGHJKLPRSTVWXYZ";
            string fraseMayus = Patente.ToUpper();

            string letra1 = fraseMayus.Substring(0, 4);

            int contador = 0;
            for (int i = 0; i < letra1.Length; i++)
            {
                if (letras.IndexOf(letra1[i]) == -1)
                {
                    contador = letras.IndexOf(letra1[i]);
                    break;
                };
            }

            int num = contador;
            return num;
        }

        public string Validacion()
        {
            string mayus = Patente.ToUpper();
            string letra1 = mayus.Substring(0, 2);
            string letra2 = mayus.Substring(2, 2);
            string letra3 = mayus.Substring(4, 2);

            string letrasNueva = "1234567890";
            string letra_1 = "ABCEFGHDKLNPRSTUVXYZWM";

            string definicion = "";

            for (int i = 0; i < letra1.Length; i++)
            {
                if (letra_1.IndexOf(letra1[i]) != -1 && letrasNueva.IndexOf(letra2[i]) != -1 && letrasNueva.IndexOf(letra3[i]) != -1)
                {
                    definicion = "Patente antigua";
                }
                else if (letra_1.IndexOf(letra1[i]) != -1 && letra_1.IndexOf(letra2[i]) != -1 && letrasNueva.IndexOf(letra3[i]) != -1)
                {
                    definicion = "Pantente Nueva";
                }
                else
                {
                    definicion = "Patente Incorrecta";
                }
            }
            return definicion;
        }

        public int ValidarNumerosAntiguo()
        {
            string numeros = "1234567890";
            string letra3 = Patente.Substring(2, 4);

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
            return num;
        }

        public int ValidarNumerosNuevo()
        {
            string numeros = "1234567890";
            string letra3 = Patente.Substring(4);

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
            return num;
        }

        public int ValidarCeroAntiguo()
        {
            string letra3 = Patente.Substring(2,4);

            int numero = Convert.ToInt32(letra3);

            return numero;
        }

        public int ValidarCeroNuevo()
        {
            string letra3 = Patente.Substring(4);

            int numero = Convert.ToInt32(letra3);

            return numero;
        }
    }
}
