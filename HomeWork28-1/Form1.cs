namespace HomeWork28_1
{
    public partial class Form1 : Form
    {
        private NumberRandom rand;
        public string[] mas = {"\"����� - ��� ����������� ���� �� ����� ������� � ������, �� ������� ����������.\" - ������� ��������",
                        "\"���� ����������, ������� �� ������ ������ � ����.\" - ������� �����",
                        "\"������ ������ ����������� ������� - ������� ���.\" - ����� ������",
                        "\"��������� - ��� �����������, ������� � ���������� �������.\" -\r\n������� ��������",
                        "\"�� �����, ������� ��� �� ������� - �����, ������� ��� ��\r\n������������.\" - ������� �����"};
        public Form1()
        {
            InitializeComponent();
            rand = new NumberRandom();
        }

        private void label1_MouseClick(object sender, MouseEventArgs e)
        {
            PrintLabel();
        }

        private void PrintLabel()
        {
            try
            {
                labelResult.Text = mas[rand.RanNumber(0, 5)];
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }
    }

}
