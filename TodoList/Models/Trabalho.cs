using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoList.Models
{
    public class Trabalho : Global
    {
        public string tarefa { get; set; }
        public string setor { get; set; }
        public string gestor { get; set; }
        
        public Trabalho() : this(3, "a definir", "a definir", "a definir", System.DateTime.Now, "a definir", "a definir", "a definir")
        {

        }

        public Trabalho(int id, string nome, string descricao, string responsavel, DateTime? dataEntrega, string tarefa, string setor, string gestor)
        {
            this.id = id;
            this.nome = nome;
            this.descricao = descricao;
            this.responsavel = responsavel;
            this.dataEntrega = dataEntrega;
            this.tarefa = tarefa;
            this.setor = setor;
            this.gestor = gestor;
        }

        internal void AtribuirTarefa()
        {
            Console.WriteLine("A tarefa é: " + tarefa);
        }

        private void DefinirSetor(){
            Console.WriteLine("O setor é: " + setor);
        }

        public virtual void RestornarSetor(){
            return this.DefinirSetor();
        }

        public override void RetornarTarefa()
        {
            return this.AtribuirTarefa();
        }

    }
}
