
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnDateiEinlesen = new System.Windows.Forms.Button();
			this.lstListe = new System.Windows.Forms.ListBox();
			this.btnDateiSpeichern = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
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
			this.btnSchleifen.Location = new System.Drawing.Point(93, 12);
			this.btnSchleifen.Name = "btnSchleifen";
			this.btnSchleifen.Size = new System.Drawing.Size(75, 23);
			this.btnSchleifen.TabIndex = 1;
			this.btnSchleifen.Text = "Schleifen";
			this.btnSchleifen.UseVisualStyleBackColor = true;
			this.btnSchleifen.Click += new System.EventHandler(this.btnSchleifen_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnDateiSpeichern);
			this.groupBox1.Controls.Add(this.lstListe);
			this.groupBox1.Controls.Add(this.btnDateiEinlesen);
			this.groupBox1.Location = new System.Drawing.Point(12, 54);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(253, 210);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Dateizugriff";
			// 
			// btnDateiEinlesen
			// 
			this.btnDateiEinlesen.Location = new System.Drawing.Point(62, 19);
			this.btnDateiEinlesen.Name = "btnDateiEinlesen";
			this.btnDateiEinlesen.Size = new System.Drawing.Size(110, 23);
			this.btnDateiEinlesen.TabIndex = 3;
			this.btnDateiEinlesen.Text = "Datei einlesen";
			this.btnDateiEinlesen.UseVisualStyleBackColor = true;
			this.btnDateiEinlesen.Click += new System.EventHandler(this.btnDateiEinlesen_Click);
			// 
			// lstListe
			// 
			this.lstListe.FormattingEnabled = true;
			this.lstListe.Location = new System.Drawing.Point(6, 48);
			this.lstListe.Name = "lstListe";
			this.lstListe.Size = new System.Drawing.Size(241, 121);
			this.lstListe.TabIndex = 4;
			// 
			// btnDateiSpeichern
			// 
			this.btnDateiSpeichern.Location = new System.Drawing.Point(62, 175);
			this.btnDateiSpeichern.Name = "btnDateiSpeichern";
			this.btnDateiSpeichern.Size = new System.Drawing.Size(110, 23);
			this.btnDateiSpeichern.TabIndex = 5;
			this.btnDateiSpeichern.Text = "Datei speichern";
			this.btnDateiSpeichern.UseVisualStyleBackColor = true;
			this.btnDateiSpeichern.Click += new System.EventHandler(this.btnDateiSpeichern_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btnSchleifen);
			this.Controls.Add(this.btnOperatoren);
			this.Name = "Form1";
			this.Text = "Wiederholung der Grundlagen";
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnOperatoren;
		private System.Windows.Forms.Button btnSchleifen;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnDateiSpeichern;
		private System.Windows.Forms.ListBox lstListe;
		private System.Windows.Forms.Button btnDateiEinlesen;
	}
}

