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
            Tarefa tarefaSelecinada = (Tarefa)listTarefas.SelectedItem;//selecionar a tarefa na lista

            CadastroTarefas tela = new CadastroTarefas();

            tela.Tarefa = tarefaSelecinada;

            DialogResult resultado = tela.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                repositorioTarefa.Editar(tela.Tarefa);
                CarregarTarefas();
            }
        }

        private void bt_excluir_Click(object sender, EventArgs e)
        {
            Tarefa tarefaSelecionada = (Tarefa)listTarefas.SelectedItem;//selecionar a tarefa na lista
        }
    }
}
