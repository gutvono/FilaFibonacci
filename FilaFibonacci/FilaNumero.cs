﻿using PilhaFibonacci;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilaFibonacci
{
    internal class FilaInteiro
    {
        Numero? head;
        Numero? tail;

        public FilaInteiro()
        {
            this.head = null;
            this.tail = null;
        }

        public void Push(Numero aux)
        {
            if (IsEmpty()) head = tail = aux;
            else
            {
                tail!.SetProximo(aux);
                tail = aux;
            }
        }

        bool IsEmpty() { return head == null && tail == null; }

        public void Print()
        {
            if (IsEmpty())
            {
                Console.WriteLine($"Fila vazia! Pressione qualquer tecla para continuar...");
                Console.ReadKey();
            }
            else
            {
                Numero aux = this.head!;
                while (aux != null)
                {
                    Console.WriteLine(aux.PrintN());
                    aux = aux.GetProximo()!;
                }
            }
        }
    }
}
