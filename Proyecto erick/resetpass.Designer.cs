namespace Proyecto_erick
{
    partial class resetpass
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
            this.btnreset = new System.Windows.Forms.Button();
            this.txtconfimpass = new System.Windows.Forms.TextBox();
            this.txtresetpass = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(245)))), ((int)(((byte)(247)))));
            this.panel1.Controls.Add(this.btnreset);
            this.panel1.Controls.Add(this.txtconfimpass);
            this.panel1.Controls.Add(this.txtresetpass);
            this.panel1.Location = new System.Drawing.Point(1, 79);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(818, 537);
            this.panel1.TabIndex = 1;
            // 
            // btnreset
            // 
            this.btnreset.Location = new System.Drawing.Point(280, 202);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(179, 36);
            this.btnreset.TabIndex = 3;
            this.btnreset.Text = "Reset Password";
            this.btnreset.UseVisualStyleBackColor = true;
            // 
            // txtconfimpass
            // 
            this.txtconfimpass.Location = new System.Drawing.Point(295, 138);
            this.txtconfimpass.Name = "txtconfimpass";
            this.txtconfimpass.Size = new System.Drawing.Size(164, 26);
            this.txtconfimpass.TabIndex = 1;
            // 
            // txtresetpass
            // 
            this.txtresetpass.Location = new System.Drawing.Point(276, 43);
            this.txtresetpass.Name = "txtresetpass";
            this.txtresetpass.Size = new System.Drawing.Size(183, 26);
            this.txtresetpass.TabIndex = 0;
            // 
            // resetpass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(197)))), ((int)(((byte)(202)))));
            this.ClientSize = new System.Drawing.Size(810, 576);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "resetpass";
            this.Text = "resetpass";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnreset;
        private System.Windows.Forms.TextBox txtconfimpass;
        private System.Windows.Forms.TextBox txtresetpass;
    }
}