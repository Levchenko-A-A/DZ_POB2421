namespace HomeWork28_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonWrite_Click(object sender, EventArgs e)
        {
            IOFile iOFile = new IOFile();
            string[] text;
            string path = textBoxDirInfo.Text;
            try
            {
                if (File.Exists(path))
                {
                    text = iOFile.ReadFile(path);
                    for (int i = 0; i < text.Length; i++)
                    {
                        listBoxValues.Items.Add(text[i]);
                    }
                }
                else throw new Exception();
                
            } 
            catch
            {
                MessageBox.Show("Файл не найден");
            }
        }
    }
}
