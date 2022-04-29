using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestaoTarefas.WinApp
{
    public partial class AtualizaItemsTarefa : Form
    {
        private readonly Tarefa tarefa;
        public AtualizaItemsTarefa(Tarefa tarefa)//informar o parametro tarefa selecionada
        {
            InitializeComponent();
            this.tarefa = tarefa;
            lb_tituloTarefa.Text = tarefa.Titulo;

            foreach (var item in tarefa.Items)
            {
                listItemsTarefa.Items.Add(item);

                int i = 0;
                if (item.Concluido)
                {
                    listItemsTarefa.SetItemChecked(i, true);
                    i++;
                }
            }
        }

        public List<ItemTarefa> ItemsConcluidos
        {
            get
            {
                return listItemsTarefa.CheckedItems.Cast<ItemTarefa>().ToList();
            }
        }
    }
}
