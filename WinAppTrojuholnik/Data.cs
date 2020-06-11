using System;
using System.IO;
using System.Windows.Forms;

namespace WinAppTrojuholnik
{
    class Data
    {

        public void UlozData(RichTextBox dataRichTextBox)
        {
            try
            {
                dataRichTextBox.SaveFile(@"data.txt", RichTextBoxStreamType.PlainText);


            }
            catch
            {
                MessageBox.Show("Chyba");
            }
        }

        public void NacitajData(RichTextBox dataRichTextBox)
        {
            dataRichTextBox.LoadFile(@"data.txt", RichTextBoxStreamType.PlainText);
        }

        public void VymazData(RichTextBox dataRichTextBox)
        {
            if (!(String.IsNullOrEmpty(dataRichTextBox.Text)))
            {

                dataRichTextBox.Clear();
                UlozData(dataRichTextBox);

            }
            else
                MessageBox.Show("Žiadne dáta na vymazanie.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
