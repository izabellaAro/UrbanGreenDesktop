namespace UBDesktop.UI
{
    partial class Funcionarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Funcionarios));
            this.flpFuncionarios = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdicionarFunc = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // flpFuncionarios
            // 
            this.flpFuncionarios.BackColor = System.Drawing.Color.Ivory;
            this.flpFuncionarios.Location = new System.Drawing.Point(27, 77);
            this.flpFuncionarios.Name = "flpFuncionarios";
            this.flpFuncionarios.Size = new System.Drawing.Size(1144, 476);
            this.flpFuncionarios.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Ivory;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(27, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(81, 51);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(114, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "Funcionários";
            // 
            // btnAdicionarFunc
            // 
            this.btnAdicionarFunc.BackColor = System.Drawing.Color.ForestGreen;
            this.btnAdicionarFunc.Font = new System.Drawing.Font("Arial Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionarFunc.Location = new System.Drawing.Point(1096, 22);
            this.btnAdicionarFunc.Name = "btnAdicionarFunc";
            this.btnAdicionarFunc.Size = new System.Drawing.Size(75, 50);
            this.btnAdicionarFunc.TabIndex = 3;
            this.btnAdicionarFunc.Text = "+";
            this.btnAdicionarFunc.UseVisualStyleBackColor = false;
            this.btnAdicionarFunc.Click += new System.EventHandler(this.btnAdicionarFunc_Click);
            // 
            // Funcionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1205, 574);
            this.Controls.Add(this.btnAdicionarFunc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.flpFuncionarios);
            this.Name = "Funcionarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Urban Green";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpFuncionarios;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdicionarFunc;
    }
}