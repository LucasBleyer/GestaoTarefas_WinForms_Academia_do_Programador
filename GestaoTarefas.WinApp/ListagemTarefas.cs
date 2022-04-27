using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GestaoTarefas.WinApp
{
    public partial class ListagemTarefas : Form
    {
        private RepositorioTarefa repositorioTarefa;

        public ListagemTarefas()
        {
            repositorioTarefa = new RepositorioTarefa();//pro repositiorioTarefa não ficar null
            InitializeComponent();
            CarregarTarefas();
        }

        private void CarregarTarefas()
        {
            List<Tarefa> tarefas = repositorioTarefa.SelecionarTodos();

            foreach(Tarefa t in tarefas)
            {
                listTarefas.Items.Add(t);
            } 
        }

        private void bt_inserir_Click(object sender, EventArgs e)
        {
            CadastroTarefas tela = new CadastroTarefas();

            DialogResult resultado = tela.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                repositorioTarefa.Inserir(tela.NovaTarefa);
                CarregarTarefas();
            }
        }

        private void bt_editar_Click(object sender, EventArgs e)
        {
            //Tarefa tarefaSelecionada = (Tarefa)listTarefas.SelectedItem;

            //if (tarefaSelecionada == null)
            //{
            //    MessageBox.Show("Selecione uma tarefa primeiro", "Edição de Tarefas",
            //                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //    return;
            //}

            //CadastroTarefas tela = new CadastroTarefas();
            //tela.Tarefa = tarefaSelecionada;

            //DialogResult resultado = tela.ShowDialog();

            //if (resultado == DialogResult.OK)
            //{
            //    repositorioTarefa.Editar(tela.Tarefa);
            //    CarregarTarefas();
            //}
        }

        private void bt_excluir_Click(object sender, EventArgs e)
        {
            //Tarefa tarefaSelecionada = (Tarefa)listTarefas.SelectedItem;

            //if (tarefaSelecionada == null)
            //{
            //    MessageBox.Show("Selecione uma tarefa primeiro", "Edição de Tarefas",
            //        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //    return;
            //}

            //DialogResult resultado = MessageBox.Show("Deseja realmente excluir a tarefa?",
            //    "Exclusão de Tarefas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            //if (resultado == DialogResult.OK)
            //{
            //    repositorioTarefa.Excluir(tarefaSelecionada);
            //    CarregarTarefas();
            //}
        }
    }
}
