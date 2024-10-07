using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caPilha
{
    internal class Pilha
    {
        //atributos
        private NoPilha topo;
        // metodos
        public Pilha()
        {
            topo = null;
        }

        internal NoPilha Topo { get => topo; set => topo = value; }

        public bool estaVazia()
        {
            if (topo == null)
            {
                return true;
            }
            else
                return false;
        }

        public void push(int n)// insere na pilha
        {
            NoPilha novoNo = new NoPilha(n);
            if (estaVazia())
            {
                topo = novoNo;
            }
            else
            {
                novoNo.Next = topo;
                topo = novoNo;
            }
        }

        public void imprime()
        {
            if (estaVazia())
            {
                Console.WriteLine("Pilha vazia");
            }
            else
            {
                NoPilha temp = topo;
                while (temp != null)
                {
                    Console.WriteLine(temp.Info.ToString());
                    temp = temp.Next;
                }

            }
        }

        public int pop()
        {
            if (estaVazia())
            {
                Console.WriteLine("Pilha esta vazia");
                return 0;
            }
            else
            {
                int temp = topo.Info;
                topo = topo.Next;
                return temp;

            }
        }
    }
}
        
   
           
            
// fim da classe pilha 
