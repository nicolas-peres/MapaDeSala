using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model.entidades;

namespace forms_dentro_do_forms.forms
{
    public partial class FrmDisciplinas : Form
    {
        DataTable dados;
        int LinhaS;

        public FrmDisciplinas()
        {
            InitializeComponent();
            dados = new DataTable();
            foreach (var atributos in typeof(DisciplinasEntidade).GetProperties())
            {
                dados.Columns.Add(atributos.Name);
            }

            dados.Rows.Add(1, "matemática", "mat", true);
            dados.Rows.Add(2, "portugues", "port", true);
            dados.Rows.Add(3, "geografia", "geo", true);

            gridDisciplina.DataSource = dados;
        }


        private void btnSave_Click_1(object sender, EventArgs e)
        {
            DisciplinasEntidade disciplina = new DisciplinasEntidade();
            disciplina.Id = Convert.ToInt32(numID.Value);
            disciplina.Nome = txtName.Text;
            disciplina.Sigla = txtSigla.Text;
            disciplina.Ativo = checkActive.Checked;

            dados.Rows.Add(disciplina.Linha());
            LimparDados();
        }
        private void LimparDados()
        {
            txtName.Text = "";
            txtSigla.Text = "";
            numID.Value = 0;
            checkActive.Checked = false;
        }


        private void FrmDisciplinas_Load(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            DataGridViewRow editar = gridDisciplina.Rows[LinhaS];
            editar.Cells[0].Value = numID.Value;
            editar.Cells[1].Value = txtName.Text;
            editar.Cells[2].Value = txtSigla.Text;
            editar.Cells[3].Value = checkActive.Checked;

        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            LimparDados();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            gridDisciplina.Rows.RemoveAt(LinhaS);
        }

        private void gridDisciplina_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LinhaS = e.RowIndex;
            txtName.Text = gridDisciplina.Rows[LinhaS].Cells[1].Value.ToString();
            txtSigla.Text = gridDisciplina.Rows[LinhaS].Cells[2].Value.ToString();
            numID.Value = Convert.ToInt32(gridDisciplina.Rows[LinhaS].Cells[0].Value);
            checkActive.Checked = Convert.ToBoolean(gridDisciplina.Rows[LinhaS].Cells[3].Value);
        }


        //private void btnDelAll_Click(object sender, EventArgs e)
        //{
        //  gridDisciplina.Rows.RemoveAt(); //nao terminado
        //}
    }
}
