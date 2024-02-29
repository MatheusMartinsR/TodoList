using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoList.Models
{
    public class Escola : Global
    {


        public string dever { get; set; }

        public string materia { get; set; }

        public string professor { get; set; }

        public Escola() : this(1, "Lição de Casa", "fazer lição de casa", "a definir", System.DateTime.Now, "trabalho", "a definir", "a definir")
        {

        }

        public Escola(int id, string nome, string descricao, string responsavel, DateTime? dataEntrega, string dever, string materia, string professor)
        {
            this.id = id;
            this.nome = nome;
            this.descricao = descricao;
            this.responsavel = responsavel;
            this.dataEntrega = dataEntrega;
            this.dever = dever;
            this.materia = materia;
            this.professor = professor;
        }


        public override void RetornarTarefa()
        {
            Console.WriteLine("O nome do dever de casa é: " + dever);
        }


    }
}
