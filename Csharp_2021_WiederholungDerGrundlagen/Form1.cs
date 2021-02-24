using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Csharp_2021_WiederholungDerGrundlagen
{
	public partial class Form1 : Form
	{
		// Dateizugriff, Aufgabe 4: Globale Variable, 
		// um die Anzahl der Speichervorgänge zu speichern
		int ZählerDateiSpeichern;
		public Form1()
		{
			InitializeComponent();
		}

		/* ---------------------------------------------------------------
		 * 
		 *							O P E R A T O R E N
		 *
		 * ---------------------------------------------------------------
		 */
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

		/* ---------------------------------------------------------------
		 * 
		 *							S C H L E I F E N
		 *
		 * ---------------------------------------------------------------
		 */
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

		/* ---------------------------------------------------------------
		 * 
		 *							D A T E I Z U G R I F F
		 *
		 * ---------------------------------------------------------------
		 */
		// Beim Dateizugriff nicht vergessen: using System.IO; 
		// Generell sollten Dateizugriffe immer innerhalb eines try-catch-Blocks erfolgen.
		// Das wird der Einfachheit halber hier allerdings weggelassen.
		private void btnDateiEinlesen_Click(object sender, EventArgs e)
		{
			// 1. 
			var ofd = new OpenFileDialog()
			{
				InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
				Filter = "Textdateien (*.txt)|*.txt",
				Title = "Datei öffnen"
			};

			// OpenFileDialog anzeigen
			// Ergebnis auswerten: Falls nicht auf "Öffnen" geklickt wurde, wird 
			// diese Funktion hier mittels "return" verlassen
			if (ofd.ShowDialog() != DialogResult.OK) return;

			// 2.
			// Hier gibt es verschiedene Möglichkeiten

			// Möglichkeit 1
			Console.WriteLine("Aufgabe 2, Möglichkeit 1:");
			string[] zeilenInDatei = File.ReadAllLines(ofd.FileName);						// Alle Zeilen der Datei in ein String-Array einlesen
			Console.WriteLine($"Die Datei hat {zeilenInDatei.Length} Zeilen");  // Größe des Arrays ausgeben => Entspricht Anzahl der Zeilen

			// Möglichkeit 2
			Console.WriteLine("Aufgabe 2, Möglichkeit 2:");
			var sr = new StreamReader(ofd.FileName);						// Objekt der Klasse StreamReader erstellen, um Datei einzulesen
			int zeilenanzahl = 0;																// Variable zum Zählen der Zeilen
			while (!sr.EndOfStream)															// Alle Zeilen einlesen. Alternative: sr.Peek() != -1
			{
				sr.ReadLine();			// Zeile einlesen
				zeilenanzahl++;			// Zeilenzähler erhöhen
			}
			Console.WriteLine($"Die Datei hat {zeilenanzahl} Zeilen");

			// 3.
			// Auch hier gibt es wieder verschiedene Möglichkeiten

			// Möglichkeit 1:
			lstListe.Items.Clear();																			// ListBox leeren
			string[] zeilenDerDatei = File.ReadAllLines(ofd.FileName);	// Alle Zeilen der Datei in ein String-Array einlesen
			foreach (var zeile in zeilenDerDatei)												// Alle Einträge dieses Arrays der Listbox hinzufügen
				lstListe.Items.Add(zeile);

			MessageBox.Show("Das war Aufgabe 3, Möglichkeit 1");

			// Möglichkeit 2:
			lstListe.Items.Clear();                               // ListBox leeren
			var sr2 = new StreamReader(ofd.FileName);							// Objekt der Klasse StreamReader erstellen, um Datei einzulesen
			while (!sr2.EndOfStream)															// Alle Zeilen einlesen. Alternative: sr.Peek() != -1
				lstListe.Items.Add(sr2.ReadLine());                 // Zeile einlesen und der ListBox hinzufügen

			MessageBox.Show("Das war Aufgabe 3, Möglichkeit 2");

			// Möglichkeit 3:
			lstListe.Items.Clear();                                     // ListBox leeren
			lstListe.Items.AddRange(File.ReadAllLines(ofd.FileName));   // Alle Zeilen der Datei einlesen und als Range der Listbox hinzufügen

			MessageBox.Show("Das war Aufgabe 3, Möglichkeit 3");
		}

		private void btnDateiSpeichern_Click(object sender, EventArgs e)
		{
			// 4.
			// => Ganz oben globale Variable anlegen
			var sfd = new SaveFileDialog()
			{
				InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
				Filter = "Textdateien (*.txt)|*.txt",
				Title = "Datei speichern",
				FileName = "MeineListe_" + ZählerDateiSpeichern + ".txt"
			};

			// SaveFileDialog anzeigen
			// Abbruch, falls nicht "Speichern" ausgewählt wurde
			if (sfd.ShowDialog() != DialogResult.OK) return;

			// 5.
			// Hier gibt es mehrere Möglichkeiten 
			// => Bitte Möglichkeiten selbst einkommentieren und testen

			// 1. Möglichkeit

			//foreach (var item in lstListe.Items)              // Jeder Eintrag der ListBox wird an die Datei angehängt
			//	File.AppendAllText(sfd.FileName, item + "\n");  // Das bedeutet aber auch: Falls diese Datei schon existiert, bleibt
			//																									// der bestehende Inhalt erhalten

			// 2. Möglichkeit

			//var sw = new StreamWriter(sfd.FileName, false);   // Pfad aus SaveFileDialog übernehmen
			//																									// false: Datei überschreiben / true: neuen Inhalt anhängen
			//foreach (var item in lstListe.Items)							// Alle Einträge der ListBox in die Datei schreiben
			//{
			//	sw.WriteLine(item);
			//}
			//sw.Close();																				// Am Ende den StreamWriter wieder schließen
			

			// 3. Möglichkeit

			File.WriteAllLines(sfd.FileName, lstListe.Items.OfType<string>().ToArray());



			// Für jeden Speichervorgang den Zähler um 1 erhöhen
			ZählerDateiSpeichern++;
		}

		/* ---------------------------------------------------------------
		 * 
		 *								D A T U M   &   U H R Z E I T
		 *
		 * ---------------------------------------------------------------
		 */
		private void btnDatumUndUhrzeit_Click(object sender, EventArgs e)
		{
			// 1. 
			Console.WriteLine(DateTime.Now);

			// 2.
			Console.WriteLine(DateTime.Now.ToShortDateString());

			// 3.
			Console.WriteLine(DateTime.Now.ToShortTimeString());
		}

		/* ---------------------------------------------------------------
		 * 
		 *				S T R I N G - F O R M A T T I E R U N G
		 *
		 * ---------------------------------------------------------------
		 */
		private void btnStringFormattierung_Click(object sender, EventArgs e)
		{
			// 1.
			double zahl = 12345.6789;

			// 2.
			Console.WriteLine($"Ausgabe ohne Nachkommastelle: {zahl:#}");

			// 3.
			Console.WriteLine($"Ausgabe mit zwei Nachkommastellen: {zahl:#.00}");

			// 4. 
			Console.WriteLine($"Ausgabe mit Tausender-Trennzeichen: {zahl:#,#} (ohne Nachkommastellen)");				 // ohne Nachkommastellen
			Console.WriteLine($"Ausgabe mit Tausender-Trennzeichen: {zahl:#,#.####} (mit Nachkommastellen)");    // mit Nachkommastellen

			// 5. 
			Console.WriteLine($"Ausgabe als Währung: {zahl:C}");

			// 6.
			Console.WriteLine($"Ausgabe linksbündig mit Breite von 20 : ->{zahl,-20}<-");

			// 7.
			Console.WriteLine($"Ausgabe rechtsbündig mit Breite von 20: ->{zahl,20}<-");
		}

		/* ---------------------------------------------------------------
		 * 
		 *							F E H L E R B E H A N D L U N G
		 *
		 * ---------------------------------------------------------------
		 */
		// 1. => Siehe Form
		private void txtFehlerbehandung_KeyDown(object sender, KeyEventArgs e)
		{
			// 2.
			if (e.KeyCode == Keys.Enter)		// Abfragen, ob Enter-Taste gedrückt wurde
			{
				try
				{
					// a.
					if (txtFehlerbehandung.Text == "") 
						throw new ArgumentException("Die Eingabe darf nicht leer sein!");

					// b.
					if (txtFehlerbehandung.Text.Length < 3) 
						throw new ArgumentException("Es müssen mindestens drei Zeichen eingegeben werden!");

					// c.
					if (!int.TryParse(txtFehlerbehandung.Text, out int eingabe)) 
						throw new ArgumentException("Bitte eine Ganzzahl eingeben!");

					// d.
					if (eingabe < 0)
						throw new ArgumentException("Die Eingabe muss > 0 sein!");

					// e. (Erfolgsfall)
					Console.WriteLine("Folgendes wurde in die Textbox eingegben: " + txtFehlerbehandung.Text);
				}
				catch (Exception ex)
				{
					// e. (Fehlerfall)
					MessageBox.Show(ex.Message);
				}
			}
		}
	}
}
