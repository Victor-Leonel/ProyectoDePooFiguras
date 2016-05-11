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

namespace ProyectoDePOO_Figuras
{
    public partial class Form1 : Form
    {

        List<Figuras> figuras;
        enum TipoFigura { Rectangulo, Circulo, Triangulo, Recta};
        private Color relleno_actual, Contorno_actual;
        private TipoFigura figura_actual;


        public Form1()
        {
            InitializeComponent();

            relleno_actual = Color.Black;
            figura_actual = TipoFigura.Circulo;
            figuras = new List<Figuras>();
            circuloToolStripMenuItem.Checked = true;


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.circuloToolStripMenuItem.Checked = true;
            this.rectanguloToolStripMenuItem.Checked = false;
            this.trianguloToolStripMenuItem.Checked = false;
            this.rectaToolStripMenuItem.Checked = false;
            //figura_actual = TipoFigura.Circulo;

        }

        private void boton2_Click(object sender, EventArgs e)
        {
            this.rectanguloToolStripMenuItem.Checked = true;
            this.circuloToolStripMenuItem.Checked = false;
            this.trianguloToolStripMenuItem.Checked = false;
            this.rectaToolStripMenuItem.Checked = false;
            //figura_actual = TipoFigura.Rectangulo;
        }

        private void boton3_Click(object sender, EventArgs e)
        {
            this.trianguloToolStripMenuItem.Checked = true;
            this.rectanguloToolStripMenuItem.Checked = false;
            this.circuloToolStripMenuItem.Checked = false;
            this.rectaToolStripMenuItem.Checked = false;
            //figura_actual = TipoFigura.Triangulo;
        }
        

        private void boton4_Click(object sender, EventArgs e)
        {
            figuras.Clear();

        }

        private void bcirculo_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            foreach (Figuras f in figuras)
            {
                f.Dibuja(this);

            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            // int z = NumericUpDown1;
        }

        private void colorToolStripMenuItem1_Click(object sender, EventArgs e)
        {

               // ColorDialog diag = new ColorDialog();
                //diag.ShowDialog();
               // Circulo.color = diag.Color;
            if (circuloToolStripMenuItem.Checked == true)
            {
                ColorDialog diag = new ColorDialog();
                diag.ShowDialog();
                relleno_actual = diag.Color;
            }

        }

        private void boton5_Click(object sender, EventArgs e)
        {
            this.rectaToolStripMenuItem.Checked = true;
            this.trianguloToolStripMenuItem.Checked = false;
            this.rectanguloToolStripMenuItem.Checked = false;
            this.circuloToolStripMenuItem.Checked = false;
            //figura_actual = TipoFigura.Triangulo;
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (MouseButtons.Left == e.Button && circuloToolStripMenuItem.Checked == true)
            {
                Circulo c = new Circulo(e.X, e.Y);
                c.Dibuja(this);
                figuras.Add(c);
            }
            if (MouseButtons.Left == e.Button && rectanguloToolStripMenuItem.Checked == true)
            {
                Rectangulo r = new Rectangulo(e.X, e.Y);
                r.Dibuja(this);
                figuras.Add(r);

            }

            if (MouseButtons.Left == e.Button && rectaToolStripMenuItem.Checked == true)
            {
                Recta re = new Recta(e.X, e.Y);
                re.Dibuja(this);
                figuras.Add(re);

            }

            if (MouseButtons.Right == e.Button)
            {

                contextMenuStrip2.Show(this, e.X, e.Y);
            }

            else if (MouseButtons.Left == e.Button && trianguloToolStripMenuItem.Checked == true)
            {
                Triangulo t = new Triangulo(e.X, e.Y);
                t.Dibuja(this);
                figuras.Add(t);
            }

            
        }
           


    }

    
    }

