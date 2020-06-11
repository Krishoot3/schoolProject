using System;
using System.Windows.Forms;

namespace WinAppTrojuholnik
{
    public partial class TrojuholForm : Form
    {
        private Trojuholnik trojuholnik = new Trojuholnik();
        private Data data = new Data();
        
        public TrojuholForm()
        {
            InitializeComponent();
            SsuGroupBox.Enabled = false;
            uholComboBox.SelectedIndex = 0;
            data.NacitajData(dataRichTextBox);

        }

        private void SssRadioButton_CheckedChanged(object sender, EventArgs e)
        {
           trojuholnik.EnableGroupBox(SssGroupBox, SsuGroupBox, SssRadioButton, SsuRadioButton);
        }

        private void uholPocitajbutton_Click(object sender, EventArgs e)
        {
            int strA = Convert.ToInt32(strA2numericUpDown.Value);
            int strB = Convert.ToInt32(strB2numericUpDown.Value);
            int uhol = Convert.ToInt32(uholNumericUpDown.Value);

            double strC = trojuholnik.StranaTroju(strA, strB, uhol, uholComboBox, dataRichTextBox);

            trojuholnik.Zostrojitelnost(strA, strB, strC, trojuSaveFileDialog, dataRichTextBox);

        }

        private void stranaPocitajButton_Click(object sender, EventArgs e)
        {
            int strA = Convert.ToInt32(strAnumericUpDown.Value);
            int strB = Convert.ToInt32(strBnumericUpDown.Value);
            int strC = Convert.ToInt32(strCnumericUpDown.Value);

            trojuholnik.Zostrojitelnost(strA, strB, strC, trojuSaveFileDialog, dataRichTextBox);

        }

        private void TrojuholForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            data.UlozData(dataRichTextBox);
            Application.Exit();
        }

        private void VymazButton_Click(object sender, EventArgs e)
        {
            data.VymazData(dataRichTextBox);

        }
    }
}
