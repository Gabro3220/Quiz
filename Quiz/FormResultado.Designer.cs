
namespace Quiz
{
    partial class FormResultado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormResultado));
            this.pnl1 = new System.Windows.Forms.Panel();
            this.lblResulErr = new System.Windows.Forms.Label();
            this.lblResulAcer = new System.Windows.Forms.Label();
            this.lblErros = new System.Windows.Forms.Label();
            this.lblAcertos = new System.Windows.Forms.Label();
            this.lbltema = new System.Windows.Forms.Label();
            this.lblMsgacerto = new System.Windows.Forms.Label();
            this.btnProximo = new System.Windows.Forms.Button();
            this.lblMsgErro = new System.Windows.Forms.Label();
            this.pnl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl1
            // 
            this.pnl1.BackColor = System.Drawing.Color.Transparent;
            this.pnl1.Controls.Add(this.lblResulErr);
            this.pnl1.Controls.Add(this.lblResulAcer);
            this.pnl1.Controls.Add(this.lblErros);
            this.pnl1.Controls.Add(this.lblAcertos);
            this.pnl1.Location = new System.Drawing.Point(506, 156);
            this.pnl1.Name = "pnl1";
            this.pnl1.Size = new System.Drawing.Size(308, 160);
            this.pnl1.TabIndex = 42;
            // 
            // lblResulErr
            // 
            this.lblResulErr.AutoSize = true;
            this.lblResulErr.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResulErr.ForeColor = System.Drawing.Color.Red;
            this.lblResulErr.Location = new System.Drawing.Point(108, 108);
            this.lblResulErr.Name = "lblResulErr";
            this.lblResulErr.Size = new System.Drawing.Size(0, 32);
            this.lblResulErr.TabIndex = 1;
            // 
            // lblResulAcer
            // 
            this.lblResulAcer.AutoSize = true;
            this.lblResulAcer.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResulAcer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(230)))), ((int)(((byte)(99)))));
            this.lblResulAcer.Location = new System.Drawing.Point(153, 28);
            this.lblResulAcer.Name = "lblResulAcer";
            this.lblResulAcer.Size = new System.Drawing.Size(0, 32);
            this.lblResulAcer.TabIndex = 1;
            // 
            // lblErros
            // 
            this.lblErros.AutoSize = true;
            this.lblErros.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErros.ForeColor = System.Drawing.Color.Red;
            this.lblErros.Location = new System.Drawing.Point(14, 104);
            this.lblErros.Name = "lblErros";
            this.lblErros.Size = new System.Drawing.Size(88, 36);
            this.lblErros.TabIndex = 0;
            this.lblErros.Text = "Erros:";
            // 
            // lblAcertos
            // 
            this.lblAcertos.AutoSize = true;
            this.lblAcertos.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAcertos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(230)))), ((int)(((byte)(99)))));
            this.lblAcertos.Location = new System.Drawing.Point(14, 24);
            this.lblAcertos.Name = "lblAcertos";
            this.lblAcertos.Size = new System.Drawing.Size(132, 36);
            this.lblAcertos.TabIndex = 0;
            this.lblAcertos.Text = "Acertos:";
            // 
            // lbltema
            // 
            this.lbltema.AutoSize = true;
            this.lbltema.BackColor = System.Drawing.Color.Transparent;
            this.lbltema.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltema.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lbltema.Location = new System.Drawing.Point(594, 99);
            this.lbltema.Name = "lbltema";
            this.lbltema.Size = new System.Drawing.Size(155, 32);
            this.lbltema.TabIndex = 40;
            this.lbltema.Text = "Resultados";
            this.lbltema.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMsgacerto
            // 
            this.lblMsgacerto.BackColor = System.Drawing.Color.Transparent;
            this.lblMsgacerto.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsgacerto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(207)))), ((int)(((byte)(99)))));
            this.lblMsgacerto.Location = new System.Drawing.Point(218, 328);
            this.lblMsgacerto.Name = "lblMsgacerto";
            this.lblMsgacerto.Size = new System.Drawing.Size(940, 38);
            this.lblMsgacerto.TabIndex = 43;
            this.lblMsgacerto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnProximo
            // 
            this.btnProximo.BackColor = System.Drawing.Color.Transparent;
            this.btnProximo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProximo.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProximo.ForeColor = System.Drawing.Color.White;
            this.btnProximo.Location = new System.Drawing.Point(969, 464);
            this.btnProximo.Name = "btnProximo";
            this.btnProximo.Size = new System.Drawing.Size(140, 32);
            this.btnProximo.TabIndex = 44;
            this.btnProximo.Text = "Reniciar";
            this.btnProximo.UseVisualStyleBackColor = false;
            this.btnProximo.Click += new System.EventHandler(this.btnProximo_Click);
            // 
            // lblMsgErro
            // 
            this.lblMsgErro.BackColor = System.Drawing.Color.Transparent;
            this.lblMsgErro.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsgErro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(207)))), ((int)(((byte)(99)))));
            this.lblMsgErro.Location = new System.Drawing.Point(218, 375);
            this.lblMsgErro.Name = "lblMsgErro";
            this.lblMsgErro.Size = new System.Drawing.Size(940, 38);
            this.lblMsgErro.TabIndex = 45;
            this.lblMsgErro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormResultado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Quiz.Properties.Resources.Minimalist_Anime_Wallpaper_Phone;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1248, 594);
            this.Controls.Add(this.lblMsgErro);
            this.Controls.Add(this.btnProximo);
            this.Controls.Add(this.lblMsgacerto);
            this.Controls.Add(this.pnl1);
            this.Controls.Add(this.lbltema);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormResultado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormResultado";
            this.Load += new System.EventHandler(this.FormResultado_Load);
            this.pnl1.ResumeLayout(false);
            this.pnl1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl1;
        private System.Windows.Forms.Label lblResulErr;
        private System.Windows.Forms.Label lblResulAcer;
        private System.Windows.Forms.Label lblErros;
        private System.Windows.Forms.Label lblAcertos;
        private System.Windows.Forms.Label lbltema;
        private System.Windows.Forms.Label lblMsgacerto;
        private System.Windows.Forms.Button btnProximo;
        private System.Windows.Forms.Label lblMsgErro;
    }
}