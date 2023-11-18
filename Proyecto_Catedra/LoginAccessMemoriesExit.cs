using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_Catedra.GuiaEntity;
using System.Configuration.Assemblies;
using System.Configuration;
using Proyecto_Catedra;
//System.Configuration.ConfigurationManager


namespace login_TALLER3
{
    public partial class Login_Form_Taller : Form
    {
        public Login_Form_Taller()
        {
            InitializeComponent();
        }

        private void Login_Form_Taller_Load(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {

            if (textBox1.Text != "")
            {
                string connectionString = ConfigurationManager.ConnectionStrings["hotel_CabanasEntities"].ConnectionString;

                string nuevoNombreServidor = textBox1.Text;
                string nuevoconnectionString = connectionString.Replace("DESKTOP-M4KQ0UB", nuevoNombreServidor);

                MessageBox.Show(connectionString);
                MessageBox.Show(nuevoconnectionString);
                this.Close();
                Form1 beginning = new Form1();
                beginning.Show();

            }

            else {
                MessageBox.Show("Escriba el nombre del servidor porfavor ");
            }


        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 beginning = new Form1();
            beginning.Show();
        }
    }
}
