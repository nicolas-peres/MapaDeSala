using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.entidades
{
    public class DisciplinasEntidade
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sigla { get; set; }
        public bool Ativo { get; set; }

        public object[] Linha()
        {
            return new object[] { Id, Nome, Sigla, Ativo }; //ORDEM DE MODIFICAÇÃO: criacao de objeto (essa Linha, ai ←) ; C# web usa isso (mas nao tem essas facilidades, entao nao pode se agarrar à essas funcoes)
        }
    }
}
