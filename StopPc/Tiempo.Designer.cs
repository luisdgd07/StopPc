/*
 * Created by SharpDevelop.
 * User: Gonzalez Duerto
 * Date: 23/04/2019
 * Time: 9:07 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace StopPc
{
	partial class Tiempo
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.NumericUpDown numericUpDown1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button button3;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tiempo));
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.label1 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.button3 = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.button2 = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			this.SuspendLayout();
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Interval = 1000;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// label1
			// 
			resources.ApplyResources(this.label1, "label1");
			this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label1.Name = "label1";
			// 
			// button1
			// 
			resources.ApplyResources(this.button1, "button1");
			this.button1.BackColor = System.Drawing.Color.White;
			this.button1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
			this.button1.Name = "button1";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// panel1
			// 
			resources.ApplyResources(this.panel1, "panel1");
			this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
			this.panel1.Controls.Add(this.button3);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.textBox1);
			this.panel1.Controls.Add(this.button2);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.numericUpDown1);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.button1);
			this.panel1.Name = "panel1";
			// 
			// button3
			// 
			resources.ApplyResources(this.button3, "button3");
			this.button3.BackColor = System.Drawing.Color.White;
			this.button3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
			this.button3.Name = "button3";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new System.EventHandler(this.Button3Click);
			// 
			// label3
			// 
			resources.ApplyResources(this.label3, "label3");
			this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label3.Name = "label3";
			// 
			// textBox1
			// 
			resources.ApplyResources(this.textBox1, "textBox1");
			this.textBox1.Name = "textBox1";
			// 
			// button2
			// 
			resources.ApplyResources(this.button2, "button2");
			this.button2.BackColor = System.Drawing.Color.White;
			this.button2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
			this.button2.Name = "button2";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// label2
			// 
			resources.ApplyResources(this.label2, "label2");
			this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label2.Name = "label2";
			this.label2.Click += new System.EventHandler(this.Label2Click);
			// 
			// numericUpDown1
			// 
			resources.ApplyResources(this.numericUpDown1, "numericUpDown1");
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.ValueChanged += new System.EventHandler(this.NumericUpDown1ValueChanged);
			// 
			// Tiempo
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.RoyalBlue;
			this.Controls.Add(this.panel1);
			this.MaximizeBox = false;
			this.Name = "Tiempo";
			this.ShowIcon = false;
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
			this.Load += new System.EventHandler(this.TiempoLoad);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			this.ResumeLayout(false);

		}
	}
}
