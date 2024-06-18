
namespace forms_dentro_do_forms
{
    partial class frm_salas
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
            this.n_pc = new System.Windows.Forms.NumericUpDown();
            this.n_cadeira = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.check_islab = new System.Windows.Forms.CheckBox();
            this.check_disp = new System.Windows.Forms.CheckBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.Grid_salas = new System.Windows.Forms.DataGridView();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.btnDel = new System.Windows.Forms.Button();
            this.btn_Delet = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.num_ID = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.n_pc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.n_cadeira)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_salas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_ID)).BeginInit();
            this.SuspendLayout();
            // 
            // n_pc
            // 
            this.n_pc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n_pc.Location = new System.Drawing.Point(262, 53);
            this.n_pc.Name = "n_pc";
            this.n_pc.Size = new System.Drawing.Size(92, 26);
            this.n_pc.TabIndex = 0;
            // 
            // n_cadeira
            // 
            this.n_cadeira.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n_cadeira.Location = new System.Drawing.Point(391, 53);
            this.n_cadeira.Name = "n_cadeira";
            this.n_cadeira.Size = new System.Drawing.Size(92, 26);
            this.n_cadeira.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(106, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nome da sala";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(259, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Núm de PCs";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(373, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Núm de cadeiras";
            // 
            // check_islab
            // 
            this.check_islab.AutoSize = true;
            this.check_islab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_islab.Location = new System.Drawing.Point(522, 52);
            this.check_islab.Name = "check_islab";
            this.check_islab.Size = new System.Drawing.Size(144, 24);
            this.check_islab.TabIndex = 10;
            this.check_islab.Text = "É um laboratório";
            this.check_islab.UseVisualStyleBackColor = true;
            // 
            // check_disp
            // 
            this.check_disp.AutoSize = true;
            this.check_disp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_disp.Location = new System.Drawing.Point(674, 52);
            this.check_disp.Name = "check_disp";
            this.check_disp.Size = new System.Drawing.Size(100, 24);
            this.check_disp.TabIndex = 11;
            this.check_disp.Text = "Disponível";
            this.check_disp.UseVisualStyleBackColor = true;
            // 
            // btn_save
            // 
            this.btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Location = new System.Drawing.Point(784, 48);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(115, 36);
            this.btn_save.TabIndex = 12;
            this.btn_save.Text = "SALVAR";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // Grid_salas
            // 
            this.Grid_salas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Grid_salas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_salas.Location = new System.Drawing.Point(40, 150);
            this.Grid_salas.Name = "Grid_salas";
            this.Grid_salas.Size = new System.Drawing.Size(859, 327);
            this.Grid_salas.TabIndex = 13;
            this.Grid_salas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_salas_CellClick);
            // 
            // txt_name
            // 
            this.txt_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.Location = new System.Drawing.Point(108, 53);
            this.txt_name.Multiline = true;
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(117, 26);
            this.txt_name.TabIndex = 14;
            // 
            // btnDel
            // 
            this.btnDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDel.Location = new System.Drawing.Point(784, 97);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(115, 34);
            this.btnDel.TabIndex = 15;
            this.btnDel.Text = "LIMPAR";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btn_Delet
            // 
            this.btn_Delet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delet.Location = new System.Drawing.Point(539, 97);
            this.btn_Delet.Name = "btn_Delet";
            this.btn_Delet.Size = new System.Drawing.Size(118, 34);
            this.btn_Delet.TabIndex = 16;
            this.btn_Delet.Text = "EXCLUIR";
            this.btn_Delet.UseVisualStyleBackColor = true;
            this.btn_Delet.Click += new System.EventHandler(this.btn_Delet_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(663, 97);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(115, 34);
            this.btnEdit.TabIndex = 17;
            this.btnEdit.Text = "EDITAR";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // num_ID
            // 
            this.num_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_ID.Location = new System.Drawing.Point(40, 54);
            this.num_ID.Name = "num_ID";
            this.num_ID.Size = new System.Drawing.Size(47, 26);
            this.num_ID.TabIndex = 18;
            // 
            // frm_salas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 504);
            this.Controls.Add(this.num_ID);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btn_Delet);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.Grid_salas);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.check_disp);
            this.Controls.Add(this.check_islab);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.n_cadeira);
            this.Controls.Add(this.n_pc);
            this.MaximizeBox = false;
            this.Name = "frm_salas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formulário de salas";
            ((System.ComponentModel.ISupportInitialize)(this.n_pc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.n_cadeira)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_salas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_ID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown n_pc;
        private System.Windows.Forms.NumericUpDown n_cadeira;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox check_islab;
        private System.Windows.Forms.CheckBox check_disp;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.DataGridView Grid_salas;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btn_Delet;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.NumericUpDown num_ID;
    }
}