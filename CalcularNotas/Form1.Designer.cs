namespace CalcularNotas
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
            this.btnSimular = new System.Windows.Forms.Button();
            this.btnMediaExame = new System.Windows.Forms.Button();
            this.btnExame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSimular
            // 
            this.btnSimular.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSimular.Location = new System.Drawing.Point(249, 69);
            this.btnSimular.Name = "btnSimular";
            this.btnSimular.Size = new System.Drawing.Size(287, 71);
            this.btnSimular.TabIndex = 2;
            this.btnSimular.Text = "Simular Média";
            this.btnSimular.UseVisualStyleBackColor = true;
            this.btnSimular.Click += new System.EventHandler(this.btnSimular_Click);
            // 
            // btnMediaExame
            // 
            this.btnMediaExame.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMediaExame.Location = new System.Drawing.Point(249, 281);
            this.btnMediaExame.Name = "btnMediaExame";
            this.btnMediaExame.Size = new System.Drawing.Size(287, 71);
            this.btnMediaExame.TabIndex = 3;
            this.btnMediaExame.Text = "Verificar a média final após a nota do Exame Final";
            this.btnMediaExame.UseVisualStyleBackColor = true;
            this.btnMediaExame.Click += new System.EventHandler(this.btnMediaExame_Click);
            // 
            // btnExame
            // 
            this.btnExame.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExame.Location = new System.Drawing.Point(249, 172);
            this.btnExame.Name = "btnExame";
            this.btnExame.Size = new System.Drawing.Size(287, 71);
            this.btnExame.TabIndex = 1;
            this.btnExame.Text = "Nota mínima para ser aprovado no Exame";
            this.btnExame.UseVisualStyleBackColor = true;
            this.btnExame.Click += new System.EventHandler(this.btnExame_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMediaExame);
            this.Controls.Add(this.btnSimular);
            this.Controls.Add(this.btnExame);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSimular;
        private System.Windows.Forms.Button btnMediaExame;
        private System.Windows.Forms.Button btnExame;
    }
}

