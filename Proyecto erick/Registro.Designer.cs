namespace Proyecto_erick
{
    partial class Registro
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btncuenta = new System.Windows.Forms.Button();
            this.btnregistro = new System.Windows.Forms.Button();
            this.txtconfirmar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtcontrasenia = new System.Windows.Forms.TextBox();
            this.txtnombusuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bntminizar = new System.Windows.Forms.Button();
            this.bntcerrar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(245)))), ((int)(((byte)(247)))));
            this.panel1.Controls.Add(this.btncuenta);
            this.panel1.Controls.Add(this.btnregistro);
            this.panel1.Controls.Add(this.txtconfirmar);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtcontrasenia);
            this.panel1.Controls.Add(this.txtnombusuario);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, 85);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1270, 759);
            this.panel1.TabIndex = 0;
            // 
            // btncuenta
            // 
            this.btncuenta.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.btncuenta.Location = new System.Drawing.Point(230, 359);
            this.btncuenta.Name = "btncuenta";
            this.btncuenta.Size = new System.Drawing.Size(341, 47);
            this.btncuenta.TabIndex = 7;
            this.btncuenta.Text = "¿Ya tiene cuenta? Incie sesión";
            this.btncuenta.UseVisualStyleBackColor = true;
            this.btncuenta.Click += new System.EventHandler(this.btncuenta_Click);
            // 
            // btnregistro
            // 
            this.btnregistro.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.btnregistro.Location = new System.Drawing.Point(260, 297);
            this.btnregistro.Name = "btnregistro";
            this.btnregistro.Size = new System.Drawing.Size(290, 43);
            this.btnregistro.TabIndex = 6;
            this.btnregistro.Text = "Registrar";
            this.btnregistro.UseVisualStyleBackColor = true;
            this.btnregistro.Click += new System.EventHandler(this.btnregistro_Click);
            // 
            // txtconfirmar
            // 
            this.txtconfirmar.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.txtconfirmar.Location = new System.Drawing.Point(367, 191);
            this.txtconfirmar.Name = "txtconfirmar";
            this.txtconfirmar.PasswordChar = '*';
            this.txtconfirmar.Size = new System.Drawing.Size(224, 33);
            this.txtconfirmar.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.label3.Location = new System.Drawing.Point(128, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(233, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Confirme contraseña:";
            // 
            // txtcontrasenia
            // 
            this.txtcontrasenia.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.txtcontrasenia.Location = new System.Drawing.Point(367, 138);
            this.txtcontrasenia.Name = "txtcontrasenia";
            this.txtcontrasenia.PasswordChar = '*';
            this.txtcontrasenia.Size = new System.Drawing.Size(224, 33);
            this.txtcontrasenia.TabIndex = 3;
            // 
            // txtnombusuario
            // 
            this.txtnombusuario.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.txtnombusuario.Location = new System.Drawing.Point(367, 78);
            this.txtnombusuario.Name = "txtnombusuario";
            this.txtnombusuario.Size = new System.Drawing.Size(224, 33);
            this.txtnombusuario.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.label2.Location = new System.Drawing.Point(128, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.label1.Location = new System.Drawing.Point(124, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre de usuario:";
            // 
            // bntminizar
            // 
            this.bntminizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(197)))), ((int)(((byte)(202)))));
            this.bntminizar.FlatAppearance.BorderSize = 0;
            this.bntminizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntminizar.Image = global::Proyecto_erick.Properties.Resources.menos__1_;
            this.bntminizar.Location = new System.Drawing.Point(746, 13);
            this.bntminizar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bntminizar.Name = "bntminizar";
            this.bntminizar.Size = new System.Drawing.Size(33, 54);
            this.bntminizar.TabIndex = 11;
            this.bntminizar.UseVisualStyleBackColor = false;
            this.bntminizar.Click += new System.EventHandler(this.button2_Click);
            // 
            // bntcerrar
            // 
            this.bntcerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(197)))), ((int)(((byte)(202)))));
            this.bntcerrar.FlatAppearance.BorderSize = 0;
            this.bntcerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntcerrar.Image = global::Proyecto_erick.Properties.Resources.close;
            this.bntcerrar.Location = new System.Drawing.Point(797, 18);
            this.bntcerrar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bntcerrar.Name = "bntcerrar";
            this.bntcerrar.Size = new System.Drawing.Size(28, 44);
            this.bntcerrar.TabIndex = 10;
            this.bntcerrar.UseVisualStyleBackColor = false;
            this.bntcerrar.Click += new System.EventHandler(this.bntcerrar_Click);
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(197)))), ((int)(((byte)(202)))));
            this.ClientSize = new System.Drawing.Size(849, 627);
            this.Controls.Add(this.bntminizar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bntcerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Registro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro";
            this.Load += new System.EventHandler(this.Registro_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btncuenta;
        private System.Windows.Forms.Button btnregistro;
        private System.Windows.Forms.TextBox txtconfirmar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtcontrasenia;
        private System.Windows.Forms.TextBox txtnombusuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bntminizar;
        private System.Windows.Forms.Button bntcerrar;
    }
}