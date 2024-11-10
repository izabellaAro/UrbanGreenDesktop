namespace UBDesktop
{
    partial class Pedidos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.flpPedidos = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCarregar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // flpPedidos
            // 
            this.flpPedidos.AutoScroll = true;
            this.flpPedidos.BackColor = System.Drawing.Color.ForestGreen;
            this.flpPedidos.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpPedidos.Location = new System.Drawing.Point(38, 57);
            this.flpPedidos.Name = "flpPedidos";
            this.flpPedidos.Size = new System.Drawing.Size(1144, 476);
            this.flpPedidos.TabIndex = 0;
            // 
            // btnCarregar
            // 
            this.btnCarregar.Location = new System.Drawing.Point(38, 28);
            this.btnCarregar.Name = "btnCarregar";
            this.btnCarregar.Size = new System.Drawing.Size(75, 23);
            this.btnCarregar.TabIndex = 1;
            this.btnCarregar.Text = "Carregar";
            this.btnCarregar.UseVisualStyleBackColor = true;
            this.btnCarregar.Click += new System.EventHandler(this.btnCarregar_Click);
            // 
            // Pedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.ClientSize = new System.Drawing.Size(1205, 574);
            this.Controls.Add(this.btnCarregar);
            this.Controls.Add(this.flpPedidos);
            this.Name = "Pedidos";
            this.Text = "Pedidos";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpPedidos;
        private System.Windows.Forms.Button btnCarregar;
    }
}