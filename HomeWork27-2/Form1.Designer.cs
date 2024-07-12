namespace HomeWork27_2
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
            textBoxSum = new TextBox();
            label2 = new Label();
            labelExpense = new Label();
            checkBoxAdd = new CheckBox();
            checkBoxTake = new CheckBox();
            buttonResult = new Button();
            textBoxPIN = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 35);
            label1.Name = "label1";
            label1.Size = new Size(124, 20);
            label1.TabIndex = 0;
            label1.Text = "Состояние счета";
            // 
            // textBoxSum
            // 
            textBoxSum.Location = new Point(42, 136);
            textBoxSum.Name = "textBoxSum";
            textBoxSum.Size = new Size(216, 27);
            textBoxSum.TabIndex = 1;
            textBoxSum.KeyPress += textBoxSum_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 113);
            label2.Name = "label2";
            label2.Size = new Size(112, 20);
            label2.TabIndex = 2;
            label2.Text = "Введите сумму";
            // 
            // labelExpense
            // 
            labelExpense.BorderStyle = BorderStyle.Fixed3D;
            labelExpense.Location = new Point(44, 69);
            labelExpense.Name = "labelExpense";
            labelExpense.Size = new Size(211, 33);
            labelExpense.TabIndex = 3;
            // 
            // checkBoxAdd
            // 
            checkBoxAdd.AutoSize = true;
            checkBoxAdd.Location = new Point(37, 246);
            checkBoxAdd.Name = "checkBoxAdd";
            checkBoxAdd.Size = new Size(156, 24);
            checkBoxAdd.TabIndex = 4;
            checkBoxAdd.Text = "Положить на счет";
            checkBoxAdd.UseVisualStyleBackColor = true;
            checkBoxAdd.CheckedChanged += checkBoxAdd_CheckedChanged;
            // 
            // checkBoxTake
            // 
            checkBoxTake.AutoSize = true;
            checkBoxTake.Location = new Point(37, 276);
            checkBoxTake.Name = "checkBoxTake";
            checkBoxTake.Size = new Size(132, 24);
            checkBoxTake.TabIndex = 5;
            checkBoxTake.Text = "Снять со счета";
            checkBoxTake.UseVisualStyleBackColor = true;
            checkBoxTake.CheckedChanged += checkBoxTake_CheckedChanged;
            // 
            // buttonResult
            // 
            buttonResult.Location = new Point(36, 317);
            buttonResult.Name = "buttonResult";
            buttonResult.Size = new Size(217, 44);
            buttonResult.TabIndex = 6;
            buttonResult.Text = "Выполнить";
            buttonResult.UseVisualStyleBackColor = true;
            buttonResult.Click += buttonResult_Click;
            // 
            // textBoxPIN
            // 
            textBoxPIN.Location = new Point(42, 202);
            textBoxPIN.MaxLength = 4;
            textBoxPIN.Name = "textBoxPIN";
            textBoxPIN.PasswordChar = '*';
            textBoxPIN.Size = new Size(125, 27);
            textBoxPIN.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(42, 179);
            label4.Name = "label4";
            label4.Size = new Size(92, 20);
            label4.TabIndex = 8;
            label4.Text = "Введите PIN";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(306, 450);
            Controls.Add(label4);
            Controls.Add(textBoxPIN);
            Controls.Add(buttonResult);
            Controls.Add(checkBoxTake);
            Controls.Add(checkBoxAdd);
            Controls.Add(labelExpense);
            Controls.Add(label2);
            Controls.Add(textBoxSum);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxSum;
        private Label label2;
        private Label labelExpense;
        private CheckBox checkBoxAdd;
        private CheckBox checkBoxTake;
        private Button buttonResult;
        private TextBox textBoxPIN;
        private Label label4;
    }
}
