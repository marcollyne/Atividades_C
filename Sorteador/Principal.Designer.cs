
namespace Sorteador
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projetoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Sortear = new System.Windows.Forms.Button();
            this.configurar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.valor1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.valor2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.editarToolStripMenuItem,
            this.projetoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(405, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoToolStripMenuItem});
            this.arquivoToolStripMenuItem.ForeColor = System.Drawing.Color.MediumOrchid;
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "A&rquivo";
            // 
            // novoToolStripMenuItem
            // 
            this.novoToolStripMenuItem.ForeColor = System.Drawing.Color.MediumOrchid;
            this.novoToolStripMenuItem.Name = "novoToolStripMenuItem";
            this.novoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.N)));
            this.novoToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.novoToolStripMenuItem.Text = "Novo";
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.ForeColor = System.Drawing.Color.MediumOrchid;
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.editarToolStripMenuItem.Text = "&Editar";
            // 
            // projetoToolStripMenuItem
            // 
            this.projetoToolStripMenuItem.ForeColor = System.Drawing.Color.MediumOrchid;
            this.projetoToolStripMenuItem.Name = "projetoToolStripMenuItem";
            this.projetoToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.projetoToolStripMenuItem.Text = "&Projeto";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(0, 102);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(405, 109);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("AR CARTER", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumOrchid;
            this.label1.Location = new System.Drawing.Point(103, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 78);
            this.label1.TabIndex = 0;
            this.label1.Text = "BEM VINDO";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Sortear
            // 
            this.Sortear.BackColor = System.Drawing.Color.Transparent;
            this.Sortear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Sortear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sortear.ForeColor = System.Drawing.Color.MediumOrchid;
            this.Sortear.Location = new System.Drawing.Point(244, 231);
            this.Sortear.Name = "Sortear";
            this.Sortear.Size = new System.Drawing.Size(116, 36);
            this.Sortear.TabIndex = 7;
            this.Sortear.Text = "SORTEAR";
            this.Sortear.UseVisualStyleBackColor = false;
            this.Sortear.Click += new System.EventHandler(this.Sortear_Click);
            // 
            // configurar
            // 
            this.configurar.BackColor = System.Drawing.Color.Transparent;
            this.configurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.configurar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.configurar.ForeColor = System.Drawing.Color.MediumOrchid;
            this.configurar.Location = new System.Drawing.Point(45, 231);
            this.configurar.Name = "configurar";
            this.configurar.Size = new System.Drawing.Size(148, 36);
            this.configurar.TabIndex = 8;
            this.configurar.Text = "CONFIGURAR";
            this.configurar.UseVisualStyleBackColor = false;
            this.configurar.Click += new System.EventHandler(this.configurar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("AR CARTER", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MediumOrchid;
            this.label2.Location = new System.Drawing.Point(23, 281);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(231, 47);
            this.label2.TabIndex = 9;
            this.label2.Text = "Números para sortear de";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // valor1
            // 
            this.valor1.AutoSize = true;
            this.valor1.Font = new System.Drawing.Font("AR CARTER", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valor1.ForeColor = System.Drawing.Color.MediumOrchid;
            this.valor1.Location = new System.Drawing.Point(258, 282);
            this.valor1.Name = "valor1";
            this.valor1.Size = new System.Drawing.Size(32, 44);
            this.valor1.TabIndex = 10;
            this.valor1.Text = " 1";
            this.valor1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("AR CARTER", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MediumOrchid;
            this.label4.Location = new System.Drawing.Point(296, 277);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 52);
            this.label4.TabIndex = 11;
            this.label4.Text = "a";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // valor2
            // 
            this.valor2.AutoSize = true;
            this.valor2.Font = new System.Drawing.Font("AR CARTER", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valor2.ForeColor = System.Drawing.Color.MediumOrchid;
            this.valor2.Location = new System.Drawing.Point(332, 282);
            this.valor2.Name = "valor2";
            this.valor2.Size = new System.Drawing.Size(45, 47);
            this.valor2.TabIndex = 12;
            this.valor2.Text = " 10";
            this.valor2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(405, 340);
            this.Controls.Add(this.valor2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.valor1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.configurar);
            this.Controls.Add(this.Sortear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projetoToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button configurar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label valor2;
        public System.Windows.Forms.Label valor1;
        public System.Windows.Forms.Button Sortear;
    }
}

