namespace jogoDaVelha
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.jogoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reiniciarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fecharToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn11 = new System.Windows.Forms.Button();
            this.btn13 = new System.Windows.Forms.Button();
            this.btn23 = new System.Windows.Forms.Button();
            this.btn22 = new System.Windows.Forms.Button();
            this.btn21 = new System.Windows.Forms.Button();
            this.btn33 = new System.Windows.Forms.Button();
            this.btn32 = new System.Windows.Forms.Button();
            this.btn31 = new System.Windows.Forms.Button();
            this.btn12 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jogoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(444, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // jogoToolStripMenuItem
            // 
            this.jogoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reiniciarToolStripMenuItem,
            this.fecharToolStripMenuItem});
            this.jogoToolStripMenuItem.Name = "jogoToolStripMenuItem";
            this.jogoToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.jogoToolStripMenuItem.Text = "Jogo";
            // 
            // reiniciarToolStripMenuItem
            // 
            this.reiniciarToolStripMenuItem.Name = "reiniciarToolStripMenuItem";
            this.reiniciarToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.reiniciarToolStripMenuItem.Text = "Reiniciar";
            this.reiniciarToolStripMenuItem.Click += new System.EventHandler(this.reiniciarToolStripMenuItem_Click);
            // 
            // fecharToolStripMenuItem
            // 
            this.fecharToolStripMenuItem.Name = "fecharToolStripMenuItem";
            this.fecharToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.fecharToolStripMenuItem.Text = "Fechar";
            this.fecharToolStripMenuItem.Click += new System.EventHandler(this.fecharToolStripMenuItem_Click);
            // 
            // btn11
            // 
            this.btn11.BackgroundImage = global::jogoDaVelha.Properties.Resources._default;
            this.btn11.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn11.Location = new System.Drawing.Point(19, 41);
            this.btn11.Name = "btn11";
            this.btn11.Size = new System.Drawing.Size(75, 75);
            this.btn11.TabIndex = 1;
            this.btn11.UseVisualStyleBackColor = true;
            this.btn11.MouseClick += new System.Windows.Forms.MouseEventHandler(this.clickBtn);
            // 
            // btn13
            // 
            this.btn13.BackgroundImage = global::jogoDaVelha.Properties.Resources._default;
            this.btn13.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn13.Location = new System.Drawing.Point(181, 41);
            this.btn13.Name = "btn13";
            this.btn13.Size = new System.Drawing.Size(75, 75);
            this.btn13.TabIndex = 3;
            this.btn13.UseVisualStyleBackColor = true;
            this.btn13.MouseClick += new System.Windows.Forms.MouseEventHandler(this.clickBtn);
            // 
            // btn23
            // 
            this.btn23.BackgroundImage = global::jogoDaVelha.Properties.Resources._default;
            this.btn23.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn23.Location = new System.Drawing.Point(181, 122);
            this.btn23.Name = "btn23";
            this.btn23.Size = new System.Drawing.Size(75, 75);
            this.btn23.TabIndex = 6;
            this.btn23.UseVisualStyleBackColor = true;
            this.btn23.MouseClick += new System.Windows.Forms.MouseEventHandler(this.clickBtn);
            // 
            // btn22
            // 
            this.btn22.BackgroundImage = global::jogoDaVelha.Properties.Resources._default;
            this.btn22.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn22.Location = new System.Drawing.Point(100, 122);
            this.btn22.Name = "btn22";
            this.btn22.Size = new System.Drawing.Size(75, 75);
            this.btn22.TabIndex = 5;
            this.btn22.UseVisualStyleBackColor = true;
            this.btn22.MouseClick += new System.Windows.Forms.MouseEventHandler(this.clickBtn);
            // 
            // btn21
            // 
            this.btn21.BackgroundImage = global::jogoDaVelha.Properties.Resources._default;
            this.btn21.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn21.Location = new System.Drawing.Point(19, 122);
            this.btn21.Name = "btn21";
            this.btn21.Size = new System.Drawing.Size(75, 75);
            this.btn21.TabIndex = 4;
            this.btn21.UseVisualStyleBackColor = true;
            this.btn21.MouseClick += new System.Windows.Forms.MouseEventHandler(this.clickBtn);
            // 
            // btn33
            // 
            this.btn33.BackgroundImage = global::jogoDaVelha.Properties.Resources._default;
            this.btn33.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn33.Location = new System.Drawing.Point(181, 203);
            this.btn33.Name = "btn33";
            this.btn33.Size = new System.Drawing.Size(75, 75);
            this.btn33.TabIndex = 9;
            this.btn33.UseVisualStyleBackColor = true;
            this.btn33.MouseClick += new System.Windows.Forms.MouseEventHandler(this.clickBtn);
            // 
            // btn32
            // 
            this.btn32.BackgroundImage = global::jogoDaVelha.Properties.Resources._default;
            this.btn32.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn32.Location = new System.Drawing.Point(100, 203);
            this.btn32.Name = "btn32";
            this.btn32.Size = new System.Drawing.Size(75, 75);
            this.btn32.TabIndex = 8;
            this.btn32.UseVisualStyleBackColor = true;
            this.btn32.MouseClick += new System.Windows.Forms.MouseEventHandler(this.clickBtn);
            // 
            // btn31
            // 
            this.btn31.BackgroundImage = global::jogoDaVelha.Properties.Resources._default;
            this.btn31.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn31.Location = new System.Drawing.Point(19, 203);
            this.btn31.Name = "btn31";
            this.btn31.Size = new System.Drawing.Size(75, 75);
            this.btn31.TabIndex = 7;
            this.btn31.UseVisualStyleBackColor = true;
            this.btn31.MouseClick += new System.Windows.Forms.MouseEventHandler(this.clickBtn);
            // 
            // btn12
            // 
            this.btn12.BackgroundImage = global::jogoDaVelha.Properties.Resources._default;
            this.btn12.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn12.Location = new System.Drawing.Point(100, 41);
            this.btn12.Name = "btn12";
            this.btn12.Size = new System.Drawing.Size(75, 75);
            this.btn12.TabIndex = 2;
            this.btn12.UseVisualStyleBackColor = true;
            this.btn12.MouseClick += new System.Windows.Forms.MouseEventHandler(this.clickBtn);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(262, 238);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Criado por:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(260, 255);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Matheus E. Fachini";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 294);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn33);
            this.Controls.Add(this.btn32);
            this.Controls.Add(this.btn31);
            this.Controls.Add(this.btn23);
            this.Controls.Add(this.btn22);
            this.Controls.Add(this.btn21);
            this.Controls.Add(this.btn13);
            this.Controls.Add(this.btn12);
            this.Controls.Add(this.btn11);
            this.Controls.Add(this.menuStrip1);
            this.HelpButton = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Jogo da Velha";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem jogoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reiniciarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fecharToolStripMenuItem;
        private System.Windows.Forms.Button btn11;
        private System.Windows.Forms.Button btn12;
        private System.Windows.Forms.Button btn13;
        private System.Windows.Forms.Button btn23;
        private System.Windows.Forms.Button btn22;
        private System.Windows.Forms.Button btn21;
        private System.Windows.Forms.Button btn33;
        private System.Windows.Forms.Button btn32;
        private System.Windows.Forms.Button btn31;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ImageList imageList1;
    }
}

