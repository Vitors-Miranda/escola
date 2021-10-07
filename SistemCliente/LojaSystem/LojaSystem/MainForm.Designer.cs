/*
 * Created by SharpDevelop.
 * User: Administrador
 * Date: 07/10/2021
 * Time: 14:24
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace LojaSystem
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.txtnome = new System.Windows.Forms.TextBox();
			this.txtemail = new System.Windows.Forms.TextBox();
			this.txtsalario = new System.Windows.Forms.TextBox();
			this.txtcpf = new System.Windows.Forms.MaskedTextBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(198, 35);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Nome";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(198, 84);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Email";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(198, 142);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 2;
			this.label3.Text = "CPF";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(198, 190);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 3;
			this.label4.Text = "Salario";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(226, 225);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(83, 42);
			this.button1.TabIndex = 4;
			this.button1.Text = "Cadastrar";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// txtnome
			// 
			this.txtnome.Location = new System.Drawing.Point(263, 32);
			this.txtnome.Name = "txtnome";
			this.txtnome.Size = new System.Drawing.Size(100, 20);
			this.txtnome.TabIndex = 5;
			// 
			// txtemail
			// 
			this.txtemail.Location = new System.Drawing.Point(263, 84);
			this.txtemail.Name = "txtemail";
			this.txtemail.Size = new System.Drawing.Size(100, 20);
			this.txtemail.TabIndex = 6;
			// 
			// txtsalario
			// 
			this.txtsalario.Location = new System.Drawing.Point(263, 190);
			this.txtsalario.Name = "txtsalario";
			this.txtsalario.Size = new System.Drawing.Size(100, 20);
			this.txtsalario.TabIndex = 7;
			// 
			// txtcpf
			// 
			this.txtcpf.Location = new System.Drawing.Point(263, 142);
			this.txtcpf.Mask = "999,999,999-99";
			this.txtcpf.Name = "txtcpf";
			this.txtcpf.Size = new System.Drawing.Size(100, 20);
			this.txtcpf.TabIndex = 8;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(548, 322);
			this.Controls.Add(this.txtcpf);
			this.Controls.Add(this.txtsalario);
			this.Controls.Add(this.txtemail);
			this.Controls.Add(this.txtnome);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "MainForm";
			this.Text = "LojaSystem";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.MaskedTextBox txtcpf;
		private System.Windows.Forms.TextBox txtsalario;
		private System.Windows.Forms.TextBox txtemail;
		private System.Windows.Forms.TextBox txtnome;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}
