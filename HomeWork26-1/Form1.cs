namespace HomeWork26_1
{
    public partial class Form1 : Form
    {
        string result;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCheck_Click(object sender, EventArgs e)
        {
            if (checkBoxOne.Checked)
            {
                result += "������� ������� 1 \n";
            }
            if (checkBoxTwo.Checked)
            {
                result += "������� ������� 2 \n";
            }
            if (checkBoxThree.Checked)
            {
                result += "������� ������� 3 \n";
            }
            if (checkBoxOne.Checked==false&&checkBoxTwo.Checked==false&&checkBoxThree.Checked==false)
                result = "�� ���� ������� �� �������";
            MessageBox.Show(result);
            result = "";
            checkBoxOne.Checked = false;
            checkBoxTwo.Checked = false;
            checkBoxThree.Checked = false;
        }

    }
}
