﻿namespace ProyectoDePOO_Figuras
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bcirculo = new System.Windows.Forms.Button();
            this.brectangulo = new System.Windows.Forms.Button();
            this.btriangulo = new System.Windows.Forms.Button();
            this.borrar = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.figuraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.circuloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rectanguloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trianguloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.colorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.boton5 = new System.Windows.Forms.Button();
            this.rectaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.contextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(-2, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(118, 477);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // bcirculo
            // 
            this.bcirculo.BackColor = System.Drawing.Color.RoyalBlue;
            this.bcirculo.ForeColor = System.Drawing.Color.Transparent;
            this.bcirculo.Image = ((System.Drawing.Image)(resources.GetObject("bcirculo.Image")));
            this.bcirculo.Location = new System.Drawing.Point(-2, 0);
            this.bcirculo.Name = "bcirculo";
            this.bcirculo.Size = new System.Drawing.Size(118, 86);
            this.bcirculo.TabIndex = 2;
            this.bcirculo.UseVisualStyleBackColor = false;
            this.bcirculo.Click += new System.EventHandler(this.button1_Click);
            // 
            // brectangulo
            // 
            this.brectangulo.BackColor = System.Drawing.SystemColors.HotTrack;
            this.brectangulo.Image = ((System.Drawing.Image)(resources.GetObject("brectangulo.Image")));
            this.brectangulo.Location = new System.Drawing.Point(-2, 85);
            this.brectangulo.Name = "brectangulo";
            this.brectangulo.Size = new System.Drawing.Size(118, 80);
            this.brectangulo.TabIndex = 3;
            this.brectangulo.UseVisualStyleBackColor = false;
            this.brectangulo.Click += new System.EventHandler(this.boton2_Click);
            // 
            // btriangulo
            // 
            this.btriangulo.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btriangulo.Image = ((System.Drawing.Image)(resources.GetObject("btriangulo.Image")));
            this.btriangulo.Location = new System.Drawing.Point(-2, 163);
            this.btriangulo.Name = "btriangulo";
            this.btriangulo.Size = new System.Drawing.Size(118, 84);
            this.btriangulo.TabIndex = 4;
            this.btriangulo.UseVisualStyleBackColor = false;
            this.btriangulo.Click += new System.EventHandler(this.boton3_Click);
            // 
            // borrar
            // 
            this.borrar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.borrar.Image = ((System.Drawing.Image)(resources.GetObject("borrar.Image")));
            this.borrar.Location = new System.Drawing.Point(-2, 301);
            this.borrar.Name = "borrar";
            this.borrar.Size = new System.Drawing.Size(118, 119);
            this.borrar.TabIndex = 5;
            this.borrar.UseVisualStyleBackColor = false;
            this.borrar.Click += new System.EventHandler(this.boton4_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.figuraToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(153, 48);
            // 
            // figuraToolStripMenuItem
            // 
            this.figuraToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.circuloToolStripMenuItem,
            this.rectanguloToolStripMenuItem,
            this.trianguloToolStripMenuItem,
            this.rectaToolStripMenuItem});
            this.figuraToolStripMenuItem.Name = "figuraToolStripMenuItem";
            this.figuraToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.figuraToolStripMenuItem.Text = "Figura";
            // 
            // circuloToolStripMenuItem
            // 
            this.circuloToolStripMenuItem.Name = "circuloToolStripMenuItem";
            this.circuloToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.circuloToolStripMenuItem.Text = "Circulo";
            // 
            // rectanguloToolStripMenuItem
            // 
            this.rectanguloToolStripMenuItem.Name = "rectanguloToolStripMenuItem";
            this.rectanguloToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.rectanguloToolStripMenuItem.Text = "Rectangulo";
            // 
            // trianguloToolStripMenuItem
            // 
            this.trianguloToolStripMenuItem.Name = "trianguloToolStripMenuItem";
            this.trianguloToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.trianguloToolStripMenuItem.Text = "Triangulo";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(-2, 444);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(118, 20);
            this.numericUpDown1.TabIndex = 6;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 419);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 22);
            this.label1.TabIndex = 7;
            this.label1.Text = "Gruesor";
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colorToolStripMenuItem1});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(104, 26);
            // 
            // colorToolStripMenuItem1
            // 
            this.colorToolStripMenuItem1.Name = "colorToolStripMenuItem1";
            this.colorToolStripMenuItem1.Size = new System.Drawing.Size(103, 22);
            this.colorToolStripMenuItem1.Text = "Color";
            this.colorToolStripMenuItem1.Click += new System.EventHandler(this.colorToolStripMenuItem1_Click);
            // 
            // boton5
            // 
            this.boton5.BackColor = System.Drawing.SystemColors.HotTrack;
            this.boton5.Image = ((System.Drawing.Image)(resources.GetObject("boton5.Image")));
            this.boton5.Location = new System.Drawing.Point(-2, 244);
            this.boton5.Name = "boton5";
            this.boton5.Size = new System.Drawing.Size(118, 59);
            this.boton5.TabIndex = 8;
            this.boton5.UseVisualStyleBackColor = false;
            this.boton5.Click += new System.EventHandler(this.boton5_Click);
            // 
            // rectaToolStripMenuItem
            // 
            this.rectaToolStripMenuItem.Name = "rectaToolStripMenuItem";
            this.rectaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.rectaToolStripMenuItem.Text = "Recta";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(938, 476);
            this.Controls.Add(this.boton5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.borrar);
            this.Controls.Add(this.btriangulo);
            this.Controls.Add(this.brectangulo);
            this.Controls.Add(this.bcirculo);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.contextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bcirculo;
        private System.Windows.Forms.Button brectangulo;
        private System.Windows.Forms.Button btriangulo;
        private System.Windows.Forms.Button borrar;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem figuraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem circuloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rectanguloToolStripMenuItem;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem trianguloToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem1;
        private System.Windows.Forms.Button boton5;
        private System.Windows.Forms.ToolStripMenuItem rectaToolStripMenuItem;
    }
}

