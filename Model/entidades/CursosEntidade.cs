using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.entidades
{
    public class CursosEntidade
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Turno { get; set; }
        public bool Ativo { get; set; }

        public object[] Linha()
        {
            return new object[] { Id, Nome, Turno, Ativo };
        }
    }
}
