using System;
using System.Windows.Forms;
using UBDesktop.API;

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
                apiService.SetToken(token);
                Pedidos form2 = new Pedidos(apiService);
                form2.ShowDialog();
            }
            else
            {
                MessageBox.Show("Login failed");
            }
        }
    }
}
