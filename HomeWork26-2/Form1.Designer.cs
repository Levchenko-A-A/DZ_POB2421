namespace HomeWork26_2
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
            label2 = new Label();
            textBoxFirst = new TextBox();
            textBoxSecond = new TextBox();
            buttonResult = new Button();
            checkBoxSum = new CheckBox();
            checkBoxSub = new CheckBox();
            checkBoxMul = new CheckBox();
            checkBoxDiv = new CheckBox();
            button1Clear = new Button();
            labelResult = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 35);
            label1.Name = "label1";
            label1.Size = new Size(144, 28);
            label1.TabIndex = 0;
            label1.Text = "Переменная А";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(267, 35);
            label2.Name = "label2";
            label2.Size = new Size(142, 28);
            label2.TabIndex = 1;
            label2.Text = "Переменная В";
            // 
            // textBoxFirst
            // 
            textBoxFirst.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxFirst.Location = new Point(37, 66);
            textBoxFirst.Multiline = true;
            textBoxFirst.Name = "textBoxFirst";
            textBoxFirst.Size = new Size(181, 63);
            textBoxFirst.TabIndex = 2;
            textBoxFirst.TextAlign = HorizontalAlignment.Center;
            textBoxFirst.KeyPress += textBoxFirst_KeyPress;
            // 
            // textBoxSecond
            // 
            textBoxSecond.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxSecond.Location = new Point(267, 66);
            textBoxSecond.Multiline = true;
            textBoxSecond.Name = "textBoxSecond";
            textBoxSecond.Size = new Size(181, 63);
            textBoxSecond.TabIndex = 3;
            textBoxSecond.TextAlign = HorizontalAlignment.Center;
            textBoxSecond.KeyPress += textBoxSecond_KeyPress;
            // 
            // buttonResult
            // 
            buttonResult.Location = new Point(37, 255);
            buttonResult.Name = "buttonResult";
            buttonResult.Size = new Size(279, 76);
            buttonResult.TabIndex = 5;
            buttonResult.Text = "Посчитать";
            buttonResult.UseVisualStyleBackColor = true;
            buttonResult.Click += buttonResult_Click;
            // 
            // checkBoxSum
            // 
            checkBoxSum.AutoSize = true;
            checkBoxSum.Location = new Point(503, 66);
            checkBoxSum.Name = "checkBoxSum";
            checkBoxSum.Size = new Size(48, 32);
            checkBoxSum.TabIndex = 6;
            checkBoxSum.Text = "+";
            checkBoxSum.UseVisualStyleBackColor = true;
            checkBoxSum.CheckedChanged += checkBoxSum_CheckedChanged;
            // 
            // checkBoxSub
            // 
            checkBoxSub.AutoSize = true;
            checkBoxSub.Location = new Point(503, 104);
            checkBoxSub.Name = "checkBoxSub";
            checkBoxSub.Size = new Size(42, 32);
            checkBoxSub.TabIndex = 7;
            checkBoxSub.Text = "-";
            checkBoxSub.UseVisualStyleBackColor = true;
            checkBoxSub.CheckedChanged += checkBoxSub_CheckedChanged;
            // 
            // checkBoxMul
            // 
            checkBoxMul.AutoSize = true;
            checkBoxMul.Location = new Point(503, 142);
            checkBoxMul.Name = "checkBoxMul";
            checkBoxMul.Size = new Size(42, 32);
            checkBoxMul.TabIndex = 8;
            checkBoxMul.Text = "*";
            checkBoxMul.UseVisualStyleBackColor = true;
            checkBoxMul.CheckedChanged += checkBoxMul_CheckedChanged;
            // 
            // checkBoxDiv
            // 
            checkBoxDiv.AutoSize = true;
            checkBoxDiv.Location = new Point(503, 180);
            checkBoxDiv.Name = "checkBoxDiv";
            checkBoxDiv.Size = new Size(42, 32);
            checkBoxDiv.TabIndex = 9;
            checkBoxDiv.Text = "/";
            checkBoxDiv.UseVisualStyleBackColor = true;
            checkBoxDiv.CheckedChanged += checkBoxDiv_CheckedChanged;
            // 
            // button1Clear
            // 
            button1Clear.ForeColor = SystemColors.ActiveCaptionText;
            button1Clear.Location = new Point(377, 255);
            button1Clear.Name = "button1Clear";
            button1Clear.Size = new Size(168, 76);
            button1Clear.TabIndex = 10;
            button1Clear.Text = "Очистка";
            button1Clear.UseVisualStyleBackColor = true;
            button1Clear.Click += button1Clear_Click;
            // 
            // labelResult
            // 
            labelResult.BackColor = Color.White;
            labelResult.BorderStyle = BorderStyle.Fixed3D;
            labelResult.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelResult.Location = new Point(39, 161);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(408, 65);
            labelResult.TabIndex = 11;
            labelResult.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(575, 428);
            Controls.Add(labelResult);
            Controls.Add(button1Clear);
            Controls.Add(checkBoxDiv);
            Controls.Add(checkBoxMul);
            Controls.Add(checkBoxSub);
            Controls.Add(checkBoxSum);
            Controls.Add(buttonResult);
            Controls.Add(textBoxSecond);
            Controls.Add(textBoxFirst);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Калькулятор";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBoxFirst;
        private TextBox textBoxSecond;
        private Button buttonResult;
        private CheckBox checkBoxSum;
        private CheckBox checkBoxSub;
        private CheckBox checkBoxMul;
        private CheckBox checkBoxDiv;
        private Button button1Clear;
        private Label labelResult;
    }
}
