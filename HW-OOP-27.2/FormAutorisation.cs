namespace HW_OOP_27._2
{
    public partial class FormAutorisation : Form
    {
        public static FormAutorisation? instance;
        private UserAuthentification userAuthentification;

        public FormAutorisation()
        {
            InitializeComponent();
            instance = this;
            userAuthentification = new UserAuthentification();
            AutoCompleteStringCollection source = new AutoCompleteStringCollection();
            if (userAuthentification.Users != null)
            {
                foreach (User s in userAuthentification.Users!)
                {
                    source.Add(s.UserName);
                }

                textBoxLogin.AutoCompleteCustomSource = source;
                textBoxLogin.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                textBoxLogin.AutoCompleteSource = AutoCompleteSource.CustomSource;
            }
        }

        private void linkLabelRegistration_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormRegistration formRegistration = new FormRegistration();
            formRegistration.Show();
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            if (userAuthentification.AuthentificationUser(textBoxLogin.Text, textBoxPassword.Text)) ;
            {
                FormTask formTask = new FormTask();
                formTask.Show();
                this.Hide();
            }
        }
    }
}
