// -----------------------------------------------------------------------
// <copyright file="Filosofo.cs" company="PUC-GO">
//     TODOS OS DIREITOS RESERVADOS POR JOSÉ RICARDO, SÁVIO CORDEIRO E WICTOR JUNQUEIRA.
// </copyright>
// -----------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Algoritmo.ProblemasClassicos
{
    public class Filosofo
    {
        public Garfo GarfoDaDireita { get; set; }
        public Garfo GarfoDaEsquerda { get; set; }
        public bool EstaPensando { get; set; }
        public int IntervaloDeTempo { get; set; }
        private static Random randomico = new Random();

        public Filosofo(ref Garfo garfoDaDireita, ref Garfo garfoDaEsquerda, int intervaloDeTempo)
        {
            EstaPensando = true;
            GarfoDaDireita = garfoDaDireita;
            GarfoDaEsquerda = garfoDaEsquerda;
            IntervaloDeTempo = intervaloDeTempo;
        }

        public void Come()
        {
            if (GarfoDaDireita.EstaSendoUtilizado || GarfoDaEsquerda.EstaSendoUtilizado)
            {
                return;
            }

            EstaPensando = false;
            GarfoDaDireita.EstaSendoUtilizado = true;
            GarfoDaEsquerda.EstaSendoUtilizado = true;

            Thread.Sleep(randomico.Next((int)(IntervaloDeTempo * 0.8), (int)(IntervaloDeTempo * 1.2)));

            EstaPensando = true;
            GarfoDaDireita.EstaSendoUtilizado = false;
            GarfoDaEsquerda.EstaSendoUtilizado = false;
        }
    }
}
