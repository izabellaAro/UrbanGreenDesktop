using System.Windows.Forms;
using UBDesktop.API;

namespace UBDesktop.UI
{
    public partial class FormNovoFuncionario : Form
    {
        private readonly APIService apiService;
        public FormNovoFuncionario(APIService apiService)
        {
            InitializeComponent();
            this.apiService = apiService;
        }

        private async void btnCadastrar_Click(object sender, System.EventArgs e)
        {
            var usuario = txtUsuario.Text;
            var senha = txtSenha.Text;
            var email = txtEmail.Text; 
            var role = txtRole.Text;

            await apiService.CreatePerfil(usuario, senha, email, role);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
