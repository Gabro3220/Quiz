
namespace Quiz
{
    partial class FormP1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormP1));
            this.lbltema = new System.Windows.Forms.Label();
            this.lblPerg = new System.Windows.Forms.Label();
            this.rdoCerta = new System.Windows.Forms.RadioButton();
            this.pnl1 = new System.Windows.Forms.Panel();
            this.rdoPerg3 = new System.Windows.Forms.RadioButton();
            this.rdoPerg2 = new System.Windows.Forms.RadioButton();
            this.btnProximo = new System.Windows.Forms.Button();
            this.pnl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbltema
            // 
            this.lbltema.AutoSize = true;
            this.lbltema.BackColor = System.Drawing.Color.Transparent;
            this.lbltema.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltema.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lbltema.Location = new System.Drawing.Point(91, 48);
            this.lbltema.Name = "lbltema";
            this.lbltema.Size = new System.Drawing.Size(165, 32);
            this.lbltema.TabIndex = 0;
            this.lbltema.Text = "1º Pergunta";
            // 
            // lblPerg
            // 
            this.lblPerg.BackColor = System.Drawing.Color.Transparent;
            this.lblPerg.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblPerg.Location = new System.Drawing.Point(256, 157);
            this.lblPerg.Name = "lblPerg";
            this.lblPerg.Size = new System.Drawing.Size(705, 31);
            this.lblPerg.TabIndex = 1;
            this.lblPerg.Text = "O que é um sistema?";
            this.lblPerg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rdoCerta
            // 
            this.rdoCerta.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.rdoCerta.AutoSize = true;
            this.rdoCerta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.rdoCerta.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoCerta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.rdoCerta.Location = new System.Drawing.Point(3, 84);
            this.rdoCerta.Name = "rdoCerta";
            this.rdoCerta.Size = new System.Drawing.Size(1053, 58);
            this.rdoCerta.TabIndex = 10;
            this.rdoCerta.TabStop = true;
            this.rdoCerta.Text = resources.GetString("rdoCerta.Text");
            this.rdoCerta.UseVisualStyleBackColor = true;
            // 
            // pnl1
            // 
            this.pnl1.BackColor = System.Drawing.Color.Transparent;
            this.pnl1.Controls.Add(this.rdoPerg3);
            this.pnl1.Controls.Add(this.rdoPerg2);
            this.pnl1.Controls.Add(this.rdoCerta);
            this.pnl1.Location = new System.Drawing.Point(69, 207);
            this.pnl1.Name = "pnl1";
            this.pnl1.Size = new System.Drawing.Size(1093, 232);
            this.pnl1.TabIndex = 3;
            // 
            // rdoPerg3
            // 
            this.rdoPerg3.AutoSize = true;
            this.rdoPerg3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoPerg3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.rdoPerg3.Location = new System.Drawing.Point(3, 180);
            this.rdoPerg3.Name = "rdoPerg3";
            this.rdoPerg3.Size = new System.Drawing.Size(1008, 22);
            this.rdoPerg3.TabIndex = 96;
            this.rdoPerg3.TabStop = true;
            this.rdoPerg3.Text = " funciona como uma espécie de portal, ou seja, age como uma espécie de “fio condu" +
    "tor” da conexão do dispositivo com a internet.";
            this.rdoPerg3.UseVisualStyleBackColor = true;
            // 
            // rdoPerg2
            // 
            this.rdoPerg2.AutoSize = true;
            this.rdoPerg2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoPerg2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.rdoPerg2.Location = new System.Drawing.Point(3, 15);
            this.rdoPerg2.Name = "rdoPerg2";
            this.rdoPerg2.Size = new System.Drawing.Size(844, 22);
            this.rdoPerg2.TabIndex = 9;
            this.rdoPerg2.TabStop = true;
            this.rdoPerg2.Text = "pode ser definido como um conjunto de instruções que permitem ao usuário controla" +
    "r um aparelho eletrônico.";
            this.rdoPerg2.UseVisualStyleBackColor = true;
            // 
            // btnProximo
            // 
            this.btnProximo.BackColor = System.Drawing.Color.Transparent;
            this.btnProximo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProximo.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProximo.ForeColor = System.Drawing.Color.White;
            this.btnProximo.Location = new System.Drawing.Point(1022, 480);
            this.btnProximo.Name = "btnProximo";
            this.btnProximo.Size = new System.Drawing.Size(140, 32);
            this.btnProximo.TabIndex = 0;
            this.btnProximo.Text = "Próximo";
            this.btnProximo.UseVisualStyleBackColor = false;
            this.btnProximo.Click += new System.EventHandler(this.btnProximo_Click);
            // 
            // FormP1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Quiz.Properties.Resources._50_Minimalist_Desktop_Wallpapers_and_Backgrounds__2021_Edition_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1248, 594);
            this.Controls.Add(this.btnProximo);
            this.Controls.Add(this.pnl1);
            this.Controls.Add(this.lblPerg);
            this.Controls.Add(this.lbltema);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormP1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormP1";
            this.pnl1.ResumeLayout(false);
            this.pnl1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltema;
        private System.Windows.Forms.Label lblPerg;
        private System.Windows.Forms.Panel pnl1;
        private System.Windows.Forms.RadioButton rdoPerg3;
        private System.Windows.Forms.RadioButton rdoPerg2;
        private System.Windows.Forms.Button btnProximo;
        private System.Windows.Forms.RadioButton rdoCerta;
    }
}