using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoTarefas.WinApp
{
    public class Tarefa
    {
        public int Numero { get; set; }
        public string Titulo { get; set; }
        public DateTime DataCriacao { get; set; }

        public Tarefa(int numero, string titulo) :this()
        {
            Numero = numero;
            Titulo = titulo;
        }

        public Tarefa()
        {
            DataCriacao = DateTime.Now;
        }

        public override string ToString()
        {
            return $"Número: {Numero} , Título: {Titulo} , Data de Criação: {DataCriacao}";//interpolar string
        }
    }
}
