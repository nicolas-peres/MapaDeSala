using forms_dentro_do_forms.forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace forms_dentro_do_forms
{
    public partial class salas : Form
    {
        public salas()
        {
            InitializeComponent();
        }

        //private void label8_Click(object sender, EventArgs e)
        //{

        //}

        //private void txt_num_pc_TextChanged(object sender, EventArgs e)
        //{ 
        //}

        //private void checkBox2_CheckedChanged(object sender, EventArgs e)
        //{

        //}

        //private void checkBox1_CheckedChanged(object sender, EventArgs e)
        //{

        //}

        //private void btn_cadastrar_Click(object sender, EventArgs e)
        //{
        //    string nome_sala = txt_nome_sala.Text;
        //    string num_cadeira = txt_num_cad.Text;
        //    string num_pc = txt_num_pc.Text;  //lembrar de sempre alterar (converter) o tipo da variavel, senao vai dar pau e vc vai ficar q nem otario procurando o erro!
        //    string predio = txt_predio.Text;
        //    if (nome_sala != "" && num_cadeira != "" && num_pc != "" && predio != "")
        //    {
        //        MessageBox.Show($"você cadastrou com sucesso! \ndados cadastrados: \nNome da sala: {nome_sala}\n Nº de PCS: {num_pc} \nNº Cadeiras: {num_cadeira} \nPrédio: {predio}");
        //    }
        //    else
        //    {
        //        MessageBox.Show("Complete todos os campos por favor");
        //    }
        //}

        //private void btn_reset_Click(object sender, EventArgs e)
        //{
        //    txt_nome_sala.Text = " ";
        //    txt_num_pc.Text = "";
        //    txt_num_cad.Text = "";
        //    txt_predio.Text = "";
        //    islab_true.Checked = false;
        //    MessageBox.Show("dados resetados!");
        //}

        //private void rEGISTROToolStripMenuItem_Click(object sender, EventArgs e)
        //{

        //}

        private void salas_Load(object sender, EventArgs e)
        {

        }


        private void salasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_salas frm_salas = new frm_salas();
            frm_salas.ShowDialog();
        }

        private void professoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProfessor professor = new FrmProfessor();
            professor.ShowDialog();
        }

        private void disciplinasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDisciplinas disciplina = new FrmDisciplinas();
            disciplina.ShowDialog();

        }

        private void horariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmHorarios horario = new FrmHorarios();
            horario.ShowDialog();
        }

        private void cursosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCursos cursos = new FrmCursos();
            cursos.ShowDialog();
        }

        private void diaDaSemanaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDiaSemana diaSemana = new FrmDiaSemana();
            diaSemana.ShowDialog();
        }
    }
}
