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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Reflection.Emit;

namespace tienda_mascotas 
{
    public partial class hueso : Form
    {
        public hueso()
        {
            InitializeComponent();
        }
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

        public int huesoP = 500;
        public int correa = 250;
        public int cama_plastica = 1000;
        public int rascador = 1250;
        public int barra_posadora = 700;
        public int saco_comidaP = 2000;
        public int saco_comidaG = 1500;
        public int collarG = 400;
        public int total,huesot,correat,camat,racadort,barrat,sacopt,sacogt,collart;
        
        
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

       public void cuenta_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {
          
    }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            racadort = rascador * Convert.ToInt32(textBox11.Text);
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            collart = collarG * Convert.ToInt32(textBox12.Text);
        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            barrat = barra_posadora * Convert.ToInt32(textBox13.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            correat= correa * Convert.ToInt32(textBox10.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            camat = cama_plastica * Convert.ToInt32(textBox16.Text);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            sacopt = saco_comidaP * Convert.ToInt32(textBox15.Text);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            collart = collarG* Convert.ToInt32(textBox12.Text);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            sacogt = saco_comidaG* Convert.ToInt32(textBox14.Text);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
           racadort = rascador* Convert.ToInt32(textBox11.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            huesot = huesoP * Convert.ToInt32(text1.Text);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            barrat = barra_posadora * Convert.ToInt32(textBox13.Text);
            huesot = huesoP * Convert.ToInt32(text1.Text);
            racadort = rascador * Convert.ToInt32(textBox11.Text);
            sacogt = saco_comidaG * Convert.ToInt32(textBox14.Text);
            camat = cama_plastica * Convert.ToInt32(textBox16.Text);
            correat = correa * Convert.ToInt32(textBox10.Text);
            collart = collarG * Convert.ToInt32(textBox12.Text);
            sacopt = saco_comidaP * Convert.ToInt32(textBox15.Text);


            if (huesot < 1)

            {
                label1.Text = "---";
            }
            else
            {
                label1.Text = "hueso:" + huesot;
            }
            if (correat < 1)
            {
                label2.Text = "----";
            }  
            else
            {
                label2.Text = "correa:" + correat;
            }
            if(camat<1)
            {

                label3.Text = "----";
                
            }
            else
            {
              label3.Text = "cama plastica" + camat;
            }
            if (racadort < 1)
            {
             label4.Text = "----";
            }
            else 
            {
                label4.Text = "rascador " + racadort;
            }
            if(collart <1)
            {
                label5.Text = "----";
            }
            else
            {
                label5.Text = "collar de gato" + collart;
            }
            if(sacopt <1)
            {
                label6.Text = "----";
            }
            else
            {
                label6.Text = "saco de comida de perro" + sacopt;
            }
            if(sacogt < 1)
            {
                label7.Text = "----";
                   
            }
            else
            {
            label7.Text = "saco de comida de gato" + sacogt;
            }
            if(barrat <1)
            {
                label8.Text = "----";

            }
            else
            {
                label8.Text = "barra" + barrat;
            }
           total= huesot+correat+camat+racadort+barrat+sacopt+sacogt+collart;
            label9.Text = "total de la compra" + total;
        
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
