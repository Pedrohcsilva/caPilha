using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caPilha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pilha p1 = new Pilha();
            p1.push(3);
            p1.push(4);
            p1.push(5);

            p1.imprime();
            Console.WriteLine("Desempilando o ... " +p1.pop());

            p1.imprime();

            Console.ReadLine();


        }
    }
}
