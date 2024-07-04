namespace HomeWork26_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void TextBoxClear()
        {
            textBoxFirst.Clear();
            textBoxSecond.Clear();
            labelResult.Text = "";
            ChekBoxEnable();
        }
        private void ChekBoxEnable()
        {
            checkBoxSum.Checked = false;
            checkBoxSum.Enabled = true;
            checkBoxSub.Checked = false;
            checkBoxSub.Enabled = true;
            checkBoxMul.Checked = false;
            checkBoxMul.Enabled = true;
            checkBoxDiv.Checked = false;
            checkBoxDiv.Enabled = true;
        }
        private void checkBoxSum_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSum.Checked)
            {
                checkBoxSum.Enabled = true;
                checkBoxSub.Enabled = false;
                checkBoxMul.Enabled = false;
                checkBoxDiv.Enabled = false;
            }
            else ChekBoxEnable();
        }
        private void checkBoxSub_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSub.Checked)
            {
                checkBoxSub.Enabled = true;
                checkBoxSum.Enabled = false;
                checkBoxMul.Enabled = false;
                checkBoxDiv.Enabled = false;
            }
            else ChekBoxEnable();
        }
        private void checkBoxMul_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxMul.Checked)
            {
                checkBoxMul.Enabled = true;
                checkBoxSum.Enabled = false;
                checkBoxSub.Enabled = false;
                checkBoxDiv.Enabled = false;
            }
            else ChekBoxEnable();
        }
        private void checkBoxDiv_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxDiv.Checked)
            {
                checkBoxDiv.Enabled = true;
                checkBoxSum.Enabled = false;
                checkBoxSub.Enabled = false;
                checkBoxMul.Enabled = false;
            }
            else ChekBoxEnable();
        }
        private void button1Clear_Click(object sender, EventArgs e)
        {
            TextBoxClear();
        }

        private void buttonResult_Click(object sender, EventArgs e)
        {
            try
            {
                double a;
                double b;
                double result;
                double.TryParse(textBoxFirst.Text, out a);
                double.TryParse(textBoxSecond.Text, out b);
                if (checkBoxSum.Checked)
                {
                    labelResult.Text = (a+b).ToString("F2");
                }
                else if (checkBoxSub.Checked)
                {
                    labelResult.Text = (a-b).ToString("F2");
                }
                else if (checkBoxMul.Checked)
                {
                    labelResult.Text = (a*b).ToString("F2");
                }
                else if (checkBoxDiv.Checked)
                {
                    try
                    {
                        if (b != 0)
                            labelResult.Text = (a / b).ToString("F2");
                        else throw new DivideByZeroException("Делить на ноль нельзя!!!");
                    }
                    catch (DivideByZeroException ex)
                    {
                        MessageBox.Show(ex.Message);

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBoxFirst_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9') return;
            if (e.KeyChar == '.') e.KeyChar = ',';
            if (e.KeyChar == ',')
            {
                if (textBoxFirst.Text.IndexOf(',') != -1 || textBoxFirst.Text.Length == 0)
                    e.Handled = true;
                return;
            }
            e.Handled = true;
        }

        private void textBoxSecond_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9') return;
            if (e.KeyChar == '.') e.KeyChar = ',';
            if (e.KeyChar == ',')
            {
                if (textBoxSecond.Text.IndexOf(',') != -1 || textBoxSecond.Text.Length == 0)
                    e.Handled = true;
                return;
            }
            e.Handled = true;
        }
    }
}
