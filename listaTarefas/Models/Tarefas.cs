using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace listaTarefas.Models
{
    public class Tarefas
    {
        public int TarefasId { get; set; }

        public string Nome { get; set; }

        public string Descricao { get; set; }

        public DateTime Inicio { get; set; }

        public DateTime Importancia { get; set; }
    }
}
