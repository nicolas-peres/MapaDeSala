
namespace forms_dentro_do_forms.forms
{
    partial class FrmDisciplinas
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
            this.gridDisciplina = new System.Windows.Forms.DataGridView();
            this.checkActive = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numID = new System.Windows.Forms.NumericUpDown();
            this.txtSigla = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClean = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridDisciplina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numID)).BeginInit();
            this.SuspendLayout();
            // 
            // gridDisciplina
            // 
            this.gridDisciplina.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridDisciplina.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDisciplina.Location = new System.Drawing.Point(44, 99);
            this.gridDisciplina.Name = "gridDisciplina";
            this.gridDisciplina.Size = new System.Drawing.Size(856, 325);
            this.gridDisciplina.TabIndex = 18;
            this.gridDisciplina.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridDisciplina_CellClick);
            // 
            // checkActive
            // 
            this.checkActive.AutoSize = true;
            this.checkActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkActive.Location = new System.Drawing.Point(370, 50);
            this.checkActive.Name = "checkActive";
            this.checkActive.Size = new System.Drawing.Size(63, 24);
            this.checkActive.TabIndex = 16;
            this.checkActive.Text = "Ativo";
            this.checkActive.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "ID";
            // 
            // numID
            // 
            this.numID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numID.Location = new System.Drawing.Point(44, 49);
            this.numID.Name = "numID";
            this.numID.Size = new System.Drawing.Size(56, 26);
            this.numID.TabIndex = 14;
            // 
            // txtSigla
            // 
            this.txtSigla.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSigla.Location = new System.Drawing.Point(243, 48);
            this.txtSigla.Name = "txtSigla";
            this.txtSigla.Size = new System.Drawing.Size(100, 26);
            this.txtSigla.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(240, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Sigla";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(123, 48);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 26);
            this.txtName.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(120, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nome";
            // 
            // btnClean
            // 
            this.btnClean.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClean.Location = new System.Drawing.Point(437, 45);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(144, 32);
            this.btnClean.TabIndex = 20;
            this.btnClean.Text = "LIMPAR DADOS";
            this.btnClean.UseVisualStyleBackColor = true;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(589, 44);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(89, 33);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "SALVAR";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click_1);
            // 
            // btnDel
            // 
            this.btnDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDel.Location = new System.Drawing.Point(685, 45);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(97, 32);
            this.btnDel.TabIndex = 21;
            this.btnDel.Text = "EXCLUIR";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(788, 45);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(93, 32);
            this.btnEditar.TabIndex = 22;
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // FrmDisciplinas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 450);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.gridDisciplina);
            this.Controls.Add(this.checkActive);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numID);
            this.Controls.Add(this.txtSigla);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.MaximizeBox = false;
            this.Name = "FrmDisciplinas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmDisciplinas";
            this.Load += new System.EventHandler(this.FrmDisciplinas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridDisciplina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridDisciplina;
        private System.Windows.Forms.CheckBox checkActive;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numID;
        private System.Windows.Forms.TextBox txtSigla;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnEditar;
    }
}