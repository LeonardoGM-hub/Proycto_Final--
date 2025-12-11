/*
 * Creado por SharpDevelop.
 * Usuario: Dell
 * Fecha: 10/12/2025
 * Hora: 01:59 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace ProyectoFinalChino
{
	partial class Form2
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
			this.lblTitulo = new System.Windows.Forms.Label();
			this.lblTitulo2 = new System.Windows.Forms.Label();
			this.lblAutores = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.btnRegresar = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// lblTitulo
			// 
			this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
			this.lblTitulo.Font = new System.Drawing.Font("Bernard MT Condensed", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitulo.ForeColor = System.Drawing.SystemColors.ButtonShadow;
			this.lblTitulo.Location = new System.Drawing.Point(12, 9);
			this.lblTitulo.Name = "lblTitulo";
			this.lblTitulo.Size = new System.Drawing.Size(242, 49);
			this.lblTitulo.TabIndex = 0;
			this.lblTitulo.Text = "Acerca de...";
			// 
			// lblTitulo2
			// 
			this.lblTitulo2.BackColor = System.Drawing.Color.Transparent;
			this.lblTitulo2.Font = new System.Drawing.Font("Elephant", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitulo2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.lblTitulo2.Location = new System.Drawing.Point(42, 109);
			this.lblTitulo2.Name = "lblTitulo2";
			this.lblTitulo2.Size = new System.Drawing.Size(602, 55);
			this.lblTitulo2.TabIndex = 1;
			this.lblTitulo2.Text = "Gracias por confiar en nosotros!";
			// 
			// lblAutores
			// 
			this.lblAutores.BackColor = System.Drawing.Color.Transparent;
			this.lblAutores.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblAutores.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.lblAutores.Location = new System.Drawing.Point(54, 179);
			this.lblAutores.Name = "lblAutores";
			this.lblAutores.Size = new System.Drawing.Size(125, 24);
			this.lblAutores.TabIndex = 3;
			this.lblAutores.Text = "Autores:";
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label2.Location = new System.Drawing.Point(42, 251);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(376, 24);
			this.label2.TabIndex = 4;
			this.label2.Text = "JOSUE FRANCISCO ZAMUDIO JURADO";
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label3.Location = new System.Drawing.Point(42, 323);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(407, 33);
			this.label3.TabIndex = 5;
			this.label3.Text = "LEONARDO GAVIÑA MORALES";
			this.label3.Click += new System.EventHandler(this.Label3Click);
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label4.Location = new System.Drawing.Point(42, 399);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(441, 31);
			this.label4.TabIndex = 6;
			this.label4.Text = "ITZEL XIMENA CHACON AVILES";
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.Font = new System.Drawing.Font("Agency FB", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label5.Location = new System.Drawing.Point(12, 522);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(387, 51);
			this.label5.TabIndex = 7;
			this.label5.Text = "No nos hacemos responsables del filtramiento de informacion confidencial de los u" +
			"susarios gracias por su comprension :)";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(514, 377);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(173, 193);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 8;
			this.pictureBox1.TabStop = false;
			// 
			// btnRegresar
			// 
			this.btnRegresar.BackColor = System.Drawing.Color.Black;
			this.btnRegresar.Font = new System.Drawing.Font("Baskerville Old Face", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRegresar.ForeColor = System.Drawing.SystemColors.Control;
			this.btnRegresar.Location = new System.Drawing.Point(523, 515);
			this.btnRegresar.Name = "btnRegresar";
			this.btnRegresar.Size = new System.Drawing.Size(164, 55);
			this.btnRegresar.TabIndex = 10;
			this.btnRegresar.Text = "Regresar";
			this.btnRegresar.UseVisualStyleBackColor = false;
			this.btnRegresar.Click += new System.EventHandler(this.BtnRegresarClick);
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(699, 582);
			this.Controls.Add(this.btnRegresar);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.lblAutores);
			this.Controls.Add(this.lblTitulo2);
			this.Controls.Add(this.lblTitulo);
			this.Name = "Form2";
			this.Text = "Form2";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button btnRegresar;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lblAutores;
		private System.Windows.Forms.Label lblTitulo2;
		private System.Windows.Forms.Label lblTitulo;
	}
}
