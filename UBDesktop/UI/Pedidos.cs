using System.Drawing;
using System.Windows.Forms;
using UBDesktop.API;
using UBDesktop.Models;

namespace UBDesktop
{
    public partial class Pedidos : Form
    {
        private readonly APIService apiService;
        public Pedidos(APIService apiService)
        {
            InitializeComponent();
            this.apiService = apiService;
        }

        public async void getPedidos()
        {
            var pedidos = await apiService.GetPedidosAsync(); 

            if (pedidos != null && pedidos.Count > 0)
            {
                flpPedidos.Controls.Clear(); 

                foreach (var pedido in pedidos)
                {
                    var card = CriarCardPedido(pedido); 
                    flpPedidos.Controls.Add(card); 
                }
            }
            else
            {
                MessageBox.Show("Nenhum pedido encontrado.");
            }
        }

        private Panel CriarCardPedido(Pedido pedido)
        {
            Panel cardPedido = new Panel
            {
                Width = 250,
                Height = 100,
                BorderStyle = BorderStyle.FixedSingle,
                Padding = new Padding(10),
                Margin = new Padding(10)
            };

            Label lblTitulo = new Label
            {
                Text = $"Pedido #{pedido.Id} - {pedido.Data.ToShortDateString()} - {pedido.NomeComprador}",
                Font = new Font("Arial", 10, FontStyle.Bold),
                Dock = DockStyle.Top
            };
            cardPedido.Controls.Add(lblTitulo);

            Label lblValorTotal = new Label
            {
                Text = $"Total: R$ {pedido.ValorTotal:F2}",
                Font = new Font("Arial", 10, FontStyle.Bold),
                Dock = DockStyle.Bottom
            };
            cardPedido.Controls.Add(lblValorTotal);

            FlowLayoutPanel flpItens = new FlowLayoutPanel
            {
                FlowDirection = FlowDirection.TopDown,
                AutoScroll = true,
                Width = 280,         
                Padding = new Padding(6),
                Dock = DockStyle.Fill
            };

            foreach (var item in pedido.ItemPedidos)
            {
                Panel itemPanel = new Panel
                {
                    Width = 280,
                    Height = 50,
                    Padding = new Padding(16),
                    Margin = new Padding(16)
                };

                Label lblNomeProduto = new Label
                {
                    Text = $"{item.Quantidade} x {item.NomeProduto} - R$ {item.Valor:F2}",
                    AutoSize = true
                };
                itemPanel.Controls.Add(lblNomeProduto);

                flpItens.Controls.Add(itemPanel);
            }

            cardPedido.Controls.Add(flpItens);

            return cardPedido;
        }

    }
}
