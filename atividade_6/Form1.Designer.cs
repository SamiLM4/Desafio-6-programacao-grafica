namespace atividade_6
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label7 = new Label();
            label4 = new Label();
            numericUpDown1 = new NumericUpDown();
            label2 = new Label();
            comboBox1 = new ComboBox();
            button7 = new Button();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            label1 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            panel2 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(numericUpDown1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(button7);
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
            panel1.Location = new Point(15, 10);
            panel1.Name = "panel1";
            panel1.Size = new Size(1485, 145);
            panel1.TabIndex = 0;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(556, 108);
            label7.Name = "label7";
            label7.Size = new Size(85, 15);
            label7.TabIndex = 23;
            label7.Text = "Comprimento ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(556, 82);
            label4.Name = "label4";
            label4.Size = new Size(70, 15);
            label4.TabIndex = 22;
            label4.Text = "f(x) = ax + b";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(91, 84);
            numericUpDown1.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(54, 23);
            numericUpDown1.TabIndex = 21;
            numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 87);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 20;
            label2.Text = "Espessura:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Nenhuma", "Sólido", "Tracejado", "Traço ponto", "Traço dois pontos", "Pontilhado" });
            comboBox1.Location = new Point(24, 55);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 0;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // button7
            // 
            button7.Location = new Point(556, 54);
            button7.Name = "button7";
            button7.Size = new Size(75, 23);
            button7.TabIndex = 18;
            button7.Text = "Formar";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(430, 78);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 17;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(430, 31);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 16;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(374, 81);
            label6.Name = "label6";
            label6.Size = new Size(50, 15);
            label6.TabIndex = 15;
            label6.Text = "Largura:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(339, 34);
            label5.Name = "label5";
            label5.Size = new Size(85, 15);
            label5.TabIndex = 14;
            label5.Text = "Comprimento:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(241, 86);
            label3.Name = "label3";
            label3.Size = new Size(28, 15);
            label3.TabIndex = 12;
            label3.Text = "Y-1:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(241, 32);
            label1.Name = "label1";
            label1.Size = new Size(28, 15);
            label1.TabIndex = 10;
            label1.Text = "X-1:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(272, 79);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(55, 23);
            textBox2.TabIndex = 7;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(272, 28);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(55, 23);
            textBox1.TabIndex = 6;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Location = new Point(11, 170);
            panel2.Name = "panel2";
            panel2.Size = new Size(1489, 585);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            panel2.MouseClick += panel2_MouseClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1512, 767);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label3;
        private Label label1;
        private Label label6;
        private Label label5;
        private TextBox textBox4;
        private TextBox textBox3;
        private Button button7;
        private Panel panel2;
        private ComboBox comboBox1;
        private Label label2;
        private NumericUpDown numericUpDown1;
        private Label label4;
        private Label label7;
    }
}
