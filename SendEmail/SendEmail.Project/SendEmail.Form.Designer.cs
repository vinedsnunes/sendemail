
namespace SendEmail.Project
{
    partial class SendEmail
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_destinatario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_assunto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_mensagem = new System.Windows.Forms.TextBox();
            this.btn_enviar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Destinatário";
            // 
            // txt_destinatario
            // 
            this.txt_destinatario.Location = new System.Drawing.Point(13, 32);
            this.txt_destinatario.Name = "txt_destinatario";
            this.txt_destinatario.Size = new System.Drawing.Size(167, 23);
            this.txt_destinatario.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Assunto";
            // 
            // txt_assunto
            // 
            this.txt_assunto.Location = new System.Drawing.Point(13, 81);
            this.txt_assunto.Name = "txt_assunto";
            this.txt_assunto.Size = new System.Drawing.Size(167, 23);
            this.txt_assunto.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mensagem";
            // 
            // txt_mensagem
            // 
            this.txt_mensagem.Location = new System.Drawing.Point(13, 130);
            this.txt_mensagem.Multiline = true;
            this.txt_mensagem.Name = "txt_mensagem";
            this.txt_mensagem.Size = new System.Drawing.Size(369, 144);
            this.txt_mensagem.TabIndex = 5;
            // 
            // btn_enviar
            // 
            this.btn_enviar.Location = new System.Drawing.Point(306, 281);
            this.btn_enviar.Name = "btn_enviar";
            this.btn_enviar.Size = new System.Drawing.Size(75, 23);
            this.btn_enviar.TabIndex = 6;
            this.btn_enviar.Text = "Enviar";
            this.btn_enviar.UseVisualStyleBackColor = true;
            this.btn_enviar.Click += new System.EventHandler(this.btn_enviar_Click);
            // 
            // SendEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_enviar);
            this.Controls.Add(this.txt_mensagem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_assunto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_destinatario);
            this.Controls.Add(this.label1);
            this.Name = "SendEmail";
            this.Text = "SendEmail";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_destinatario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_assunto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_mensagem;
        private System.Windows.Forms.Button btn_enviar;
    }
}