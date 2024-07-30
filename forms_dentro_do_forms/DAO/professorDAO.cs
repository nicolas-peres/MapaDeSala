using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using Model.entidades;

namespace MapaSala.DAO
{
    public class ProfessorDAO
    {
        private string Linhaconexao = "Server = LS05MPF; Database=AULA_DS;User Id = sa; Password=admsasql";
        private SqlConnection Conexao;
        public professorDAO()
        {
            Conexao = new SqlConnection(Linhaconexao);
        }
        public void Inserir(ProfessoresEntidade professor)
        {
            Conexao.Open();
            string query = "Insert into Professores "
        }

    }
}
