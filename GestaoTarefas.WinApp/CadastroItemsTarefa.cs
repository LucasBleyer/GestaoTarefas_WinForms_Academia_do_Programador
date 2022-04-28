using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace GestaoTarefas.WinApp
{
    public partial class CadastroItemsTarefa : Form
    {
        public CadastroItemsTarefa(Tarefa tarefa)
        {
            InitializeComponent();

            lb_tituloTarefa.Text = tarefa.Titulo;

            foreach (ItemTarefa items in tarefa.Items)
            {
                listItemsTarefas.Items.Add(items);
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
            ItemTarefa itemTarefa = new ItemTarefa();

            itemTarefa.Titulo = txtTituloItem.Text;

            listItemsTarefas.Items.Add(itemTarefa);
        }
    }
}
