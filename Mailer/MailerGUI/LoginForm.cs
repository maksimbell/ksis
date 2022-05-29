using OpenPop.Pop3;
using OpenPop.Mime;

namespace MailerGUI
{
    public partial class LoginForm : Form
    {
        //bswtpzwybiichuhh
        //rtsgvxxyjwjitasz
        private UserPackage userPackage;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            userPackage = new UserPackage(loginArea.Text,
                passwordArea.Text, int.Parse(tbPort.Text), cbServer.Text, cbSsl.Checked);

            ClientForm clientForm = new ClientForm(userPackage);
            clientForm.Show();
        }

        private void cbSsl_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            cbServer.Items.Add("imap.gmail.com");
            cbServer.SelectedIndex = 0;

            tbPort.Text = "993";
            cbSsl.Checked = true;

            loginArea.Text = "jealousdorr@gmail.com";
            passwordArea.Text = "bswtpzwybiichuhh";
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
    }
}