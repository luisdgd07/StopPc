/*
 * Created by SharpDevelop.
 * User: Gonzalez Duerto
 * Date: 23/04/2019
 * Time: 9:30 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace StopPc
{
	partial class Stop
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Panel panel2;
		
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.AllowDrop = true;
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Margin = new System.Windows.Forms.Padding(0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(3390, 2056);
			this.panel1.TabIndex = 0;
			this.panel1.UseWaitCursor = true;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.label1);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Cursor = System.Windows.Forms.Cursors.WaitCursor;
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(3390, 2056);
			this.panel2.TabIndex = 2;
			this.panel2.UseWaitCursor = true;
			this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel2Paint);
			// 
			// label1
			// 
			this.label1.AllowDrop = true;
			this.label1.AutoEllipsis = true;
			this.label1.Cursor = System.Windows.Forms.Cursors.WaitCursor;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(978, 148);
			this.label1.TabIndex = 0;
			this.label1.Text = "label1";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label1.UseWaitCursor = true;
			this.label1.Click += new System.EventHandler(this.Label1Click);
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label2.Location = new System.Drawing.Point(57, 351);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(630, 59);
			this.label2.TabIndex = 1;
			this.label2.Text = "Tiempo de bloqueo:";
			this.label2.UseWaitCursor = true;
			// 
			// Stop
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.AutoScroll = true;
			this.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.ClientSize = new System.Drawing.Size(980, 473);
			this.Controls.Add(this.panel1);
			this.Name = "Stop";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Stop";
			this.UseWaitCursor = true;
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.MantenimientoLoad);
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.ResumeLayout(false);

		}
	}
}
