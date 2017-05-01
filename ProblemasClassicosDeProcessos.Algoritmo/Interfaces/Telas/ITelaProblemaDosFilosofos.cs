// -----------------------------------------------------------------------
// <copyright file="ITelaProblemaDosFilosofos.cs" company="PUC-GO">
//     TODOS OS DIREITOS RESERVADOS POR JOSÉ RICARDO, SÁVIO CORDEIRO E WICTOR JUNQUEIRA.
// </copyright>
// -----------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using Algoritmo.ProblemasClassicos;

namespace ProblemasClassicosDeProcessos.Algoritmo.Interfaces.Telas
{
    public interface ITelaProblemaDosFilosofos
    {
        IList<Filosofo> ListaDeFilosofos { set; }
        IList<Garfo> ListaDeGarfos { set; }
    }
}
