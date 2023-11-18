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
    public partial class Experiencias : Form
    {
        public Experiencias()
        {
            InitializeComponent();
        }

        private void Btt_Volver_Click(object sender, EventArgs e)
        {
            Form1 back = new Form1();
            back.Show();
            this.Hide();
        }

        private void Picture_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
