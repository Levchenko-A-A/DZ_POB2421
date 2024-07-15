using System.Windows.Forms;

namespace HomeWork28_2
{
    public partial class Form1 : Form
    {
        private PasswordGenerator[] mas;
        private int count;
        private int selectedIndex;
        public Form1()
        {
            InitializeComponent();
            count = 0;
            mas = new PasswordGenerator[count];
        }

        private void buttonRegen_Click(object sender, EventArgs e)
        {
            AddNewLogin();
        }
        private void buttonRemov_Click(object sender, EventArgs e)
        {
            RemoveLogin();
        }

        private void AddNewLogin()
        {
            if (textBoxUser.Text.Length != 0)
            {
                if (FindLoginListBox(textBoxUser.Text))
                {
                    PasswordGenerator NewLogin = new PasswordGenerator();
                    string NewPassword = NewLogin.GenNewPassword();
                    NewLogin.setLogin(textBoxUser.Text);
                    NewLogin.setPassword(NewPassword);
                    count++;
                    Array.Resize<PasswordGenerator>(ref mas, count);
                    mas[count - 1] = NewLogin;
                    listBoxLogin.Items.Add(NewLogin.getLogin());
                    listBoxPassword.Items.Add(NewLogin.getPassword());
                    textBoxUser.Clear();
                }
                else MessageBox.Show("Такой логин уже существует");
            }
            textBoxUser.Clear();
        }
        private void RemoveLogin()
        {
            if(listBoxLogin.SelectedIndex!=-1)
            {
                int index = listBoxLogin.SelectedIndex;
                listBoxLogin.Items.RemoveAt(index);
                listBoxPassword.Items.RemoveAt(index);
                PasswordGenerator[] temp = new PasswordGenerator[--count];
                int j = 0;
                for (int i = 0; i < mas.Length; i++)
                {
                    if (i != index) temp[j++] = mas[i];
                }
                Array.Resize<PasswordGenerator>(ref mas, count);
                Array.Copy(temp, mas, count);
            }
        }
        private bool FindLoginListBox(string username)
        {

            for (int i = 0; i < listBoxLogin.Items.Count; i++)
            {
                if (listBoxLogin.Items[i].ToString() == username)
                    return false;
            }
            return true;
        }

        
    }
}
