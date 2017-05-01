// -----------------------------------------------------------------------
// <copyright file="ControladorProblemaDosFilosofos.cs" company="PUC-GO">
//     TODOS OS DIREITOS RESERVADOS POR JOSÉ RICARDO, SÁVIO CORDEIRO E WICTOR JUNQUEIRA.
// </copyright>
// -----------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProblemasClassicosDeProcessos.Algoritmo.Interfaces.Controles;
using ProblemasClassicosDeProcessos.Algoritmo.Interfaces.Telas;
using Algoritmo.ProblemasClassicos;
using System.Threading;

namespace ProblemasClassicosDeProcessos.Algoritmo.Controladores.Controladores
{
    public class ControladorProblemaDosFilosofos : IControleProblemaDosFilosofos
    {
        public int Tempo 
        {
            set 
            {
                var problemaDosFilosofos = ProblemaDosFilosofos.ObtenhaInstancia();
                problemaDosFilosofos.IntervaloDeTempo = value;
            } 
        }
        private ITelaProblemaDosFilosofos _tela;

        public ControladorProblemaDosFilosofos(ITelaProblemaDosFilosofos tela)
        {
            _tela = tela;
        }

        public void Execute()
        {
            var problemaDosFilosofos = ProblemaDosFilosofos.ObtenhaInstancia();

            problemaDosFilosofos.Execute();
        }

        public void AtualizeSituacao()
        {
            var problemaDosFilosofos = ProblemaDosFilosofos.ObtenhaInstancia();
            _tela.ListaDeGarfos = problemaDosFilosofos.ListaDeGarfos;
            _tela.ListaDeFilosofos = problemaDosFilosofos.ListaDeFilosofos;
        }
    }
}
