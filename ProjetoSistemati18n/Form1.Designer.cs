namespace ProjetoSistemati18n
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.label1 = new System.Windows.Forms.Label();
            this.cadastrar = new System.Windows.Forms.Button();
            this.consultar = new System.Windows.Forms.Button();
            this.atualizar = new System.Windows.Forms.Button();
            this.excluir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Escolha uma das opções abaixo: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cadastrar
            // 
            this.cadastrar.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.cadastrar.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Bold);
            this.cadastrar.Location = new System.Drawing.Point(53, 91);
            this.cadastrar.Name = "cadastrar";
            this.cadastrar.Size = new System.Drawing.Size(220, 72);
            this.cadastrar.TabIndex = 5;
            this.cadastrar.Text = "Cadastrar";
            this.cadastrar.UseVisualStyleBackColor = false;
            this.cadastrar.Click += new System.EventHandler(this.cadastrar_Click);
            // 
            // consultar
            // 
            this.consultar.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.consultar.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Bold);
            this.consultar.Location = new System.Drawing.Point(53, 169);
            this.consultar.Name = "consultar";
            this.consultar.Size = new System.Drawing.Size(220, 72);
            this.consultar.TabIndex = 6;
            this.consultar.Text = "Consultar";
            this.consultar.UseVisualStyleBackColor = false;
            this.consultar.Click += new System.EventHandler(this.consultar_Click);
            // 
            // atualizar
            // 
            this.atualizar.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.atualizar.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Bold);
            this.atualizar.Location = new System.Drawing.Point(53, 247);
            this.atualizar.Name = "atualizar";
            this.atualizar.Size = new System.Drawing.Size(220, 72);
            this.atualizar.TabIndex = 7;
            this.atualizar.Text = "Atualizar";
            this.atualizar.UseVisualStyleBackColor = false;
            this.atualizar.Click += new System.EventHandler(this.atualizar_Click);
            // 
            // excluir
            // 
            this.excluir.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.excluir.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Bold);
            this.excluir.Location = new System.Drawing.Point(53, 325);
            this.excluir.Name = "excluir";
            this.excluir.Size = new System.Drawing.Size(220, 72);
            this.excluir.TabIndex = 8;
            this.excluir.Text = "Excluir";
            this.excluir.UseVisualStyleBackColor = false;
            this.excluir.Click += new System.EventHandler(this.excluir_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(327, 450);
            this.Controls.Add(this.excluir);
            this.Controls.Add(this.atualizar);
            this.Controls.Add(this.consultar);
            this.Controls.Add(this.cadastrar);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cadastrar;
        private System.Windows.Forms.Button consultar;
        private System.Windows.Forms.Button atualizar;
        private System.Windows.Forms.Button excluir;
    }
}

