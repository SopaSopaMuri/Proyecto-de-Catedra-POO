using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Catedra
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            var postr = this.PointToScreen(Lhora.Location);
            postr = Picture_01.PointToClient(postr);
            Lhora.Parent = Picture_01;
            Lhora.Location = postr;
            Lhora.BackColor = Color.Transparent;

            var possr = this.PointToScreen(LFecha.Location);
            possr = Picture_01.PointToClient(possr);
            LFecha.Parent = Picture_01;
            LFecha.Location = possr;
            LFecha.BackColor = Color.Transparent;
        }

        private void Hora_Y_Tiempo_Tick(object sender, EventArgs e)
        {
            Lhora.Text = DateTime.Now.ToString("HH: mm");
            LFecha.Text = DateTime.Now.ToString("dddd, MMMM yyyy");
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Picture_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Btt_Comida_Click(object sender, EventArgs e)
        {
            Menu_Comida comida = new Menu_Comida();
            comida.Show();
            this.Hide();
        }

        private void Btt_Lujo_Click(object sender, EventArgs e)
        {
            Experiencias experiencias = new Experiencias();
            experiencias.Show();
            this.Hide();
        }

        private void Btt_Informacion_Click(object sender, EventArgs e)
        {
            Infoo info = new Infoo();
            info.Show();
        }

       

        private void Btt_Reguistrar_Click(object sender, EventArgs e)
        {
            Reserva reg = new Reserva();
            reg.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
