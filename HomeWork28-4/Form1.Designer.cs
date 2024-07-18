namespace HomeWork28_4
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
            listBoxValues = new ListBox();
            label1 = new Label();
            textBoxDirInfo = new TextBox();
            buttonWrite = new Button();
            SuspendLayout();
            // 
            // listBoxValues
            // 
            listBoxValues.FormattingEnabled = true;
            listBoxValues.Location = new Point(12, 12);
            listBoxValues.Name = "listBoxValues";
            listBoxValues.Size = new Size(342, 344);
            listBoxValues.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 359);
            label1.Name = "label1";
            label1.Size = new Size(158, 20);
            label1.TabIndex = 2;
            label1.Text = "Укажите путь к файлу";
            // 
            // textBoxDirInfo
            // 
            textBoxDirInfo.Location = new Point(12, 382);
            textBoxDirInfo.Name = "textBoxDirInfo";
            textBoxDirInfo.Size = new Size(342, 27);
            textBoxDirInfo.TabIndex = 3;
            // 
            // buttonWrite
            // 
            buttonWrite.Location = new Point(12, 415);
            buttonWrite.Name = "buttonWrite";
            buttonWrite.Size = new Size(94, 29);
            buttonWrite.TabIndex = 4;
            buttonWrite.Text = "Записать";
            buttonWrite.UseVisualStyleBackColor = true;
            buttonWrite.Click += buttonWrite_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(369, 492);
            Controls.Add(buttonWrite);
            Controls.Add(textBoxDirInfo);
            Controls.Add(label1);
            Controls.Add(listBoxValues);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxValues;
        private Label label1;
        private TextBox textBoxDirInfo;
        private Button buttonWrite;
    }
}
