namespace WinAppTrojuholnik
{
    partial class TrojuholForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrojuholForm));
            this.SssRadioButton = new System.Windows.Forms.RadioButton();
            this.SsuRadioButton = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SssGroupBox = new System.Windows.Forms.GroupBox();
            this.stranaPocitajButton = new System.Windows.Forms.Button();
            this.strCnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.strBnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.strAnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SsuGroupBox = new System.Windows.Forms.GroupBox();
            this.uholPocitajbutton = new System.Windows.Forms.Button();
            this.uholComboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.strB2numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.strA2numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.uholNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.trojuSaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataRichTextBox = new System.Windows.Forms.RichTextBox();
            this.VymazButton = new System.Windows.Forms.Button();
            this.SssGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.strCnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.strBnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.strAnumericUpDown)).BeginInit();
            this.SsuGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.strB2numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.strA2numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uholNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // SssRadioButton
            // 
            this.SssRadioButton.AutoSize = true;
            this.SssRadioButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.SssRadioButton.Checked = true;
            this.SssRadioButton.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SssRadioButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.SssRadioButton.Location = new System.Drawing.Point(142, 79);
            this.SssRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.SssRadioButton.Name = "SssRadioButton";
            this.SssRadioButton.Size = new System.Drawing.Size(38, 19);
            this.SssRadioButton.TabIndex = 0;
            this.SssRadioButton.TabStop = true;
            this.SssRadioButton.Text = "3S";
            this.SssRadioButton.UseVisualStyleBackColor = false;
            this.SssRadioButton.CheckedChanged += new System.EventHandler(this.SssRadioButton_CheckedChanged);
            // 
            // SsuRadioButton
            // 
            this.SsuRadioButton.AutoSize = true;
            this.SsuRadioButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.SsuRadioButton.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SsuRadioButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.SsuRadioButton.Location = new System.Drawing.Point(712, 79);
            this.SsuRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.SsuRadioButton.Name = "SsuRadioButton";
            this.SsuRadioButton.Size = new System.Drawing.Size(53, 19);
            this.SsuRadioButton.TabIndex = 1;
            this.SsuRadioButton.Text = "2S1U";
            this.SsuRadioButton.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(89, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Zadanie troch strán";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(609, 24);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(255, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Zadanie dvoch strán a jedného uhlu";
            // 
            // SssGroupBox
            // 
            this.SssGroupBox.Controls.Add(this.stranaPocitajButton);
            this.SssGroupBox.Controls.Add(this.strCnumericUpDown);
            this.SssGroupBox.Controls.Add(this.strBnumericUpDown);
            this.SssGroupBox.Controls.Add(this.strAnumericUpDown);
            this.SssGroupBox.Controls.Add(this.label5);
            this.SssGroupBox.Controls.Add(this.label3);
            this.SssGroupBox.Controls.Add(this.label4);
            this.SssGroupBox.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SssGroupBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.SssGroupBox.Location = new System.Drawing.Point(27, 127);
            this.SssGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.SssGroupBox.Name = "SssGroupBox";
            this.SssGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.SssGroupBox.Size = new System.Drawing.Size(275, 243);
            this.SssGroupBox.TabIndex = 4;
            this.SssGroupBox.TabStop = false;
            this.SssGroupBox.Text = "Zadaj strany";
            // 
            // stranaPocitajButton
            // 
            this.stranaPocitajButton.BackColor = System.Drawing.Color.SkyBlue;
            this.stranaPocitajButton.FlatAppearance.BorderSize = 0;
            this.stranaPocitajButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stranaPocitajButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.stranaPocitajButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.stranaPocitajButton.Location = new System.Drawing.Point(82, 189);
            this.stranaPocitajButton.Margin = new System.Windows.Forms.Padding(4);
            this.stranaPocitajButton.Name = "stranaPocitajButton";
            this.stranaPocitajButton.Size = new System.Drawing.Size(108, 35);
            this.stranaPocitajButton.TabIndex = 9;
            this.stranaPocitajButton.Text = "POČÍTAJ";
            this.stranaPocitajButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.stranaPocitajButton.UseVisualStyleBackColor = false;
            this.stranaPocitajButton.Click += new System.EventHandler(this.stranaPocitajButton_Click);
            // 
            // strCnumericUpDown
            // 
            this.strCnumericUpDown.Location = new System.Drawing.Point(97, 133);
            this.strCnumericUpDown.Margin = new System.Windows.Forms.Padding(4);
            this.strCnumericUpDown.Name = "strCnumericUpDown";
            this.strCnumericUpDown.Size = new System.Drawing.Size(140, 23);
            this.strCnumericUpDown.TabIndex = 2;
            // 
            // strBnumericUpDown
            // 
            this.strBnumericUpDown.Location = new System.Drawing.Point(97, 85);
            this.strBnumericUpDown.Margin = new System.Windows.Forms.Padding(4);
            this.strBnumericUpDown.Name = "strBnumericUpDown";
            this.strBnumericUpDown.Size = new System.Drawing.Size(140, 23);
            this.strBnumericUpDown.TabIndex = 1;
            // 
            // strAnumericUpDown
            // 
            this.strAnumericUpDown.Location = new System.Drawing.Point(97, 41);
            this.strAnumericUpDown.Margin = new System.Windows.Forms.Padding(4);
            this.strAnumericUpDown.Name = "strAnumericUpDown";
            this.strAnumericUpDown.Size = new System.Drawing.Size(140, 23);
            this.strAnumericUpDown.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 135);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Strana c:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 43);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Strana a:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 87);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Strana b:";
            // 
            // SsuGroupBox
            // 
            this.SsuGroupBox.Controls.Add(this.uholPocitajbutton);
            this.SsuGroupBox.Controls.Add(this.uholComboBox);
            this.SsuGroupBox.Controls.Add(this.label7);
            this.SsuGroupBox.Controls.Add(this.strB2numericUpDown);
            this.SsuGroupBox.Controls.Add(this.label8);
            this.SsuGroupBox.Controls.Add(this.strA2numericUpDown);
            this.SsuGroupBox.Controls.Add(this.uholNumericUpDown);
            this.SsuGroupBox.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SsuGroupBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.SsuGroupBox.Location = new System.Drawing.Point(602, 127);
            this.SsuGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.SsuGroupBox.Name = "SsuGroupBox";
            this.SsuGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.SsuGroupBox.Size = new System.Drawing.Size(275, 243);
            this.SsuGroupBox.TabIndex = 5;
            this.SsuGroupBox.TabStop = false;
            this.SsuGroupBox.Text = "Zadaj strany a uhol";
            // 
            // uholPocitajbutton
            // 
            this.uholPocitajbutton.BackColor = System.Drawing.Color.SkyBlue;
            this.uholPocitajbutton.FlatAppearance.BorderSize = 0;
            this.uholPocitajbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uholPocitajbutton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uholPocitajbutton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.uholPocitajbutton.Location = new System.Drawing.Point(87, 189);
            this.uholPocitajbutton.Margin = new System.Windows.Forms.Padding(4);
            this.uholPocitajbutton.Name = "uholPocitajbutton";
            this.uholPocitajbutton.Size = new System.Drawing.Size(108, 35);
            this.uholPocitajbutton.TabIndex = 19;
            this.uholPocitajbutton.Text = "POČÍTAJ";
            this.uholPocitajbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.uholPocitajbutton.UseVisualStyleBackColor = false;
            this.uholPocitajbutton.Click += new System.EventHandler(this.uholPocitajbutton_Click);
            // 
            // uholComboBox
            // 
            this.uholComboBox.FormattingEnabled = true;
            this.uholComboBox.Items.AddRange(new object[] {
            "α",
            "β",
            "γ"});
            this.uholComboBox.Location = new System.Drawing.Point(21, 128);
            this.uholComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.uholComboBox.Name = "uholComboBox";
            this.uholComboBox.Size = new System.Drawing.Size(54, 23);
            this.uholComboBox.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 85);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 15);
            this.label7.TabIndex = 10;
            this.label7.Text = "Strana b:";
            // 
            // strB2numericUpDown
            // 
            this.strB2numericUpDown.Location = new System.Drawing.Point(97, 83);
            this.strB2numericUpDown.Margin = new System.Windows.Forms.Padding(4);
            this.strB2numericUpDown.Name = "strB2numericUpDown";
            this.strB2numericUpDown.Size = new System.Drawing.Size(140, 23);
            this.strB2numericUpDown.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 42);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 15);
            this.label8.TabIndex = 9;
            this.label8.Text = "Strana a:";
            // 
            // strA2numericUpDown
            // 
            this.strA2numericUpDown.Location = new System.Drawing.Point(97, 40);
            this.strA2numericUpDown.Margin = new System.Windows.Forms.Padding(4);
            this.strA2numericUpDown.Name = "strA2numericUpDown";
            this.strA2numericUpDown.Size = new System.Drawing.Size(140, 23);
            this.strA2numericUpDown.TabIndex = 3;
            // 
            // uholNumericUpDown
            // 
            this.uholNumericUpDown.Location = new System.Drawing.Point(97, 129);
            this.uholNumericUpDown.Margin = new System.Windows.Forms.Padding(4);
            this.uholNumericUpDown.Name = "uholNumericUpDown";
            this.uholNumericUpDown.Size = new System.Drawing.Size(140, 23);
            this.uholNumericUpDown.TabIndex = 12;
            // 
            // trojuSaveFileDialog
            // 
            this.trojuSaveFileDialog.DefaultExt = "txt";
            this.trojuSaveFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(352, 79);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(199, 177);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // dataRichTextBox
            // 
            this.dataRichTextBox.Location = new System.Drawing.Point(213, 377);
            this.dataRichTextBox.Name = "dataRichTextBox";
            this.dataRichTextBox.ReadOnly = true;
            this.dataRichTextBox.Size = new System.Drawing.Size(464, 224);
            this.dataRichTextBox.TabIndex = 8;
            this.dataRichTextBox.Text = "";
            // 
            // VymazButton
            // 
            this.VymazButton.BackColor = System.Drawing.Color.SkyBlue;
            this.VymazButton.FlatAppearance.BorderSize = 0;
            this.VymazButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VymazButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.VymazButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.VymazButton.Location = new System.Drawing.Point(388, 623);
            this.VymazButton.Margin = new System.Windows.Forms.Padding(4);
            this.VymazButton.Name = "VymazButton";
            this.VymazButton.Size = new System.Drawing.Size(108, 35);
            this.VymazButton.TabIndex = 10;
            this.VymazButton.Text = "VYMAŽ";
            this.VymazButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.VymazButton.UseVisualStyleBackColor = false;
            this.VymazButton.Click += new System.EventHandler(this.VymazButton_Click);
            // 
            // TrojuholForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(901, 671);
            this.Controls.Add(this.VymazButton);
            this.Controls.Add(this.dataRichTextBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.SsuGroupBox);
            this.Controls.Add(this.SssGroupBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SsuRadioButton);
            this.Controls.Add(this.SssRadioButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "TrojuholForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trojuholník";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TrojuholForm_FormClosing);
            this.SssGroupBox.ResumeLayout(false);
            this.SssGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.strCnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.strBnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.strAnumericUpDown)).EndInit();
            this.SsuGroupBox.ResumeLayout(false);
            this.SsuGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.strB2numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.strA2numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uholNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton SssRadioButton;
        private System.Windows.Forms.RadioButton SsuRadioButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox SssGroupBox;
        private System.Windows.Forms.NumericUpDown strCnumericUpDown;
        private System.Windows.Forms.NumericUpDown strBnumericUpDown;
        private System.Windows.Forms.NumericUpDown strAnumericUpDown;
        private System.Windows.Forms.GroupBox SsuGroupBox;
        private System.Windows.Forms.NumericUpDown strB2numericUpDown;
        private System.Windows.Forms.NumericUpDown strA2numericUpDown;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown uholNumericUpDown;
        private System.Windows.Forms.ComboBox uholComboBox;
        private System.Windows.Forms.Button stranaPocitajButton;
        private System.Windows.Forms.Button uholPocitajbutton;
        private System.Windows.Forms.SaveFileDialog trojuSaveFileDialog;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RichTextBox dataRichTextBox;
        private System.Windows.Forms.Button VymazButton;
    }
}

