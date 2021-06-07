using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.IO;

namespace tienda_mascotas
{


    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        public int hueso = 500;
        public int correa = 250;
        public int cama_plastica = 1000;
        public int rascador = 1250;
        public int barra_posadora = 700;
        public int saco_comidaP = 2000;
        public int saco_comidaG = 1500;
        public int collarG = 400;



        protected override void OnPaintBackground(PaintEventArgs e)
        {
            using (LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle,
                                                                       Color.White,
                                                                       Color.Green,
                                                                       90F))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            login inicioS = new login();
            inicioS.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
                
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            registro inicio = new registro();
            inicio.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TextReader mostrar = new StreamReader("animales");
            MessageBox.Show(mostrar.ReadToEnd());

            mostrar.Close();

        }

        private void button10_Click(object sender, EventArgs e)
        {
            login inicioS = new login();
            inicioS.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            login inicioS = new login();
            inicioS.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            login inicioS = new login();
            inicioS.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            login inicioS = new login();
            inicioS.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            login inicioS = new login();
            inicioS.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            login inicioS = new login();
            inicioS.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            login inicioS = new login();
            inicioS.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            login inicioS = new login();
            inicioS.Show();
        }
    }
}
