namespace IOOP_project
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string stat;

            User obj1 = new User(txtUsername.Text,txtPassword.Text);
            stat = obj1.login(txtUsername.Text);
            if (stat != null)
            {
                MessageBox.Show(stat);
            }
            txtUsername.Text = string.Empty;
            txtPassword.Text = string.Empty;
        }
    }
}