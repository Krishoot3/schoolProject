using System;
using System.Collections.Generic;

using System.IO;
using System.Windows.Forms;

namespace WinAppTrojuholnik
{
    
    class Trojuholnik
    {
        private List<object> vlasTroj = new List<object>();
        

        public void EnableGroupBox(GroupBox SssGroupBox, GroupBox SsuGroupBox, RadioButton SssRadioButton, RadioButton SsuRadioButton)
        {
            if (SssRadioButton.Checked)
            {
                SssGroupBox.Enabled = true;
                SsuGroupBox.Enabled = false;
            }
            else if (SsuRadioButton.Checked)
            {
                SsuGroupBox.Enabled = true;
                SssGroupBox.Enabled = false;
            }
        }

        public double StranaTroju(int strA, int strB, int uhol, ComboBox uholComboBox, RichTextBox dataRichTextBox)
        {
            double vysledok = 0;
            if (uholComboBox.SelectedIndex == 0)
            {
                // a^2 = b^2 + c^2 - 2bc * cosAlfa
                dataRichTextBox.AppendText("a^2 = b^2 + c^2 - 2bc * cosAlfa" + Environment.NewLine);
                dataRichTextBox.AppendText(strA + "^2 = " + strB + "^2 + c^2 - 2 * " + strB + "c * cos" + uhol + Environment.NewLine);

                double ax = 1;
                double bx = -2 * strB * Math.Cos(uhol * (Math.PI / 180.0));
                double cx = Math.Pow(strB, 2) - Math.Pow(strA, 2);
                dataRichTextBox.AppendText("c^2 +(" + Math.Round(bx, 3) + "c) + (" + cx + ")\n");

                double d = Math.Pow(bx, 2) - (4 * ax * cx);
                dataRichTextBox.AppendText("D = bx^2 - 4 * ax * cx = " + Math.Round(bx, 3) + "^2 - 4 * " + ax + " * " + cx + " = " + Math.Round(d, 3) + Environment.NewLine);

                if (d >= 0)
                {
                    double x1 = (-bx + (Math.Sqrt(d))) / (2 * ax);
                    dataRichTextBox.AppendText("x1 = [-(" + Math.Round(bx, 3) + ") + √" + Math.Round(d, 3) + "] / (2 * " + ax + ") = " + Math.Round(x1, 3) + Environment.NewLine);

                    double x2 = (-bx - (Math.Sqrt(d))) / (2 * ax);
                    dataRichTextBox.AppendText("x2 = [-(" + Math.Round(bx, 3) + ") - √" + Math.Round(d, 3) + "] / (2 * " + ax + ") = " + Math.Round(x2, 3) + Environment.NewLine + "\n");

                    if (x1 > x2) vysledok = x1;
                    else
                        vysledok = x2;

                }

                return vysledok;

            }
            else if (uholComboBox.SelectedIndex == 1)
            {
                // b^2 = a^2 + c^2 - 2ac * cosBeta
                dataRichTextBox.AppendText("b^2 = a^2 + c^2 - 2ac * cosBeta" + Environment.NewLine);
                dataRichTextBox.AppendText(strB + "^2 = " + strA + "^2 + c^2 - 2 * " + strA + "c * cos" + uhol + Environment.NewLine + "\n");

                double ax = 1;
                double bx = -2 * strA * Math.Cos(uhol * (Math.PI / 180.0));
                double cx = Math.Pow(strA, 2) - Math.Pow(strB, 2);
                dataRichTextBox.AppendText("c^2 +(" + Math.Round(bx, 3) + "c) + (" + cx + ")\n");

                double d = Math.Pow(bx, 2) - (4 * ax * cx);
                dataRichTextBox.AppendText("D = bx^2 - 4 * ax * cx = " + Math.Round(bx, 3) + "^2 - 4 * " + ax + " * " + cx + " = " + Math.Round(d, 3) + Environment.NewLine);

                if (d >= 0)
                {
                    double x1 = (-bx + (Math.Sqrt(d))) / (2 * ax);
                    dataRichTextBox.AppendText("x1 = [-(" + Math.Round(bx, 3) + ") + √" + Math.Round(d, 3) + "] / (2 * " + ax + ") = " + Math.Round(x1, 3) + Environment.NewLine);

                    double x2 = (-bx - (Math.Sqrt(d))) / (2 * ax);
                    dataRichTextBox.AppendText("x2 = [-(" + Math.Round(bx, 3) + ") - √" + Math.Round(d, 3) + "] / (2 * " + ax + ") = " + Math.Round(x2, 3) + Environment.NewLine + "\n");

                    if (x1 > x2) vysledok = x1;
                    else
                        vysledok = x2;

                }
                return vysledok;

            }
            else
                // c = Sqrt(a^2 + b^2 - 2ab * cosGama)
                vysledok = Math.Sqrt(Math.Pow(strA, 2) + Math.Pow(strB, 2) - 2 * strA * strB * Math.Cos(uhol * (Math.PI / 180.0)));
                dataRichTextBox.AppendText("c^2 = a^2 + b^2 - 2ab * cosGama" + Environment.NewLine);
                dataRichTextBox.AppendText("c = √[" + strA + "^2 + " + strB + "^2 - 2 * " + strA + " * " + strB + " cos" + uhol + "] = " + Math.Round(vysledok, 3) + Environment.NewLine + "\n");
                return vysledok;

            
        }

        public void Zostrojitelnost(int a, int b, double c, SaveFileDialog trojuSaveFileDialog, RichTextBox dataRichTextBox)
        {

            if ((a + b > c) && (b + c > a) && (c + a > b))
            {
                    vlasTroj.Add("zostrojitelný");

                    vlasTroj.Add(TypTroj(a, b, c));

                    vlasTroj.Add(Math.Round(Obvod(a, b, c)));
                    dataRichTextBox.AppendText("O = " + a + " + " + b + " + " + Math.Round(c, 3) + " = " + Math.Round(Obvod(a, b, c), 3) + Environment.NewLine);

                    vlasTroj.Add(Math.Round(Obsah(a, b, c, Obvod(a, b, c)), 3));
                    double s = Math.Round((Obvod(a, b, c) / 2), 3);
                    dataRichTextBox.AppendText("s = O / 2 = " + Math.Round(Obvod(a, b, c), 3) + "/ 2 = " + s + Environment.NewLine);

                    dataRichTextBox.AppendText("S = √[s * (s - a) * (s - b) * (s - c)]" + Environment.NewLine);
                    dataRichTextBox.AppendText("S = √[" + s + "* (" + s + " - " + a + ") * (" + s + " - " + b + ") * (" + s + " - " + Math.Round(c, 3) + ")] = " + Math.Round(Obsah(a, b, c, Obvod(a, b, c)), 3) + Environment.NewLine + "\n");

                    vlasTroj.Add(a); vlasTroj.Add(b); vlasTroj.Add(Math.Round(c, 3));

                    DialogResult dialogResult = MessageBox.Show("Prajete si uložiť, vypočítané hodnoty do súboru?", "Ulož", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogResult == DialogResult.Yes)
                {

                    UlozButt(trojuSaveFileDialog);
                    vlasTroj.Clear();
                }
                else
                {
                    vlasTroj.Clear();
                }
                   
              }
              else
                MessageBox.Show("Trojuholník nie je zostrojitelný", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
        }

        private string TypTroj(int a, int b, double c)
        {
            string typ = String.Empty;

            if (a == b && b == c && c == a)
            {
                return "rovnostranný";
            }
            else if (Math.Pow(a, 2) == (Math.Pow(c, 2) + Math.Pow(b, 2)))
            {
                return "pravouhlý";
            }
            else if (a == b || b == c || c == a )
            {
                return "rovnoramenný";
            }
            else
                return "rôznostranný";
        }


        private double Obvod(int a, int b, double c)
        {
            return a + b + c;
        }

        private double Obsah(int a, int b, double c, double obvod)
        {
            double s = obvod / 2;
            

            return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
        }

        private void Uloz(string cesta)
        {
            
                using (StreamWriter sw = new StreamWriter(cesta))
                {

                    sw.WriteLine(string.Format("Trojuholník je {0} a {1}.", vlasTroj[0], vlasTroj[1]));

                    sw.WriteLine(string.Format("Obvod trojuhlníka je {0} a obsah je {1}.", vlasTroj[2], vlasTroj[3]));

                    sw.WriteLine(string.Format("Strana a = {0} b = {1} c = {2}.", vlasTroj[4], vlasTroj[5], vlasTroj[6]));

                    sw.Flush();
            }


        }

        public void UlozButt(SaveFileDialog trojuSaveFileDialog)
        {
           
                DialogResult vysledok = trojuSaveFileDialog.ShowDialog();
                if (vysledok == DialogResult.OK)
                {
                    try
                    {
                        Uloz(trojuSaveFileDialog.FileName);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Súbor sa nepodarilo uložiť.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
          
        }
    }
}
