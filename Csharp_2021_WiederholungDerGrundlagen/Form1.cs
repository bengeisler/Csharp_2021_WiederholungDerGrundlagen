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

		private void btnSchleifen_Click(object sender, EventArgs e)
		{
			// 1.a
			Console.WriteLine("1a");
			// Start bei 1, damit die Nummer des Durchlaufs auch korrekt bei 1 beginnt
			for (int i = 1; i < 6; i++)		// Code-Snippen für for-Schleife: for
			{
				Console.WriteLine("Durchlauf: " + i);
			}

			// 1.b
			Console.WriteLine("1b");
			for (int i = 5; i < 10; i++)
			{
				Console.WriteLine("Durchlauf: " + i);
			}

			// 1.c
			Console.WriteLine("1c");
			// Diese Schleife wird 6 mal ausgeführt, da der Schleifenzähler bei 0
			// startet und bis einschließlich 5 läuft
			int durchlaufZähler = 0;
			for (int i = 0; i <= 5; i++)
			{
				durchlaufZähler++;
			}
			Console.WriteLine($"Diese Schleife wurde {durchlaufZähler} mal durchlaufen");
		}
	}
}
