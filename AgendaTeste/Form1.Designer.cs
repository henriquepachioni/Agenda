﻿namespace AgendaTeste
{
    partial class Form1
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
            this.lblContatoNovo = new System.Windows.Forms.Label();
            this.txtContatoNovo = new System.Windows.Forms.TextBox();
            this.lblContatoSalvo = new System.Windows.Forms.Label();
            this.txtContatoSalvo = new System.Windows.Forms.TextBox();
            this.btnSalvarContato = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblContatoNovo
            // 
            this.lblContatoNovo.AutoSize = true;
            this.lblContatoNovo.Location = new System.Drawing.Point(13, 13);
            this.lblContatoNovo.Name = "lblContatoNovo";
            this.lblContatoNovo.Size = new System.Drawing.Size(73, 13);
            this.lblContatoNovo.TabIndex = 0;
            this.lblContatoNovo.Text = "Contato Novo";
            this.lblContatoNovo.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtContatoNovo
            // 
            this.txtContatoNovo.Location = new System.Drawing.Point(16, 30);
            this.txtContatoNovo.Name = "txtContatoNovo";
            this.txtContatoNovo.Size = new System.Drawing.Size(366, 20);
            this.txtContatoNovo.TabIndex = 1;
            // 
            // lblContatoSalvo
            // 
            this.lblContatoSalvo.AutoSize = true;
            this.lblContatoSalvo.Location = new System.Drawing.Point(13, 63);
            this.lblContatoSalvo.Name = "lblContatoSalvo";
            this.lblContatoSalvo.Size = new System.Drawing.Size(74, 13);
            this.lblContatoSalvo.TabIndex = 2;
            this.lblContatoSalvo.Text = "Contato Salvo";
            // 
            // txtContatoSalvo
            // 
            this.txtContatoSalvo.Enabled = false;
            this.txtContatoSalvo.Location = new System.Drawing.Point(16, 79);
            this.txtContatoSalvo.Name = "txtContatoSalvo";
            this.txtContatoSalvo.Size = new System.Drawing.Size(366, 20);
            this.txtContatoSalvo.TabIndex = 3;
            // 
            // btnSalvarContato
            // 
            this.btnSalvarContato.Location = new System.Drawing.Point(16, 118);
            this.btnSalvarContato.Name = "btnSalvarContato";
            this.btnSalvarContato.Size = new System.Drawing.Size(99, 31);
            this.btnSalvarContato.TabIndex = 4;
            this.btnSalvarContato.Text = "Salvar Contato";
            this.btnSalvarContato.UseVisualStyleBackColor = true;
            this.btnSalvarContato.Click += new System.EventHandler(this.btnSalvarContato_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSalvarContato);
            this.Controls.Add(this.txtContatoSalvo);
            this.Controls.Add(this.lblContatoSalvo);
            this.Controls.Add(this.txtContatoNovo);
            this.Controls.Add(this.lblContatoNovo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblContatoNovo;
        private System.Windows.Forms.TextBox txtContatoNovo;
        private System.Windows.Forms.Label lblContatoSalvo;
        private System.Windows.Forms.TextBox txtContatoSalvo;
        private System.Windows.Forms.Button btnSalvarContato;
    }
}
