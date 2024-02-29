using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoList.Models
{
    internal class Casa : Global
    {

       public string comodo { get; set; }


        public Casa() : this(2, "a definir", "a definir", "a definir", System.DateTime.Now, "a definir")
        {

        }

        public Casa(int id, string nome, string descricao, string responsavel, DateTime? dataEntrega, string comodo)
        {
            this.id = id;
            this.nome = nome;
            this.descricao = descricao;
            this.responsavel = responsavel;
            this.dataEntrega = dataEntrega;
            this.comodo = comodo;
        }

        public virtual void RetornarComodo()
        {
            Console.WriteLine("O comodo é: " +comodo);
        }

    }
}
