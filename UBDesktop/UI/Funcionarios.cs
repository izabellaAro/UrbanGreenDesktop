using System.Drawing;
using System.Windows.Forms;
using UBDesktop.API;
using UBDesktop.Models;

namespace UBDesktop.UI
{
    public partial class Funcionarios : Form
    {
        private readonly APIService apiService;
        public Funcionarios(APIService apiService)
        {
            InitializeComponent();
            this.apiService = apiService;
        }

        public async void getFuncionarios()
        {
            var funcionarios = await apiService.GetFuncionariosAsync();

            if (funcionarios != null && funcionarios.Count > 0)
            {
                flpFuncionarios.Controls.Clear();

                foreach (var funcionario in funcionarios)
                {
                    var card = CriarCard(funcionario);
                    flpFuncionarios.Controls.Add(card);
                }
            }
            else
            {
                MessageBox.Show("Nenhum funcionário encontrado.");
            }
        }

        private Panel CriarCard(GetFuncionariosResponse funcionario)
        {
            Panel card = new Panel
            {
                Width = 400,
                Height = 110,
                BorderStyle = BorderStyle.FixedSingle,
                Padding = new Padding(10),
                AutoScroll = true,
                Margin = new Padding(10)
            };

            Label lblRole = new Label
            {
                Text = $"Tipo do perfil:{funcionario.Role}",
                Font = new Font("Arial", 10, FontStyle.Bold),
                Dock = DockStyle.Top
            };
            card.Controls.Add(lblRole);

            Label lblEmail = new Label
            {
                Text = $"E-mail:{funcionario.Email}",
                Font = new Font("Arial", 10, FontStyle.Bold),
                Dock = DockStyle.Top
            };
            card.Controls.Add(lblEmail);

            Label lblNome = new Label
            {
                Text = $"Usuário:{funcionario.Nome}",
                Font = new Font("Arial", 10, FontStyle.Bold),
                Dock = DockStyle.Top
            };
            card.Controls.Add(lblNome);

            Label lblId = new Label
            {
                Text = $"Id #{funcionario.Id}",
                Font = new Font("Arial", 10, FontStyle.Bold),
                Dock = DockStyle.Top
            };
            card.Controls.Add(lblId);

            return card;
        }

        private void btnAdicionarFunc_Click(object sender, System.EventArgs e)
        {
            FormNovoFuncionario form = new FormNovoFuncionario(apiService);
            form.ShowDialog();
        }

        private void btnRetornar_Click(object sender, System.EventArgs e)
        {
            this.Hide();
            Principal principal = new Principal(apiService);
            principal.ShowDialog();
            this.Close();
        }
    }
}
