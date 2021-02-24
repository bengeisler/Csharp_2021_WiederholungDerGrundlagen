
namespace Csharp_2021_WiederholungDerGrundlagen
{
	partial class FormMöbelstückHinzufügen
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.btnSpeichern = new System.Windows.Forms.Button();
			this.txtBezeichnung = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtPreis = new System.Windows.Forms.TextBox();
			this.txtFarbe = new System.Windows.Forms.TextBox();
			this.btnAbbrechen = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(13, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(72, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Bezeichnung:";
			// 
			// btnSpeichern
			// 
			this.btnSpeichern.Location = new System.Drawing.Point(16, 106);
			this.btnSpeichern.Name = "btnSpeichern";
			this.btnSpeichern.Size = new System.Drawing.Size(75, 23);
			this.btnSpeichern.TabIndex = 1;
			this.btnSpeichern.Text = "Speichern";
			this.btnSpeichern.UseVisualStyleBackColor = true;
			this.btnSpeichern.Click += new System.EventHandler(this.btnSpeichern_Click);
			// 
			// txtBezeichnung
			// 
			this.txtBezeichnung.Location = new System.Drawing.Point(107, 10);
			this.txtBezeichnung.Name = "txtBezeichnung";
			this.txtBezeichnung.Size = new System.Drawing.Size(159, 20);
			this.txtBezeichnung.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(13, 71);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(37, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Farbe:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(13, 42);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(33, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "Preis:";
			// 
			// txtPreis
			// 
			this.txtPreis.Location = new System.Drawing.Point(107, 39);
			this.txtPreis.Name = "txtPreis";
			this.txtPreis.Size = new System.Drawing.Size(159, 20);
			this.txtPreis.TabIndex = 5;
			// 
			// txtFarbe
			// 
			this.txtFarbe.Location = new System.Drawing.Point(107, 68);
			this.txtFarbe.Name = "txtFarbe";
			this.txtFarbe.Size = new System.Drawing.Size(159, 20);
			this.txtFarbe.TabIndex = 6;
			// 
			// btnAbbrechen
			// 
			this.btnAbbrechen.Location = new System.Drawing.Point(191, 106);
			this.btnAbbrechen.Name = "btnAbbrechen";
			this.btnAbbrechen.Size = new System.Drawing.Size(75, 23);
			this.btnAbbrechen.TabIndex = 7;
			this.btnAbbrechen.Text = "Abbrechen";
			this.btnAbbrechen.UseVisualStyleBackColor = true;
			this.btnAbbrechen.Click += new System.EventHandler(this.btnAbbrechen_Click);
			// 
			// FormMöbelstückHinzufügen
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(283, 146);
			this.Controls.Add(this.btnAbbrechen);
			this.Controls.Add(this.txtFarbe);
			this.Controls.Add(this.txtPreis);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtBezeichnung);
			this.Controls.Add(this.btnSpeichern);
			this.Controls.Add(this.label1);
			this.Name = "FormMöbelstückHinzufügen";
			this.Text = "Möbelstück hinzufügen";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnSpeichern;
		private System.Windows.Forms.TextBox txtBezeichnung;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtPreis;
		private System.Windows.Forms.TextBox txtFarbe;
		private System.Windows.Forms.Button btnAbbrechen;
	}
}