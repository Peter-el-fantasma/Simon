using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simon
{
    public partial class Simon : Form
    {
        static List<int> patron = new List<int>();
        static List<int> patronfijo = new List<int>();
        bool intro = true;

        Random rnd = new Random();

        int iJ = 0;
        int iM = 0;

        int colorencendido = -1;

        public Simon()
        {
            InitializeComponent();

            nvl_1.Visible = false;
            nvl_2.Visible = false;
            nvl_3.Visible = false;
            nvl_4.Visible = false;
            lbl_corona.Visible = false;

            timer1.Interval = 1000;
            timer1.Tick += Timer1_Tick;

            timer2.Interval = 500;
            timer2.Tick += Timer2_Tick;
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            btn_start.Visible = false;
            nvl_1.Visible = true;
            nvl_2.Visible = false;
            nvl_3.Visible = false;
            nvl_4.Visible = false;

            resetJuego();
            patronfijo = new List<int> { 0, 1, 3, 2, 0, 1 };

            intro = true;
            iM = 0;

            timer1.Interval = 1000;
            timer2.Interval = 500;

            timer1.Start();
        }

        void resetJuego()
        {
            patron.Clear();
            iJ = 0;
            iM = 0;
            intro = true;
            colorencendido = -1;

            timer1.Stop();
            timer2.Stop();

            apagarTodos();
        }

        bool Niveles()
        {
            if (patron.Count == 8 || patron.Count == 14 || patron.Count == 20 || patron.Count == 31)
            {
                timer1.Stop(); timer2.Stop();
                patronfijo = new List<int> { 0, 1, 3, 2, 0, 1 };
                intro = true;

                if (patron.Count == 8)
                {
                    nvl_1.Visible = false;
                    nvl_2.Visible = true;
                    nvl_3.Visible = false;
                    nvl_4.Visible = false;
                    timer1.Interval = 800;
                    timer2.Interval = 400;
                    MessageBox.Show("Felicidades, usted pasó al 2do nivel");
                }
                else if (patron.Count == 14)
                {
                    nvl_1.Visible = false;
                    nvl_2.Visible = false;
                    nvl_3.Visible = true;
                    nvl_4.Visible = false;
                    timer1.Interval = 600;
                    timer2.Interval = 300;
                    MessageBox.Show("Felicidades, usted pasó al 3er nivel");
                }
                else if (patron.Count == 20)
                {
                    nvl_1.Visible = false;
                    nvl_2.Visible = false;
                    nvl_3.Visible = false;
                    nvl_4.Visible = true;
                    timer1.Interval = 400;
                    timer2.Interval = 200;
                    MessageBox.Show("Felicidades, usted pasó al 4to nivel");
                }
                else if (patron.Count == 31)
                {
                    timer1.Stop();
                    timer2.Stop();
                    MessageBox.Show("Felicidades, usted ganó el juego 🜲");
                    btn_start.Visible = true;
                    lbl_corona.Visible = true;
                    return true;
                }
            }
            return false;
        }

        void agregarPaso()
        {
            patron.Add(rnd.Next(0, 4));
        }

        void mostrarPaso()
        {
            iM = 0;
            timer1.Start();
        }

        void prenderTodos()
        {
            pbVerde.Image = Properties.Resources.VerdeOn;
            pbRojo.Image = Properties.Resources.RojoOn;
            pbAmarillo.Image = Properties.Resources.AmarilloOn;
            pbAzul.Image = Properties.Resources.AzulOn;
        }

        void apagarTodos()
        {
            pbVerde.Image = Properties.Resources.Verde;
            pbRojo.Image = Properties.Resources.Rojo;
            pbAmarillo.Image = Properties.Resources.Amarillo;
            pbAzul.Image = Properties.Resources.Azul;
        }

        private async void Timer1_Tick(object sender, EventArgs e)
        {
            List<int> listaActual = intro ? patronfijo : patron;

            if (iM < listaActual.Count)
            {
                int i = listaActual[iM];
                colorencendido = i;

                if (i == 0) pbVerde.Image = Properties.Resources.VerdeOn;
                else if (i == 1) pbRojo.Image = Properties.Resources.RojoOn;
                else if (i == 2) pbAmarillo.Image = Properties.Resources.AmarilloOn;
                else if (i == 3) pbAzul.Image = Properties.Resources.AzulOn;

                timer2.Start();
                iM++;
            }
            else
            {
                timer1.Stop();

                if (intro)
                {
                    prenderTodos();
                    await Task.Delay(500);
                    apagarTodos();

                    intro = false;

                    iJ = 0;

                    if (patron.Count == 0)
                        agregarPaso();

                    mostrarPaso();
                }
            }
        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
            if (colorencendido == 0) pbVerde.Image = Properties.Resources.Verde;
            else if (colorencendido == 1) pbRojo.Image = Properties.Resources.Rojo;
            else if (colorencendido == 2) pbAmarillo.Image = Properties.Resources.Amarillo;
            else if (colorencendido == 3) pbAzul.Image = Properties.Resources.Azul;

            colorencendido = -1;
            timer2.Stop();
        }

        private void pbVerde_MouseClick(object sender, MouseEventArgs e)
        {
            verificarClick(0);
        }

        private void pbRojo_MouseClick(object sender, MouseEventArgs e)
        {
            verificarClick(1);
        }

        private void pbAmarillo_MouseClick(object sender, MouseEventArgs e)
        {
            verificarClick(2);
        }

        private void pbAzul_MouseClick(object sender, MouseEventArgs e)
        {
            verificarClick(3);
        }

        void verificarClick(int color)
        {
            if (iJ >= patron.Count)
                return;

            if (color == patron[iJ])
            {
                iJ++;
                if (iJ == patron.Count)
                {
                    iJ = 0;

                    if (Niveles())
                        return;

                    agregarPaso();
                    mostrarPaso();
                }
            }
            else
            {
                timer1.Stop();
                timer2.Stop();

                MessageBox.Show("Fin del juego. Tu puntaje fue: " + patron.Count);

                btn_start.Visible = true;
                resetJuego();
            }
        }

        private void pbVerde_MouseEnter(object sender, EventArgs e)
        {
            pbVerde.Image = Properties.Resources.VerdeHover;
        }

        private void pbVerde_MouseLeave(object sender, EventArgs e)
        {
            pbVerde.Image = Properties.Resources.Verde;
        }

        private void pbRojo_MouseEnter(object sender, EventArgs e)
        {
            pbRojo.Image = Properties.Resources.RojoHover;
        }

        private void pbRojo_MouseLeave(object sender, EventArgs e)
        {
            pbRojo.Image = Properties.Resources.Rojo;
        }

        private void pbAmarillo_MouseEnter(object sender, EventArgs e)
        {
            pbAmarillo.Image = Properties.Resources.AmarilloHover;
        }

        private void pbAmarillo_MouseLeave(object sender, EventArgs e)
        {
            pbAmarillo.Image = Properties.Resources.Amarillo;
        }

        private void pbAzul_MouseEnter(object sender, EventArgs e)
        {
            pbAzul.Image = Properties.Resources.AzulHover;
        }

        private void pbAzul_MouseLeave(object sender, EventArgs e)
        {
            pbAzul.Image = Properties.Resources.Azul;
        }
    }
}