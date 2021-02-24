using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csharp_2021_WiederholungDerGrundlagen
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		// Aufgabe "Operatoren"
		private void btnOperatoren_Click(object sender, EventArgs e)
		{
			// 1.
			int i = 0;						// Lokale Variable vom Datentyp "int" erstellen
			i++;									// ++ Operator: Variable um 1 erhöhen. 
			Console.WriteLine(i); // Variable in der Konsole ausgeben. Kürzel für Code-Snippet: cw

			// 2.
			i += 3;               // Variable um 3 erhöhen. Alternativschreibweise: i = i + 3;
			Console.WriteLine(i);

			// 3.
			i *= 3;               // Variable mit 3 multiplizieren. Alternativschreibweise: i = i * 3;
			Console.WriteLine(i);

			// 4.
			double erhöhungInProzent = i * 0.2;		// Erhöhung um 20% berechnen (Datentyp double)
			i += (int)erhöhungInProzent;					// Diese Erhöhung zu i hinzuzählen, dabei double in int wandeln
			Console.WriteLine(i);						

			// 5.
			int ergebnis = i / 4;		// Ergebnis der Division berechnen
			int rest = i % 4;				// Mit dem Modulo-Operator den Rest der Division berechnen
			Console.WriteLine($"Ergebnis: {ergebnis}, Rest: {rest}");

			// 6.
			Console.WriteLine("Der aktuelle Wert der Zahl beträgt: " + ergebnis);

			// 7.
			string k = "Mein Text";
			Console.WriteLine(k);

			// 8.
			k += " ist kurz.";    // Text anhängen
			Console.WriteLine(k);

		}
	}
}
