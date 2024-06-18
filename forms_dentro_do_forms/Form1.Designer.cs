
namespace forms_dentro_do_forms
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
            this.btn_abrir_cadastro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_abrir_cadastro
            // 
            this.btn_abrir_cadastro.Location = new System.Drawing.Point(278, 187);
            this.btn_abrir_cadastro.Name = "btn_abrir_cadastro";
            this.btn_abrir_cadastro.Size = new System.Drawing.Size(241, 65);
            this.btn_abrir_cadastro.TabIndex = 0;
            this.btn_abrir_cadastro.Text = "Cadastrar Salas";
            this.btn_abrir_cadastro.UseVisualStyleBackColor = true;
            this.btn_abrir_cadastro.Click += new System.EventHandler(this.btn_cadastro_salas);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_abrir_cadastro);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_abrir_cadastro;
    }
}

