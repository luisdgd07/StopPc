/*
 * Created by SharpDevelop.
 * User: Gonzalez Duerto
 * Date: 23/04/2019
 * Time: 9:30 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace StopPc
{
	/// <summary>
	/// Description of Mantenimiento.
	/// </summary>
	public partial class Stop : Form
	{
		public Stop()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void Label1Click(object sender, EventArgs e)
		{
	
		}
		void MantenimientoLoad(object sender, EventArgs e)
		{
	
		}
		public void settexto(String t){
			label1.Text=t;
		
	}
		public void settextot(String t){
			label2.Text=t;
		}
		void Panel2Paint(object sender, PaintEventArgs e)
		{
	
		}
	}
}
