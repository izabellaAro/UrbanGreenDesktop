using System;
using System.Windows.Forms;
using UBDesktop.API;

namespace UBDesktop.UI
{
    public partial class Principal : Form
    {
        private readonly APIService apiService;
        public Principal(APIService apiService)
        {
            InitializeComponent();
            this.apiService = apiService;
        }

        private async void btnPedidos_Click(object sender, EventArgs e)
        {
            this.Hide(); 
            Cab form2 = new Cab(apiService);
            form2.getPedidos();
            form2.ShowDialog();
            this.Close();
        }
    }
}
