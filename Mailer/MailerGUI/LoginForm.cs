using OpenPop.Pop3;
using OpenPop.Mime;

namespace MailerGUI
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            /*MailClient clientForm = new MailClient();
            clientForm.Show();*/
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
        }
    }
}