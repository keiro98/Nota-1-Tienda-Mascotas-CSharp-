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
using System.Linq.Expressions;

namespace tienda_mascotas
{
    public partial class login : Form
    {
        public login()
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

        private void contraseña_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        string contras;
        string usuar ;
        string mail;
        public  void button1_Click(object sender, EventArgs e)
        {
            String mail = email.Text;
            String usuar = usuario.Text;
            String contra = contraseña.Text;
            String animales = "C:\\C\\" + mail + usuar + ".txt";
            if (File.Exists(animales))
            {
                contras = File.ReadAllText(animales);


                if (contra.Equals(contras))
                {
                    MessageBox.Show("login exitoso");


                    hueso inicioSS = new hueso();
                    inicioSS.Show();
                }
                else
                {
                    MessageBox.Show("contraseña incorrecta");

                }
            }
            else
            {
                MessageBox.Show("usuario no existe o equivocado");
            }

           
             





        }
        
        private void email_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            registro inicio = new registro();
            inicio.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
    }

