﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caPilha
{
    internal class NoPilha
    {
        //atributos
        private int info;
        private NoPilha next;
        //metodos

        public NoPilha(int n)
        {
            info = n;
            next = null;

        }

        public int Info { get => info; set => info = value; }
        internal NoPilha Next { get => next; set => next = value; }
    }// fim da classe pillha 
}
