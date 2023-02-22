﻿using ByteBank_ATENDIMENTO.ByteBank.Modelos.Conta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank_ATENDIMENTO.ByteBank.Util
{
    public class ListaDeContasCorrentes
    {
        private ContaCorrente[] _itens = null;
        private int _proximaPosicao = 0;

        public ListaDeContasCorrentes(int tamanhoInicial = 5)
        {
            _itens = new ContaCorrente[tamanhoInicial];
        }

        public void Adicionar(ContaCorrente item)
        {
            Console.WriteLine($"Adicionando item na posição {_proximaPosicao}");
            VerificarCapacidade(_proximaPosicao + 1);
            _itens[_proximaPosicao] = item;
            _proximaPosicao++;
        }

        private void VerificarCapacidade(int tamanhoNecessario)
        {
            if(_itens.Length>=tamanhoNecessario)
            {
                return;
            }
            Console.WriteLine("Aumentando a capacidade da lista!");

            ContaCorrente[] novoArray = new ContaCorrente[tamanhoNecessario];

            for (int i = 0; i < _itens.Length; i++)
            {
                novoArray[i] = _itens[i];   
            }
            _itens = novoArray;
        }
    }
}
