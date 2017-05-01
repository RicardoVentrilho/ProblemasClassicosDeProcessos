// -----------------------------------------------------------------------
// <copyright file="ProblemaDosFilosofos.cs" company="PUC-GO">
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
    enum ProblemaDosFilosofosEnumerador
    {
        QUANTIDADE_DE_FILOSOFOS = 5,

        INTERVALO_DE_TEMPO = 100
    }

    public class ProblemaDosFilosofos
    {
        #region Propriedades

        public IList<Thread> ListaDeThreads { set; get; }
        public IList<Filosofo> ListaDeFilosofos { set; get; }
        public IList<Garfo> ListaDeGarfos { set; get; }
        public int IntervaloDeTempo
        {
            set
            {
                foreach (Filosofo filosofo in ListaDeFilosofos)
                {
                    filosofo.IntervaloDeTempo = value;
                }
            }
        }

        private static ProblemaDosFilosofos _instancia = null;

        #endregion

        #region Singleton

        private ProblemaDosFilosofos()
        {
            ListaDeFilosofos = new List<Filosofo>();
            ListaDeThreads = new List<Thread>();
            ListaDeGarfos = new List<Garfo>();

            for (int i = 0; i < (int)ProblemaDosFilosofosEnumerador.QUANTIDADE_DE_FILOSOFOS; i++)
            {
                ListaDeGarfos.Add(new Garfo());
            }

            for (int i = 0; i < (int)ProblemaDosFilosofosEnumerador.QUANTIDADE_DE_FILOSOFOS; i++)
            {
                var garfoDaDireita = ListaDeGarfos[i];
                var garfoDaEsquerda = ListaDeGarfos[(i + 1) % (int)ProblemaDosFilosofosEnumerador.QUANTIDADE_DE_FILOSOFOS];
                var filosofo = new Filosofo(ref garfoDaDireita, ref garfoDaEsquerda, (int)ProblemaDosFilosofosEnumerador.INTERVALO_DE_TEMPO);

                ListaDeFilosofos.Add(filosofo);
                ListaDeThreads.Add(new Thread(filosofo.Come));
            }
        }

        public static ProblemaDosFilosofos ObtenhaInstancia()
        {
            if (_instancia == null)
            {
                _instancia = new ProblemaDosFilosofos();
            }

            return _instancia;
        }

        #endregion

        public void Execute()
        {
            while (true)
            {
                for (int i = 0; i < ListaDeThreads.Count; i++)
                {
                    if (!ListaDeThreads[i].IsAlive)
                    {
                        ListaDeThreads[i] = new Thread(ListaDeFilosofos[i].Come);
                        ListaDeThreads[i].Start();
                    }
                }
            }
        }
    }
}
