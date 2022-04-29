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

            listTarefas.Items.Clear();
            foreach (Tarefa tarefa in tarefas)
            {
                listTarefas.Items.Add(tarefa);
            } 
        }

        private void bt_inserir_Click(object sender, EventArgs e)
        {
            CadastroTarefas tela = new CadastroTarefas();
            tela.Tarefa = new Tarefa();

            DialogResult resultado = tela.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                repositorioTarefa.Inserir(tela.Tarefa);
                CarregarTarefas();
            }
        }

        private void bt_editar_Click(object sender, EventArgs e)
        {
            Tarefa tarefaSelecionada = (Tarefa)listTarefas.SelectedItem;//selecionar a tarefa na lista

            if (tarefaSelecionada == null)
            {
                MessageBox.Show("Selecione uma tarefa primeiro",
                "Edição de Tarefas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                CadastroTarefas tela = new CadastroTarefas();
                tela.Tarefa = tarefaSelecionada;

                DialogResult resultado = tela.ShowDialog();

                if (resultado == DialogResult.OK)
                {
                    repositorioTarefa.Editar(tela.Tarefa);
                    CarregarTarefas();
                }
            }
        }

        private void bt_excluir_Click(object sender, EventArgs e)
        {
            Tarefa tarefaSelecionada = (Tarefa)listTarefas.SelectedItem;//selecionar a tarefa na lista

            if (tarefaSelecionada == null)
            {
                MessageBox.Show("Não existe nenhuma tarefa selecionada!",
                "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                DialogResult resultado = MessageBox.Show("Deseja realmente excluir esta tarefa?",
                "Exclusão de Tarefas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (resultado == DialogResult.OK)
                {
                    repositorioTarefa.Excluir(tarefaSelecionada);
                    CarregarTarefas();
                }
            }
        }

        private void bt_cadastrar_Click(object sender, EventArgs e)
        {
            Tarefa tarefaSelecionada = (Tarefa)listTarefas.SelectedItem;//selecionar a tarefa na lista

            if (tarefaSelecionada == null)
            {
                MessageBox.Show("Não existe nenhuma tarefa selecionada!",
                "Edição de Tarefas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            CadastroItemsTarefa tela = new CadastroItemsTarefa(tarefaSelecionada);

            if (tela.ShowDialog() == DialogResult.OK)
            {
                List<ItemTarefa> items = tela.ItemsAdicionados;//propriedade do cadastro items tarefa

                repositorioTarefa.AdicionarItens(tarefaSelecionada, items);

                CarregarTarefas();
            }
        }
    }
}