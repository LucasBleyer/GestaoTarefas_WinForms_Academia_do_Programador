using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace GestaoTarefas.WinApp
{
    public partial class CadastroItemsTarefa : Form
    {
        private readonly Tarefa tarefa;
        public CadastroItemsTarefa(Tarefa tarefa)
        {
            InitializeComponent();
            this.tarefa = tarefa;
            lb_tituloTarefa.Text = tarefa.Titulo;

            foreach (var item in tarefa.Items)
            {
                listItemsTarefas.Items.Add(item);
            }

        }
        public List<ItemTarefa> ItemsAdicionados //propriedade
        {
            get
            {
                return listItemsTarefas.Items.Cast<ItemTarefa>().ToList();
                //retorna uma lista de objetos fazendo cast em cada elemento da lista
            }
        }
        private void bt_adicionar_Click(object sender, EventArgs e)
        {
            List<string> titulos = ItemsAdicionados.Select(t => t.Titulo).ToList();

            //se o item ainda não está na lista de item(Contains == False) adiciona o item
            if (titulos.Count == 0 || titulos.Contains(txtTituloItem.Text) == false)
            {
                ItemTarefa itemTarefa = new ItemTarefa();

                itemTarefa.Titulo = txtTituloItem.Text;

                listItemsTarefas.Items.Add(itemTarefa);
            }
        }
    }
}
