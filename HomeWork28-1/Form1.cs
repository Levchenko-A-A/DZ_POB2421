namespace HomeWork28_1
{
    public partial class Form1 : Form
    {
        private NumberRandom rand;
        public string[] mas = {"\"Успех - это способность идти от одной неудачи к другой, не потеряв энтузиазма.\" - Уинстон Черчилль",
                        "\"Будь изменением, которое ты хочешь видеть в мире.\" - Махатма Ганди",
                        "\"Лучший способ предсказать будущее - создать его.\" - Питер Друкер",
                        "\"Сложности - это возможности, скрытые в обманчивой обертке.\" -\r\nАльберт Эйнштейн",
                        "\"Не важно, сколько раз вы падаете - важно, сколько раз вы\r\nподнимаетесь.\" - Мэрилин Монро"};
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
