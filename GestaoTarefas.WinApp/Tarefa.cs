using System;

namespace GestaoTarefas.WinApp
{
    public partial class ListagemTarefas
    {
        public class Tarefa
        {
            public int numero { get; set; }
            public string titulo { get; set; }
            public DateTime dataCriacao { get; set; }

            public Tarefa(int numero, string titulo, DateTime dataCriacao)
            {
                this.numero = numero;
                this.titulo = titulo;
                this.dataCriacao = DateTime.Now;
            }

            public override string ToString()
            {
                return $"Número: {numero}, Título: {titulo}, Data de Criação: {dataCriacao}";
            }
        }
    }
}
