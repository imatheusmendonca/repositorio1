namespace ProjetoNovo
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.botao = new System.Windows.Forms.Button();
            this.primeiraMensagem = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // botao
            // 
            this.botao.BackColor = System.Drawing.Color.Goldenrod;
            this.botao.Font = new System.Drawing.Font("Broadway", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botao.ForeColor = System.Drawing.Color.MediumBlue;
            this.botao.Location = new System.Drawing.Point(178, 35);
            this.botao.Name = "botao";
            this.botao.Size = new System.Drawing.Size(486, 313);
            this.botao.TabIndex = 0;
            this.botao.Text = "CLIQUE AQUI!";
            this.botao.UseVisualStyleBackColor = false;
            this.botao.Click += new System.EventHandler(this.botao_Click);
            // 
            // primeiraMensagem
            // 
            this.primeiraMensagem.AutoSize = true;
            this.primeiraMensagem.Font = new System.Drawing.Font("Old English Text MT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.primeiraMensagem.Location = new System.Drawing.Point(172, 351);
            this.primeiraMensagem.Name = "primeiraMensagem";
            this.primeiraMensagem.Size = new System.Drawing.Size(492, 32);
            this.primeiraMensagem.TabIndex = 1;
            this.primeiraMensagem.Text = "Você está precisando de férias, descanse!";
            this.primeiraMensagem.Click += new System.EventHandler(this.primeiraMensagem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.primeiraMensagem);
            this.Controls.Add(this.botao);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botao;
        private System.Windows.Forms.Label primeiraMensagem;
    }
}

