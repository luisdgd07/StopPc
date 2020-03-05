/*
 * Created by SharpDevelop.
 * User: Gonzalez Duerto
 * Date: 23/04/2019
 * Time: 9:07 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Windows.Forms.VisualStyles;

namespace StopPc
{
	/// <summary>
	/// Description of Tiempo.
	/// </summary>
	public partial class Tiempo : Form
	{        
		[DllImport("user32.dll")]
        private static extern void BlockInput(bool fBlock);
		//private static extern void Bl
        private int tiempoBlock;
        Stop mante;
		public Tiempo()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
        	tiempoBlock = int.Parse(numericUpDown1.Value.ToString());
            BlockInput(true);
           
            timer1.Start();
            mante=new Stop();
            mante.settexto(textBox1.Text);
            mante.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (tiempoBlock > 0)
            {
                tiempoBlock--;
                //label2.Text = "Tiempo de Mantenimiento: " + tiempoBlock.ToString() + " Seg.";
                mante.settextot("Tiempo de bloqueo: "+tiempoBlock.ToString() + " Seg.");
            }
            else
            {
                timer1.Stop();
                BlockInput(false);
                //mante.settextot("Tiempo de bloqueo: "+tiempoBlock.ToString() + " Seg.");
                //label2.Text = "Tiempo de Mantenimiento: ";
            }
        }
		void TiempoLoad(object sender, EventArgs e)
		{
	
		}
		void Button2Click(object sender, EventArgs e)
		{
			System.Diagnostics.Process.Start("http://paypal.me/LGonzalezduerto");
		}
		void NumericUpDown1ValueChanged(object sender, EventArgs e)
		{
	
		}
		void Label2Click(object sender, EventArgs e)
		{
	
		}
		void Button3Click(object sender, EventArgs e)
		{
				System.Diagnostics.Process.Start("http://www.facebook.com/ldgapps");
		}
	}
}
