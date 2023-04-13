using System;

namespace Proyecto
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Introduzca un numero de cuatro digitos");
            int valor = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            if (valor >= 1000 & valor <= 9999)
            {
                Numero numero = new Numero(valor);
                numero.Digitos();

                Procesos procesos = new Procesos();
                procesos.Ordenar(numero.lista3.ToArray());

                Console.WriteLine("Su ecuacion se resolvio adecuadamente");
                Console.WriteLine("Sus datos ordenados son los siguientes");
                foreach (decimal x in numero.lista3.ToArray())
                {
                    Console.WriteLine(x);
                }

            } else
            {
                Console.WriteLine("Introduzca un numero de cuatro digitos");
                valor = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                
            }
        }
    }
}
