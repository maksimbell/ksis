using OpenPop.Pop3;
using OpenPop.Mime;

namespace MailerGUI
{
    public partial class LoginForm : Form
    {
        //bswtpzwybiichuhh
        //rtsgvxxyjwjitasz
        private UserPackage userPackage;

        ClientForm clientForm;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                userPackage = new UserPackage(loginArea.Text,
                    passwordArea.Text, int.Parse(tbPort.Text), cbServer.Text, cbSsl.Checked);

                 clientForm = ClientForm.GetInstance(userPackage);
                clientForm.Show();
                clientForm.BringToFront();
            }
            catch (CustomMailerException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbSsl_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            cbServer.Items.Add("gmail.com");
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