using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoTarefas.WinApp
{
    public class Tarefa : RepositorioTarefa
    {
        public int numero { get; set; }
        public string titulo { get; set; }
        public DateTime dataCriacao { get; set; }

        public Tarefa tarefa
        {
            get { return tarefa; }
            set
            {
                tarefa = value;
                txtNumero.Text = tarefa.numero.ToString();//label numero da terefa
                txtTitulo.Text = tarefa.titulo;//label titulo da tarefa
            }
        }

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
