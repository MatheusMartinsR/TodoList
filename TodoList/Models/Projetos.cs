using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoList.Models
{
    internal class Projetos : Global
    {
        public string ideia { get; set; }
        public string desenvolvimento { get; set; }
        public string conclusao { get; set; }

        public Projetos() : this(2, "a definir", "a definir", "a definir", System.DateTime.Now, "a definir", "a definir", "a definir")
        {

        }

        public Projetos(int id, string nome, string descricao, string responsavel, DateTime? dataEntrega, string ideia, string desenvolvimento, string conclusao)
        {
            this.id = id;
            this.nome = nome;
            this.descricao = descricao;
            this.responsavel = responsavel;
            this.dataEntrega = dataEntrega;
            this.ideia = ideia;
            this.desenvolvimento = desenvolvimento;
            this.conclusao = conclusao;
        }

        public override void RetornarTarefa()
        {
            Console.WriteLine("A ideia do projeto é: " + ideia);
        }

    }
}
