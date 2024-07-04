namespace HomeWork27_1
{
    public partial class Form1 : Form
    {
        Converter converter=new Converter();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal tmp;
            decimal.TryParse(textBoxRub.Text, out tmp);
            labelDollars.Text = Converter.ToDollars(tmp).ToString("F2");
            labelEuros.Text=Converter.ToEuros(tmp).ToString("F2");
            labelZlotys.Text=Converter.ToZlotys(tmp).ToString("F2");
            labelYuan.Text = Converter.ToYuan(tmp).ToString("F2");
            labelRupes.Text = Converter.ToRupes(tmp).ToString("F2");
        }

        private void textBoxRub_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9') return;
            if (e.KeyChar == '.') e.KeyChar = ',';
            if (e.KeyChar == ',')
            {
                if (textBoxRub.Text.IndexOf(',') != -1 || textBoxRub.Text.Length == 0)
                    e.Handled = true;
                return;
            }
            e.Handled = true;
        }
    }
}
