namespace HomeWork26_1
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
            groupBox1 = new GroupBox();
            checkBoxThree = new CheckBox();
            checkBoxTwo = new CheckBox();
            checkBoxOne = new CheckBox();
            buttonCheck = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(checkBoxThree);
            groupBox1.Controls.Add(checkBoxTwo);
            groupBox1.Controls.Add(checkBoxOne);
            groupBox1.Location = new Point(28, 33);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(309, 157);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // checkBoxThree
            // 
            checkBoxThree.AutoSize = true;
            checkBoxThree.Location = new Point(37, 104);
            checkBoxThree.Name = "checkBoxThree";
            checkBoxThree.Size = new Size(98, 24);
            checkBoxThree.TabIndex = 2;
            checkBoxThree.Text = "Галочка 3";
            checkBoxThree.UseVisualStyleBackColor = true;
            // 
            // checkBoxTwo
            // 
            checkBoxTwo.AutoSize = true;
            checkBoxTwo.Location = new Point(37, 74);
            checkBoxTwo.Name = "checkBoxTwo";
            checkBoxTwo.Size = new Size(98, 24);
            checkBoxTwo.TabIndex = 1;
            checkBoxTwo.Text = "Галочка 2";
            checkBoxTwo.UseVisualStyleBackColor = true;
            // 
            // checkBoxOne
            // 
            checkBoxOne.AutoSize = true;
            checkBoxOne.Location = new Point(37, 44);
            checkBoxOne.Name = "checkBoxOne";
            checkBoxOne.Size = new Size(98, 24);
            checkBoxOne.TabIndex = 0;
            checkBoxOne.Text = "Галочка 1";
            checkBoxOne.UseVisualStyleBackColor = true;
            // 
            // buttonCheck
            // 
            buttonCheck.Location = new Point(28, 222);
            buttonCheck.Name = "buttonCheck";
            buttonCheck.Size = new Size(309, 109);
            buttonCheck.TabIndex = 1;
            buttonCheck.Text = "Проверить флажок";
            buttonCheck.UseVisualStyleBackColor = true;
            buttonCheck.Click += buttonCheck_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(364, 351);
            Controls.Add(buttonCheck);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button buttonCheck;
        private CheckBox checkBoxThree;
        private CheckBox checkBoxTwo;
        private CheckBox checkBoxOne;
    }
}
