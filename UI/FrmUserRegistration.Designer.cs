
namespace UI
{
    partial class FrmUserRegistration
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblCpf = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtDocumento = new System.Windows.Forms.MaskedTextBox();
            this.txtEmail = new System.Windows.Forms.MaskedTextBox();
            this.BtnSendForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(39, 46);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(53, 16);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Nome:";
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpf.Location = new System.Drawing.Point(39, 115);
            this.lblCpf.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(35, 16);
            this.lblCpf.TabIndex = 1;
            this.lblCpf.Text = "Cpf:";
            this.lblCpf.Click += new System.EventHandler(this.lblTel_Click);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(39, 83);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(51, 16);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "Email:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(156, 46);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(350, 22);
            this.txtName.TabIndex = 3;
            // 
            // txtDocumento
            // 
            this.txtDocumento.Culture = new System.Globalization.CultureInfo("");
            this.txtDocumento.Location = new System.Drawing.Point(156, 112);
            this.txtDocumento.Mask = "000.000.000-00";
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(122, 22);
            this.txtDocumento.TabIndex = 6;
            // 
            // txtEmail
            // 
            this.txtEmail.Culture = new System.Globalization.CultureInfo("");
            this.txtEmail.Location = new System.Drawing.Point(156, 80);
            this.txtEmail.Mask = "aaaaa@aaaaaa.aaa";
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(122, 22);
            this.txtEmail.TabIndex = 7;
            // 
            // BtnSendForm
            // 
            this.BtnSendForm.Location = new System.Drawing.Point(357, 162);
            this.BtnSendForm.Name = "BtnSendForm";
            this.BtnSendForm.Size = new System.Drawing.Size(149, 23);
            this.BtnSendForm.TabIndex = 8;
            this.BtnSendForm.Text = "Enviar formulário";
            this.BtnSendForm.UseVisualStyleBackColor = true;
            this.BtnSendForm.Click += new System.EventHandler(this.BtnSendForm_Click);
            // 
            // FrmUserRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 554);
            this.Controls.Add(this.BtnSendForm);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtDocumento);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblCpf);
            this.Controls.Add(this.lblName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmUserRegistration";
            this.Text = "User registration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.MaskedTextBox txtDocumento;
        private System.Windows.Forms.MaskedTextBox txtEmail;
        private System.Windows.Forms.Button BtnSendForm;
    }
}

