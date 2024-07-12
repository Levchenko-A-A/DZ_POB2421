using static System.Net.Mime.MediaTypeNames;

namespace HomeWork27_2
{
    public partial class Form1 : Form
    {
        Account account = new Account(0, 1111);

        public Form1()
        {
            InitializeComponent();
        }
        private void textBoxSum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9') return;
            if (e.KeyChar == '.') e.KeyChar = ',';
            if (e.KeyChar == ',')
            {
                if (textBoxSum.Text.IndexOf(',') != -1 || textBoxSum.Text.Length == 0)
                    e.Handled = true;
                return;
            }
            if (Char.IsControl(e.KeyChar))
                return;
            e.Handled = true;
        }

        private void buttonResult_Click(object sender, EventArgs e)
        {
            int chekPin;
            int.TryParse(textBoxPIN.Text, out chekPin);

            if (account.GetpIn() != chekPin)
            {
                MessageBox.Show("Pin введен не корректно!!!");
            }
            else
            {
                if(checkBoxAdd.Checked) 
                {
                    decimal sum;
                    decimal.TryParse(textBoxSum.Text, out sum);
                    if (sum > 0)
                    {
                        account.AddExpense(sum);
                        labelExpense.Text = account.GetExpense().ToString();
                    }
                    else MessageBox.Show("Некорректный ввод суммы.");

                }
                else if(checkBoxTake.Checked)
                {
                    decimal sum;
                    decimal.TryParse(textBoxSum.Text, out sum);
                    if (sum <= account.GetExpense())
                    {
                        account.SubExpense(sum);
                        labelExpense.Text = account.GetExpense().ToString();
                    }
                    else MessageBox.Show("Введенная сумма больше отстатка.");
                }
            }

        }

        private void checkBoxAdd_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAdd.Checked)
            {
                checkBoxTake.Checked = false;
                checkBoxTake.Enabled = false;
                checkBoxAdd.Checked = true;
            }
            else 
            {
                checkBoxTake.Checked = false;
                checkBoxTake.Enabled = true;
                checkBoxAdd.Checked = false;
            }
        }

        private void checkBoxTake_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxTake.Checked)
            {
                checkBoxAdd.Checked = false;
                checkBoxAdd.Enabled = false;
                checkBoxTake.Checked = true;
            }
            else
            {
                checkBoxAdd.Checked = false;
                checkBoxAdd.Enabled = true;
                checkBoxTake.Checked= false;
            }
        }
        private void ControlNumber()
        {

        }
    }
}
