using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * CLASSE PILHA - IMPLEMENTA O TIPO ABSTRATO DE DADOS PILHA ESTÁTICA
 * OPERAÇÕES: 
 *	Empilhar(x) -> coloca o elemento x no topo da pilha
 *	Desempilhar() -> retorna o elemento situado no topo da pilha
 *	Vazia() -> retorna true se a pilha está vazia
 *	Cheia() -> returna true se a pilha está cheia
 */

namespace TiposAbstratosDeDados
{
    class Pilha
    {
        private int[] vet; // vetor para armazenar os elementos da pilha
        private int topo; // indica a posição do topo

        public Pilha(int tamanho) // CONSTRUTOR
        { 
            vet = new int[tamanho];
            topo = 0;
        }
        public void Empilhar(int item)
        {
            vet[topo] = item;
            topo++;
        }
        public int Desempilhar()
        {
            topo--;
            return (vet[topo]);
        }
        public bool Cheia()
        {
            return (topo == vet.Length);
        }
        public bool Vazia()
        {
            return (topo == 0);
        }
    }
}

