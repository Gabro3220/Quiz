﻿
namespace Quiz
{
    partial class FormP2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormP2));
            this.btnProximo = new System.Windows.Forms.Button();
            this.pnl1 = new System.Windows.Forms.Panel();
            this.rdoPerg4 = new System.Windows.Forms.RadioButton();
            this.rdoPerg2 = new System.Windows.Forms.RadioButton();
            this.rdoCerta = new System.Windows.Forms.RadioButton();
            this.lblPerg = new System.Windows.Forms.Label();
            this.lbltema = new System.Windows.Forms.Label();
            this.pnl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnProximo
            // 
            this.btnProximo.BackColor = System.Drawing.Color.Transparent;
            this.btnProximo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProximo.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProximo.ForeColor = System.Drawing.Color.White;
            this.btnProximo.Location = new System.Drawing.Point(922, 458);
            this.btnProximo.Name = "btnProximo";
            this.btnProximo.Size = new System.Drawing.Size(140, 32);
            this.btnProximo.TabIndex = 4;
            this.btnProximo.Text = "Próximo";
            this.btnProximo.UseVisualStyleBackColor = false;
            this.btnProximo.Click += new System.EventHandler(this.btnProximo_Click);
            // 
            // pnl1
            // 
            this.pnl1.BackColor = System.Drawing.Color.Transparent;
            this.pnl1.Controls.Add(this.rdoPerg4);
            this.pnl1.Controls.Add(this.rdoPerg2);
            this.pnl1.Controls.Add(this.rdoCerta);
            this.pnl1.Location = new System.Drawing.Point(168, 187);
            this.pnl1.Name = "pnl1";
            this.pnl1.Size = new System.Drawing.Size(844, 232);
            this.pnl1.TabIndex = 7;
            // 
            // rdoPerg4
            // 
            this.rdoPerg4.AutoSize = true;
            this.rdoPerg4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoPerg4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.rdoPerg4.Location = new System.Drawing.Point(16, 112);
            this.rdoPerg4.Name = "rdoPerg4";
            this.rdoPerg4.Size = new System.Drawing.Size(596, 22);
            this.rdoPerg4.TabIndex = 100;
            this.rdoPerg4.TabStop = true;
            this.rdoPerg4.Text = " é uma linguagem de marcação utilizada na construção de páginas na Web.";
            this.rdoPerg4.UseVisualStyleBackColor = true;
            // 
            // rdoPerg2
            // 
            this.rdoPerg2.AutoSize = true;
            this.rdoPerg2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoPerg2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.rdoPerg2.Location = new System.Drawing.Point(16, 46);
            this.rdoPerg2.Name = "rdoPerg2";
            this.rdoPerg2.Size = new System.Drawing.Size(708, 22);
            this.rdoPerg2.TabIndex = 9;
            this.rdoPerg2.TabStop = true;
            this.rdoPerg2.Text = "é um software malicioso que é desenvolvido por programadores geralmente inescrupu" +
    "losos.";
            this.rdoPerg2.UseVisualStyleBackColor = true;
            // 
            // rdoCerta
            // 
            this.rdoCerta.AutoSize = true;
            this.rdoCerta.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoCerta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.rdoCerta.Location = new System.Drawing.Point(16, 170);
            this.rdoCerta.Name = "rdoCerta";
            this.rdoCerta.Size = new System.Drawing.Size(714, 22);
            this.rdoCerta.TabIndex = 10;
            this.rdoCerta.TabStop = true;
            this.rdoCerta.Text = " é um conjunto de instruções que descrevem uma tarefa a ser realizada por um comp" +
    "utador. ";
            this.rdoCerta.UseVisualStyleBackColor = true;
            // 
            // lblPerg
            // 
            this.lblPerg.BackColor = System.Drawing.Color.Transparent;
            this.lblPerg.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblPerg.Location = new System.Drawing.Point(266, 140);
            this.lblPerg.Name = "lblPerg";
            this.lblPerg.Size = new System.Drawing.Size(705, 31);
            this.lblPerg.TabIndex = 6;
            this.lblPerg.Text = "O que é um programa?";
            this.lblPerg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbltema
            // 
            this.lbltema.AutoSize = true;
            this.lbltema.BackColor = System.Drawing.Color.Transparent;
            this.lbltema.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltema.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lbltema.Location = new System.Drawing.Point(178, 83);
            this.lbltema.Name = "lbltema";
            this.lbltema.Size = new System.Drawing.Size(165, 32);
            this.lbltema.TabIndex = 5;
            this.lbltema.Text = "2º Pergunta";
            // 
            // FormP2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
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
            this.Name = "FormP2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormP2";
            this.pnl1.ResumeLayout(false);
            this.pnl1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnProximo;
        private System.Windows.Forms.Panel pnl1;
        private System.Windows.Forms.RadioButton rdoPerg4;
        private System.Windows.Forms.RadioButton rdoPerg2;
        private System.Windows.Forms.RadioButton rdoCerta;
        private System.Windows.Forms.Label lblPerg;
        private System.Windows.Forms.Label lbltema;
    }
}