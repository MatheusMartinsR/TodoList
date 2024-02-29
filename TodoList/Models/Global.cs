using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoList.Models
{
    public class Global
    {

        public int id { get; set; }
        public string nome { get; set; }
        public string descricao { get; set; }
        public string responsavel { get; set; }
        public DateTime? dataEntrega { get; set; } = DateTime.Now;

        public Global()
        {

        }

        public Global(int id, string nome, string descricao, string responsavel, DateTime? dataEntrega)
        {
            this.id = id;
            this.nome = nome;
            this.descricao = descricao;
            this.responsavel = responsavel;
            this.dataEntrega = dataEntrega;
        }

        protected virtual void RetornarTarefa()
        {
            Console.WriteLine("O nome da tarefa é: " + nome);
        }

        protected virtual void RetornarDescricao()
        {
            Console.WriteLine("A descrição da tarefa é: " + descricao);
        }

        protected virtual void RetornarResponsavel()
        {
            Console.WriteLine("O nome do responsável é: " + responsavel);
        }

        protected virtual void RetornarDataEntrega()
        {
            Console.WriteLine("A data de entrega é: " + dataEntrega);
        }


    }

    
} 
