using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.entidades
{
    public class ProfessoresEntidade
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Apelido { get; set; }

        public object[] Linha()
        {
            return new object[] { Id, Nome, Apelido };  //é a mesma coisa do bagui ali em cima ↑ soq "mais certo"
        }
    }

    
}

