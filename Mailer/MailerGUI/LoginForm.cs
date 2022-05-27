using OpenPop.Pop3;
using OpenPop.Mime;

namespace MailerGUI
{
    public partial class LoginForm : Form
    {
        private UserPackage userPackage;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            userPackage = new UserPackage(loginArea.Text, 
                passwordArea.Text, int.Parse(tbPort.Text), cbServer.Text, cbSsl.Checked);

            MailClient clientForm = new MailClient(userPackage);
            clientForm.Show();
            //this.Hide();
        }

        private void cbSsl_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            cbServer.Items.Add("pop.gmail.com");
            cbServer.SelectedIndex = 0;

            tbPort.Text = "995";
            cbSsl.Checked = true;

            loginArea.Text = "lilfidgetx@gmail.com";
            passwordArea.Text = "rtsgvxxyjwjitasz";
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
    }
}