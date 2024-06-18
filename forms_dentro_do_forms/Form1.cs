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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_cadastro_salas(object sender, EventArgs e)
        {
            salas sala = new salas();
            frm_salas frm_salas = new frm_salas();
            frm_salas.ShowDialog(); //quando falamos de objetos, podemos falar q na verdade é uma aba de aplicativo (foi criado um objeto form que abre outro (o cadastro)
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
