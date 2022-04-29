using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoTarefas.WinApp
{
    public class RepositorioTarefa
    {
        List<Tarefa> tarefas = new List<Tarefa>();
        private int contador = 0;

        public List<Tarefa> SelecionarTodos()
        {
            return tarefas;
        }

        public void Inserir(Tarefa novaTarefa)
        {
            novaTarefa.Numero = ++contador;
            tarefas.Add(novaTarefa);
        }

        public void Editar(Tarefa tarefa)
        {
            foreach (var item in tarefas)
            {
                if (item.Numero == tarefa.Numero)
                {
                    item.Titulo = tarefa.Titulo;
                    break;
                }
            }
        }
        public void Excluir(Tarefa tarefa)
        {
            tarefas.Remove(tarefa);
        }

        public void AdicionarItens(Tarefa tarefaSelecionada, List<ItemTarefa> items)
        {
            foreach (var item in items)
            {
                tarefaSelecionada.AdicionarItem(item);
            }
        }

        public void AtualizarItems(Tarefa tarefaSelecionada, List<ItemTarefa> itemsConcluidos)
        {
            foreach (var item in itemsConcluidos)
            {
                tarefaSelecionada.ConcluirItem(item);
            }
        }
    }
}