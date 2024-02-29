using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoList.Models
{
    internal class Viagens : Global
    {
        public string passeios { get; set; }
        public string compras { get; set; }

        public Viagens() : this(4, "a definir", "a definir", "a definir", System.DateTime.Now, "a definir", "a definir")
        {

        }

        public Viagens(int id, string nome, string descricao, string responsavel, DateTime? dataEntrega, string passeios, string compras)
        {
            this.id = id;
            this.nome = nome;
            this.descricao = descricao;
            this.responsavel = responsavel;
            this.dataEntrega = dataEntrega;
            this.passeios = passeios;
            this.compras = compras;
        }

        internal void AtribuirPasseio()
        {
            Console.WriteLine("O passeio é: " + passeios);
        }

        private void DefinirCompras()
        {
            Console.WriteLine("As compras são: " + compras);
        }

        public virtual void RetornarCompras()
        {
            return this.DefinirCompras();
        }

        public override void RetornarPasseio()
        {
            return this.AtribuirPasseio();
        }
    }
}
