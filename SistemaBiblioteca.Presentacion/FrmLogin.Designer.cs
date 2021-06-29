
namespace SistemaBiblioteca.Presentacion
{
    partial class FrmLogin
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
            this.LblEmail = new System.Windows.Forms.Label();
            this.LblClave = new System.Windows.Forms.Label();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.TxtClave = new System.Windows.Forms.TextBox();
            this.BtnIngresar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblEmail
            // 
            this.LblEmail.AutoSize = true;
            this.LblEmail.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEmail.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LblEmail.Location = new System.Drawing.Point(25, 87);
            this.LblEmail.Name = "LblEmail";
            this.LblEmail.Size = new System.Drawing.Size(63, 23);
            this.LblEmail.TabIndex = 0;
            this.LblEmail.Text = "Email";
            // 
            // LblClave
            // 
            this.LblClave.AutoSize = true;
            this.LblClave.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblClave.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LblClave.Location = new System.Drawing.Point(25, 144);
            this.LblClave.Name = "LblClave";
            this.LblClave.Size = new System.Drawing.Size(65, 23);
            this.LblClave.TabIndex = 1;
            this.LblClave.Text = "Clave";
            // 
            // TxtEmail
            // 
            this.TxtEmail.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEmail.Location = new System.Drawing.Point(112, 84);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(310, 31);
            this.TxtEmail.TabIndex = 2;
            // 
            // TxtClave
            // 
            this.TxtClave.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtClave.Location = new System.Drawing.Point(112, 141);
            this.TxtClave.Name = "TxtClave";
            this.TxtClave.PasswordChar = '*';
            this.TxtClave.Size = new System.Drawing.Size(310, 31);
            this.TxtClave.TabIndex = 3;
            // 
            // BtnIngresar
            // 
            this.BtnIngresar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnIngresar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnIngresar.Location = new System.Drawing.Point(98, 204);
            this.BtnIngresar.Name = "BtnIngresar";
            this.BtnIngresar.Size = new System.Drawing.Size(114, 50);
            this.BtnIngresar.TabIndex = 4;
            this.BtnIngresar.Text = "Ingresar";
            this.BtnIngresar.UseVisualStyleBackColor = true;
            this.BtnIngresar.Click += new System.EventHandler(this.BtnIngresar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.Location = new System.Drawing.Point(285, 204);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(118, 50);
            this.BtnCancelar.TabIndex = 5;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(676, 289);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnIngresar);
            this.Controls.Add(this.TxtClave);
            this.Controls.Add(this.TxtEmail);
            this.Controls.Add(this.LblClave);
            this.Controls.Add(this.LblEmail);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingreso";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblEmail;
        private System.Windows.Forms.Label LblClave;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.TextBox TxtClave;
        private System.Windows.Forms.Button BtnIngresar;
        private System.Windows.Forms.Button BtnCancelar;
    }
}