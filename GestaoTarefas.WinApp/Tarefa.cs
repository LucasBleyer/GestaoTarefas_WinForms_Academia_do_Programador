using System;
using System.Collections.Generic;

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
            return $"Número: {Numero} , Título: {Titulo} , Data de Criação: {DataCriacao}";//interpolar string
        }

        internal void AdicionarItem(ItemTarefa item)
        {
            //verificar se o item ja foi adicionado ou nao
            if (items.Exists(x => x.Equals(item) == false)){
                items.Add(item);
            }
            
                
            
        }
    }
}
