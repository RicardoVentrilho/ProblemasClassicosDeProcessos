using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using Algoritmo.ProblemasClassicos;
using ProblemasClassicosDeProcessos.Algoritmo.Interfaces.Telas;
using ProblemasClassicosDeProcessos.Algoritmo.Controladores.Controladores;

namespace ProblemasClassicosDeProcessos.Algoritmo.WindowsForms
{
    public partial class FilosofosJantandoUI : Form, ITelaProblemaDosFilosofos
    {
        #region Propriedades

        private ControladorProblemaDosFilosofos _controlador;

        #endregion

        public FilosofosJantandoUI()
        {
            InitializeComponent();

            Barra.Value = 1;
            _controlador = new ControladorProblemaDosFilosofos(this);

            AdicionaControleDasImagens();
        }

        private void AdicionaControleDasImagens()
        {

            ImagemDeFundo.Controls.Add(Filosofo1);
            ImagemDeFundo.Controls.Add(Garfo1);

            ImagemDeFundo.Controls.Add(Filosofo2);
            ImagemDeFundo.Controls.Add(Garfo2);

            ImagemDeFundo.Controls.Add(Filosofo3);
            ImagemDeFundo.Controls.Add(Garfo3);

            ImagemDeFundo.Controls.Add(Filosofo4);
            ImagemDeFundo.Controls.Add(Garfo4);

            ImagemDeFundo.Controls.Add(Filosofo5);
            ImagemDeFundo.Controls.Add(Garfo5);
        }

        private void FilosofosJantandoUI_Load(object sender, EventArgs e)
        {
            Thread thread = new Thread(_controlador.Execute);
            thread.Start();
        }

        public IList<Filosofo> ListaDeFilosofos
        {
            set 
            {
                var filosofosPensando = value;

                Filosofo1.Visible = !filosofosPensando[0].EstaPensando;
                Filosofo2.Visible = !filosofosPensando[1].EstaPensando;
                Filosofo3.Visible = !filosofosPensando[2].EstaPensando;
                Filosofo4.Visible = !filosofosPensando[3].EstaPensando;
                Filosofo5.Visible = !filosofosPensando[4].EstaPensando;
            }
        }

        public IList<Garfo> ListaDeGarfos
        {
            set 
            {
                var garfosUtilizados = value;

                Garfo1.Visible = garfosUtilizados[0].EstaSendoUtilizado;
                Garfo2.Visible = garfosUtilizados[1].EstaSendoUtilizado;
                Garfo3.Visible = garfosUtilizados[2].EstaSendoUtilizado;
                Garfo4.Visible = garfosUtilizados[3].EstaSendoUtilizado;
                Garfo5.Visible = garfosUtilizados[4].EstaSendoUtilizado;
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            _controlador.AtualizeSituacao();
        }

        private void Barra_Scroll(object sender, EventArgs e)
        {
            _controlador.Tempo = Barra.Value * 100;
        }
    }
}
