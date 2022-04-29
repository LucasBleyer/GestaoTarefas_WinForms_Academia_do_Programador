using System;
using System.Collections.Generic;
using System.Linq;

namespace GestaoTarefas.WinApp
{
    public class Tarefa
    {
        private List<ItemTarefa> items = new List<ItemTarefa>();
        public Tarefa(int numero, string titulo) : this()
        {
            Numero = numero;
            Titulo = titulo;
        }

        public Tarefa()
        {
            DataCriacao = DateTime.Now;
        }
        public int Numero { get; set; }
        public string Titulo { get; set; }
        public DateTime DataCriacao { get; set; }
        public List<ItemTarefa> Items { get { return items;} }

        public override string ToString()
        {
            var percentual = calcularPercentualConcluido();
            return $"Número: {Numero} , Título: {Titulo} , Data de Criação: {DataCriacao}, Percentual: {percentual}%";//interpolar string
        }

        public void AdicionarItem(ItemTarefa item)
        {
            //verificar se o item ja foi adicionado ou nao
            if (items.Exists(x => x.Equals(item)) == false){
                items.Add(item);
            }
        }

        public void ConcluirItem(ItemTarefa item)
        {
            ItemTarefa itemTarefa = items.Find(x => x.Equals(item));
            itemTarefa.Concluir();
        }

        public decimal calcularPercentualConcluido()
        {
            if (items.Count == 0)
            {
                return 0;
            }

            int quant_concluidas = items.Count(x => x.Concluido);
            var percentual = (quant_concluidas / (decimal)items.Count()) * 100;

            return Math.Round(percentual, 2);
        }
    }
}
