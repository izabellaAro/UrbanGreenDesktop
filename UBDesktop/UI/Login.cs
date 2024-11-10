using System;
using System.Windows.Forms;
using UBDesktop.API;
using UBDesktop.UI;

namespace UBDesktop
{
    public partial class Login : Form
    {
        private readonly APIService apiService;

        public Login()
        {
            InitializeComponent();
            apiService = new APIService();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            var username = txtUsername.Text;
            var password = txtPassword.Text;

            var token = await apiService.LoginAsync(username, password);

            if (!string.IsNullOrEmpty(token))
            {
                this.Hide();
                apiService.SetToken(token);
                Principal form2 = new Principal(apiService);
                form2.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Login failed");
            }
        }
    }
}
