
namespace Csharp_2021_WiederholungDerGrundlagen
{
	partial class Form1
	{
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Verwendete Ressourcen bereinigen.
		/// </summary>
		/// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Vom Windows Form-Designer generierter Code

		/// <summary>
		/// Erforderliche Methode für die Designerunterstützung.
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
		/// </summary>
		private void InitializeComponent()
		{
			this.btnOperatoren = new System.Windows.Forms.Button();
			this.btnSchleifen = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnOperatoren
			// 
			this.btnOperatoren.Location = new System.Drawing.Point(12, 12);
			this.btnOperatoren.Name = "btnOperatoren";
			this.btnOperatoren.Size = new System.Drawing.Size(75, 23);
			this.btnOperatoren.TabIndex = 0;
			this.btnOperatoren.Text = "Operatoren";
			this.btnOperatoren.UseVisualStyleBackColor = true;
			this.btnOperatoren.Click += new System.EventHandler(this.btnOperatoren_Click);
			// 
			// btnSchleifen
			// 
			this.btnSchleifen.Location = new System.Drawing.Point(12, 41);
			this.btnSchleifen.Name = "btnSchleifen";
			this.btnSchleifen.Size = new System.Drawing.Size(75, 23);
			this.btnSchleifen.TabIndex = 1;
			this.btnSchleifen.Text = "Schleifen";
			this.btnSchleifen.UseVisualStyleBackColor = true;
			this.btnSchleifen.Click += new System.EventHandler(this.btnSchleifen_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnSchleifen);
			this.Controls.Add(this.btnOperatoren);
			this.Name = "Form1";
			this.Text = "Wiederholung der Grundlagen";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnOperatoren;
		private System.Windows.Forms.Button btnSchleifen;
	}
}

