 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using Model.entidades;
using System.Data;

namespace MapaSala.DAO
{
    public class ProfessorDAO
    {
        private string Linhaconexao = "Server = LS05MPF; Database=AULA_DS;User Id = sa; Password=admsasql";
        private SqlConnection Conexao;
        public ProfessorDAO()
        {
            Conexao = new SqlConnection(Linhaconexao);
        }
        public void Inserir(ProfessoresEntidade professor)
        {
            Conexao.Open();
            string query = "Insert into Professores (Nome, Apelido) Values (@nome, @apelido) ";
            SqlCommand comando = new SqlCommand(query, Conexao);
            SqlParameter parametro1 = new SqlParameter("@nome", professor.Nome);
            SqlParameter parametro2 = new SqlParameter("@apelido", professor.Apelido);
            comando.Parameters.Add(parametro1);
            comando.Parameters.Add(parametro2);
            comando.ExecuteNonQuery();
            Conexao.Close();
        }
        public DataTable ObterProfessor()
        {
            DataTable dt = new DataTable();
            Conexao.Open();
            string query = "SELECT * FROM Professores";
            SqlCommand comando = new SqlCommand(query, Conexao);
            SqlDataReader Leitura = comando.ExecuteReader();
            foreach (var atributos in typeof(ProfessoresEntidade).GetProperties())
            {
                dt.Columns.Add(atributos.Name);
            }
            

            if (Leitura.HasRows)
            {
                while (Leitura.Read())
                {
                    ProfessoresEntidade professor = new ProfessoresEntidade();
                    professor.Id = Convert.ToInt32(Leitura[0]);
                    professor.Nome = Leitura[1].ToString();
                    professor.Apelido = Leitura[2].ToString();
                    dt.Rows.Add(professor.Linha());

                }
            }
            return dt;
        }

    }
}
