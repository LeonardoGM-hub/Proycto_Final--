/*
 * Creado por SharpDevelop.
 * Usuario: Dell
 * Fecha: 10/12/2025
 * Hora: 01:59 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProyectoFinalChino
{
	/// <summary>
	/// Description of Form2.
	/// </summary>
	public partial class Form2 : Form
	{
		public Form2()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Label3Click(object sender, EventArgs e)
		{
			
		}
		
		void BtnRegresarClick(object sender, EventArgs e)
		{
			Form1 f = new Form1();
			f.Show();
			this.Close();			
		}
	}
}
