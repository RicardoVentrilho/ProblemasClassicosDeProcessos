// -----------------------------------------------------------------------
// <copyright file="IControleDoProblemaDosFilosofos.cs" company="PUC-GO">
//     TODOS OS DIREITOS RESERVADOS POR JOSÉ RICARDO, SÁVIO CORDEIRO E WICTOR JUNQUEIRA.
// </copyright>
// -----------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProblemasClassicosDeProcessos.Algoritmo.Interfaces.Controles
{
    public interface IControleProblemaDosFilosofos
    {
        void Execute();
        void AtualizeSituacao();
    }
}
