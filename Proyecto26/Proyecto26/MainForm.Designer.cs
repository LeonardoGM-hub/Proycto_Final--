/*
 * Creado por SharpDevelop.
 * Usuario: CC1_PC32
 * Fecha: 08/12/2025
 * Hora: 02:24 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace Proyecto26
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.label1 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.rdbDulce = new System.Windows.Forms.RadioButton();
			this.rdbSalado = new System.Windows.Forms.RadioButton();
			this.label2 = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.SaddleBrown;
			this.label1.Font = new System.Drawing.Font("Microsoft Uighur", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label1.Location = new System.Drawing.Point(246, 57);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(390, 51);
			this.label1.TabIndex = 0;
			this.label1.Text = "Pasteleria Espacial para ti";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(-2, 2);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(429, 122);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(425, 2);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(459, 122);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 2;
			this.pictureBox2.TabStop = false;
			// 
			// rdbDulce
			// 
			this.rdbDulce.BackColor = System.Drawing.Color.Peru;
			this.rdbDulce.Location = new System.Drawing.Point(358, 130);
			this.rdbDulce.Name = "rdbDulce";
			this.rdbDulce.Size = new System.Drawing.Size(54, 24);
			this.rdbDulce.TabIndex = 3;
			this.rdbDulce.TabStop = true;
			this.rdbDulce.Text = "Dulce";
			this.rdbDulce.UseVisualStyleBackColor = false;
			// 
			// rdbSalado
			// 
			this.rdbSalado.BackColor = System.Drawing.Color.Peru;
			this.rdbSalado.Location = new System.Drawing.Point(437, 130);
			this.rdbSalado.Name = "rdbSalado";
			this.rdbSalado.Size = new System.Drawing.Size(59, 24);
			this.rdbSalado.TabIndex = 4;
			this.rdbSalado.TabStop = true;
			this.rdbSalado.Text = "Salado";
			this.rdbSalado.UseVisualStyleBackColor = false;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(12, 166);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(162, 22);
			this.label2.TabIndex = 5;
			this.label2.Text = "Selecciona Producto: ";
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(180, 165);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(168, 21);
			this.comboBox1.TabIndex = 7;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(392, 168);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(44, 23);
			this.label3.TabIndex = 8;
			this.label3.Text = "Precio";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(497, 168);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(52, 23);
			this.label4.TabIndex = 9;
			this.label4.Text = "Cantidad";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(623, 168);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(40, 23);
			this.label5.TabIndex = 10;
			this.label5.Text = "Total";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(358, 189);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(100, 20);
			this.textBox1.TabIndex = 11;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(471, 189);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(100, 20);
			this.textBox2.TabIndex = 12;
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(589, 189);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(100, 20);
			this.textBox3.TabIndex = 13;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.Peru;
			this.button1.Location = new System.Drawing.Point(713, 163);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(123, 23);
			this.button1.TabIndex = 14;
			this.button1.Text = "Agregar producto";
			this.button1.UseVisualStyleBackColor = false;
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.Peru;
			this.button2.Location = new System.Drawing.Point(713, 192);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(123, 23);
			this.button2.TabIndex = 15;
			this.button2.Text = "Eliminar producto";
			this.button2.UseVisualStyleBackColor = false;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.PeachPuff;
			this.ClientSize = new System.Drawing.Size(875, 382);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.rdbSalado);
			this.Controls.Add(this.rdbDulce);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.pictureBox2);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "MainForm";
			this.Text = "Proyecto26";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.RadioButton rdbSalado;
		private System.Windows.Forms.RadioButton rdbDulce;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label1;
	}
}
