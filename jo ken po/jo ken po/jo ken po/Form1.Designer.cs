
namespace jo_ken_po
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btPedra = new System.Windows.Forms.Button();
            this.btPapel = new System.Windows.Forms.Button();
            this.btTesoura = new System.Windows.Forms.Button();
            this.pictureJogador = new System.Windows.Forms.PictureBox();
            this.pictureCpu = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ptJogador = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ptCpu = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureJogador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCpu)).BeginInit();
            this.SuspendLayout();
            // 
            // btPedra
            // 
            this.btPedra.BackgroundImage = global::jo_ken_po.Properties.Resources.pedraD;
            this.btPedra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btPedra.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btPedra.Location = new System.Drawing.Point(19, 306);
            this.btPedra.Name = "btPedra";
            this.btPedra.Size = new System.Drawing.Size(120, 120);
            this.btPedra.TabIndex = 0;
            this.btPedra.Tag = "0";
            this.btPedra.UseVisualStyleBackColor = true;
            this.btPedra.Click += new System.EventHandler(this.clickJogada);
            // 
            // btPapel
            // 
            this.btPapel.BackgroundImage = global::jo_ken_po.Properties.Resources.papelD;
            this.btPapel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btPapel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btPapel.Location = new System.Drawing.Point(166, 306);
            this.btPapel.Name = "btPapel";
            this.btPapel.Size = new System.Drawing.Size(120, 120);
            this.btPapel.TabIndex = 1;
            this.btPapel.Tag = "1";
            this.btPapel.UseVisualStyleBackColor = true;
            this.btPapel.Click += new System.EventHandler(this.clickJogada);
            // 
            // btTesoura
            // 
            this.btTesoura.BackgroundImage = global::jo_ken_po.Properties.Resources.tesouraD;
            this.btTesoura.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btTesoura.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btTesoura.Location = new System.Drawing.Point(323, 306);
            this.btTesoura.Name = "btTesoura";
            this.btTesoura.Size = new System.Drawing.Size(120, 120);
            this.btTesoura.TabIndex = 2;
            this.btTesoura.Tag = "2";
            this.btTesoura.UseVisualStyleBackColor = true;
            this.btTesoura.Click += new System.EventHandler(this.clickJogada);
            // 
            // pictureJogador
            // 
            this.pictureJogador.BackColor = System.Drawing.Color.White;
            this.pictureJogador.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureJogador.Location = new System.Drawing.Point(52, 131);
            this.pictureJogador.Name = "pictureJogador";
            this.pictureJogador.Size = new System.Drawing.Size(120, 120);
            this.pictureJogador.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureJogador.TabIndex = 3;
            this.pictureJogador.TabStop = false;
            // 
            // pictureCpu
            // 
            this.pictureCpu.BackColor = System.Drawing.Color.White;
            this.pictureCpu.Location = new System.Drawing.Point(294, 131);
            this.pictureCpu.Name = "pictureCpu";
            this.pictureCpu.Size = new System.Drawing.Size(120, 120);
            this.pictureCpu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureCpu.TabIndex = 4;
            this.pictureCpu.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ravie", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(59, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "Jogador";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ravie", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(328, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 26);
            this.label2.TabIndex = 6;
            this.label2.Text = "CPU";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(71, 264);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Pontos";
            // 
            // ptJogador
            // 
            this.ptJogador.AutoSize = true;
            this.ptJogador.Location = new System.Drawing.Point(131, 266);
            this.ptJogador.Name = "ptJogador";
            this.ptJogador.Size = new System.Drawing.Size(13, 15);
            this.ptJogador.TabIndex = 8;
            this.ptJogador.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(312, 265);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Pontos";
            // 
            // ptCpu
            // 
            this.ptCpu.AutoSize = true;
            this.ptCpu.Location = new System.Drawing.Point(373, 267);
            this.ptCpu.Name = "ptCpu";
            this.ptCpu.Size = new System.Drawing.Size(13, 15);
            this.ptCpu.TabIndex = 10;
            this.ptCpu.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Ravie", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(98, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(270, 50);
            this.label4.TabIndex = 11;
            this.label4.Text = "JO KEN PÔ";
            // 
            // btClose
            // 
            this.btClose.BackColor = System.Drawing.Color.Red;
            this.btClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btClose.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btClose.ForeColor = System.Drawing.Color.White;
            this.btClose.Location = new System.Drawing.Point(443, 3);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(27, 23);
            this.btClose.TabIndex = 12;
            this.btClose.Text = "X";
            this.btClose.UseVisualStyleBackColor = false;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(474, 451);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ptCpu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ptJogador);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureCpu);
            this.Controls.Add(this.pictureJogador);
            this.Controls.Add(this.btTesoura);
            this.Controls.Add(this.btPapel);
            this.Controls.Add(this.btPedra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pedra, papel e tesoura";
            ((System.ComponentModel.ISupportInitialize)(this.pictureJogador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCpu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btPedra;
        private System.Windows.Forms.Button btPapel;
        private System.Windows.Forms.Button btTesoura;
        private System.Windows.Forms.PictureBox pictureJogador;
        private System.Windows.Forms.PictureBox pictureCpu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label ptJogador;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label ptCpu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btClose;
    }
}

