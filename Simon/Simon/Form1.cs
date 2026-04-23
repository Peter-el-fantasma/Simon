using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simon
{
    public partial class Simon : Form
    {
        static List<int> patron = new List<int>();

        Random rnd = new Random();

        int iJ= 0;
        int iM= 0;

        int colorencendido = -1;
        public Simon()
        {
            InitializeComponent();
        }
        void btn_start_Click (object sender, EventArgs e)
        {
            
            btn_start.Visible=false;
            timer1.Interval = 1000;
            timer1.Tick += Timer1_Tick;

            timer2.Interval = 500;
            timer2.Tick += Timer2_Tick;

            agregarPaso();
            mostrarPaso();

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

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (iM < patron.Count)
            {
                int i = patron[iM];
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
            verificarClick(2
                );
        }

        private void pbAzul_MouseClick(object sender, MouseEventArgs e)
        {
            verificarClick(3);
        }

        void verificarClick(int color)
        {
            if (color == patron[iJ])
            {
                iJ++;
                if (iJ == patron.Count)
                {
                    iJ = 0;
                    agregarPaso();
                    mostrarPaso();
                }
            }
            else
            {
                MessageBox.Show("Fin del juego. Tu puntaje fue: " + patron.Count);
                Close();
            }

        }
        
        // Esto es pal Hover
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
