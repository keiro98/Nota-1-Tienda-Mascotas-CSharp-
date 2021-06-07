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
    public partial class registro : Form
    {
        public registro()
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
        private void login_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String imail = email.Text;
            String user = usuario.Text;
            String contra = contraseña.Text;
            String animales = "C:\\C\\" + imail + user + ".txt";
            if (File.Exists(animales))
            {
                MessageBox.Show("no es posible registar este usuario");

            }
            else
            {
                File.WriteAllText(animales,contra);
                MessageBox.Show("registro exitoso!");
                email.Text = "";
                usuario.Text = "";
                contraseña.Text = "";
              
                
                hueso inicioSS = new hueso();
              inicioSS.Show();

            
            
            
            
            }
              
        }

     
                    
            
        private void pictureBox6_Click(object sender, EventArgs e)
        {
           


        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                contraseña.UseSystemPasswordChar = false;
            }
            else 
            {
                contraseña.UseSystemPasswordChar = true;
            }
        }

        private void usuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
