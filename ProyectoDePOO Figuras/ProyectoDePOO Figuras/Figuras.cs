using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace ProyectoDePOO_Figuras
{
    abstract class Figuras : IComparable
    {
        protected int X, Y, Z, W, A, F, L, K;
        protected Pen pluma;
        protected int ancho, largo;
        protected Color color;
        protected SolidBrush brocha;


        public Figuras(int x, int y)
        {
            X = x;
            Y = y;
            brocha = new SolidBrush(Color.Blue);
            pluma = new Pen(Color.Aqua, 2);
            Random rnd = new Random();
            ancho = rnd.Next(10, 80);
            Z = rnd.Next(100, 500);
            W = rnd.Next(100, 500);
            A = rnd.Next(100, 500);
            F = rnd.Next(100, 500);
            L = rnd.Next(100, 500);
            K = rnd.Next(100, 500);

            largo = ancho;
        }

        public abstract void Dibuja(Form f);

        public int CompareTo(object obj)
        {
            return this.largo.CompareTo(((Figuras)obj).largo);
        }
    }

    class Rectangulo : Figuras
    {
        public Rectangulo(int x, int y) : base(x, y)
        {
        }
        public override void Dibuja(Form f)
        {
            Graphics g = f.CreateGraphics();
            g.DrawRectangle(pluma, this.X, this.Y, ancho, largo);
            g.FillRectangle(brocha, this.X, this.Y, ancho, largo);


        }
    }

    class Circulo : Figuras
    {
        public Circulo(int x, int y): base(x, y)
        {

        }
        public override void Dibuja(Form f)
        {
            Graphics g = f.CreateGraphics();
            g.DrawEllipse(pluma, this.X, this.Y, ancho, largo);
            g.FillEllipse(brocha, this.X, this.Y, ancho, largo);
        }
    }


    class Triangulo : Figuras
    {
        public Triangulo(int x, int y): base(x, y)
        {

        }

        // public override void OnPaint(PaintEventArgs e)
        public override void Dibuja(Form f)
        {
            //Llamada al método de la clase base.
            // base.OnPaint(e);
            Graphics g = f.CreateGraphics();

            //Establecemos los vértices de un triángulo.
            Point Vertice1 = new Point(this.Z, 300);
            Point Vertice2 = new Point(this.A, 50);
            Point Vertice3 = new Point(800, this.W);

            //Cargamos en memoria (instanciar) un objeto GraphicsPath. 
            GraphicsPath ruta = new GraphicsPath();

            //Establecemos una secuencia de lineas sobre el objeto "ruta".
            ruta.AddLine(Vertice1, Vertice2);
            ruta.AddLine(Vertice2, Vertice3);
            ruta.AddLine(Vertice3, Vertice1);

            //Dibujamos la secuencia de lineas.
            //e.Graphics.DrawPath(new Pen(Color.Black, 4), ruta);
            g.DrawPath(new Pen(Color.Black, 4), ruta);

            //Rellenamos con un color el interior de la secuencia de lineas.
            // e.Graphics.FillPath(new SolidBrush(Color.Orange), ruta);
            g.FillPath(new SolidBrush(Color.Yellow), ruta);
        }


    }

}