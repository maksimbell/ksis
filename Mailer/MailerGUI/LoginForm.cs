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
            MailClient clientForm = new MailClient();
            clientForm.Show();
        }
    }
}