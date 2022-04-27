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

        public Tarefa(int numero, string titulo)
        {
            this.Numero = numero;
            this.Titulo = titulo;
        }
        public Tarefa()
        {

        }

        public override string ToString()
        {
            return $"Número: {Numero}, Título: {Titulo}";//interpolar string
        }
    }
}
