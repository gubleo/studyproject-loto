namespace projetoLotomania
{
    partial class Lotomania
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lotomania));
            this.button_gerar = new System.Windows.Forms.Button();
            this.Resultado = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.closeaplication = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_gerar
            // 
            this.button_gerar.Location = new System.Drawing.Point(12, 518);
            this.button_gerar.Name = "button_gerar";
            this.button_gerar.Size = new System.Drawing.Size(192, 23);
            this.button_gerar.TabIndex = 0;
            this.button_gerar.Text = "Sortear Números";
            this.button_gerar.UseVisualStyleBackColor = true;
            this.button_gerar.Click += new System.EventHandler(this.button_gerar_Click);
            // 
            // Resultado
            // 
            this.Resultado.FormattingEnabled = true;
            this.Resultado.Location = new System.Drawing.Point(12, 27);
            this.Resultado.Name = "Resultado";
            this.Resultado.Size = new System.Drawing.Size(192, 485);
            this.Resultado.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Os números sorteados são:";
            // 
            // closeaplication
            // 
            this.closeaplication.Location = new System.Drawing.Point(12, 547);
            this.closeaplication.Name = "closeaplication";
            this.closeaplication.Size = new System.Drawing.Size(192, 23);
            this.closeaplication.TabIndex = 3;
            this.closeaplication.Text = "Fechar";
            this.closeaplication.UseVisualStyleBackColor = true;
            this.closeaplication.Click += new System.EventHandler(this.closeaplication_Click);
            // 
            // Lotomania
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(220, 586);
            this.Controls.Add(this.closeaplication);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Resultado);
            this.Controls.Add(this.button_gerar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Lotomania";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lotomania";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_gerar;
        private System.Windows.Forms.ListBox Resultado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button closeaplication;
    }
}

