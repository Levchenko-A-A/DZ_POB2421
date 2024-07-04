namespace HomeWork27_1
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
            label1 = new Label();
            textBoxRub = new TextBox();
            label2 = new Label();
            labelDollars = new Label();
            labelEuros = new Label();
            label4 = new Label();
            labelZlotys = new Label();
            label5 = new Label();
            labelYuan = new Label();
            label6 = new Label();
            labelRupes = new Label();
            label7 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 20);
            label1.Name = "label1";
            label1.Size = new Size(202, 20);
            label1.TabIndex = 0;
            label1.Text = "Введите количество рублей";
            // 
            // textBoxRub
            // 
            textBoxRub.BorderStyle = BorderStyle.FixedSingle;
            textBoxRub.Location = new Point(21, 43);
            textBoxRub.Multiline = true;
            textBoxRub.Name = "textBoxRub";
            textBoxRub.Size = new Size(125, 27);
            textBoxRub.TabIndex = 1;
            textBoxRub.KeyPress += textBoxRub_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 83);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 2;
            label2.Text = "Доллары";
            // 
            // labelDollars
            // 
            labelDollars.BorderStyle = BorderStyle.FixedSingle;
            labelDollars.Location = new Point(21, 106);
            labelDollars.Name = "labelDollars";
            labelDollars.Size = new Size(125, 33);
            labelDollars.TabIndex = 3;
            // 
            // labelEuros
            // 
            labelEuros.BorderStyle = BorderStyle.FixedSingle;
            labelEuros.Location = new Point(21, 169);
            labelEuros.Name = "labelEuros";
            labelEuros.Size = new Size(125, 33);
            labelEuros.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 146);
            label4.Name = "label4";
            label4.Size = new Size(43, 20);
            label4.TabIndex = 4;
            label4.Text = "Евро";
            // 
            // labelZlotys
            // 
            labelZlotys.BorderStyle = BorderStyle.FixedSingle;
            labelZlotys.Location = new Point(21, 232);
            labelZlotys.Name = "labelZlotys";
            labelZlotys.Size = new Size(125, 33);
            labelZlotys.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(21, 209);
            label5.Name = "label5";
            label5.Size = new Size(51, 20);
            label5.TabIndex = 6;
            label5.Text = "Злоты";
            // 
            // labelYuan
            // 
            labelYuan.BorderStyle = BorderStyle.FixedSingle;
            labelYuan.Location = new Point(21, 295);
            labelYuan.Name = "labelYuan";
            labelYuan.Size = new Size(125, 33);
            labelYuan.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(21, 272);
            label6.Name = "label6";
            label6.Size = new Size(49, 20);
            label6.TabIndex = 8;
            label6.Text = "Юань";
            // 
            // labelRupes
            // 
            labelRupes.BorderStyle = BorderStyle.FixedSingle;
            labelRupes.Location = new Point(21, 358);
            labelRupes.Name = "labelRupes";
            labelRupes.Size = new Size(125, 33);
            labelRupes.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(21, 335);
            label7.Name = "label7";
            label7.Size = new Size(51, 20);
            label7.TabIndex = 10;
            label7.Text = "Рупий";
            // 
            // button1
            // 
            button1.Location = new Point(23, 410);
            button1.Name = "button1";
            button1.Size = new Size(200, 31);
            button1.TabIndex = 12;
            button1.Text = "Пересчитать";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(311, 466);
            Controls.Add(button1);
            Controls.Add(labelRupes);
            Controls.Add(label7);
            Controls.Add(labelYuan);
            Controls.Add(label6);
            Controls.Add(labelZlotys);
            Controls.Add(label5);
            Controls.Add(labelEuros);
            Controls.Add(label4);
            Controls.Add(labelDollars);
            Controls.Add(label2);
            Controls.Add(textBoxRub);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Конвертер";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxRub;
        private Label label2;
        private Label labelDollars;
        private Label labelEuros;
        private Label label4;
        private Label labelZlotys;
        private Label label5;
        private Label labelYuan;
        private Label label6;
        private Label labelRupes;
        private Label label7;
        private Button button1;
    }
}
