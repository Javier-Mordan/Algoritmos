using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    internal class Numero
    {
        public int numero { get; set; }
        public int valor1;
        public int valor2;
        public int valor3;
        public int valor4;

        public Numero(int _umero)
        {
            numero = _umero;            
        }
        public List<int> lista1 = new List<int>();
        public List<decimal>lista3 = new List<decimal> ();
        int suma;
        int mult;
        public void Digitos()
        {
            valor1 = numero / 1000;
            valor2 = (numero % 1000)/100;
            valor3 = (numero % 100)/10;
            valor4 = (numero % 10)%10;
            List<int> lista2 = new List<int>() { valor1, valor2, valor3, valor4};

            suma = valor4 + valor1;
            mult = valor3 * valor2;
            Log
            lista1.Add(numero);            
            
        }

        private decimal Log()
        {
            decimal log = (decimal)Math.Log(suma, mult);
            lista3.Add(log);
            return log;
        }
    }
}
