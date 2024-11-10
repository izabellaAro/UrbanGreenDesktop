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
            Pedidos form2 = new Pedidos(apiService);
            form2.getPedidos();
            form2.ShowDialog();
            this.Close();
        }

        private void btnFuncionarios_Click(object sender, EventArgs e)
        {
            this.Hide();
            Funcionarios form2 = new Funcionarios(apiService);
            form2.getFuncionarios();
            form2.ShowDialog();
            this.Close();
        }
    }
}
