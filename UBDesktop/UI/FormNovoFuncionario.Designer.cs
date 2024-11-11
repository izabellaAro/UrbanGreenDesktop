namespace UBDesktop.UI
{
    partial class FormNovoFuncionario
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
            this.components = new System.ComponentModel.Container();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtRole = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(185, 110);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(185, 30);
            this.txtUsuario.TabIndex = 0;
            // 
            // txtSenha
            // 
            this.txtSenha.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(185, 157);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(185, 30);
            this.txtSenha.TabIndex = 1;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(185, 209);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(185, 30);
            this.txtEmail.TabIndex = 2;
            // 
            // txtRole
            // 
            this.txtRole.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRole.Location = new System.Drawing.Point(185, 259);
            this.txtRole.Name = "txtRole";
            this.txtRole.Size = new System.Drawing.Size(185, 30);
            this.txtRole.TabIndex = 3;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.ForestGreen;
            this.btnCadastrar.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.ForeColor = System.Drawing.Color.White;
            this.btnCadastrar.Location = new System.Drawing.Point(202, 310);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(133, 35);
            this.btnCadastrar.TabIndex = 4;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Arial Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.ForestGreen;
            this.label1.Location = new System.Drawing.Point(107, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(347, 32);
            this.label1.TabIndex = 5;
            this.label1.Text = "Cadastrar um novo usuário";
            // 
            // FormNovoFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(559, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.txtRole);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtUsuario);
            this.Name = "FormNovoFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Urban Green";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtRole;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}